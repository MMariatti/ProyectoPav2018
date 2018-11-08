using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheDulJ.Classes; 

namespace ScheDulJ.Forms
{
    public partial class frmAgregarUsuario : Form
    {

        public frmAgregarUsuario()
        {
            InitializeComponent();
        }
        private void limpiarUsuarios()
        {
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPasswordConfirm.Text = string.Empty; 
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            //Corroborar Datos
            corroborarDatos();
            //Agregar Usuario a BD 
            if (MessageBox.Show("Esta seguro que desea crear el usuario?", "Confirmar Creacion Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                agregarUsuario(txtUsuario.Text, txtPassword.Text);
                limpiarUsuarios();
            }           

        }       //AGREGAR USUARIO 
        private void agregarUsuario(string nombre , string contra)
        {

            Classes.Usuarios usuario = new Classes.Usuarios(nombre, contra);
            usuario.Save(); 
            this.Close(); 
            
        }        //CORROBORAR DATOS
        private void corroborarDatos()
        {
            if (txtUsuario.Text == string.Empty || txtPassword.Text == string.Empty || txtPasswordConfirm.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Usuario y/o Contrasena", "Error al Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtPassword.Text != txtPasswordConfirm.Text)
            {
                MessageBox.Show("Las contrasenas no coinciden , ingrese nuevamente", "Error al Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = string.Empty;
                txtPasswordConfirm.Text = string.Empty;
            }

        }
        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
