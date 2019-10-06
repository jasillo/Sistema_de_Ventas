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
        ConectionDB conection;
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
                TextBox objTextBox = (TextBox)sender;
                string word = objTextBox.Text;
                filter_word = word;
                InventoryDataGrid.DataSource = conection.getProducts(word.Trim());
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            conection = new ConectionDB();
            conection.openConnection();
        }

        private void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conection.closeConnection();
        }

        private void InventoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= InventoryDataGrid.RowCount - 1)
            {
                return;
            }
            row_selected_id = InventoryDataGrid.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            string name = InventoryDataGrid.Rows[e.RowIndex].Cells["Nombre del Producto"].FormattedValue.ToString();
            string amount = InventoryDataGrid.Rows[e.RowIndex].Cells["Cantidad"].FormattedValue.ToString();
            string price = InventoryDataGrid.Rows[e.RowIndex].Cells["Precio de Venta"].FormattedValue.ToString();
            string stock = InventoryDataGrid.Rows[e.RowIndex].Cells["Stock Minimo"].FormattedValue.ToString();

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
            name_input.Text = "";
            amount_input.Text = "";
            price_input.Text = "";
            stock_input.Text = "";
            SaveButton.Visible = false;
            DeleteButton.Visible = false;
            InsertButton.Visible = true;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            //validar campos
            if (!validateAllFields())
            {
                return;
            }
            conection.CreateProduct(name_input.Text, amount_input.Text, price_input.Text, stock_input.Text);
            //actualizar grilla
            InventoryDataGrid.DataSource = conection.getProducts(filter_word.Trim());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //validar campos
            if (!validateAllFields())
            {
                return;
            }
            conection.UpdateProduct(row_selected_id, name_input.Text, amount_input.Text, price_input.Text, stock_input.Text);
            //actualizar grilla
            InventoryDataGrid.DataSource = conection.getProducts(filter_word.Trim());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Esta seguro que desea borra este producto?", "Confirmar Borrado!!", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                conection.DeleteProduct(row_selected_id);
                //actualizar grilla
                InventoryDataGrid.DataSource = conection.getProducts(filter_word.Trim());
            }
        }

        private bool validateAllFields()
        {
            if (!conection.validateFieldAsString(name_input.Text))
            {
                MessageBox.Show("Error en el nombre del producto");
                return false;
            }
            if (!conection.validateFieldAsNumber(amount_input.Text))
            {
                MessageBox.Show("Error en la cantidad");
                return false;
            }
            if (!conection.validateFieldAsNumber(price_input.Text))
            {
                MessageBox.Show("Error en el precio");
                return false;
            }
            if (!conection.validateFieldAsNumber(stock_input.Text))
            {
                MessageBox.Show("Error en el stock");
                return false;
            }
            return true;
        }
    }
}
