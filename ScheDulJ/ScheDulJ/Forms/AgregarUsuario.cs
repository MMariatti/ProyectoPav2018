using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheDulJ.Forms
{
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
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
            CorroborarDatos();
            //Agregar Usuario a BD 
            if (MessageBox.Show("Esta seguro que desea crear el usuario?", "Confirmar Creacion Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AgregarUsuario(txtUsuario.Text, txtPassword.Text);
                MessageBox.Show("Usuario Creado Correctamente", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos(); 
            }           

        }       //AGREGAR USUARIO 
        private void AgregarUsuario(string nombre , string password)
        {
            BDHelper bdHelper = new BDHelper();
            string consultaSQL = "INSERT INTO Usuarios (Usuario,Password)" +
                " VALUES ('"+nombre+"','"+password+"');";
            bdHelper.ConsultarSQLVoid(consultaSQL);
            this.Close(); 
            
        }        //CORROBORAR DATOS
        private void CorroborarDatos()
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
