namespace W5P_Resolution_Patcher
{
    partial class About
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
            this.label_AboutTitle = new System.Windows.Forms.Label();
            this.label_AboutAuthor = new System.Windows.Forms.Label();
            this.linkLabel_GitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_AboutTitle
            // 
            this.label_AboutTitle.AutoSize = true;
            this.label_AboutTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_AboutTitle.Location = new System.Drawing.Point(13, 9);
            this.label_AboutTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_AboutTitle.Name = "label_AboutTitle";
            this.label_AboutTitle.Size = new System.Drawing.Size(206, 22);
            this.label_AboutTitle.TabIndex = 0;
            this.label_AboutTitle.Text = "W5P Resolution Patcher";
            // 
            // label_AboutAuthor
            // 
            this.label_AboutAuthor.AutoSize = true;
            this.label_AboutAuthor.Location = new System.Drawing.Point(14, 31);
            this.label_AboutAuthor.Name = "label_AboutAuthor";
            this.label_AboutAuthor.Size = new System.Drawing.Size(68, 17);
            this.label_AboutAuthor.TabIndex = 1;
            this.label_AboutAuthor.Text = "By kKsk03";
            // 
            // linkLabel_GitHub
            // 
            this.linkLabel_GitHub.AutoSize = true;
            this.linkLabel_GitHub.Location = new System.Drawing.Point(16, 48);
            this.linkLabel_GitHub.Name = "linkLabel_GitHub";
            this.linkLabel_GitHub.Size = new System.Drawing.Size(48, 17);
            this.linkLabel_GitHub.TabIndex = 2;
            this.linkLabel_GitHub.TabStop = true;
            this.linkLabel_GitHub.Text = "GitHub";
            this.linkLabel_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GitHub_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 80);
            this.Controls.Add(this.linkLabel_GitHub);
            this.Controls.Add(this.label_AboutAuthor);
            this.Controls.Add(this.label_AboutTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 119);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 119);
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AboutTitle;
        private System.Windows.Forms.Label label_AboutAuthor;
        private System.Windows.Forms.LinkLabel linkLabel_GitHub;
    }
}