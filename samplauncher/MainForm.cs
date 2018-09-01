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
using Newtonsoft.Json;

namespace SAMPLauncher
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            ClientInfoSave cis = new ClientInfoSave();
            if (!File.Exists(Directory.GetCurrentDirectory() + "/settings.json"))
            {
                string serialized = JsonConvert.SerializeObject(cis);
                using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/settings.json"))
                {
                    sw.Write(serialized);
                    sw.Close();
                }
            }

            using (StreamReader sw = new StreamReader(Directory.GetCurrentDirectory()+"/settings.json"))
            {
               
                string json = sw.ReadToEnd();
                cis = JsonConvert.DeserializeObject<ClientInfoSave>(json);
                ClientInfo.nickname = cis.nickname;
                ClientInfo.path = cis.path;
                ClientInfo.modpackstatus = cis.modpackstatus;
                sw.Close();
            }
            tbNickname.Text = ClientInfo.nickname;

            this.Text = ServerInfo.servername + " launcher";

        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (tbNickname.Text.Length >= 3 && tbNickname.Text.Length <= 32)
            {
                ClientInfo.nickname = tbNickname.Text;
                Process.Start(ClientInfo.path + "/samp.exe -c -n " + ClientInfo.nickname + " -h " + ServerInfo.ip + " -p " + ServerInfo.port);
            }
            else
            {
                MessageBox.Show("Длина Никнейма должна быть больше 3 и меньше 32 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bModpack_Click(object sender, EventArgs e)
        {
            ModPackInstaller formMPI = new ModPackInstaller();
            formMPI.Show();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            Settings formSettings = new Settings();
            formSettings.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientInfoSave cis = new ClientInfoSave();
            cis.nickname = ClientInfo.nickname;
            cis.path = ClientInfo.path;
            cis.modpackstatus = ClientInfo.modpackstatus;
            string serialized = JsonConvert.SerializeObject(cis);
            using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/settings.json"))
            {
                sw.Write(serialized);
                sw.Close();
            }
        }

        private void pbVK_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/"+ServerInfo.group);
        }

        private void pbSite_Click(object sender, EventArgs e)
        {
            Process.Start(ServerInfo.site);
        }
    }

    static class ServerInfo
    {
        public static readonly string servername = "SAMP";
        public static readonly string ip = "127.0.0.1";
        public static readonly string port = "7777";
        public static readonly string group = "club1"; // Группа ВКонтакте
        public static readonly string site = "htpps://github.com/pasvitas/samplauncher";
    }

    static public class ClientInfo
    {
        public static string nickname = "Nickname";
        public static string path = " ";
        public static int modpackstatus = 0;
    }

    public class ClientInfoSave
    {
        public string nickname = "Nickname";
        public string path = " ";
        public int modpackstatus = 0;
    }

   
}
