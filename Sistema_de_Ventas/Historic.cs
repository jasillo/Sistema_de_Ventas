using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class Historic : Form
    {
        public Historic()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            if (ventas_radio.Checked)
            {
                MainDataGrid.DataSource = ConDB.getListOfSales(startTimePicker.Value.ToString("yyyy-MM-dd"), endTimePicker.Value.ToString("yyyy-MM-dd"));
                formatDataGrid_Sales();
                total_input.Text = ConDB.getTotalSales(startTimePicker.Value.ToString("yyyy-MM-dd"), endTimePicker.Value.ToString("yyyy-MM-dd")).ToString();
                return;
            }
            if (ingreso_radio.Checked)
            {
                MainDataGrid.DataSource = ConDB.getListOfEntries(startTimePicker.Value.ToString("yyyy-MM-dd"), endTimePicker.Value.ToString("yyyy-MM-dd"));
                formatDataGrid_entries();
                total_input.Text = ConDB.getTotalEntries(startTimePicker.Value.ToString("yyyy-MM-dd"), endTimePicker.Value.ToString("yyyy-MM-dd")).ToString();
                return;
            }
            if (producto_radio.Checked)
            {
                MainDataGrid.DataSource = ConDB.getHistoricalProducts(startTimePicker.Value.ToString("yyyy-MM-dd"), endTimePicker.Value.ToString("yyyy-MM-dd"));
                formatDataGrid_historicalProducts();
                return;
            }
        }

        

        private void SaleDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            detailDataGrid.DataSource = ConDB.getListOfDetails(MainDataGrid.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
            formatDataGrid_details();
        }

        private void formatDataGrid_Sales()
        {
            MainDataGrid.Columns["amount"].HeaderText = "Cantidad de Items";
            MainDataGrid.Columns["total"].HeaderText = "total de Venta";
            MainDataGrid.Columns["date"].HeaderText = "fecha";

            MainDataGrid.Columns["id"].Width = 40;
            MainDataGrid.Columns["name"].Visible = false;
            MainDataGrid.Columns["amount"].Width = 100;
            MainDataGrid.Columns["total"].Width = 100;
            MainDataGrid.Columns["date"].Width = 100;
            MainDataGrid.Columns["id_user"].Visible = false;
        }

        private void formatDataGrid_details()
        {
            detailDataGrid.Columns["product_name"].HeaderText = "producto";
            detailDataGrid.Columns["price"].HeaderText = "precio";
            detailDataGrid.Columns["amount"].HeaderText = "cantidad";
            detailDataGrid.Columns["total"].HeaderText = "total";

            detailDataGrid.Columns["id"].Visible = false;
            detailDataGrid.Columns["id_sale"].Visible = false;
            detailDataGrid.Columns["id_product"].Visible = false;
            detailDataGrid.Columns["product_name"].Width = 250;
            detailDataGrid.Columns["price"].Width = 60;
            detailDataGrid.Columns["amount"].Width = 60;
            detailDataGrid.Columns["total"].Width = 60;
        }

        private void formatDataGrid_entries()
        {
            MainDataGrid.Columns["product_name"].HeaderText = "Nombre del Producto";
            MainDataGrid.Columns["total"].HeaderText = "total de la compra";
            MainDataGrid.Columns["amount"].HeaderText = "Cantidad";
            MainDataGrid.Columns["date"].HeaderText = "fecha";

            MainDataGrid.Columns["id"].Visible = false;
            MainDataGrid.Columns["id_product"].Visible = false;
            MainDataGrid.Columns["id_user"].Visible = false;
            MainDataGrid.Columns["product_name"].Width = 250;
            MainDataGrid.Columns["amount"].Width = 60;
            MainDataGrid.Columns["total"].Width = 60;
            MainDataGrid.Columns["date"].Width = 100;
        }

        private void formatDataGrid_historicalProducts()
        {
            MainDataGrid.Columns["type"].HeaderText = "Tipo";
            MainDataGrid.Columns["description"].HeaderText = "detalle del producto";
            MainDataGrid.Columns["date"].HeaderText = "fecha";

            MainDataGrid.Columns["id"].Visible = false;
            MainDataGrid.Columns["id_product"].Visible = false;
            MainDataGrid.Columns["id_user"].Visible = false;
            MainDataGrid.Columns["type"].Width = 60;
            MainDataGrid.Columns["description"].Width = 450;
            MainDataGrid.Columns["date"].Width = 100;
        }

        private void ventas_radio_CheckedChanged(object sender, EventArgs e)
        {
            labelGrid1.Text = "Ventas:";
            detailDataGrid.Visible = true;
            total_label.Visible = true;
            total_input.Visible = true;
            total_input.Text = "00.00";
            detail_label.Visible = true;
            MainDataGrid.Width = 480;
            MainDataGrid.DataSource = null;
            MainDataGrid.Refresh();
        }

        private void ingreso_radio_CheckedChanged(object sender, EventArgs e)
        {
            labelGrid1.Text = "Ingreso a Almacen:";
            detailDataGrid.Visible = false;
            total_label.Visible = true;
            total_input.Visible = true;
            detail_label.Visible = false;
            total_input.Text = "00.00";
            MainDataGrid.Width = 480;
            MainDataGrid.DataSource = null;
            MainDataGrid.Refresh();
        }

        private void producto_radio_CheckedChanged(object sender, EventArgs e)
        {
            labelGrid1.Text = "Historico de Productos:";
            detailDataGrid.Visible = false;
            total_label.Visible = false;
            total_input.Visible = false;
            detail_label.Visible = false;
            MainDataGrid.Width = 650;
            MainDataGrid.DataSource = null;
            MainDataGrid.Refresh();

        }

        private void Historic_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConDB.mainForm.Show();
        }
    }
}
