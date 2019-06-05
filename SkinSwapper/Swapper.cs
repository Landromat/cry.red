using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace SkinSwapper
{
    public partial class Swapper : Form
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


        public Swapper()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 2, 2));
        }

        private void Swapper_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Swapper_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Skins11_Load(object sender, EventArgs e)
        {

        }

        private void Skins11_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Skins11_Load_1(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void switchpanel()
        {
            panel2.BringToFront();
            panel1.BringToFront();
            panel3.BringToFront();
            pictureBox2.BringToFront();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            skins11.BringToFront();
            switchpanel();
        }

        private void Label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            settings1.BringToFront();
            switchpanel();
        }

        private void Label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            backblings1.BringToFront();
            switchpanel();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/QVxC8S");
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            other1.BringToFront();
            switchpanel();
        }

        private void Label4_MouseHover(object sender, EventArgs e)
        {

        }

        private void Panel4_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
