using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RedisChatClient.Forms
{
    public partial class MainWindow : Form, IForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ReInit()
        {
            Clients.Subscriptions.getInstance();
            Clients.Friends.getInstance();
            Clients.Channels.getInstance().pullAll();
            Clients.Friends.getInstance().pullAll();
            var user = Clients.User.getInstance().getSignedInUser().Username;
            this.Text = "Xin chào " + user;

            var gList = Clients.Channels.getInstance().getGlobalList();
            var uList = Clients.Channels.getInstance().getUserList();
            var listUser = Clients.User.getInstance().getListUser();
            var friend = Clients.Friends.getInstance().getUserList();

            subscribedList.Items.Clear();
            globalList.Items.Clear();
            myfriendList.Items.Clear();

            foreach (String uItem in uList)
            {
                subscribedList.Items.Add(uItem);
            }

            foreach (var entry in gList)
            {
                globalList.Items.Add(entry.Key);
            }

            foreach (String fri in friend)
            {
                myfriendList.Items.Add(fri);
            }
        }

        public void Toggle()
        {
            if (this.Visible)
            {
                this.Visible = false;
            }
            else
            {
                ReInit();
                this.Visible = true;
            }
        }

        private void thôngTinNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var me = FormController.getInstance();
            me.getForm("UserInfo").Toggle();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            var me = Forms.FormController.getInstance();
            me.getForm("SignIn").Toggle();
            this.Toggle();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var me = FormController.getInstance();
            me.getForm("MainWindow").Toggle();
            me.getForm("SignIn").Toggle();
            Clients.User.signOut();
        }

        private void globalList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (globalList.SelectedItem == null) return;

            var selected = globalList.SelectedItem.ToString();

            if (Clients.MessagesBroker.getInstance().getBroker(selected) == null)
            {
                Clients.Channels.getInstance().Subscribe(selected);
                Clients.Subscriptions.getInstance().Subscribe(selected);
            }
            Clients.MessagesBroker.getInstance().getBroker(selected).Display();

            ReInit();
        }

        private void subscribedList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (subscribedList.SelectedItem == null) return;

            var selected = subscribedList.SelectedItem.ToString();

            if (Clients.MessagesBroker.getInstance().getBroker(selected) == null)
            {
                Clients.Subscriptions.getInstance().Subscribe(selected);
            }
            Clients.MessagesBroker.getInstance().getBroker(selected).Display();
        }

        private void btn_unsubscribe_Click(object sender, EventArgs e)
        {
            if (subscribedList.SelectedItem == null) return;

            var selected = subscribedList.SelectedItem.ToString();

            Clients.Subscriptions.getInstance().Unsubscribe(selected);
            Clients.Channels.getInstance().Unsubscribe(selected);

            subscribedList.Items.Remove(selected);
            ReInit();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReInit();
        }

        private void new_channel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (new_channel.TextLength == 0) return;

                if (!subscribedList.Items.Contains(new_channel.Text))
                {
                    Clients.Channels.getInstance().Subscribe(new_channel.Text);
                    ReInit();
                }
                if (Clients.MessagesBroker.getInstance().getBroker(new_channel.Text) == null)
                {
                    Clients.Subscriptions.getInstance().Subscribe(new_channel.Text);
                }
                Clients.MessagesBroker.getInstance().getBroker(new_channel.Text).Display();

                new_channel.Text = "";
            }
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Bạn có muốn tắt chương trình ngay bây giờ?", "Hỏi", MessageBoxButtons.YesNo);
            if (msg == DialogResult.Yes)
            {
                Process.GetCurrentProcess().Kill();
                ///Application.Exit(); suck
            }
        }

        private void txtAddFriend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAddFriend.TextLength == 0) return;

                if (!Clients.User.getInstance().checkAccount(txtAddFriend.Text))
                {
                    MessageBox.Show("Not Found Friend", "fail", MessageBoxButtons.OK);
                    return;
                }
                if (Clients.MessagesBroker.getInstance().getBroker(txtAddFriend.Text) == null)
                {
                    Clients.Friends.getInstance().AddFriend(txtAddFriend.Text);
                    Clients.Friends.getInstance().Friend(txtAddFriend.Text);
                }

                Clients.MessagesBroker.getInstance().getBroker(txtAddFriend.Text).Display();

                ReInit();

                txtAddFriend.Text = "";
            }
        }

        private void myfriendList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (myfriendList.SelectedItem == null) return;

            var selected = myfriendList.SelectedItem.ToString();

            if (Clients.MessagesBroker.getInstance().getBroker(selected) == null)
            {
                Clients.Friends.getInstance().Friend(selected);
            }
            Clients.MessagesBroker.getInstance().getBroker(selected).Display();

            ReInit();
        }
    }
}