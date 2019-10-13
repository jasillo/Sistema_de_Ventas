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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Form inventoryForm = new InventoryForm();
            inventoryForm.ShowDialog();
        }

        private void PurchasesButton_Click(object sender, EventArgs e)
        {
            Form purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            Form salesForm = new SalesForm();
            salesForm.ShowDialog();
        }

        private void passwordMenuItem_Click(object sender, EventArgs e)
        {
            Form userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void stadisticsButton_Click(object sender, EventArgs e)
        {
            Form stadisticsForm = new StadisticsForm();
            stadisticsForm.ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (ConDB.userRole == 1)
                stadisticsButton.Enabled = true;
        }
    }
}
