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

namespace ScheDulJ
{
    public partial class FrmLogin : Form
    {

        private string usuarioActual;
        private string contraseñaActual; 

        public FrmLogin()
        {
            InitializeComponent();
        }
       
        private bool loguear(string usuario, string contra)
        {
            DataTable tabla;
            string consulta = "SELECT usuario , contra FROM Usuarios U WHERE " +
                "U.usuario = '" + usuario + "' AND U.contra = '" + contra + "' AND U.activo = 1"; 
            tabla = DBHelper.ConsultarSQL(consulta);
            if (tabla.Rows.Count == 0)
            {
                return false; 
            }
            else
            {
                contraseñaActual = contra;
                usuarioActual = usuario; 
                return true;
            }
        }
        //EVENTOS
        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuarioInsert.Text == string.Empty || txtPasswordInsert.Text == string.Empty) {
                MessageBox.Show("Ingrese Usuario y/o Contrasena" , "Error al Iniciar Sesion" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                //Logueo con base de datos 
                if (loguear(txtUsuarioInsert.Text, txtPasswordInsert.Text))
                    {
                    //Logueo satisfactorio, creacion de instancia de menu principal 
                    FrmMainMenu frmMainMenu;
                    frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();
                    //Minimizacion del frmLogin y eliminacion del TaskBar 
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                    }
                else
                {
                    MessageBox.Show("Usuario Incorrecto, por favor ingrese nuevamente", "Error al Iniciar Sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuarioInsert.Text = "Usuario";
                    txtPasswordInsert.UseSystemPasswordChar = true; 
                    txtPasswordInsert.Text = "Contraseña";

                }
            }
                
        }       
        private void txtUsuarioInsert_Clicked(object sender, EventArgs e)
        {
            txtUsuarioInsert.Text = string.Empty;
        }
        private void btnExitLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la aplicacion?", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la aplicacion", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        private void txtPasswordInsert_Clicked(object sender, EventArgs e)
        {
            txtPasswordInsert.Text = string.Empty;
            txtPasswordInsert.UseSystemPasswordChar = true;
        }
  
        public Sesion SesionActual()
        {
            Sesion sesion = new Sesion(usuarioActual, contraseñaActual);
            return sesion; 
        }
    }


}
