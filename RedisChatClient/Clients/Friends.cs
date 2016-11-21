using System;
using System.Collections.Generic;
using StackExchange.Redis;

namespace RedisChatClient.Clients
{
    internal class Friends
    {
        private static Friends instance;

        private Dictionary<String, double> global;

        private HashSet<String> user;

        private ISubscriber subscriber;
        private Friends()
        {
            global = new Dictionary<String, double>();
            user = new HashSet<string>();
            subscriber = Connection.getClient()
               .getConnection()
               .GetSubscriber();
        }

        public static Friends getInstance()
        {
            if (instance == null)
            {
                instance = new Friends();
            }
            return instance;
        }
        public static void Reset()
        {
            instance = new Friends();
        }

        public void Subscribe(String channel)
        {
            Forms.IChatForm receiver = Forms.FormController.getInstance().newChatForm();

            receiver.channel = channel;
            MessagesBroker.getInstance().addBroker(channel, receiver);
            subscriber.Subscribe(channel, (chn, mes) =>
            {
                MessagesBroker.getInstance().messageHandle(channel, mes);
            });
        }

        public void Friend(String username)
        {
            Forms.IChatForm receiver = Forms.FormController.getInstance().newChatForm();

            receiver.channel = username;
            MessagesBroker.getInstance().addBroker(username, receiver);
            subscriber.Subscribe(username, (chn, mes) =>
            {
                MessagesBroker.getInstance().messageHandle(username, mes);
            });
        }

        public Dictionary<String, double> getGlobalList()
        {
            return new Dictionary<string, double>(global);
        }

        public HashSet<String> getUserList()
        {
            return new HashSet<string>(user);
        }

        public void pullAll()
        {
            var db = Connection.getClient().getDatabase();
            var globalList = db.SortedSetRangeByRankWithScores(globalkey(), 0, -1, Order.Descending);
            global = ExtensionMethods.ToStringDictionary(globalList);

            var userList = db.SortedSetRangeByScore(userkey());
            user = new HashSet<string>(userList.ToStringArray());
        }

        public void AddFriend(String username)
        {

            if (!user.Contains(username))
            {
                var userThis = User.getInstance().getSignedInUser().Username;
                var db = Connection.getClient().getDatabase();

                db.SortedSetIncrement(globalkey(), username, 1);
                db.SortedSetAdd(userkey(), username, 0);
                user.Add(username);

                db.SortedSetIncrement(globalkey(), username, 1);
                db.SortedSetAdd(userkeyOther(username), userThis, 0);
                user.Add(username);
            }
        }

        public void RemoveFriend(String username)
        {
            if (user.Contains(username))
            {
                var db = Connection.getClient().getDatabase();

                db.SortedSetDecrement(globalkey(), username, 1);
                db.SortedSetRemove(userkey(), username);
                user.Remove(username);
            }
        }

        public static String userkeyOther(String userOther)
        {
            return String.Format("friend:{0}:{1}", userOther, Utils.hashing("friend", userOther));
        }
        public static String userkey()
        {
            var username = User.getInstance().getSignedInUser().Username;
            return String.Format("friend:{0}:{1}", username, Utils.hashing("friend", username));
        }

        public static String globalkey()
        {
            return "friend";
        }

    }
}
