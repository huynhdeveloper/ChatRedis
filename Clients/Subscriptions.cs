using Jil;
using StackExchange.Redis;
using System;

namespace RedisChatClient.Clients
{
    internal class Subscriptions
    {
        private static Subscriptions instance;

        private ISubscriber subscriber;

        private Subscriptions()
        {
            subscriber = Connection.getClient()
                .getConnection()
                .GetSubscriber();
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

        public void Unsubscribe(String channel)
        {
            subscriber.Unsubscribe(channel);
            MessagesBroker.getInstance().removeBroker(channel);
        }

        public void Publish(Json.Message message)
        {
            var db = Connection.getClient().getDatabase();
            var mes = JSON.Serialize<Json.Message>(message);
            db.Publish(message.Channel, mes);
        }

        public static void Reset()
        {
            getInstance().subscriber.UnsubscribeAll();
            MessagesBroker.Reset();
            instance = new Subscriptions();
        }

        public static Subscriptions getInstance()
        {
            if (instance == null)
            {
                instance = new Subscriptions();
            }
            return instance;
        }
    }
}