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
        ConectionDB conection;
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
                TextBox objTextBox = (TextBox)sender;
                string word = objTextBox.Text;
                filter_word = word;
                InventoryDataGrid.DataSource = conection.getProductsForPurchase(word.Trim());
            }
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            conection = new ConectionDB();
            conection.openConnection();
        }

        private void PurchaseForm_FormClosing(object sender, FormClosingEventArgs e)
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
            original_amount = InventoryDataGrid.Rows[e.RowIndex].Cells["Cantidad"].FormattedValue.ToString();
            string name = InventoryDataGrid.Rows[e.RowIndex].Cells["Nombre del Producto"].FormattedValue.ToString();

            name_input.Text = name;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (row_selected_id == "")
            {
                return;
            }
            if (!validateAllFields())
            {
                return;
            }
            conection.RegisterWareHouseEntry(row_selected_id, name_input.Text, price_input.Text, amount_input.Text, original_amount);
            MessageBox.Show("Exito!");
            InventoryDataGrid.DataSource = conection.getProductsForPurchase(filter_word.Trim());
        }

        private bool validateAllFields()
        {
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
            if (float.Parse(amount_input.Text) <= 0.0f)
            {
                MessageBox.Show("Error en la cantidad");
                return false;
            }
            if (float.Parse(price_input.Text) <= 0.0f)
            {
                MessageBox.Show("Error en el precio");
                return false;
            }
            return true;
        }
    }
}
