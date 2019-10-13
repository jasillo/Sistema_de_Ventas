﻿using System;
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
    }
}
