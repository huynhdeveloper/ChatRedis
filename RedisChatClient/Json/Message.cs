using System;

namespace RedisChatClient.Json
{
    [Serializable]
    public class Message
    {
        public String Channel { get; set; }
        public String Username { get; set; }
        public long Timestamp { get; set; }
        public String Content { get; set; }
    }
}