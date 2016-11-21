namespace RedisChatClient.Forms
{
    internal interface IChatForm
    {
        string channel { get; set; }

        int msgqueued { get; set; }

        void Send();

        void Receive(Json.Message message);

        void Display();

        void Conceal();

        void CleanUp();
    }
}