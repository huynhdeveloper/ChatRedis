using Jil;
using RedisChatClient.Forms;
using System;
using System.Collections.Generic;

namespace RedisChatClient.Clients
{
    internal class MessagesBroker
    {
        private static MessagesBroker instance;

        private Dictionary<String, IChatForm> messageBrokers;

        private MessagesBroker()
        {
            messageBrokers = new Dictionary<string, IChatForm>();
        }

        public static MessagesBroker getInstance()
        {
            if (instance == null)
            {
                instance = new MessagesBroker();
            }
            return instance;
        }

        public void addBroker(String identifier, IChatForm broker)
        {
            messageBrokers.Add(identifier, broker);
        }

        public void removeBroker(String identifier)
        {
            getBroker(identifier).CleanUp();
            messageBrokers.Remove(identifier);
        }

        public IChatForm getBroker(String identifier)
        {
            IChatForm inControl;
            messageBrokers.TryGetValue(identifier, out inControl);
            return inControl;
        }

        public static void Reset()
        {
            foreach (IChatForm f in getInstance().messageBrokers.Values)
            {
                f.CleanUp();
            }
            getInstance().messageBrokers.Clear();
            instance = new MessagesBroker();
        }

        public void messageHandle(String channel, String message)
        {
            IChatForm inControl = getBroker(channel);
            if (inControl != null)
            {
                inControl.Receive(JSON.Deserialize<Json.Message>(message));
            }
            else
            {
                throw new Exception("Incoming message from known channel wasn't proceeded.");
            }
        }
    }
}