namespace SAMPLauncher
{
    partial class ModPackInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModPackInstaller));
            this.lStatus = new System.Windows.Forms.Label();
            this.bInstall = new System.Windows.Forms.Button();
            this.pbFileProgess = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lStatus
            // 
            this.lStatus.Location = new System.Drawing.Point(9, 44);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(274, 18);
            this.lStatus.TabIndex = 2;
            this.lStatus.Text = "Готово к установке";
            this.lStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bInstall
            // 
            this.bInstall.Location = new System.Drawing.Point(12, 66);
            this.bInstall.Name = "bInstall";
            this.bInstall.Size = new System.Drawing.Size(271, 23);
            this.bInstall.TabIndex = 3;
            this.bInstall.Text = "Установить";
            this.bInstall.UseVisualStyleBackColor = true;
            this.bInstall.Click += new System.EventHandler(this.bInstall_Click);
            // 
            // pbFileProgess
            // 
            this.pbFileProgess.Location = new System.Drawing.Point(13, 13);
            this.pbFileProgess.Name = "pbFileProgess";
            this.pbFileProgess.Size = new System.Drawing.Size(270, 23);
            this.pbFileProgess.TabIndex = 4;
            // 
            // ModPackInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 101);
            this.Controls.Add(this.pbFileProgess);
            this.Controls.Add(this.bInstall);
            this.Controls.Add(this.lStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModPackInstaller";
            this.Text = "Установка модпака";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Button bInstall;
        private System.Windows.Forms.ProgressBar pbFileProgess;
    }
}