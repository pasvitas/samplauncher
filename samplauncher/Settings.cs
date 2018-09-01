using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMPLauncher
{
    public partial class Settings : Form
    {


        public Settings()
        {
            InitializeComponent();
            tbPath.Text = ClientInfo.path;
        }

        private void bPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.CheckFileExists = true;
                ofd.Filter = "SAMP|samp.exe";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    tbPath.Text = Path.GetDirectoryName(ofd.FileName);

                }
            }
        }

        private void bDownloadSamp_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + "/SAMP/install.exe");
        }

        private void bDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientInfo.path = tbPath.Text;
        }
    }
}
