namespace PasswordFinder
{
    partial class AboutForm
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
            this.licenseBox = new System.Windows.Forms.TextBox();
            this.GitPage = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(179, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = " PASSWORDFINDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Release Version 1.0.1 - 2019.02.16";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Made By Re-Coma(Ha-Jeong-Hyun)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "In BAKHWA PROJECT";
            // 
            // licenseBox
            // 
            this.licenseBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseBox.Location = new System.Drawing.Point(12, 191);
            this.licenseBox.Multiline = true;
            this.licenseBox.Name = "licenseBox";
            this.licenseBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.licenseBox.Size = new System.Drawing.Size(723, 325);
            this.licenseBox.TabIndex = 4;
            // 
            // GitPage
            // 
            this.GitPage.AutoSize = true;
            this.GitPage.Location = new System.Drawing.Point(12, 166);
            this.GitPage.Name = "GitPage";
            this.GitPage.Size = new System.Drawing.Size(112, 12);
            this.GitPage.TabIndex = 5;
            this.GitPage.TabStop = true;
            this.GitPage.Text = "Re-Coma\'s GitHub";
            this.GitPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitPage_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(747, 528);
            this.Controls.Add(this.GitPage);
            this.Controls.Add(this.licenseBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.Click += new System.EventHandler(this.AboutForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox licenseBox;
        private System.Windows.Forms.LinkLabel GitPage;
    }
}