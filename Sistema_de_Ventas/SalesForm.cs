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
    public partial class SalesForm : Form
    {
        string row_selected_id = "";
        string filter_word = "";
        float current_amount = 0.0f;
        DataTable detailsDataTable = new DataTable();

        public SalesForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Shown(object sender, EventArgs e)
        {
            setDetailsGridFormat();
            filterTextBox.Focus();
        }

        private void filterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filter_word = filterTextBox.Text.Trim();
                InventoryDataGrid.DataSource = ConDB.getProductsList(filter_word);
                setProductsGridFormat();
            }
        }

        private void setProductsGridFormat()
        {
            InventoryDataGrid.Columns["name"].HeaderText = "Nombre del Producto";
            InventoryDataGrid.Columns["sale_price"].HeaderText = "Precio de Venta";

            InventoryDataGrid.Columns["id"].Visible = false;
            InventoryDataGrid.Columns["name"].Width = 300;
            InventoryDataGrid.Columns["amount"].Visible = false;
            InventoryDataGrid.Columns["sale_price"].Width = 60;
            InventoryDataGrid.Columns["minimum"].Visible = false;
            InventoryDataGrid.Columns["bar_code"].Visible = false;
            InventoryDataGrid.Columns["photo"].Visible = false;
        }

        private void setDetailsGridFormat()
        {
            DetailDataGrid.DataSource = detailsDataTable;
            detailsDataTable.Columns.Add("id");
            detailsDataTable.Columns.Add("name");
            detailsDataTable.Columns.Add("price");
            detailsDataTable.Columns.Add("amount");
            detailsDataTable.Columns.Add("total");

            DetailDataGrid.Columns["id"].Visible = false;
            DetailDataGrid.Columns["name"].Width = 300;
            DetailDataGrid.Columns["price"].Width = 70;
            DetailDataGrid.Columns["amount"].Width = 70;
            DetailDataGrid.Columns["total"].Width = 70;

            DetailDataGrid.Columns["name"].HeaderText = "Nombre del Producto";
            DetailDataGrid.Columns["price"].HeaderText = "Precio Unidad";
            DetailDataGrid.Columns["amount"].HeaderText = "Cantidad";
            DetailDataGrid.Columns["total"].HeaderText = "Total";
        }

        private void InventoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= InventoryDataGrid.RowCount - 1)
            {
                return;
            }
            row_selected_id = InventoryDataGrid.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            string price = InventoryDataGrid.Rows[e.RowIndex].Cells["sale_price"].FormattedValue.ToString();
            string name = InventoryDataGrid.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();

            name_input.Text = name;
            price_input.Text = price;
            amount_input.Focus();
        }

        private void addToDetails()
        {
            if (row_selected_id == "")
            {
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (current_amount <= 0.0f)
            {
                MessageBox.Show("La cantidad no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            detailsDataTable.Rows.Add(new object[] { row_selected_id, name_input.Text, price_input.Text, amount_input.Text, getTotalRow(amount_input.Text, price_input.Text) });
            cleanfields();
            calculateTotalSale();
            filterTextBox.Focus();
        }

        private void calculateTotalSale()
        {
            float total = 0.0f;
            for (int index = 0; index < detailsDataTable.Rows.Count; index++)
            {
                total += float.Parse(detailsDataTable.Rows[index]["total"].ToString());
            }
            totalSale_input.Text = total.ToString();
        }

        private float convertToFloat(string word)
        {
            string temp = word.Replace(",", ".");
            Console.WriteLine(temp);
            return float.Parse(temp);
        }

        private void amount_input_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string word = amount_input.Text.Trim().Replace(".", ",");
                try
                {
                    current_amount = float.Parse(word);
                }
                catch (Exception)
                {
                    MessageBox.Show("La cantidad no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                addToDetails();
            }
        }

        private string getTotalRow(string amount, string price)
        {
            float a = float.Parse(amount.Trim().Replace(".", ","));
            float p = float.Parse(price.Trim().Replace(".", ","));

            return (a * p).ToString();
        }

        private void cleanfields()
        {
            row_selected_id = "";
            current_amount = 0.0f;
            name_input.Text = "";
            amount_input.Text = "1,0";
            price_input.Text = "0.0";
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            if (detailsDataTable.Rows.Count <= 0)
            {
                MessageBox.Show("Debe existir al menos un producto en la lista", "Faltan Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var confirmResult = MessageBox.Show("Desea confirmar la venta?", "Confirmar Venta", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int id_sale = ConDB.insertSale(detailsDataTable.Rows.Count, totalSale_input.Text);
                Console.WriteLine(id_sale.ToString());
                if (id_sale == -1)
                {
                    MessageBox.Show("Error al Procesar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DataRow row in detailsDataTable.Rows)
                {
                    bool res = ConDB.insertDetailSale(id_sale, row["id"].ToString(), row["name"].ToString(), row["price"].ToString(), row["amount"].ToString(), row["total"].ToString());
                    if (!res)
                        MessageBox.Show("no se pudo insertar " + row["name"].ToString());
                    bool res2 = ConDB.reduceInventory(row["id"].ToString(), row["amount"].ToString());
                    if (!res2)
                        MessageBox.Show("no se pudo reducir " + row["name"].ToString());
                }
                detailsDataTable.Clear();
                totalSale_input.Text = "00,00";
            }
        }

        private void DetailDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= DetailDataGrid.RowCount)
            {
                return;
            }
            name_input.Text = DetailDataGrid.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            price_input.Text = DetailDataGrid.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
            amount_input.Text = DetailDataGrid.Rows[e.RowIndex].Cells["amount"].FormattedValue.ToString();

            DetailDataGrid.Rows.RemoveAt(e.RowIndex);
            amount_input.Focus();
            calculateTotalSale();
        }

        private void SalesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConDB.mainForm.Show();
        }

        private void barcode_input_KeyDown(object sender, KeyEventArgs e)
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
                price_input.Text = res[2];
            }
        }
    }
}
