using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SkinSwapper
{
    public partial class other : UserControl
    {
        public other()
        {
            InitializeComponent();
        }

        bool checkPak()
        {
            // this just checks if our string in settings is empty,

            if (SkinSwapper.Properties.Settings.Default.pakFiles == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            if (SkinSwapper.Properties.Settings.Default.season1)
            {
                SkinSwapper.Properties.Settings.Default.errMsg = "lobby swap already in use!";
                Form err = new msgBox();
                err.Show();
            }
            else
            {
                if (checkPak())
                {
                    SkinSwapper.Properties.Settings.Default.buttonEnabled = false;
                    SkinSwapper.Properties.Settings.Default.errMsg = "swapped lobby! This feature may not work!";
                    Form err = new msgBox();
                    err.Show();

                    // do final initialization
                    string path = SkinSwapper.Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak";
                    string path2 = SkinSwapper.Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                    if (File.Exists(path) && File.Exists(path2))
                    {
                        smethod_0(path2, 329881841L, byte_1);
                        SkinSwapper.Properties.Settings.Default.season1 = true;

                        SkinSwapper.Properties.Settings.Default.Save();
                        SkinSwapper.Properties.Settings.Default.buttonEnabled = true;
                    }
                    else
                    {
                        SkinSwapper.Properties.Settings.Default.errMsg = "pak files not found in specified folder!";
                        Form te = new msgBox();
                        te.Show();
                    }
                }
                else
                {
                    SkinSwapper.Properties.Settings.Default.errMsg = @"specify your ""paks"" folder in settings";
                    Form err = new msgBox();
                    err.Show();
                }
            }
        }


        public static void smethod_0(string string_0, long long_0, byte[] byte_20)
        {
            BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(long_0, SeekOrigin.Begin);
            binaryWriter.Write(byte_20);
            binaryWriter.Close();
        }

        private void Other_Load(object sender, EventArgs e)
        {

        }


        #region region.bytes

        private static byte[] byte_0 = new byte[]
    {
        47,
        71,
        97,
        109,
        101,
        47,
        73,
        116,
        101,
        109,
        115,
        47,
        69,
        118,
        101,
        110,
        116,
        115,
        47,
        83,
        104,
        97,
        114,
        101,
        100,
        47,
        76,
        111,
        98,
        98,
        121,
        66,
        71,
        95,
        83,
        101,
        97,
        115,
        111,
        110,
        57,
        46,
        76,
        111,
        98,
        98,
        121,
        66,
        71,
        95,
        83,
        101,
        97,
        115,
        111,
        110,
        57
    };

        // Token: 0x04000060 RID: 96
        private static byte[] byte_1 = new byte[]
        {
        47,
        71,
        97,
        109,
        101,
        47,
        73,
        116,
        101,
        109,
        115,
        47,
        69,
        118,
        101,
        110,
        116,
        115,
        47,
        83,
        104,
        97,
        114,
        101,
        100,
        47,
        76,
        111,
        98,
        98,
        121,
        66,
        71,
        95,
        83,
        101,
        97,
        103,
        111,
        110,
        57,
        46,
        76,
        111,
        98,
        98,
        100,
        66,
        71,
        95,
        114,
        101,
        97,
        115,
        102,
        110,
        57
        };


        #endregion

        private void Button3_Click(object sender, EventArgs e)
        {
            if (SkinSwapper.Properties.Settings.Default.season1)
            {

                if (checkPak())
                {
                    SkinSwapper.Properties.Settings.Default.buttonEnabled = false;
                    SkinSwapper.Properties.Settings.Default.errMsg = "reverted lobby!";
                    Form err = new msgBox();
                    err.Show();

                    // do final initialization
                    string path = SkinSwapper.Properties.Settings.Default.pakFiles + "\\pakchunk0-WindowsClient.pak";
                    string path2 = SkinSwapper.Properties.Settings.Default.pakFiles + "\\pakchunk10_s1-WindowsClient.pak";
                    if (File.Exists(path) && File.Exists(path2))
                    {
                        smethod_0(path2, 1441793175L, byte_0);
                        SkinSwapper.Properties.Settings.Default.season1 = false;

                        SkinSwapper.Properties.Settings.Default.Save();
                        SkinSwapper.Properties.Settings.Default.buttonEnabled = true;
                    }
                    else
                    {
                        SkinSwapper.Properties.Settings.Default.errMsg = "pak files not found in specified folder!";
                        Form te = new msgBox();
                        te.Show();
                    }
                }
                else
                {
                    SkinSwapper.Properties.Settings.Default.errMsg = @"specify your ""paks"" folder in settings";
                    Form err = new msgBox();
                    err.Show();
                }
            }
            else
            {
                SkinSwapper.Properties.Settings.Default.errMsg = "lobby swapper isn't in use!";
                Form te = new msgBox();
                te.Show();
            }
        }
    }
}
