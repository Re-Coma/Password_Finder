namespace PasswordFinder
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.DataStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.InputDataStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyDataStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDataStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DataView = new System.Windows.Forms.ListView();
            this.Site = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pswd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selectMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyId = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPaswd = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.reviveStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.selectMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataStripMenu,
            this.GuestStripMenu,
            this.도움말HToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(441, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // DataStripMenu
            // 
            this.DataStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InputDataStrip,
            this.ModifyDataStrip,
            this.DeleteDataStrip});
            this.DataStripMenu.Name = "DataStripMenu";
            this.DataStripMenu.Size = new System.Drawing.Size(72, 20);
            this.DataStripMenu.Text = "데이터(&D)";
            // 
            // InputDataStrip
            // 
            this.InputDataStrip.Name = "InputDataStrip";
            this.InputDataStrip.Size = new System.Drawing.Size(98, 22);
            this.InputDataStrip.Text = "추가";
            this.InputDataStrip.Click += new System.EventHandler(this.InputDataStrip_Click);
            // 
            // ModifyDataStrip
            // 
            this.ModifyDataStrip.Name = "ModifyDataStrip";
            this.ModifyDataStrip.Size = new System.Drawing.Size(98, 22);
            this.ModifyDataStrip.Text = "변경";
            this.ModifyDataStrip.Click += new System.EventHandler(this.ModifyDataStrip_Click);
            // 
            // DeleteDataStrip
            // 
            this.DeleteDataStrip.Name = "DeleteDataStrip";
            this.DeleteDataStrip.Size = new System.Drawing.Size(98, 22);
            this.DeleteDataStrip.Text = "제거";
            this.DeleteDataStrip.Click += new System.EventHandler(this.DeleteDataStrip_Click);
            // 
            // GuestStripMenu
            // 
            this.GuestStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModifyInfo});
            this.GuestStripMenu.Name = "GuestStripMenu";
            this.GuestStripMenu.Size = new System.Drawing.Size(59, 20);
            this.GuestStripMenu.Text = "계정(&G)";
            // 
            // ModifyInfo
            // 
            this.ModifyInfo.Name = "ModifyInfo";
            this.ModifyInfo.Size = new System.Drawing.Size(191, 22);
            this.ModifyInfo.Text = "아이디/패스워드 수정";
            this.ModifyInfo.Click += new System.EventHandler(this.ModifyInfo_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutStrip});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // AboutStrip
            // 
            this.AboutStrip.Name = "AboutStrip";
            this.AboutStrip.Size = new System.Drawing.Size(113, 22);
            this.AboutStrip.Text = "About..";
            this.AboutStrip.Click += new System.EventHandler(this.AboutStrip_Click);
            // 
            // DataView
            // 
            this.DataView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Site,
            this.ID,
            this.Pswd});
            this.DataView.ContextMenuStrip = this.selectMenu;
            this.DataView.Location = new System.Drawing.Point(12, 27);
            this.DataView.MultiSelect = false;
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(417, 401);
            this.DataView.TabIndex = 1;
            this.DataView.UseCompatibleStateImageBehavior = false;
            this.DataView.View = System.Windows.Forms.View.Details;
            // 
            // Site
            // 
            this.Site.Text = "Site";
            this.Site.Width = 118;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 124;
            // 
            // Pswd
            // 
            this.Pswd.Text = "Password";
            this.Pswd.Width = 163;
            // 
            // selectMenu
            // 
            this.selectMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyId,
            this.copyPaswd,
            this.deleteStrip,
            this.reviveStrip});
            this.selectMenu.Name = "selectMenu";
            this.selectMenu.Size = new System.Drawing.Size(181, 114);
            // 
            // copyId
            // 
            this.copyId.Name = "copyId";
            this.copyId.Size = new System.Drawing.Size(150, 22);
            this.copyId.Text = "아이디 복사";
            this.copyId.Click += new System.EventHandler(this.copyId_Click);
            // 
            // copyPaswd
            // 
            this.copyPaswd.Name = "copyPaswd";
            this.copyPaswd.Size = new System.Drawing.Size(180, 22);
            this.copyPaswd.Text = "패스워드 복사";
            this.copyPaswd.Click += new System.EventHandler(this.copyPaswd_Click);
            // 
            // deleteStrip
            // 
            this.deleteStrip.Name = "deleteStrip";
            this.deleteStrip.Size = new System.Drawing.Size(180, 22);
            this.deleteStrip.Text = "제거";
            this.deleteStrip.Click += new System.EventHandler(this.DeleteDataStrip_Click);
            // 
            // reviveStrip
            // 
            this.reviveStrip.Name = "reviveStrip";
            this.reviveStrip.Size = new System.Drawing.Size(180, 22);
            this.reviveStrip.Text = "수정";
            this.reviveStrip.Click += new System.EventHandler(this.ModifyInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(441, 440);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordFinder";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.selectMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem DataStripMenu;
        private System.Windows.Forms.ToolStripMenuItem GuestStripMenu;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutStrip;
        private System.Windows.Forms.ToolStripMenuItem InputDataStrip;
        private System.Windows.Forms.ToolStripMenuItem ModifyDataStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteDataStrip;
        private System.Windows.Forms.ToolStripMenuItem ModifyInfo;
        private System.Windows.Forms.ListView DataView;
        private System.Windows.Forms.ColumnHeader Site;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Pswd;
        private System.Windows.Forms.ContextMenuStrip selectMenu;
        private System.Windows.Forms.ToolStripMenuItem copyId;
        private System.Windows.Forms.ToolStripMenuItem copyPaswd;
        private System.Windows.Forms.ToolStripMenuItem deleteStrip;
        private System.Windows.Forms.ToolStripMenuItem reviveStrip;
    }
}