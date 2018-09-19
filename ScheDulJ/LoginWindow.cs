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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtPasswordInsert_Clicked(object sender, EventArgs e)
        {
            txtPasswordInsert.Text = string.Empty;
            txtPasswordInsert.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuarioInsert.Text == string.Empty || txtPasswordInsert.Text == string.Empty) {
                MessageBox.Show("Ingrese Usuario y/o Contrasena" , "Error al Iniciar Sesion" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            else
            {
                //Logueo satisfactorio, creacion de instancia de menu principal 
                FrmMainMenu frmMainMenu;
                frmMainMenu = new FrmMainMenu();
                frmMainMenu.Show();
                //Minimizacion del frmLogin y eliminacion del TaskBar 
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false; 
            }
        }


        private void txtUsuarioInsert_Clicked(object sender, EventArgs e)
        {
            txtUsuarioInsert.Text = string.Empty;
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Esta seguro de cerrar la aplicacion", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
            Environment.Exit(1);
             }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar la aplicacion", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }     
    }
}
