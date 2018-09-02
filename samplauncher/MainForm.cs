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


            try
            {
                using (StreamReader sw = new StreamReader(Directory.GetCurrentDirectory() + "/settings.json"))
                {

                    string json = sw.ReadToEnd();
                    cis = JsonConvert.DeserializeObject<ClientInfoSave>(json);
                    ClientInfo.nickname = cis.nickname;
                    ClientInfo.path = cis.path;
                    ClientInfo.modpackstatus = cis.modpackstatus;
                    ClientInfo.exitonstart = cis.exitonstart;
                    sw.Close();
                }
            }
            catch
            {

            }
            tbNickname.Text = ClientInfo.nickname;

            this.Text = ServerInfo.servername + " launcher";
            bModpack.Enabled = ServerInfo.allowInstallModPack;
            if (!ServerInfo.allowInstallModPack) bModpack.Hide();

        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (tbNickname.Text.Length >= 3 && tbNickname.Text.Length <= 32)
            {
                ClientInfo.nickname = tbNickname.Text;
                Process.Start(ClientInfo.path + "/samp.exe", ServerInfo.ip + ":" + ServerInfo.port + " -n" + ClientInfo.nickname);
                if (ClientInfo.exitonstart)
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Длина Никнейма должна быть больше 3 и меньше 32 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bModpack_Click(object sender, EventArgs e)
        {
            ModPackInstaller formMPI = new ModPackInstaller();
            formMPI.ShowDialog();
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            Settings formSettings = new Settings();
            
            formSettings.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClientInfoSave cis = new ClientInfoSave();
            cis.nickname = ClientInfo.nickname;
            cis.path = ClientInfo.path;
            cis.modpackstatus = ClientInfo.modpackstatus;
            cis.exitonstart = ClientInfo.exitonstart;
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
        public static readonly string servername = "SAMP"; // Название сервера
        public static readonly string ip = "127.0.0.1"; // IP
        public static readonly string port = "7779"; // Порт
        public static readonly string group = "pasvitas"; // Группа ВКонтакте. Только id или краткое имя (без vk.com)
        public static readonly string site = "htpps://github.com/pasvitas/samplauncher"; // Сайт
        public static readonly bool allowInstallSamp = true; //Добавляет кнопку "Установить SAMP"
        public static readonly bool allowInstallModPack = true; //Добавляет кнопку "Установить модпак"
    }

    static public class ClientInfo
    {
        public static string nickname = "Nickname";
        public static string path = " ";
        public static int modpackstatus = 0;
        public static bool exitonstart = false;
    }

    public class ClientInfoSave
    {
        public string nickname = "Nickname";
        public string path = " ";
        public int modpackstatus = 0;
        public bool exitonstart = false;
    }

   
}
