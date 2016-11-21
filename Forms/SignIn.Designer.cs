namespace RedisChatClient.Forms
{
    partial class SignIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_signin = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passpharse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.btn_goto_signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_signin
            // 
            this.btn_signin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.Location = new System.Drawing.Point(12, 310);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(310, 34);
            this.btn_signin.TabIndex = 2;
            this.btn_signin.Text = "Đăng nhập";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 44);
            this.label5.TabIndex = 14;
            this.label5.Text = "Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu";
            // 
            // passpharse
            // 
            this.passpharse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passpharse.Location = new System.Drawing.Point(12, 225);
            this.passpharse.Name = "passpharse";
            this.passpharse.PasswordChar = '•';
            this.passpharse.Size = new System.Drawing.Size(310, 23);
            this.passpharse.TabIndex = 1;
            this.passpharse.Text = "123456";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tên tài khoản";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(12, 181);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(310, 23);
            this.username.TabIndex = 0;
            this.username.Text = "huynh";
            // 
            // btn_goto_signup
            // 
            this.btn_goto_signup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goto_signup.Location = new System.Drawing.Point(12, 350);
            this.btn_goto_signup.Name = "btn_goto_signup";
            this.btn_goto_signup.Size = new System.Drawing.Size(310, 34);
            this.btn_goto_signup.TabIndex = 3;
            this.btn_goto_signup.Text = "Đăng kí tài khoản";
            this.btn_goto_signup.UseVisualStyleBackColor = true;
            this.btn_goto_signup.Click += new System.EventHandler(this.btn_goto_signup_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 512);
            this.Controls.Add(this.btn_goto_signup);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passpharse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignIn_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passpharse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button btn_goto_signup;
    }
}