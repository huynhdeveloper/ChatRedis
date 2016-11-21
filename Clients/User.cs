using Jil;
using StackExchange.Redis;
using System;
using System.Collections.Generic;

namespace RedisChatClient.Clients
{
    internal class User
    {
        private static User instance;

        private Json.User info;

        private HashSet<String> user;
        private HashSet<String> listUser;

        private User()
        {
            listUser = new HashSet<string>();
            user = new HashSet<string>();
        }

        public HashSet<String> getListUser()
        {
            return new HashSet<string>(user);
        }

        public Json.User getSignedInUser()
        {
            return info.Clone();
        }

        public static bool signIn(String username, String passpharse)
        {
            var userkey = userKey(username);
            var keystring = keyString(username, passpharse);
            var db = Connection.getClient().getDatabase();

            if (db.HashExists(userkey, keystring))
            {
                var userInfo = db.HashGet(userkey, infoString());

                getInstance().info = JSON.Deserialize<Json.User>(userInfo);
                return true;
            }
            return false;
        }

        public static bool signUp(Json.User user, String passpharse)
        {
            var db = Connection.getClient().getDatabase();
            var userkey = userKey(user.Username);

            if (db.KeyExists(userkey))
            {
                return false;
            }
            var time = Utils.toUnixTime(DateTime.Now);
            var keystring = keyString(user.Username, passpharse);

            db.HashSet(userkey, keystring, time);
            db.HashSet(userkey, infoString(), JSON.Serialize<Json.User>(user));
            getInstance().info = user;
            return true;
        }

        public static void signOut()
        {
            Subscriptions.Reset();
            Channels.Reset();
            instance = new User();
        }

        public static void updateUserData(Json.User user)
        {
            Json.User t = getInstance().getSignedInUser();
            if (t != null)
            {
                var userkey = userKey(user.Username);
                var db = Connection.getClient().getDatabase();
                t.Email = user.Email;

                db.HashSet(userkey, infoString(), JSON.Serialize<Json.User>(t));
                getInstance().info = user;
                return;
            }
        }

        public static void updateUserPasspharse(String newpass, String oldpass)
        {
            Json.User t = getInstance().getSignedInUser();
            if (t != null)
            {
                var db = Connection.getClient().getDatabase();

                var userkey = userKey(t.Username);
                var oldkey = keyString(t.Username, oldpass);
                var newkey = keyString(t.Username, newpass);
                var time = Utils.toUnixTime(DateTime.Now);
                if (db.HashExists(userkey, oldkey))
                {
                    db.HashSet(userkey, newkey, time);
                    db.HashDelete(userkey, oldkey);
                }
            }
        }

        public bool checkAccount(String Username)
        {
            var user = Clients.User.getInstance().getSignedInUser();
            var db = Connection.getClient().getDatabase();
            var userkey = userKey(Username);
            var a = user.Username;
            if (db.KeyExists(userkey))
            {
                if(user.Username == Username)
                {
                    return false;
                }
                return true;
            }
            
            return false;
        }

        public static User getInstance()
        {
            if (instance == null)
            {
                instance = new User();
            }
            return instance;
        }

        public static String userKey(String username)
        {
            return String.Format("user:{0}:{1}", username, Utils.hashing("user", username));
        }

        public static String passKey(String username, String passpharse)
        {
            return Utils.hashing(username, passpharse);
        }

        public static String keyString(String username, String passpharse)
        {
            return String.Format("passpharse:{0}", passKey(username, passpharse));
        }

        public static String infoString()
        {
            return "info";
        }
    }
}