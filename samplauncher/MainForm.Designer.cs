namespace SAMPLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbNickname = new System.Windows.Forms.TextBox();
            this.bPlay = new System.Windows.Forms.Button();
            this.bModpack = new System.Windows.Forms.Button();
            this.lNickname = new System.Windows.Forms.Label();
            this.bSettings = new System.Windows.Forms.Button();
            this.pbVK = new System.Windows.Forms.PictureBox();
            this.pbSite = new System.Windows.Forms.PictureBox();
            this.lRights = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSite)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNickname
            // 
            this.tbNickname.Location = new System.Drawing.Point(264, 418);
            this.tbNickname.Name = "tbNickname";
            this.tbNickname.Size = new System.Drawing.Size(147, 20);
            this.tbNickname.TabIndex = 0;
            // 
            // bPlay
            // 
            this.bPlay.Location = new System.Drawing.Point(433, 368);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(238, 70);
            this.bPlay.TabIndex = 1;
            this.bPlay.Text = "Играть";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // bModpack
            // 
            this.bModpack.Location = new System.Drawing.Point(264, 368);
            this.bModpack.Name = "bModpack";
            this.bModpack.Size = new System.Drawing.Size(147, 23);
            this.bModpack.TabIndex = 2;
            this.bModpack.Text = "Установить модпак";
            this.bModpack.UseVisualStyleBackColor = true;
            this.bModpack.Click += new System.EventHandler(this.bModpack_Click);
            // 
            // lNickname
            // 
            this.lNickname.AutoSize = true;
            this.lNickname.BackColor = System.Drawing.Color.Transparent;
            this.lNickname.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNickname.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lNickname.Location = new System.Drawing.Point(294, 394);
            this.lNickname.Name = "lNickname";
            this.lNickname.Size = new System.Drawing.Size(84, 21);
            this.lNickname.TabIndex = 3;
            this.lNickname.Text = "Никнейм";
            // 
            // bSettings
            // 
            this.bSettings.Location = new System.Drawing.Point(13, 391);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(102, 47);
            this.bSettings.TabIndex = 4;
            this.bSettings.Text = "Настройки";
            this.bSettings.UseVisualStyleBackColor = true;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // pbVK
            // 
            this.pbVK.BackColor = System.Drawing.Color.Transparent;
            this.pbVK.Image = global::SAMPLauncher.Properties.Resources.icovk;
            this.pbVK.Location = new System.Drawing.Point(620, 12);
            this.pbVK.Name = "pbVK";
            this.pbVK.Size = new System.Drawing.Size(51, 50);
            this.pbVK.TabIndex = 5;
            this.pbVK.TabStop = false;
            this.pbVK.Click += new System.EventHandler(this.pbVK_Click);
            // 
            // pbSite
            // 
            this.pbSite.BackColor = System.Drawing.Color.Transparent;
            this.pbSite.Image = global::SAMPLauncher.Properties.Resources.icosite;
            this.pbSite.Location = new System.Drawing.Point(564, 12);
            this.pbSite.Name = "pbSite";
            this.pbSite.Size = new System.Drawing.Size(50, 50);
            this.pbSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSite.TabIndex = 6;
            this.pbSite.TabStop = false;
            this.pbSite.Click += new System.EventHandler(this.pbSite_Click);
            // 
            // lRights
            // 
            this.lRights.AutoSize = true;
            this.lRights.BackColor = System.Drawing.Color.Transparent;
            this.lRights.Location = new System.Drawing.Point(611, 441);
            this.lRights.Name = "lRights";
            this.lRights.Size = new System.Drawing.Size(60, 13);
            this.lRights.TabIndex = 7;
            this.lRights.Text = "by pasvitas";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAMPLauncher.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 457);
            this.Controls.Add(this.lRights);
            this.Controls.Add(this.pbSite);
            this.Controls.Add(this.pbVK);
            this.Controls.Add(this.bSettings);
            this.Controls.Add(this.lNickname);
            this.Controls.Add(this.bModpack);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.tbNickname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbVK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNickname;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bModpack;
        private System.Windows.Forms.Label lNickname;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.PictureBox pbVK;
        private System.Windows.Forms.PictureBox pbSite;
        private System.Windows.Forms.Label lRights;
    }
}

