namespace PasswordFinder
{
    partial class ModifyInfoForm
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
            this.MainText = new System.Windows.Forms.Label();
            this.CommentText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RePaswdText = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.pswdBox = new System.Windows.Forms.TextBox();
            this.RepswdBox = new System.Windows.Forms.TextBox();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.Location = new System.Drawing.Point(183, 24);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(69, 12);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "사용자 확인";
            this.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommentText
            // 
            this.CommentText.AutoSize = true;
            this.CommentText.Location = new System.Drawing.Point(67, 71);
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(289, 12);
            this.CommentText.TabIndex = 1;
            this.CommentText.Text = "사용자 확인을 위해 아이디와 비밀번호를 입력하세요";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "비밀번호";
            // 
            // RePaswdText
            // 
            this.RePaswdText.AutoSize = true;
            this.RePaswdText.Location = new System.Drawing.Point(41, 213);
            this.RePaswdText.Name = "RePaswdText";
            this.RePaswdText.Size = new System.Drawing.Size(81, 12);
            this.RePaswdText.TabIndex = 4;
            this.RePaswdText.Text = "비밀번호 확인";
            this.RePaswdText.Visible = false;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(144, 127);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(226, 21);
            this.idBox.TabIndex = 5;
            // 
            // pswdBox
            // 
            this.pswdBox.Location = new System.Drawing.Point(144, 167);
            this.pswdBox.Name = "pswdBox";
            this.pswdBox.PasswordChar = '*';
            this.pswdBox.Size = new System.Drawing.Size(226, 21);
            this.pswdBox.TabIndex = 6;
            // 
            // RepswdBox
            // 
            this.RepswdBox.Location = new System.Drawing.Point(144, 209);
            this.RepswdBox.Name = "RepswdBox";
            this.RepswdBox.PasswordChar = '*';
            this.RepswdBox.Size = new System.Drawing.Size(226, 21);
            this.RepswdBox.TabIndex = 7;
            this.RepswdBox.Visible = false;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(43, 270);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(98, 35);
            this.OKBtn.TabIndex = 8;
            this.OKBtn.Text = "확인";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(270, 270);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(100, 35);
            this.CancelBtn.TabIndex = 9;
            this.CancelBtn.Text = "취소";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ModifyInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(438, 350);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.RepswdBox);
            this.Controls.Add(this.pswdBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.RePaswdText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CommentText);
            this.Controls.Add(this.MainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifyInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "계정 수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Label CommentText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RePaswdText;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox pswdBox;
        private System.Windows.Forms.TextBox RepswdBox;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}