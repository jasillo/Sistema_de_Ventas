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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadisticsButton = new System.Windows.Forms.Button();
            this.historicalButton = new System.Windows.Forms.Button();
            this.SalesButton = new System.Windows.Forms.Button();
            this.PurchasesButton = new System.Windows.Forms.Button();
            this.InventoryButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Enabled = false;
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
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 115);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aqui se registran los ingresos a almacen, como tambien devoluciones, el producto " +
    "debe estar registrado previamente en el Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Enabled = false;
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
            this.label4.Enabled = false;
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
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(915, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 115);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aqui se pueden ver estadisticas de los productos, como cual se vendio mas, cual s" +
    "e vende menos, las ganancias registradas, etc.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Usuario";
            // 
            // passwordMenuItem
            // 
            this.passwordMenuItem.Name = "passwordMenuItem";
            this.passwordMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passwordMenuItem.Text = "Cambiar contraseña";
            this.passwordMenuItem.Click += new System.EventHandler(this.passwordMenuItem_Click);
            // 
            // stadisticsButton
            // 
            this.stadisticsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stadisticsButton.BackgroundImage")));
            this.stadisticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stadisticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stadisticsButton.Enabled = false;
            this.stadisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stadisticsButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.stadisticsButton.Location = new System.Drawing.Point(928, 57);
            this.stadisticsButton.Name = "stadisticsButton";
            this.stadisticsButton.Size = new System.Drawing.Size(183, 132);
            this.stadisticsButton.TabIndex = 5;
            this.stadisticsButton.Text = "Estadisticas";
            this.stadisticsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stadisticsButton.UseVisualStyleBackColor = true;
            this.stadisticsButton.Click += new System.EventHandler(this.stadisticsButton_Click);
            // 
            // historicalButton
            // 
            this.historicalButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("historicalButton.BackgroundImage")));
            this.historicalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.historicalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.historicalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historicalButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.historicalButton.Location = new System.Drawing.Point(699, 57);
            this.historicalButton.Name = "historicalButton";
            this.historicalButton.Size = new System.Drawing.Size(183, 132);
            this.historicalButton.TabIndex = 4;
            this.historicalButton.Text = "Historial";
            this.historicalButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.historicalButton.UseVisualStyleBackColor = true;
            this.historicalButton.Click += new System.EventHandler(this.historicalButton_Click);
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
            this.SalesButton.TabIndex = 3;
            this.SalesButton.Text = "Ventas";
            this.SalesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SalesButton.UseVisualStyleBackColor = true;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stadisticsButton);
            this.Controls.Add(this.historicalButton);
            this.Controls.Add(this.SalesButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PurchasesButton);
            this.Controls.Add(this.InventoryButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
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
        private System.Windows.Forms.Button historicalButton;
        private System.Windows.Forms.Button stadisticsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordMenuItem;
    }
}

