using RedisChatClient.Json;
using System;
using System.Windows.Forms;

namespace RedisChatClient.Forms
{
    public partial class ChatForm : Form, IChatForm
    {
        public ChatForm()
        {
            InitializeComponent();
            msgqueued = 0;
        }

        public string channel { get; set; }

        public int msgqueued { get; set; }

        public void Receive(Json.Message message)
        {
            if (this.content.InvokeRequired)
            {
                ReceiveCallback r = new ReceiveCallback(Receive);
                this.Invoke(r, message);
                return;
            }
            else
            {
                msgqueued += 1;

                var sentTime = Clients.Utils.toDateTime(message.Timestamp);
                var user = message.Username;
                var content = message.Content;
                var append = String.Format("\r\n{0} : {1}\r\n{2}\r\n", user, sentTime.ToString("MMM dd, hh:mm tt"), content);

                this.content.AppendText(append);
                FormTextRefresh();
            }
        }

        public void Send()
        {
            msgqueued = -1;
            Json.Message mes = new Json.Message();

            mes.Username = Clients.User.getInstance().getSignedInUser().Username;
            mes.Channel = this.channel;
            mes.Timestamp = Clients.Utils.toUnixTime(DateTime.Now);
            mes.Content = this.input.Text;

            Clients.Subscriptions.getInstance().Publish(mes);
            FormTextRefresh();
        }

        public void Display()
        {
            this.Visible = true;
            FormTextRefresh();
        }

        public void Conceal()
        {
            this.Visible = false;
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Conceal();
        }

        private void FormTextRefresh()
        {
            this.Text = String.Format("({0}) Bạn đang chat ở kênh {1}", msgqueued, channel);
        }

        private delegate void ReceiveCallback(Json.Message message);

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.content.Clear();
            msgqueued = 0;
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift)
            {
                e.SuppressKeyPress = true;
                if (input.TextLength < 2) return;
                Send();
                input.Clear();
            }
        }

        public void CleanUp()
        {
            this.Dispose();
        }
    }
}