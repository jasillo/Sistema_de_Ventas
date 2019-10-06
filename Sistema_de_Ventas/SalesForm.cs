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
        ConectionDB conection;
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
            filterTextBox.Focus();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            conection = new ConectionDB();
            conection.openConnection();
            setDetailsGridFormat();
        }

        private void SalesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conection.closeConnection();
        }

        private void filterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filter_word = filterTextBox.Text.Trim();
                InventoryDataGrid.DataSource = conection.getProductsForSales(filter_word);
                setProductsGridFormat();
            }
        }

        private void setProductsGridFormat()
        {
            InventoryDataGrid.Columns[0].Width = 25;
            InventoryDataGrid.Columns[0].Visible = false;
            InventoryDataGrid.Columns[0].Resizable = DataGridViewTriState.False;
            InventoryDataGrid.Columns["Precio"].Width = 60;
            InventoryDataGrid.Columns["Nombre del Producto"].Width = 300;
        }

        private void setDetailsGridFormat()
        {
            DetailDataGrid.DataSource = detailsDataTable;
            detailsDataTable.Columns.Add("Id");
            detailsDataTable.Columns.Add("Nombre del Producto");
            detailsDataTable.Columns.Add("Precio");
            detailsDataTable.Columns.Add("Cantidad");
            detailsDataTable.Columns.Add("Total");
            DetailDataGrid.Columns["Id"].Visible = false;

            DetailDataGrid.Columns["Nombre del Producto"].Width = 300;
            DetailDataGrid.Columns["Precio"].Width = 70;
            DetailDataGrid.Columns["Cantidad"].Width = 70;
            DetailDataGrid.Columns["Total"].Width = 70;
        }

        private void InventoryDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= InventoryDataGrid.RowCount - 1)
            {
                return;
            }
            row_selected_id = InventoryDataGrid.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
            string price = InventoryDataGrid.Rows[e.RowIndex].Cells["Precio"].FormattedValue.ToString();
            string name = InventoryDataGrid.Rows[e.RowIndex].Cells["Nombre del Producto"].FormattedValue.ToString();

            name_input.Text = name;
            price_input.Text = price;
            //total_input.Text = (float.Parse(price) * float.Parse(amount_input.Text)).ToString();
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
            var confirmResult = MessageBox.Show("Desea confirmar la venta?", "Confirmar Venta", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int id_sale = conection.insertSale(detailsDataTable.Rows.Count ,totalSale_input.Text);
                if (id_sale == -1)
                {
                    MessageBox.Show("Error al Procesar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DataRow row in detailsDataTable.Rows)
                {
                    bool res = conection.insertDetailSale(id_sale, row["Id"].ToString(), row["Nombre del Producto"].ToString(), row["Precio"].ToString(), row["Cantidad"].ToString(), row["Total"].ToString());
                    if (!res)
                    {
                        MessageBox.Show("no se pudo insertar " + row["Nombre del Producto"].ToString());
                    }
                    bool res2 = conection.reduceInventory(row["Id"].ToString(), row["Cantidad"].ToString());
                    if (!res2)
                        MessageBox.Show("no se pudo reducir " + row["Nombre del Producto"].ToString());
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
            name_input.Text = DetailDataGrid.Rows[e.RowIndex].Cells["Nombre del Producto"].FormattedValue.ToString();
            price_input.Text = DetailDataGrid.Rows[e.RowIndex].Cells["Precio"].FormattedValue.ToString();
            amount_input.Text = DetailDataGrid.Rows[e.RowIndex].Cells["Cantidad"].FormattedValue.ToString();

            DetailDataGrid.Rows.RemoveAt(e.RowIndex);
            amount_input.Focus();
            calculateTotalSale();
        }
    }
}
