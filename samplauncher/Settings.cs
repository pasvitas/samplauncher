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
            cbExitOnStart.Checked = ClientInfo.exitonstart;

            //FIXME: По какой-то причине не работает. C#, спаси
            bDownloadSamp.Enabled = ServerInfo.allowInstallSamp;
            if (!ServerInfo.allowInstallSamp) bDownloadSamp.Hide(); 

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
                    ClientInfo.path = tbPath.Text;
                }
            }
        }

        private void bDownloadSamp_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Directory.GetCurrentDirectory() + "/SAMP/install.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bDone_Click(object sender, EventArgs e)
        {
            ClientInfo.path = tbPath.Text;
            this.Close();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientInfo.path = tbPath.Text;
        }

        private void cbExitOnStart_CheckedChanged(object sender, EventArgs e)
        {
            ClientInfo.exitonstart = cbExitOnStart.Checked;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }
    }
}
