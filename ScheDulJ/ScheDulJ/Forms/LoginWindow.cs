using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheDulJ
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //INSTANCIA DE BDHELPER
        BDHelper bdHelper = new BDHelper();
        //METODO LOGUEO
        private bool Loguear(string usuario, string password)
        {
            bdHelper.CadenaConexion = @"Data Source=FRANNOTEBOOK\TESTSERVER;Initial Catalog=ScheDulJ;Integrated Security=True";
            DataTable tabla;
            string consulta = "SELECT Usuario , Password FROM Usuarios U WHERE " +
                "U.Usuario = '" + usuario + "' AND U.Password = '" + password + "'"; 
            tabla = bdHelper.ConsultarSQL(consulta);
            if (tabla.Rows.Count == 0)
            {
                return false; 
            }
            else
            {
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
                if (Loguear(txtUsuarioInsert.Text, txtPasswordInsert.Text))
                    {
                    //Logueo satisfactorio, creacion de instancia de menu principal 
                    MessageBox.Show("Inicio de sesion satisfactorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
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
                    txtPasswordInsert.UseSystemPasswordChar = false; 
                    txtPasswordInsert.Text = "Contrasena";

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
  
    }


}
