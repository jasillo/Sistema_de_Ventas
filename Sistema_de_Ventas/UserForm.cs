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

        public UserForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // validacion de campos
            string validOldPwd = ConDB.validString(oldPwd_input.Text);
            if (oldPwd_input.Text != validOldPwd)
            {
                MessageBox.Show("La contraseña actual no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string validNewtPwd = ConDB.validString(newPwd_input.Text);
            if (validNewtPwd != newPwd_input.Text)
            {
                MessageBox.Show("La contraseña nueva no es valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // confirmacion de password
            if (newPwd_input.Text != reNewPwd_input.Text)
            {
                MessageBox.Show("La nueva contraseña y repetir contraseña no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //operacion de verificacion en la base de datos
            if (ConDB.changePassword(newPwd_input.Text))
                MessageBox.Show("contraseña guardada con exito", "Exito!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Error al cambiar la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
