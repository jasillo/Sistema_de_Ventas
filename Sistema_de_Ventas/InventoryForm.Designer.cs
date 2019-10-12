namespace Sistema_de_Ventas
{
    partial class InventoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.InventoryDataGrid = new System.Windows.Forms.DataGridView();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.amount_input = new System.Windows.Forms.TextBox();
            this.price_input = new System.Windows.Forms.TextBox();
            this.stock_input = new System.Windows.Forms.TextBox();
            this.photo_input = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.barcode_input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // InventoryDataGrid
            // 
            this.InventoryDataGrid.AllowUserToAddRows = false;
            this.InventoryDataGrid.AllowUserToDeleteRows = false;
            this.InventoryDataGrid.AllowUserToResizeColumns = false;
            this.InventoryDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.InventoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InventoryDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.InventoryDataGrid.Location = new System.Drawing.Point(12, 87);
            this.InventoryDataGrid.Name = "InventoryDataGrid";
            this.InventoryDataGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InventoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.InventoryDataGrid.RowHeadersVisible = false;
            this.InventoryDataGrid.Size = new System.Drawing.Size(516, 351);
            this.InventoryDataGrid.TabIndex = 2;
            this.InventoryDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InventoryDataGrid_CellClick);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(12, 50);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(516, 20);
            this.filterTextBox.TabIndex = 1;
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Productos :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad  Actual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(560, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio de Venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(560, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock Minimo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(560, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Foto:";
            // 
            // name_input
            // 
            this.name_input.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.name_input.Location = new System.Drawing.Point(706, 50);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(341, 20);
            this.name_input.TabIndex = 8;
            // 
            // amount_input
            // 
            this.amount_input.Location = new System.Drawing.Point(706, 84);
            this.amount_input.Name = "amount_input";
            this.amount_input.ReadOnly = true;
            this.amount_input.Size = new System.Drawing.Size(180, 20);
            this.amount_input.TabIndex = 9;
            this.amount_input.Text = "0,0";
            // 
            // price_input
            // 
            this.price_input.Location = new System.Drawing.Point(706, 117);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(180, 20);
            this.price_input.TabIndex = 10;
            this.price_input.Text = "0,0";
            // 
            // stock_input
            // 
            this.stock_input.Location = new System.Drawing.Point(706, 151);
            this.stock_input.Name = "stock_input";
            this.stock_input.Size = new System.Drawing.Size(180, 20);
            this.stock_input.TabIndex = 11;
            this.stock_input.Text = "0,0";
            // 
            // photo_input
            // 
            this.photo_input.Enabled = false;
            this.photo_input.Location = new System.Drawing.Point(706, 217);
            this.photo_input.Name = "photo_input";
            this.photo_input.ReadOnly = true;
            this.photo_input.Size = new System.Drawing.Size(180, 20);
            this.photo_input.TabIndex = 12;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.ForestGreen;
            this.InsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.InsertButton.Location = new System.Drawing.Point(563, 314);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(129, 58);
            this.InsertButton.TabIndex = 13;
            this.InsertButton.Text = "Crear Nuevo Producto";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SaveButton.Location = new System.Drawing.Point(741, 314);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(137, 58);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Guardar Cambios";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Location = new System.Drawing.Point(925, 314);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(122, 58);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Eliminar Producto";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CleanButton.BackgroundImage")));
            this.CleanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CleanButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CleanButton.Location = new System.Drawing.Point(969, 132);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(78, 71);
            this.CleanButton.TabIndex = 16;
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(560, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Codigo de Barras:";
            // 
            // barcode_input
            // 
            this.barcode_input.Enabled = false;
            this.barcode_input.Location = new System.Drawing.Point(706, 183);
            this.barcode_input.Name = "barcode_input";
            this.barcode_input.ReadOnly = true;
            this.barcode_input.Size = new System.Drawing.Size(180, 20);
            this.barcode_input.TabIndex = 18;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.barcode_input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.photo_input);
            this.Controls.Add(this.stock_input);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.amount_input);
            this.Controls.Add(this.name_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.InventoryDataGrid);
            this.Name = "InventoryForm";
            this.Text = "Inventario de Productos";
            this.Shown += new System.EventHandler(this.cleanButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.InventoryDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView InventoryDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.TextBox amount_input;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.TextBox stock_input;
        private System.Windows.Forms.TextBox photo_input;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox barcode_input;
    }
}