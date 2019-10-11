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
    public partial class UserForm : Form
    {
        ConectionDB conection;

        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            conection = new ConectionDB();
            conection.openConnection();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            conection.closeConnection();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // validacion de campos
            string validUsername = conection.validString(user_input.Text.Trim());
            if (validUsername != user_input.Text.Trim())
            {
                MessageBox.Show("El usuario no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string validOldPwd = conection.validString(oldPwd_input.Text);
            if (oldPwd_input.Text != validOldPwd)
            {
                MessageBox.Show("La contraseña actual no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string validNewtPwd = conection.validString(newPwd_input.Text);
            if (validNewtPwd != newPwd_input.Text)
            {
                MessageBox.Show("La contraseña nueva no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (newPwd_input.Text != reNewPwd_input.Text)
            {
                MessageBox.Show("La nueva contraseña y repetir contraseña no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           
            //operacion de verificacion en la base de datos
            int userID = conection.getUserID(validUsername, oldPwd_input.Text);
            if (userID == -1)
            {
                MessageBox.Show("El usuario y/o la actual contraseña son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (conection.changePassword(userID,newPwd_input.Text))
                MessageBox.Show("contraseña guardada con exito", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Error al cambiar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
