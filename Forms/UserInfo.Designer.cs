namespace RedisChatClient.Forms
{
    partial class UserInfo
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
            this.btn_update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newpass_repeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oldpass = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(12, 350);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(310, 34);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Cập nhật tài khoản";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 51);
            this.label5.TabIndex = 18;
            this.label5.Text = "Người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email *";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(12, 181);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(310, 23);
            this.email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nhập lại mật khẩu mới";
            // 
            // newpass_repeat
            // 
            this.newpass_repeat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass_repeat.Location = new System.Drawing.Point(12, 269);
            this.newpass_repeat.Name = "newpass_repeat";
            this.newpass_repeat.PasswordChar = '•';
            this.newpass_repeat.Size = new System.Drawing.Size(310, 23);
            this.newpass_repeat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mật khẩu mới";
            // 
            // newpass
            // 
            this.newpass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpass.Location = new System.Drawing.Point(12, 225);
            this.newpass.Name = "newpass";
            this.newpass.PasswordChar = '•';
            this.newpass.Size = new System.Drawing.Size(310, 23);
            this.newpass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mật khẩu hiện tại *";
            // 
            // oldpass
            // 
            this.oldpass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldpass.Location = new System.Drawing.Point(12, 313);
            this.oldpass.Name = "oldpass";
            this.oldpass.PasswordChar = '•';
            this.oldpass.Size = new System.Drawing.Size(310, 23);
            this.oldpass.TabIndex = 4;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(15, 88);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(87, 15);
            this.username.TabIndex = 22;
            this.username.Text = "{Tên tài khoản}";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 512);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldpass);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newpass_repeat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newpass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserInfo";
            this.Text = "Thông tin người dùng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newpass_repeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldpass;
        private System.Windows.Forms.Label username;
    }
}