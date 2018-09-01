namespace SAMPLauncher
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lPath = new System.Windows.Forms.Label();
            this.bPath = new System.Windows.Forms.Button();
            this.bDone = new System.Windows.Forms.Button();
            this.bDownloadSamp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(12, 32);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(193, 20);
            this.tbPath.TabIndex = 0;
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Location = new System.Drawing.Point(12, 13);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(37, 13);
            this.lPath.TabIndex = 1;
            this.lPath.Text = "Путь: ";
            // 
            // bPath
            // 
            this.bPath.Location = new System.Drawing.Point(211, 32);
            this.bPath.Name = "bPath";
            this.bPath.Size = new System.Drawing.Size(40, 20);
            this.bPath.TabIndex = 2;
            this.bPath.Text = "...";
            this.bPath.UseVisualStyleBackColor = true;
            this.bPath.Click += new System.EventHandler(this.bPath_Click);
            // 
            // bDone
            // 
            this.bDone.Location = new System.Drawing.Point(176, 58);
            this.bDone.Name = "bDone";
            this.bDone.Size = new System.Drawing.Size(75, 23);
            this.bDone.TabIndex = 3;
            this.bDone.Text = "Готово";
            this.bDone.UseVisualStyleBackColor = true;
            this.bDone.Click += new System.EventHandler(this.bDone_Click);
            // 
            // bDownloadSamp
            // 
            this.bDownloadSamp.Location = new System.Drawing.Point(12, 58);
            this.bDownloadSamp.Name = "bDownloadSamp";
            this.bDownloadSamp.Size = new System.Drawing.Size(158, 23);
            this.bDownloadSamp.TabIndex = 4;
            this.bDownloadSamp.Text = "Установить SAMP";
            this.bDownloadSamp.UseVisualStyleBackColor = true;
            this.bDownloadSamp.Click += new System.EventHandler(this.bDownloadSamp_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 92);
            this.Controls.Add(this.bDownloadSamp);
            this.Controls.Add(this.bDone);
            this.Controls.Add(this.bPath);
            this.Controls.Add(this.lPath);
            this.Controls.Add(this.tbPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.Button bPath;
        private System.Windows.Forms.Button bDone;
        private System.Windows.Forms.Button bDownloadSamp;
    }
}