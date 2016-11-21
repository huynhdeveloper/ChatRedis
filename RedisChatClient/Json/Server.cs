using System;

namespace RedisChatClient.Json
{
    [Serializable]
    public class Server
    {
        public String Instance { get; set; }
        public int TargetingDB { get; set; }
    }
}