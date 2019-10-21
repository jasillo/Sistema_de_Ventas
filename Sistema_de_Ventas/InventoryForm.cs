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
    public partial class InventoryForm : Form
    {
        string row_selected_id = "";
        string filter_word = "";

        public InventoryForm()
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
            InventoryDataGrid.Columns["sale_price"].HeaderText = "Precio de Venta";
            InventoryDataGrid.Columns["minimum"].HeaderText = "Stock Minimo";
            InventoryDataGrid.Columns["bar_code"].HeaderText = "Codigo de Barras";

            InventoryDataGrid.Columns["id"].Visible = false;
            InventoryDataGrid.Columns["name"].Width = 300;
            InventoryDataGrid.Columns["amount"].Width = 60;
            InventoryDataGrid.Columns["sale_price"].Width = 60;
            InventoryDataGrid.Columns["minimum"].Width = 60;
            InventoryDataGrid.Columns["bar_code"].Visible = false;
            InventoryDataGrid.Columns["photo"].Visible = false;
        }

        private void InventoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 )
                return;
            row_selected_id = InventoryDataGrid.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            string name = InventoryDataGrid.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            string amount = InventoryDataGrid.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();
            string price = InventoryDataGrid.Rows[e.RowIndex].Cells["sale_price"].FormattedValue.ToString();
            string stock = InventoryDataGrid.Rows[e.RowIndex].Cells["minimum"].FormattedValue.ToString();

            name_input.Text = name;
            amount_input.Text = amount;
            price_input.Text = price;
            stock_input.Text = stock;
            SaveButton.Visible = true;
            DeleteButton.Visible = true;
            InsertButton.Visible = false;
        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            clean();
            MessageBox.Show("Formulario Limpio, ya se puede crear uno nuevo", "Limpio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clean()
        {
            name_input.Text = "";
            amount_input.Text = "0,0";
            price_input.Text = "0,0";
            stock_input.Text = "0,0";
            SaveButton.Visible = false;
            DeleteButton.Visible = false;
            InsertButton.Visible = true;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            string name = ConDB.validString(name_input.Text);
            string amount = ConDB.validNumber(amount_input.Text);
            string price = ConDB.validNumber(price_input.Text);
            string stock = ConDB.validNumber(stock_input.Text);

            name_input.Text = name;
            if (price == "error")
            {
                MessageBox.Show("El precio no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stock == "error")
            {
                MessageBox.Show("El stock no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ConDB.CreateProduct(name, amount, price, stock, barcode_input.Text))
            {
                MessageBox.Show("Producto creado exitosamente", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = ConDB.validString(name_input.Text);
            string amount = ConDB.validNumber(amount_input.Text);
            string price = ConDB.validNumber(price_input.Text);
            string stock = ConDB.validNumber(stock_input.Text);

            name_input.Text = name;
            if (price == "error")
            {
                MessageBox.Show("El precio no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stock == "error")
            {
                MessageBox.Show("El stock no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ConDB.UpdateProduct(row_selected_id, name, amount, price, stock))
            {
                MessageBox.Show("Producto modificado exitosamente", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se pudo modificar el producto, puede que ya exista un producto con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InventoryDataGrid.DataSource = ConDB.getProductsList(filter_word);
            formatDataGrid();
            clean();
            filterTextBox.Focus();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Esta seguro que desea borra este producto? esto conlleva a perdida de información", "Confirmar Borrado!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (ConDB.DeleteProduct(row_selected_id))
                {
                    MessageBox.Show("El Producto fue eliminado exitosamente", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                InventoryDataGrid.DataSource = ConDB.getProductsList(filter_word);
                formatDataGrid();
                clean();
                filterTextBox.Focus();
            }
        }

        private void InventoryForm_Shown(object sender, EventArgs e)
        {
            filterTextBox.Focus();
        }

        private void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConDB.mainForm.Show();
        }
    }
}
