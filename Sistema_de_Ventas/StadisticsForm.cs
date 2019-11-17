using System;
using System.IO;
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
    public partial class StadisticsForm : Form
    {
        public StadisticsForm()
        {
            InitializeComponent();
        }

        private void passwordMenuItem_Click(object sender, EventArgs e)
        {
            if (backupFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                if (ConDB.makeBackup(backupFolderBrowser.SelectedPath))
                    MessageBox.Show("Se creo con exito el backup", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("Error al crear el backup", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StadisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConDB.mainForm.Show();
        }

        private void csvMenuItem_Click(object sender, EventArgs e)
        {
            using (var reader = new StreamReader(@"D:\inventario.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    ConDB.CreateProduct(values[0], values[1], values[2], "0", "");
                }
            }
            MessageBox.Show("terminado");
        }

        private void StadisticsForm_Load(object sender, EventArgs e)
        {
            MainDataGrid.DataSource = ConDB.getStatistic();
        }

        private void MainDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            detailDataGrid.DataSource = ConDB.getDetailStatistic(MainDataGrid.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString());
        }
    }
}
