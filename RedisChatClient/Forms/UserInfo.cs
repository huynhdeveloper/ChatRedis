using Jil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedisChatClient.Forms
{
    public partial class UserInfo : Form, IForm
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        public void ReInit()
        {
            var user = Clients.User.getInstance().getSignedInUser();
            username.Text = user.Username;
            email.Text = user.Email;
            newpass.Text = "";
            newpass_repeat.Text = "";
            oldpass.Text = "";
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

        private void UserInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Toggle();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (oldpass.TextLength == 0)
            {
                MessageBox.Show("Bạn phải nhập mật khẩu để cập nhật thông tin tài khoản", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (email.TextLength == 0)
            {
                MessageBox.Show("Địa chỉ email không được phép bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!Clients.Utils.emailValidate(email.Text))
            {
                MessageBox.Show("Email nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!newpass.Text.Equals(newpass_repeat.Text))
            {
                MessageBox.Show("Mật khẩu mới không trùng nhau", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (newpass.TextLength < 4 && newpass.TextLength != 0)
            {
                MessageBox.Show("Mật khẩu mới phải dài tối thiểu 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var user = Clients.User.getInstance().getSignedInUser();

            var db = Clients.Connection.getClient().getDatabase();

            var userkey = Clients.User.userKey(user.Username);
            var keystring = Clients.User.keyString(user.Username, oldpass.Text);

            if (db.HashExists(userkey, keystring))
            {
                user.Email = email.Text;
                Clients.User.updateUserData(user);
                if (newpass.TextLength > 3)
                {
                    Clients.User.updateUserPasspharse(newpass.Text, oldpass.Text);
                }
                MessageBox.Show("Đã cập nhật thông tin người dùng thành công", "Thông báo", MessageBoxButtons.OK);
                Toggle();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác", "Lỗi", MessageBoxButtons.OK);
            }
        }
    }
}