using System;
using System.IO;
using System.Windows.Forms;

namespace W5P_Resolution_Patcher
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void button_SelectGame_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "wmn5r.exe|wmn5r.exe";
            openFileDialog.Title = "Select wmn5r.exe";
            openFileDialog.InitialDirectory = @"C:\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (!validateGameFile(filePath))
                {
                    MessageBox.Show("Please choose version 3.00.05 (Update 05) of wmn5r.exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                textBox_GameLocation.Text = filePath;
            }
        }

        public bool validateGameFile(string gameFilePath)
        {
            long length = new FileInfo(gameFilePath).Length;
            long num = 35321856;
            if (length != num)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBox_GameLocation_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_GameLocation.Text))
            {
                groupBox_ResChooseBox.Enabled = false;
                button_ApplyRes.Enabled = false;
            }
            else
            {
                if (textBox_GameLocation.Text.Contains("wmn5r.exe"))
                {
                    groupBox_ResChooseBox.Enabled = true;
                    button_ApplyRes.Enabled = true;
                }
                else
                {
                    groupBox_ResChooseBox.Enabled = false;
                    button_ApplyRes.Enabled = false;
                }
            }
        }

        private void button_ApplyRes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_GameLocation.Text))
            {
                MessageBox.Show("Please select wmn5r.exe above first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!File.Exists(textBox_GameLocation.Text))
            {
                MessageBox.Show("wmn5r.exe does not exist in the path you selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            short Xres = Convert.ToInt16("1360");
            short Yres = Convert.ToInt16("768");
            if (radioButton_1360_768.Checked == true)
            {
                Xres = Convert.ToInt16("1360");
                Yres = Convert.ToInt16("768");
            }
            else if (radioButton_1280_720.Checked == true)
            {
                Xres = Convert.ToInt16("1280");
                Yres = Convert.ToInt16("720");
            }
            else if (radioButton_1920_1080.Checked == true)
            {
                Xres = Convert.ToInt16("1920");
                Yres = Convert.ToInt16("1080");
            }
            else if (radioButton_2560_1440.Checked == true)
            {
                Xres = Convert.ToInt16("2560");
                Yres = Convert.ToInt16("1440");
            }
            else if (radioButton_3840_2160.Checked == true)
            {
                Xres = Convert.ToInt16("3840");
                Yres = Convert.ToInt16("2160");
            }
            else
            {
                MessageBox.Show("Please select resolution", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Start Patch
            try
            {
                string gameLocation = textBox_GameLocation.Text;
                Directory.SetCurrentDirectory(Path.GetDirectoryName(gameLocation));
                try
                {
                    File.Copy(gameLocation, "wmn5r.bak", overwrite: false);
                }
                catch
                {
                    Console.WriteLine("Backup already exists!");
                }
                byte[] buffer = new byte[44];
                using (FileStream fileStream = new FileStream(gameLocation, FileMode.Open, FileAccess.ReadWrite))
                {
                    byte[] buffer2 = new byte[6] { 233, 191, 40, 90, 0, 144 };
                    fileStream.Position = 9706168; // 0x9426B8
                    fileStream.Write(buffer2, 0, 6);
                    byte[] buffer3 = new byte[5] { 233, 214, 5, 90, 0 };
                    fileStream.Position = 9715129; // 0x9449B9
                    fileStream.Write(buffer3, 0, 5);
                    byte[] buffer4 = new byte[46]
                    {
                    199, 69, 168, 85, 85, 53, 63, 243, 68, 15,
                    89, 93, 168, 243, 68, 15, 17, 93, 168, 233,
                    42, 215, 165, 255, 199, 69, 216, 85, 85, 53,
                    63, 243, 15, 89, 69, 216, 243, 15, 17, 69,
                    216, 233, 20, 250, 165, 255
                    };
                    fileStream.Position = 15614844; // 0xEE4F7C
                    fileStream.Write(buffer4, 0, 46);
                    byte[] bytes = BitConverter.GetBytes(Xres);
                    byte[] bytes2 = BitConverter.GetBytes(Yres);
                    BitConverter.GetBytes(Xres * 4);
                    BitConverter.GetBytes(Yres * 4);
                    fileStream.Position = 2315563; // 0x23612B
                    fileStream.Write(bytes, 0, 2);
                    fileStream.Position = 2315569; // 0x236131
                    fileStream.Write(bytes2, 0, 2);
                    fileStream.Position = 12074411; // 0xB849AB
                    fileStream.Write(bytes, 0, 2);
                    fileStream.Position = 12074419; // 0xB849B3
                    fileStream.Write(bytes2, 0, 2);
                    fileStream.Position = 12072562; // 0xB84272
                    fileStream.Write(bytes, 0, 2);
                    fileStream.Position = 12072575; // 0xB8427F
                    fileStream.Write(bytes2, 0, 2);
                    // Only 16:9
                    byte[] bytes3 = BitConverter.GetBytes(765f / (float)Yres);
                    byte[] buffer5 = new byte[24]
                    {
                        57, 142, 227, 63, 243, 15, 17, 69, 176, 243,
                        15, 17, 77, 180, 243, 15, 17, 69, 144, 243,
                        15, 17, 77, 148
                    };
                    fileStream.Position = 1670846; // 0x198ABE
                    byte[] buffer6 = new byte[4] { 171, 170, 226, 63 };
                    fileStream.Position = 956777; // 0x0EA569
                    fileStream.Write(buffer6, 0, 4);
                    fileStream.Position = 15614847; // 0xEE4F7F
                    fileStream.Write(bytes3, 0, 4);
                    fileStream.Position = 15614871; // 0xEE4F97
                    fileStream.Write(bytes3, 0, 4);
                    fileStream.Position = 9706109; // 0x94267D
                    fileStream.Write(buffer5, 4, 5);
                    fileStream.Position = 9711722; // 0x943C6A
                    fileStream.Write(buffer5, 14, 5);
                    fileStream.Position = 15614890; // 0xEE4FAA
                    fileStream.Write(buffer, 0, 44);
                }
                MessageBox.Show("Applied changes", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("Unable to read or write wmn5r.exe, please close the game and run this program as administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
