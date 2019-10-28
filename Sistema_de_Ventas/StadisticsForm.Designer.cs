namespace Sistema_de_Ventas
{
    partial class StadisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StadisticsForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backup_itemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csvMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backup_itemMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backup_itemMenu
            // 
            this.backup_itemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordMenuItem,
            this.csvMenuItem});
            this.backup_itemMenu.ForeColor = System.Drawing.Color.Tomato;
            this.backup_itemMenu.Name = "backup_itemMenu";
            this.backup_itemMenu.Size = new System.Drawing.Size(72, 20);
            this.backup_itemMenu.Text = "Seguridad";
            // 
            // passwordMenuItem
            // 
            this.passwordMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.passwordMenuItem.Name = "passwordMenuItem";
            this.passwordMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passwordMenuItem.Text = "Copia de Seguridad";
            this.passwordMenuItem.Click += new System.EventHandler(this.passwordMenuItem_Click);
            // 
            // csvMenuItem
            // 
            this.csvMenuItem.ForeColor = System.Drawing.Color.Tomato;
            this.csvMenuItem.Name = "csvMenuItem";
            this.csvMenuItem.Size = new System.Drawing.Size(180, 22);
            this.csvMenuItem.Text = "subir csv";
            this.csvMenuItem.Click += new System.EventHandler(this.csvMenuItem_Click);
            // 
            // backupFolderBrowser
            // 
            this.backupFolderBrowser.Description = "Seleccione la carpeta donde desea guardar la copia de respado:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Estadisticas";
            // 
            // StadisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StadisticsForm";
            this.Text = "Estadisticas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StadisticsForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backup_itemMenu;
        private System.Windows.Forms.ToolStripMenuItem passwordMenuItem;
        private System.Windows.Forms.FolderBrowserDialog backupFolderBrowser;
        private System.Windows.Forms.ToolStripMenuItem csvMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}