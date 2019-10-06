﻿namespace Sistema_de_Ventas
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.price_input = new System.Windows.Forms.TextBox();
            this.amount_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barcode_input = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DetailDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalSale_input = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryDataGrid.Location = new System.Drawing.Point(12, 66);
            this.InventoryDataGrid.MultiSelect = false;
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.ReadOnly = true;
            this.InventoryDataGrid.RowHeadersVisible = false;
            this.InventoryDataGrid.Size = new System.Drawing.Size(387, 497);
            this.InventoryDataGrid.TabIndex = 4;
            this.InventoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryDataGrid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar Productos :";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(12, 40);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(387, 20);
            this.filterTextBox.TabIndex = 6;
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTextBox_KeyDown);
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(588, 89);
            this.price_input.Name = "price_input";
            this.price_input.ReadOnly = true;
            this.price_input.Size = new System.Drawing.Size(194, 20);
            this.price_input.TabIndex = 32;
            this.price_input.Text = "0,0";
            // 
            // amount_input
            // 
            this.amount_input.Location = new System.Drawing.Point(588, 117);
            this.amount_input.Name = "amount_input";
            this.amount_input.Size = new System.Drawing.Size(194, 20);
            this.amount_input.TabIndex = 31;
            this.amount_input.Text = "1,0";
            this.amount_input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.amount_input_KeyUp);
            // 
            // name_input
            // 
            this.name_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.name_input.Location = new System.Drawing.Point(588, 60);
            this.name_input.Name = "name_input";
            this.name_input.ReadOnly = true;
            this.name_input.Size = new System.Drawing.Size(400, 20);
            this.name_input.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre del Producto:";
            // 
            // barcode_input
            // 
            this.barcode_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.barcode_input.Location = new System.Drawing.Point(588, 31);
            this.barcode_input.Name = "barcode_input";
            this.barcode_input.ReadOnly = true;
            this.barcode_input.Size = new System.Drawing.Size(194, 20);
            this.barcode_input.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(452, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Codigo de Barras:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(451, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Detalle de Venta:";
            // 
            // DetailDataGrid
            // 
            this.DetailDataGrid.AllowUserToAddRows = false;
            this.DetailDataGrid.AllowUserToDeleteRows = false;
            this.DetailDataGrid.AllowUserToResizeColumns = false;
            this.DetailDataGrid.AllowUserToResizeRows = false;
            this.DetailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DetailDataGrid.Location = new System.Drawing.Point(455, 190);
            this.DetailDataGrid.MultiSelect = false;
            this.DetailDataGrid.Name = "DetailDataGrid";
            this.DetailDataGrid.ReadOnly = true;
            this.DetailDataGrid.RowHeadersVisible = false;
            this.DetailDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DetailDataGrid.Size = new System.Drawing.Size(533, 321);
            this.DetailDataGrid.TabIndex = 39;
            this.DetailDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetailDataGrid_CellClick);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(455, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(532, 2);
            this.label8.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(806, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Total:";
            // 
            // totalSale_input
            // 
            this.totalSale_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSale_input.Location = new System.Drawing.Point(866, 517);
            this.totalSale_input.Name = "totalSale_input";
            this.totalSale_input.ReadOnly = true;
            this.totalSale_input.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalSale_input.Size = new System.Drawing.Size(121, 26);
            this.totalSale_input.TabIndex = 42;
            this.totalSale_input.Text = "00.00";
            // 
            // processButton
            // 
            this.processButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("processButton.BackgroundImage")));
            this.processButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.processButton.Location = new System.Drawing.Point(1013, 443);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(100, 100);
            this.processButton.TabIndex = 43;
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 575);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.totalSale_input);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DetailDataGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.barcode_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.amount_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.InventoryDataGrid);
            this.Name = "SalesForm";
            this.Text = "Formulario de Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesForm_FormClosing);
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.TextBox amount_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcode_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DetailDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalSale_input;
        private System.Windows.Forms.Button processButton;
    }
}