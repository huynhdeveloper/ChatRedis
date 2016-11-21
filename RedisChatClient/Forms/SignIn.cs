using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RedisChatClient.Forms
{
    public partial class SignIn : Form, IForm
    {
        public SignIn()
        {
            InitializeComponent();
        }

        public void ReInit()
        {
            this.username.Text = "";
            this.passpharse.Text = "";
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

        private void btn_goto_signup_Click(object sender, EventArgs e)
        {
            var me = FormController.getInstance();
            me.getForm("SignUp").Toggle();
            me.getForm("SignIn").Toggle();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            var ulength = this.username.TextLength;
            var plength = this.passpharse.TextLength;
            if (ulength > 3 && plength > 3)
            {
                var result = Clients.User.signIn(this.username.Text, this.passpharse.Text);

                if (!result)
                {
                    MessageBox.Show("Thông tin đăng nhập không chính xác hoặc tài khoản không tồn tại", "Đăng nhập thất bại", MessageBoxButtons.OK);
                }
                else
                {
                    ///MessageBox.Show(Clients.User.getInstance().getSignedInUser().Username);

                    var me = Forms.FormController.getInstance();
                    me.getForm("MainWindow").Toggle();
                    Toggle();
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập phải dài hơn 4 kí tự", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void SignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
            ///Application.Exit(); suck
        }
    }
}