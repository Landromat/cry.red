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

namespace SkinSwapper
{
    public partial class msgBox : Form
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

        public msgBox()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();
            this.ShowInTaskbar = false;


            this.TopMost = true;
            label3.Text = SkinSwapper.Properties.Settings.Default.errMsg;
                button2.Visible = true;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (SkinSwapper.Properties.Settings.Default.buttonEnabled)
            {
                button2.Text = "Done!";
                button2.Visible = true;
                timer1.Stop();
            }

        }
    }
}
