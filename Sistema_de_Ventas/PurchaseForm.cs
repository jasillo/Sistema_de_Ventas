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
                filter_word = conection.validString(filterTextBox.Text);
                filterTextBox.Text = filter_word;
                InventoryDataGrid.DataSource = conection.getProductsForPurchase(filter_word);
                formatDataGrid();
            }
        }

        private void formatDataGrid()
        {
            InventoryDataGrid.Columns["id"].Visible = false;
            InventoryDataGrid.Columns["Nombre del Producto"].Width = 300;
            InventoryDataGrid.Columns["Cantidad"].Width = 60;
            InventoryDataGrid.Columns["Stock Minimo"].Width = 60;
        }

        private void clean()
        {
            name_input.Text = "";
            amount_input.Text = "0,0";
            price_input.Text = "0,0";
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
            if (e.RowIndex == -1)
                return;
            row_selected_id = InventoryDataGrid.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            original_amount = InventoryDataGrid.Rows[e.RowIndex].Cells["Cantidad"].FormattedValue.ToString();
            string name = InventoryDataGrid.Rows[e.RowIndex].Cells["Nombre del Producto"].FormattedValue.ToString();

            name_input.Text = name;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (row_selected_id == "")
                return;
            string amount = conection.validNumber(amount_input.Text);
            string price = conection.validNumber(price_input.Text);

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

            if (conection.RegisterWareHouseEntry(row_selected_id, name_input.Text, price, amount))
            {
                
                if (conection.updateCurrentStock(row_selected_id, original_amount, amount))
                    MessageBox.Show("Entrada en almacen exitosa", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("Se hizo el registro de la entrada, pero no se pudo actualizar el stock actual", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No se pudo crear el producto, puede que ya exista un producto con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InventoryDataGrid.DataSource = conection.getProductsForPurchase(filter_word);
            formatDataGrid();
            clean();
            filterTextBox.Focus();
        }
                
        private void PurchaseForm_Shown(object sender, EventArgs e)
        {
            filterTextBox.Focus();
        }
    }
}
