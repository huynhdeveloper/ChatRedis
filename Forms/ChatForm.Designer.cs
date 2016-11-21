namespace RedisChatClient.Forms
{
    partial class ChatForm
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
            this.input = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(12, 418);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.input.Size = new System.Drawing.Size(467, 54);
            this.input.TabIndex = 1;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(485, 418);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(46, 54);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Xóa";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(12, 12);
            this.content.MaxLength = 0;
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.ReadOnly = true;
            this.content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.content.Size = new System.Drawing.Size(519, 389);
            this.content.TabIndex = 2;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 484);
            this.Controls.Add(this.content);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.Text = "(n) Cửa sổ chat (Channel)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox content;
    }
}