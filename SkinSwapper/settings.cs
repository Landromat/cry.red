using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections;

namespace SkinSwapper
{
    public partial class settings : UserControl
    {
        public settings()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = SkinSwapper.Properties.Settings.Default.pakFiles;
            string env = Environment.UserName;
            if (env == "Lumin")
            {
                label8.Text += "telerik";
            }
            else
            {
                label8.Text += env;
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // create a new folder dialog ---

            FolderBrowserDialog browser = new FolderBrowserDialog();
            string tempPath = "";

            if (browser.ShowDialog() == DialogResult.OK)
            {
                tempPath = browser.SelectedPath;
                textBox1.Text = tempPath;


                SkinSwapper.Properties.Settings.Default.pakFiles = tempPath;


                SkinSwapper.Properties.Settings.Default.Save();


            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SkinSwapper.Properties.Settings.Default.rogueagt = false;
            SkinSwapper.Properties.Settings.Default.elf = false;
            SkinSwapper.Properties.Settings.Default.ikonik = false;
            SkinSwapper.Properties.Settings.Default.fable = false;
            SkinSwapper.Properties.Settings.Default.frozen = false;
            SkinSwapper.Properties.Settings.Default.RngRaider = false;
            SkinSwapper.Properties.Settings.Default.galaxyWing = false;
            SkinSwapper.Properties.Settings.Default.ghTrooper = false;
            SkinSwapper.Properties.Settings.Default.whipLash = false;
            SkinSwapper.Properties.Settings.Default.redLine = false;
            SkinSwapper.Properties.Settings.Default.bkshield = false;
            SkinSwapper.Properties.Settings.Default.uplink = false;
            SkinSwapper.Properties.Settings.Default.reconExp = false;
            SkinSwapper.Properties.Settings.Default.shattered = false;
            SkinSwapper.Properties.Settings.Default.galaxyGril = false;
            SkinSwapper.Properties.Settings.Default.darkBmber = false;
            SkinSwapper.Properties.Settings.Default.bday_cake = false;
            SkinSwapper.Properties.Settings.Default.buttonEnabled = true;
            SkinSwapper.Properties.Settings.Default.season1 = false;
            SkinSwapper.Properties.Settings.Default.Save();

            

            SkinSwapper.Properties.Settings.Default.errMsg = "Successfully reset config!";
            Form te = new msgBox();
            te.Show();

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form issReport = new reportIssue();
            issReport.Show();
        }

        private void Label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Label2_MouseHover(object sender, EventArgs e)
        {

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

        private void Label4_MouseDown(object sender, MouseEventArgs e)
        {

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

        private void Label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(229, 9, 79);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
