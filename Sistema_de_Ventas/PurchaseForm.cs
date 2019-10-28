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
    public partial class PurchaseForm : Form
    {
        string row_selected_id = "";
        string filter_word = "";
        string original_amount = "";

        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void filterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filter_word = ConDB.validString(filterTextBox.Text);
                filterTextBox.Text = filter_word;
                InventoryDataGrid.DataSource = ConDB.getProductsList(filter_word);
                formatDataGrid();
            }
        }

        private void formatDataGrid()
        {
            InventoryDataGrid.Columns["name"].HeaderText = "Nombre del Producto";
            InventoryDataGrid.Columns["amount"].HeaderText = "Cantidad";
            InventoryDataGrid.Columns["sale_price"].HeaderText = "precio de venta";

            InventoryDataGrid.Columns["id"].Visible = false;
            InventoryDataGrid.Columns["name"].Width = 300;
            InventoryDataGrid.Columns["amount"].Width = 60;
            InventoryDataGrid.Columns["sale_price"].Width = 60;
            InventoryDataGrid.Columns["minimum"].Visible = false;
            InventoryDataGrid.Columns["bar_code"].Visible = false;
            InventoryDataGrid.Columns["photo"].Visible = false;
        }

        private void clean()
        {
            name_input.Text = "";
            amount_input.Text = "0,0";
            price_input.Text = "0,0";
        }
            
        private void InventoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            row_selected_id = InventoryDataGrid.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            original_amount = InventoryDataGrid.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
            string name = InventoryDataGrid.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();

            name_input.Text = name;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (row_selected_id == "")
                return;
            string amount = ConDB.validNumber(amount_input.Text);
            string price = ConDB.validNumber(price_input.Text);

            if (price == "error")
            {
                MessageBox.Show("El precio no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (amount == "error")
            {
                MessageBox.Show("La cantidad no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ConDB.RegisterWareHouseEntry(row_selected_id, name_input.Text, price, amount))
            {
                MessageBox.Show("Entrada en almacen exitosa", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se pudo crear el producto, puede que ya exista un producto con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InventoryDataGrid.DataSource = ConDB.getProductsList(filter_word);
            formatDataGrid();
            clean();
            filterTextBox.Focus();
        }
                
        private void PurchaseForm_Shown(object sender, EventArgs e)
        {
            filterTextBox.Focus();
        }

        private void PurchaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConDB.mainForm.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<string> res = ConDB.getProductByBarcode(barcode_input.Text);
                if (res.Count == 0)
                    return;
                row_selected_id = res[0];
                filter_word = res[1];
                filterTextBox.Text = ConDB.validString(res[1]);
                name_input.Text = res[1];
                amount_input.Text = "0";
                price_input.Text = "0";
            }
        }
    }
}
