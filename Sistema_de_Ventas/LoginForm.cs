﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Ventas
{
    public partial class LoginForm : Form
    {
        bool conectionActive = false;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void conection_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form intiDForm = new initBDForm();
            intiDForm.ShowDialog();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (conectionActive)
            {
                login();
            } else
            {
                if (!ConDB.openConnection())
                {
                    MessageBox.Show("No se pudo conectar a la base de datos, haga click en 'solucionar problemas de coneccion' y siga los pasos",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conectionActive = false;
                }
                else
                {
                    login();
                    conectionActive = true;
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader(@"D:\ErrorLog\coneccion.txt"))
            {
                string temp = file.ReadLine();
                ConDB.cadena = temp;
                Console.WriteLine(ConDB.cadena);
                file.Close();
            }

            if (!ConDB.openConnection())
            {
                MessageBox.Show("No se pudo conectar a la base de datos, haga click en 'solucionar problemas de coneccion' y siga los pasos",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conectionActive = false;
            }
            else
                conectionActive = true;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConDB.closeConnection();
        }

        private void login()
        {
            string uname = ConDB.validString(username_input.Text.Trim());
            string pwd = ConDB.validString(pwd_input.Text);

            if (ConDB.login(uname, pwd))
            {
                this.Hide();
                ConDB.mainForm = new MainForm();
                ConDB.mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario y/o la contraseña son incorrectos",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
