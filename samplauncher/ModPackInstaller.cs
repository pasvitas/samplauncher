﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XArchiveDragon;

namespace SAMPLauncher
{
    public partial class ModPackInstaller : Form
    {
        public ModPackInstaller()
        {
            InitializeComponent();
            if (ClientInfo.modpackstatus == 1) lStatus.Text = "Предыдущая установка не завершена";
            else if (ClientInfo.modpackstatus == 2) lStatus.Text = "Установлено";
        }

        private void bInstall_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(ClientInfo.path))
            {
                IMG_Archive gta3img = new IMG_Archive(ClientInfo.path + @"/models/gta3.img");
                MessageBox.Show("Открыто: " + ClientInfo.path + @"/models/gta3.img");
                string backupDirPath = string.Empty;
                lStatus.Text = "Установка...";
                ClientInfo.modpackstatus = 1;
                try
                {
                    MessageBox.Show(Directory.GetCurrentDirectory());
                    string[] pathes = Directory.GetFiles(Directory.GetCurrentDirectory() + @"/ModPack");
                    for(int i = 0; i < pathes.Length; i++)
                    {
                        pathes[i] = Path.GetFileName(pathes[i]);
                    }
                    gta3img.Replace(Directory.GetFiles(Directory.GetCurrentDirectory() + @"/ModPack"), pathes, true, backupDirPath, pbFileProgess);
                    MessageBox.Show("Replaces: " + Directory.GetFiles(Directory.GetCurrentDirectory() + "/ModPack")[0].ToString() + " to " + pathes[0]);
                    ClientInfo.modpackstatus = 2;
                    lStatus.Text = "Установлено";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберете путь с GTA SA");
            }
        }
    }
}