using System;

namespace RedisChatClient.Json
{
    [Serializable]
    public class User
    {
        public String Email { get; set; }
        public String Username { get; set; }
        public long RegisteredDate { get; set; }

        public Json.User Clone()
        {
            var t = new Json.User();

            t.Email = Email;
            t.Username = Username;
            t.RegisteredDate = RegisteredDate;

            return t;
        }
    }
}