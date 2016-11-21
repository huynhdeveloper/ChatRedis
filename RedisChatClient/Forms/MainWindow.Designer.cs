namespace RedisChatClient.Forms
{
    partial class MainWindow
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ngườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátChươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kênhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.subscribedTab = new System.Windows.Forms.TabPage();
            this.btn_unsubscribe = new System.Windows.Forms.Button();
            this.subscribedList = new System.Windows.Forms.ListBox();
            this.globalTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.new_channel = new System.Windows.Forms.TextBox();
            this.globalList = new System.Windows.Forms.ListBox();
            this.myfriend = new System.Windows.Forms.TabPage();
            this.myfriendList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddFriend = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.subscribedTab.SuspendLayout();
            this.globalTab.SuspendLayout();
            this.myfriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ngườiDùngToolStripMenuItem,
            this.kênhToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(334, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ngườiDùngToolStripMenuItem
            // 
            this.ngườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNgườiDùngToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.toolStripSeparator1,
            this.thoátChươngTrìnhToolStripMenuItem});
            this.ngườiDùngToolStripMenuItem.Name = "ngườiDùngToolStripMenuItem";
            this.ngườiDùngToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ngườiDùngToolStripMenuItem.Text = "Người dùng";
            // 
            // thôngTinNgườiDùngToolStripMenuItem
            // 
            this.thôngTinNgườiDùngToolStripMenuItem.Name = "thôngTinNgườiDùngToolStripMenuItem";
            this.thôngTinNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.thôngTinNgườiDùngToolStripMenuItem.Text = "Thông tin người dùng";
            this.thôngTinNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.thôngTinNgườiDùngToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // thoátChươngTrìnhToolStripMenuItem
            // 
            this.thoátChươngTrìnhToolStripMenuItem.Name = "thoátChươngTrìnhToolStripMenuItem";
            this.thoátChươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.thoátChươngTrìnhToolStripMenuItem.Text = "Thoát chương trình";
            this.thoátChươngTrìnhToolStripMenuItem.Click += new System.EventHandler(this.thoátChươngTrìnhToolStripMenuItem_Click);
            // 
            // kênhToolStripMenuItem
            // 
            this.kênhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem});
            this.kênhToolStripMenuItem.Name = "kênhToolStripMenuItem";
            this.kênhToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.kênhToolStripMenuItem.Text = "Kênh";
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập nhật";
            this.cậpNhậtToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.subscribedTab);
            this.tabControl.Controls.Add(this.globalTab);
            this.tabControl.Controls.Add(this.myfriend);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(310, 473);
            this.tabControl.TabIndex = 1;
            // 
            // subscribedTab
            // 
            this.subscribedTab.Controls.Add(this.btn_unsubscribe);
            this.subscribedTab.Controls.Add(this.subscribedList);
            this.subscribedTab.Location = new System.Drawing.Point(4, 24);
            this.subscribedTab.Name = "subscribedTab";
            this.subscribedTab.Padding = new System.Windows.Forms.Padding(3);
            this.subscribedTab.Size = new System.Drawing.Size(302, 445);
            this.subscribedTab.TabIndex = 0;
            this.subscribedTab.Text = "Đã theo dõi";
            this.subscribedTab.UseVisualStyleBackColor = true;
            // 
            // btn_unsubscribe
            // 
            this.btn_unsubscribe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unsubscribe.ForeColor = System.Drawing.Color.Black;
            this.btn_unsubscribe.Location = new System.Drawing.Point(189, 403);
            this.btn_unsubscribe.Name = "btn_unsubscribe";
            this.btn_unsubscribe.Size = new System.Drawing.Size(107, 34);
            this.btn_unsubscribe.TabIndex = 17;
            this.btn_unsubscribe.Text = "Bỏ đăng kí";
            this.btn_unsubscribe.UseVisualStyleBackColor = true;
            this.btn_unsubscribe.Click += new System.EventHandler(this.btn_unsubscribe_Click);
            // 
            // subscribedList
            // 
            this.subscribedList.FormattingEnabled = true;
            this.subscribedList.ItemHeight = 15;
            this.subscribedList.Location = new System.Drawing.Point(6, 21);
            this.subscribedList.Name = "subscribedList";
            this.subscribedList.Size = new System.Drawing.Size(290, 379);
            this.subscribedList.TabIndex = 0;
            this.subscribedList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.subscribedList_MouseDoubleClick);
            // 
            // globalTab
            // 
            this.globalTab.Controls.Add(this.label1);
            this.globalTab.Controls.Add(this.new_channel);
            this.globalTab.Controls.Add(this.globalList);
            this.globalTab.Location = new System.Drawing.Point(4, 24);
            this.globalTab.Name = "globalTab";
            this.globalTab.Padding = new System.Windows.Forms.Padding(3);
            this.globalTab.Size = new System.Drawing.Size(302, 445);
            this.globalTab.TabIndex = 1;
            this.globalTab.Text = "Kênh khác";
            this.globalTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Kênh mới";
            // 
            // new_channel
            // 
            this.new_channel.Location = new System.Drawing.Point(67, 410);
            this.new_channel.Name = "new_channel";
            this.new_channel.Size = new System.Drawing.Size(229, 23);
            this.new_channel.TabIndex = 20;
            this.new_channel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.new_channel_KeyDown);
            // 
            // globalList
            // 
            this.globalList.FormattingEnabled = true;
            this.globalList.ItemHeight = 15;
            this.globalList.Location = new System.Drawing.Point(6, 21);
            this.globalList.Name = "globalList";
            this.globalList.Size = new System.Drawing.Size(290, 379);
            this.globalList.TabIndex = 18;
            this.globalList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.globalList_MouseDoubleClick);
            // 
            // myfriend
            // 
            this.myfriend.Controls.Add(this.label2);
            this.myfriend.Controls.Add(this.txtAddFriend);
            this.myfriend.Controls.Add(this.myfriendList);
            this.myfriend.Location = new System.Drawing.Point(4, 24);
            this.myfriend.Name = "myfriend";
            this.myfriend.Size = new System.Drawing.Size(302, 445);
            this.myfriend.TabIndex = 2;
            this.myfriend.Text = "Bạn Bè";
            this.myfriend.UseVisualStyleBackColor = true;
            // 
            // myfriendList
            // 
            this.myfriendList.FormattingEnabled = true;
            this.myfriendList.ItemHeight = 15;
            this.myfriendList.Location = new System.Drawing.Point(9, 18);
            this.myfriendList.Name = "myfriendList";
            this.myfriendList.Size = new System.Drawing.Size(290, 379);
            this.myfriendList.TabIndex = 19;
            this.myfriendList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.myfriendList_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Bạn mới";
            // 
            // txtAddFriend
            // 
            this.txtAddFriend.Location = new System.Drawing.Point(63, 406);
            this.txtAddFriend.Name = "txtAddFriend";
            this.txtAddFriend.Size = new System.Drawing.Size(229, 23);
            this.txtAddFriend.TabIndex = 23;
            this.txtAddFriend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddFriend_KeyDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 512);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Xin chào {username}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.subscribedTab.ResumeLayout(false);
            this.globalTab.ResumeLayout(false);
            this.globalTab.PerformLayout();
            this.myfriend.ResumeLayout(false);
            this.myfriend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ngườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem thoátChươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage subscribedTab;
        private System.Windows.Forms.TabPage globalTab;
        private System.Windows.Forms.ListBox subscribedList;
        private System.Windows.Forms.Button btn_unsubscribe;
        private System.Windows.Forms.ListBox globalList;
        private System.Windows.Forms.TextBox new_channel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem kênhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.TabPage myfriend;
        private System.Windows.Forms.ListBox myfriendList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddFriend;
    }
}