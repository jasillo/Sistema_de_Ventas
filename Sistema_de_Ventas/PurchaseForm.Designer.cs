﻿namespace Sistema_de_Ventas
{
    partial class PurchaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsertButton = new System.Windows.Forms.Button();
            this.price_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.amount_input = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.AllowUserToAddRows = false;
            this.InventoryDataGrid.AllowUserToDeleteRows = false;
            this.InventoryDataGrid.AllowUserToResizeColumns = false;
            this.InventoryDataGrid.AllowUserToResizeRows = false;
            this.InventoryDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.InventoryDataGrid.Location = new System.Drawing.Point(12, 97);
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.InventoryDataGrid.RowHeadersVisible = false;
            this.InventoryDataGrid.Size = new System.Drawing.Size(458, 337);
            this.InventoryDataGrid.TabIndex = 3;
            this.InventoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryDataGrid_CellClick);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(107, 71);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(363, 20);
            this.filterTextBox.TabIndex = 4;
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(107, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar Productos :";
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.ForestGreen;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.InsertButton.Location = new System.Drawing.Point(828, 249);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(129, 58);
            this.InsertButton.TabIndex = 29;
            this.InsertButton.Text = "Registrar Ingreso";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(644, 156);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(110, 20);
            this.price_input.TabIndex = 26;
            this.price_input.Text = "0.0";
            // 
            // name_input
            // 
            this.name_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.name_input.Location = new System.Drawing.Point(644, 80);
            this.name_input.Name = "name_input";
            this.name_input.ReadOnly = true;
            this.name_input.Size = new System.Drawing.Size(313, 20);
            this.name_input.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(490, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio de Compra (Total):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(490, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(490, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cantidad (unid):";
            // 
            // amount_input
            // 
            this.amount_input.Location = new System.Drawing.Point(644, 117);
            this.amount_input.Name = "amount_input";
            this.amount_input.Size = new System.Drawing.Size(110, 20);
            this.amount_input.TabIndex = 25;
            this.amount_input.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(101, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 31);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ingreso a Almacen";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 446);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.amount_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.InventoryDataGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos a Almacen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PurchaseForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amount_input;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}