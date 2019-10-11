namespace Sistema_de_Ventas
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InventoryButton = new System.Windows.Forms.Button();
            this.PurchasesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backupFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initBDMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InventoryButton
            // 
            this.InventoryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InventoryButton.BackgroundImage")));
            this.InventoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InventoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.InventoryButton.Location = new System.Drawing.Point(25, 57);
            this.InventoryButton.Name = "InventoryButton";
            this.InventoryButton.Size = new System.Drawing.Size(183, 140);
            this.InventoryButton.TabIndex = 0;
            this.InventoryButton.Text = "Inventario";
            this.InventoryButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InventoryButton.UseVisualStyleBackColor = true;
            this.InventoryButton.Click += new System.EventHandler(this.InventoryButton_Click);
            // 
            // PurchasesButton
            // 
            this.PurchasesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PurchasesButton.BackgroundImage")));
            this.PurchasesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PurchasesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchasesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasesButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PurchasesButton.Location = new System.Drawing.Point(247, 57);
            this.PurchasesButton.Name = "PurchasesButton";
            this.PurchasesButton.Size = new System.Drawing.Size(183, 140);
            this.PurchasesButton.TabIndex = 1;
            this.PurchasesButton.Text = "Ingreso a Almacen";
            this.PurchasesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PurchasesButton.UseVisualStyleBackColor = true;
            this.PurchasesButton.Click += new System.EventHandler(this.PurchasesButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 115);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aqui puede crear, modificar o eliminar (no recomendado) productos como el precio," +
    " nombre, stock minimo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 115);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aqui se registran los ingresos a almacen, el producto a ingresar debe estar regis" +
    "trado en Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SalesButton
            // 
            this.SalesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalesButton.BackgroundImage")));
            this.SalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SalesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.SalesButton.Location = new System.Drawing.Point(472, 57);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(183, 136);
            this.SalesButton.TabIndex = 4;
            this.SalesButton.Text = "Ventas";
            this.SalesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(699, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 132);
            this.button1.TabIndex = 5;
            this.button1.Text = "Historial";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(928, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 132);
            this.button2.TabIndex = 6;
            this.button2.Text = "Estadisticas";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 115);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aqui se registran las ventas realizadas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(687, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 115);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aqui se puede ver todo el historial de ventas, ingresos y modificaciones de los p" +
    "roductos a travez del tiempo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(915, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 115);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aqui se pueden ver estadisticas de los productos, como cual se vendio mas, cual s" +
    "e vende menos, las ganancias registradas, etc.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backupFolderBrowser
            // 
            this.backupFolderBrowser.Description = "Seleccione la carpeta donde desea guardar la copia de respado:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initBDMenuItem,
            this.backupMenuItem,
            this.passwordMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Seguridad";
            // 
            // initBDMenuItem
            // 
            this.initBDMenuItem.Name = "initBDMenuItem";
            this.initBDMenuItem.Size = new System.Drawing.Size(182, 22);
            this.initBDMenuItem.Text = "Iniciar Base de Datos";
            this.initBDMenuItem.Click += new System.EventHandler(this.initBDMenuItem_Click);
            // 
            // backupMenuItem
            // 
            this.backupMenuItem.Name = "backupMenuItem";
            this.backupMenuItem.Size = new System.Drawing.Size(182, 22);
            this.backupMenuItem.Text = "Copia de Seguridad";
            this.backupMenuItem.Click += new System.EventHandler(this.backupMenuItem_Click);
            // 
            // passwordMenuItem
            // 
            this.passwordMenuItem.Name = "passwordMenuItem";
            this.passwordMenuItem.Size = new System.Drawing.Size(182, 22);
            this.passwordMenuItem.Text = "Cambiar contraseña";
            this.passwordMenuItem.Click += new System.EventHandler(this.passwordMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1140, 382);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchasesButton);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sistema de Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InventoryButton;
        private System.Windows.Forms.Button PurchasesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog backupFolderBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initBDMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordMenuItem;
    }
}

