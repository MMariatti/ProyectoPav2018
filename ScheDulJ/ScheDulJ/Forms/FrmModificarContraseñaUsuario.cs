using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ScheDulJ.Forms
{
    public partial class FrmModificarContraseñaUsuario : Form
    {
        public FrmModificarContraseñaUsuario()
        {
            InitializeComponent();
        }

        private void FrmModificarContraseñaUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        // Corroborar que el usuario que ingresa no sea vacio 
        private bool CorroborarUsuario()
        {
            if (txtUsuario.Text.ToLower() == string.Empty)
            {
                MessageBox.Show("No ha ingresado el nombre del usuario", "Error al cargar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                txtUsuario.Clear();
                return false;

            }
            else
            {
                return true;
            }


        }
        //Metodo para buscar el usuario al que le vamos a cambiar la contraseña
        private bool BuscarUsuario(string nombre)
        {
            DataTable tabla = new DataTable();
            string consultaSql = "SELECT usuario FROM Usuarios Where usuario = '" + nombre + "' AND activo =1";
            tabla = DBHelper.ConsultarSQL(consultaSql);
            if (tabla.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }



        }

        //Corroborar que las contraseñas coincidan
        private bool CorroborarContraseñas()
        {
            if (txtPassword.Text != txtPasswordConfirmada.Text)
            {
                MessageBox.Show("Las contraseñas no son identicas", "Error al cargar las contraseñas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }




        }

        //Cambia la contraseña actual por la nueva que ingresamos

        private void CambiarContraseña(string contra, string nombre)
        {
            string consultaSql = "UPDATE Usuarios SET contra = '" + contra + "' WHERE usuario = '" + nombre + "'";
            DBHelper.ConsultarSQLVoid(consultaSql);
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (CorroborarUsuario() == true)
            {

                if (BuscarUsuario(txtUsuario.Text) == true)
                {
                    txtPassword.Enabled = true;
                    txtPasswordConfirmada.Enabled = true;
                    txtPassword.Focus();
                }
                else
                {
                    MessageBox.Show("El usuario ingresado no existe", "Busqueda de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    txtUsuario.Clear();
                }
            }
        }

        private void FrmModificarContraseñaUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnModificarContraseña_Click(object sender, EventArgs e)
        {
            if (CorroborarContraseñas() == true)
            {
                if (MessageBox.Show("¿Está seguro que quiere cambiar su contraseña?", "Cambiar contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CambiarContraseña(txtPasswordConfirmada.Text, txtUsuario.Text);
                    MessageBox.Show("Contraseña cambiada correctamente", "Cambiar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                txtPassword.Clear();
                txtPasswordConfirmada.Clear();
                txtPassword.Focus();
            }



        }
    }
}
