using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.InteropServices;
using System.Net;
using System.Drawing.Text;
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;

namespace SkinSwapper
{
    public partial class Form1 : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // height of ellipse
    int nHeightEllipse // width of ellipse
);


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();






        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 2, 2));
        }



        bool isElevated;
        /// <summary>
        /// /
        /// </summary>

        string checksum;

        private void Form1_Load(object sender, EventArgs e)
        {
            //      SkinSwapper.Properties.Settings.Default.pakFiles = "";
            //checksum = new WebClient().DownloadString("https://reserve-beds.000webhostapp.com/checksum_version.txt");
            label2.Visible = false;
            panel5.Visible = false;
            this.CenterToScreen();
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            if (isElevated)
            {
                // check for font

                string fontDestination = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Fonts), "braindead_font.ttf");
                if (File.Exists(fontDestination))
                {
                    // font is installed continue

                    
                
                }
                else
                {
                    MessageBox.Show(@"You must install ""braindead_font.ttf"" before continuing!");
                    WebClient wc = new WebClient();
                    wc.DownloadFile("http://aetherial.win/visitor2.ttf", "braindead_font.ttf");
                    Process.Start("braindead_font.ttf");
                    Application.Exit();
                }

                // check for font
            }
            else
            {
                MessageBox.Show("Run as administrator!");
                Application.Exit();
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        { 
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*
        string
        myText="this is my text to write";
        for(int i=0;i<myText.Length;i++)
        {
        Console.Write(myText[i]);
        System.Threading.
        Thread.Sleep(50);
        }
        */
         
        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {//
                label2.Text = "checking for updates...";
                label2.Visible = true;
                panel5.Visible = true;
                timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (panel4.Width < 167)
            {
                panel4.Size = new Size(panel4.Width + 2, 1);
            }
            else
            {
                timer2.Stop();
                this.Hide();
                Form main = new Swapper();
                main.ShowDialog();
                this.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/QVxC8S");
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            if (panel4.Width < 85)
            {
                panel4.Size = new Size(panel4.Width + 2, 1);
            }
            else
            {
                label2.Text = "update found! Check discord";
                panel4.BackColor = Color.FromArgb(100, 0, 255);
                timer3.Start();
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(4000);
            Application.Exit();
        }
    }
}
