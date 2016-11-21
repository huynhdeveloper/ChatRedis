using System;
using System.Windows.Forms;

namespace RedisChatClient.Forms
{
    public partial class SignUp : Form, IForm
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public void ReInit()
        {
            this.username.Text = "";
            this.passpharse.Text = "";
            this.email.Text = "";
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

        private void btn_backto_signin_Click(object sender, EventArgs e)
        {
            var me = FormController.getInstance();
            me.getForm("SignIn").Toggle();
            me.getForm("SignUp").Toggle();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (this.username.TextLength == 0 || this.passpharse.TextLength == 0 || this.email.TextLength == 0)
            {
                MessageBox.Show("Thông tin tài khoản không được phép bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (this.username.TextLength < 4 || this.passpharse.TextLength < 4)
            {
                MessageBox.Show("Tên tài khoản và mật khẩu phải dài tối thiểu 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (!Clients.Utils.emailValidate(this.email.Text))
            {
                MessageBox.Show("Email nhập vào không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            var newUser = new Json.User();
            newUser.Email = this.email.Text;
            newUser.Username = this.username.Text;
            newUser.RegisteredDate = Clients.Utils.toUnixTime(DateTime.Now);

            var result = Clients.User.signUp(newUser, this.passpharse.Text);
            if (!result)
            {
                MessageBox.Show("Tài khoản này đã có người dử dụng", "Đăng kí thất bại", MessageBoxButtons.OK);
                return;
            }

            ///MessageBox.Show(Clients.User.getInstance().getSignedInUser().Username);
            var me = Forms.FormController.getInstance();
            me.getForm("MainWindow").Toggle();
            Toggle();
        }

        private void SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            var me = Forms.FormController.getInstance();
            me.getForm("SignIn").Toggle();
            Toggle();
        }
    }
}