using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinSwapper
{
    public partial class reportIssue : Form
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

        public reportIssue()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }

        private void ReportIssue_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;


            this.TopMost = true;
            this.CenterToScreen();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Message" || textBox2.Text == "Your Discord#0000")
            {
                SkinSwapper.Properties.Settings.Default.errMsg = "Please fill out all fields!";
                Form err = new msgBox();
                err.Show();
            }
            else
            {
                string ip = new WebClient().DownloadString("http://icanhazip.com/");

                using (dWebHook dcWeb = new dWebHook())
                {
                    dcWeb.ProfilePicture = "https://static.giantbomb.com/uploads/original/4/42381/1196379-gas_mask_respirator.jpg";
                    dcWeb.UserName = "Issue Report";
                    dcWeb.WebHook = "https://discordapp.com/api/webhooks/585273503176065039/4ALHTDcPzlH7mj5yKXAdMMz8FjkB5dRorSPrxrbhANnfmFPmJP5hJ3yR_0BXTEwcjKh5";
                    dcWeb.SendMessage(textBox1.Text + " - " + textBox2.Text);
                }
                SkinSwapper.Properties.Settings.Default.errMsg = "issue submitted!";
                Form err = new msgBox();
                err.Show();
                this.Close();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
