namespace PasswordFinder
{
    partial class InputForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SiteBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.PswdBox = new System.Windows.Forms.TextBox();
            this.InputBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "새 데이터를 추가합니다";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "사이트 및 프로그램 이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "아이디";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "비밀번호";
            // 
            // SiteBox
            // 
            this.SiteBox.Location = new System.Drawing.Point(179, 71);
            this.SiteBox.Name = "SiteBox";
            this.SiteBox.Size = new System.Drawing.Size(247, 21);
            this.SiteBox.TabIndex = 4;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(179, 109);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(247, 21);
            this.idBox.TabIndex = 5;
            // 
            // PswdBox
            // 
            this.PswdBox.Location = new System.Drawing.Point(179, 147);
            this.PswdBox.Name = "PswdBox";
            this.PswdBox.Size = new System.Drawing.Size(247, 21);
            this.PswdBox.TabIndex = 6;
            // 
            // InputBtn
            // 
            this.InputBtn.Location = new System.Drawing.Point(217, 194);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(93, 26);
            this.InputBtn.TabIndex = 7;
            this.InputBtn.Text = "입력";
            this.InputBtn.UseVisualStyleBackColor = true;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(333, 194);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(93, 26);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "취소";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(495, 232);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.PswdBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.SiteBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "데이터 추가";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SiteBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox PswdBox;
        private System.Windows.Forms.Button InputBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}