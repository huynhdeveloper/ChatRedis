using StackExchange.Redis;
using System;

namespace RedisChatClient.Clients
{
    internal class Connection
    {
        private static Connection instance;

        private static Json.Server config;

        private ConnectionMultiplexer connection;

        private IDatabase database;

        private Connection()
        {
            if (config != null)
            {
                connection = ConnectionMultiplexer.Connect(config.Instance);
                database = connection.GetDatabase(config.TargetingDB);
            }
            else
            {
                throw new Exception("No server's config loaded");
            }
        }

        public static Connection getClient()
        {
            if (instance == null)
            {
                instance = new Connection();
            }
            return instance;
        }

        public ConnectionMultiplexer getConnection()
        {
            return connection;
        }

        public IDatabase getDatabase()
        {
            return database;
        }

        public static void Init(Json.Server Config)
        {
            if (instance == null)
            {
                config = Config;
                instance = new Connection();
            }
        }
    }
}