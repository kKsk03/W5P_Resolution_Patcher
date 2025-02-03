namespace W5P_Resolution_Patcher
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label_SelectGame = new System.Windows.Forms.Label();
            this.textBox_GameLocation = new System.Windows.Forms.TextBox();
            this.button_SelectGame = new System.Windows.Forms.Button();
            this.groupBox_ResChooseBox = new System.Windows.Forms.GroupBox();
            this.radioButton_3840_2160 = new System.Windows.Forms.RadioButton();
            this.radioButton_2560_1440 = new System.Windows.Forms.RadioButton();
            this.radioButton_1920_1080 = new System.Windows.Forms.RadioButton();
            this.radioButton_1280_720 = new System.Windows.Forms.RadioButton();
            this.radioButton_1360_768 = new System.Windows.Forms.RadioButton();
            this.button_ApplyRes = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.groupBox_ResChooseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_SelectGame
            // 
            this.label_SelectGame.AutoSize = true;
            this.label_SelectGame.Location = new System.Drawing.Point(12, 9);
            this.label_SelectGame.Name = "label_SelectGame";
            this.label_SelectGame.Size = new System.Drawing.Size(108, 17);
            this.label_SelectGame.TabIndex = 0;
            this.label_SelectGame.Text = "Select wmn5r.exe";
            // 
            // textBox_GameLocation
            // 
            this.textBox_GameLocation.Location = new System.Drawing.Point(15, 29);
            this.textBox_GameLocation.Name = "textBox_GameLocation";
            this.textBox_GameLocation.Size = new System.Drawing.Size(231, 23);
            this.textBox_GameLocation.TabIndex = 1;
            this.textBox_GameLocation.TextChanged += new System.EventHandler(this.textBox_GameLocation_TextChanged);
            // 
            // button_SelectGame
            // 
            this.button_SelectGame.Location = new System.Drawing.Point(252, 29);
            this.button_SelectGame.Name = "button_SelectGame";
            this.button_SelectGame.Size = new System.Drawing.Size(75, 23);
            this.button_SelectGame.TabIndex = 2;
            this.button_SelectGame.Text = "Select...";
            this.button_SelectGame.UseVisualStyleBackColor = true;
            this.button_SelectGame.Click += new System.EventHandler(this.button_SelectGame_Click);
            // 
            // groupBox_ResChooseBox
            // 
            this.groupBox_ResChooseBox.Controls.Add(this.radioButton_3840_2160);
            this.groupBox_ResChooseBox.Controls.Add(this.radioButton_2560_1440);
            this.groupBox_ResChooseBox.Controls.Add(this.radioButton_1920_1080);
            this.groupBox_ResChooseBox.Controls.Add(this.radioButton_1280_720);
            this.groupBox_ResChooseBox.Controls.Add(this.radioButton_1360_768);
            this.groupBox_ResChooseBox.Enabled = false;
            this.groupBox_ResChooseBox.Location = new System.Drawing.Point(15, 58);
            this.groupBox_ResChooseBox.Name = "groupBox_ResChooseBox";
            this.groupBox_ResChooseBox.Size = new System.Drawing.Size(312, 79);
            this.groupBox_ResChooseBox.TabIndex = 3;
            this.groupBox_ResChooseBox.TabStop = false;
            this.groupBox_ResChooseBox.Text = "Select resolution";
            // 
            // radioButton_3840_2160
            // 
            this.radioButton_3840_2160.AutoSize = true;
            this.radioButton_3840_2160.Location = new System.Drawing.Point(187, 22);
            this.radioButton_3840_2160.Name = "radioButton_3840_2160";
            this.radioButton_3840_2160.Size = new System.Drawing.Size(88, 21);
            this.radioButton_3840_2160.TabIndex = 4;
            this.radioButton_3840_2160.Text = "3840x2160";
            this.radioButton_3840_2160.UseVisualStyleBackColor = true;
            // 
            // radioButton_2560_1440
            // 
            this.radioButton_2560_1440.AutoSize = true;
            this.radioButton_2560_1440.Location = new System.Drawing.Point(93, 49);
            this.radioButton_2560_1440.Name = "radioButton_2560_1440";
            this.radioButton_2560_1440.Size = new System.Drawing.Size(88, 21);
            this.radioButton_2560_1440.TabIndex = 3;
            this.radioButton_2560_1440.Text = "2560x1440";
            this.radioButton_2560_1440.UseVisualStyleBackColor = true;
            // 
            // radioButton_1920_1080
            // 
            this.radioButton_1920_1080.AutoSize = true;
            this.radioButton_1920_1080.Location = new System.Drawing.Point(93, 22);
            this.radioButton_1920_1080.Name = "radioButton_1920_1080";
            this.radioButton_1920_1080.Size = new System.Drawing.Size(88, 21);
            this.radioButton_1920_1080.TabIndex = 2;
            this.radioButton_1920_1080.Text = "1920x1080";
            this.radioButton_1920_1080.UseVisualStyleBackColor = true;
            // 
            // radioButton_1280_720
            // 
            this.radioButton_1280_720.AutoSize = true;
            this.radioButton_1280_720.Location = new System.Drawing.Point(6, 49);
            this.radioButton_1280_720.Name = "radioButton_1280_720";
            this.radioButton_1280_720.Size = new System.Drawing.Size(81, 21);
            this.radioButton_1280_720.TabIndex = 1;
            this.radioButton_1280_720.Text = "1280x720";
            this.radioButton_1280_720.UseVisualStyleBackColor = true;
            // 
            // radioButton_1360_768
            // 
            this.radioButton_1360_768.AutoSize = true;
            this.radioButton_1360_768.Checked = true;
            this.radioButton_1360_768.Location = new System.Drawing.Point(6, 22);
            this.radioButton_1360_768.Name = "radioButton_1360_768";
            this.radioButton_1360_768.Size = new System.Drawing.Size(81, 21);
            this.radioButton_1360_768.TabIndex = 0;
            this.radioButton_1360_768.TabStop = true;
            this.radioButton_1360_768.Text = "1360x768";
            this.radioButton_1360_768.UseVisualStyleBackColor = true;
            // 
            // button_ApplyRes
            // 
            this.button_ApplyRes.Enabled = false;
            this.button_ApplyRes.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ApplyRes.Location = new System.Drawing.Point(15, 143);
            this.button_ApplyRes.Name = "button_ApplyRes";
            this.button_ApplyRes.Size = new System.Drawing.Size(243, 30);
            this.button_ApplyRes.TabIndex = 4;
            this.button_ApplyRes.Text = "Apply";
            this.button_ApplyRes.UseVisualStyleBackColor = true;
            this.button_ApplyRes.Click += new System.EventHandler(this.button_ApplyRes_Click);
            // 
            // button_About
            // 
            this.button_About.Location = new System.Drawing.Point(264, 143);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(63, 30);
            this.button_About.TabIndex = 5;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 185);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_ApplyRes);
            this.Controls.Add(this.groupBox_ResChooseBox);
            this.Controls.Add(this.button_SelectGame);
            this.Controls.Add(this.textBox_GameLocation);
            this.Controls.Add(this.label_SelectGame);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(355, 224);
            this.MinimumSize = new System.Drawing.Size(355, 224);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W5P Resolution Patcher";
            this.groupBox_ResChooseBox.ResumeLayout(false);
            this.groupBox_ResChooseBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_SelectGame;
        private System.Windows.Forms.TextBox textBox_GameLocation;
        private System.Windows.Forms.Button button_SelectGame;
        private System.Windows.Forms.GroupBox groupBox_ResChooseBox;
        private System.Windows.Forms.RadioButton radioButton_1360_768;
        private System.Windows.Forms.RadioButton radioButton_1280_720;
        private System.Windows.Forms.RadioButton radioButton_1920_1080;
        private System.Windows.Forms.RadioButton radioButton_2560_1440;
        private System.Windows.Forms.RadioButton radioButton_3840_2160;
        private System.Windows.Forms.Button button_ApplyRes;
        private System.Windows.Forms.Button button_About;
    }
}

