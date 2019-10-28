namespace Sistema_de_Ventas
{
    partial class Historic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historic));
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.detailDataGrid = new System.Windows.Forms.DataGridView();
            this.labelGrid1 = new System.Windows.Forms.Label();
            this.detail_label = new System.Windows.Forms.Label();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.total_label = new System.Windows.Forms.Label();
            this.total_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.producto_radio = new System.Windows.Forms.RadioButton();
            this.ingreso_radio = new System.Windows.Forms.RadioButton();
            this.ventas_radio = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startTimePicker
            // 
            this.startTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startTimePicker.Location = new System.Drawing.Point(375, 26);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(132, 26);
            this.startTimePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde: ";
            // 
            // endTimePicker
            // 
            this.endTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endTimePicker.Location = new System.Drawing.Point(375, 58);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(132, 26);
            this.endTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasta: ";
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.AllowUserToAddRows = false;
            this.MainDataGrid.AllowUserToDeleteRows = false;
            this.MainDataGrid.AllowUserToResizeColumns = false;
            this.MainDataGrid.AllowUserToResizeRows = false;
            this.MainDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MainDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.MainDataGrid.Location = new System.Drawing.Point(27, 136);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MainDataGrid.RowHeadersVisible = false;
            this.MainDataGrid.Size = new System.Drawing.Size(480, 351);
            this.MainDataGrid.TabIndex = 4;
            this.MainDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaleDataGrid_CellClick);
            // 
            // detailDataGrid
            // 
            this.detailDataGrid.AllowUserToAddRows = false;
            this.detailDataGrid.AllowUserToDeleteRows = false;
            this.detailDataGrid.AllowUserToResizeColumns = false;
            this.detailDataGrid.AllowUserToResizeRows = false;
            this.detailDataGrid.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.detailDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailDataGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.detailDataGrid.Location = new System.Drawing.Point(541, 136);
            this.detailDataGrid.Name = "detailDataGrid";
            this.detailDataGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.detailDataGrid.RowHeadersVisible = false;
            this.detailDataGrid.Size = new System.Drawing.Size(509, 351);
            this.detailDataGrid.TabIndex = 5;
            // 
            // labelGrid1
            // 
            this.labelGrid1.AutoSize = true;
            this.labelGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrid1.Location = new System.Drawing.Point(24, 115);
            this.labelGrid1.Name = "labelGrid1";
            this.labelGrid1.Size = new System.Drawing.Size(53, 18);
            this.labelGrid1.TabIndex = 6;
            this.labelGrid1.Text = "Venta: ";
            // 
            // detail_label
            // 
            this.detail_label.AutoSize = true;
            this.detail_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail_label.Location = new System.Drawing.Point(538, 115);
            this.detail_label.Name = "detail_label";
            this.detail_label.Size = new System.Drawing.Size(61, 18);
            this.detail_label.TabIndex = 7;
            this.detail_label.Text = "Detalle: ";
            // 
            // MostrarButton
            // 
            this.MostrarButton.BackColor = System.Drawing.Color.White;
            this.MostrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarButton.Location = new System.Drawing.Point(398, 90);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(109, 31);
            this.MostrarButton.TabIndex = 8;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = false;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(348, 500);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(44, 18);
            this.total_label.TabIndex = 9;
            this.total_label.Text = "total: ";
            // 
            // total_input
            // 
            this.total_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_input.Location = new System.Drawing.Point(407, 493);
            this.total_input.Name = "total_input";
            this.total_input.Size = new System.Drawing.Size(100, 29);
            this.total_input.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.producto_radio);
            this.groupBox1.Controls.Add(this.ingreso_radio);
            this.groupBox1.Controls.Add(this.ventas_radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(128, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 89);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // producto_radio
            // 
            this.producto_radio.AutoSize = true;
            this.producto_radio.Location = new System.Drawing.Point(6, 62);
            this.producto_radio.Name = "producto_radio";
            this.producto_radio.Size = new System.Drawing.Size(90, 21);
            this.producto_radio.TabIndex = 2;
            this.producto_radio.Text = "Productos";
            this.producto_radio.UseVisualStyleBackColor = true;
            this.producto_radio.CheckedChanged += new System.EventHandler(this.producto_radio_CheckedChanged);
            // 
            // ingreso_radio
            // 
            this.ingreso_radio.AutoSize = true;
            this.ingreso_radio.Location = new System.Drawing.Point(6, 36);
            this.ingreso_radio.Name = "ingreso_radio";
            this.ingreso_radio.Size = new System.Drawing.Size(143, 21);
            this.ingreso_radio.TabIndex = 1;
            this.ingreso_radio.Text = "Ingreso a Almacen";
            this.ingreso_radio.UseVisualStyleBackColor = true;
            this.ingreso_radio.CheckedChanged += new System.EventHandler(this.ingreso_radio_CheckedChanged);
            // 
            // ventas_radio
            // 
            this.ventas_radio.AutoSize = true;
            this.ventas_radio.Checked = true;
            this.ventas_radio.Location = new System.Drawing.Point(6, 9);
            this.ventas_radio.Name = "ventas_radio";
            this.ventas_radio.Size = new System.Drawing.Size(70, 21);
            this.ventas_radio.TabIndex = 0;
            this.ventas_radio.TabStop = true;
            this.ventas_radio.Text = "Ventas";
            this.ventas_radio.UseVisualStyleBackColor = true;
            this.ventas_radio.CheckedChanged += new System.EventHandler(this.ventas_radio_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Historic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1092, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.total_input);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detail_label);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.labelGrid1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detailDataGrid);
            this.Controls.Add(this.MainDataGrid);
            this.Name = "Historic";
            this.Text = "Historial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Historic_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label detail_label;
        private System.Windows.Forms.Label labelGrid1;
        private System.Windows.Forms.DataGridView detailDataGrid;
        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.TextBox total_input;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton producto_radio;
        private System.Windows.Forms.RadioButton ingreso_radio;
        private System.Windows.Forms.RadioButton ventas_radio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}