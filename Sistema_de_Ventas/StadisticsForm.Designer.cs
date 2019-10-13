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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backup_itemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backup_itemMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backup_itemMenu
            // 
            this.backup_itemMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordMenuItem});
            this.backup_itemMenu.Name = "backup_itemMenu";
            this.backup_itemMenu.Size = new System.Drawing.Size(72, 20);
            this.backup_itemMenu.Text = "Seguridad";
            // 
            // passwordMenuItem
            // 
            this.passwordMenuItem.Name = "passwordMenuItem";
            this.passwordMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passwordMenuItem.Text = "Copia de Seguridad";
            this.passwordMenuItem.Click += new System.EventHandler(this.passwordMenuItem_Click);
            // 
            // backupFolderBrowser
            // 
            this.backupFolderBrowser.Description = "Seleccione la carpeta donde desea guardar la copia de respado:";
            // 
            // StadisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 533);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StadisticsForm";
            this.Text = "StadisticsForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backup_itemMenu;
        private System.Windows.Forms.ToolStripMenuItem passwordMenuItem;
        private System.Windows.Forms.FolderBrowserDialog backupFolderBrowser;
    }
}