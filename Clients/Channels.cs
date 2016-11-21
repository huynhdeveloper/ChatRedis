using StackExchange.Redis;
using System;
using System.Collections.Generic;

namespace RedisChatClient.Clients
{
    internal class Channels
    {
        private static Channels instance;

        private Dictionary<String, double> global;

        private HashSet<String> user;

        private Channels()
        {
            global = new Dictionary<String, double>();
            user = new HashSet<string>();
        }

        public static Channels getInstance()
        {
            if (instance == null)
            {
                instance = new Channels();
            }
            return instance;
        }

        public static void Reset()
        {
            instance = new Channels();
        }

        public void Subscribe(String channel)
        {
            if (!user.Contains(channel))
            {
                var db = Connection.getClient().getDatabase();

                db.SortedSetIncrement(globalkey(), channel, 1);
                db.SortedSetAdd(userkey(), channel, 0);
                user.Add(channel);
            }
        }

        public void Unsubscribe(String channel)
        {
            if (user.Contains(channel))
            {
                var db = Connection.getClient().getDatabase();

                db.SortedSetDecrement(globalkey(), channel, 1);
                db.SortedSetRemove(userkey(), channel);
                user.Remove(channel);
            }
        }

        public void pullAll()
        {
            var db = Connection.getClient().getDatabase();
            var globalList = db.SortedSetRangeByRankWithScores(globalkey(), 0, -1, Order.Descending);
            global = ExtensionMethods.ToStringDictionary(globalList);

            var userList = db.SortedSetRangeByScore(userkey());
            user = new HashSet<string>(userList.ToStringArray());
        }

        public Dictionary<String, double> getGlobalList()
        {
            return new Dictionary<string, double>(global);
        }

        public HashSet<String> getUserList()
        {
            return new HashSet<string>(user);
        }

        public static String userkey()
        {
            var username = User.getInstance().getSignedInUser().Username;
            return String.Format("subscription:{0}:{1}", username, Utils.hashing("subscription", username));
        }

        public static String globalkey()
        {
            return "globalChannels";
        }
    }
}