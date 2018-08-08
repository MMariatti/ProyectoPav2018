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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsuarioInsert_TextChanged(object sender, EventArgs e)
        {
            
         }

        private void txtPasswordInsert_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPasswordInsert_Clicked(object sender, EventArgs e)
        {
            txtPasswordInsert.Text = "";
            txtPasswordInsert.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuarioInsert.Text == "") {
                MessageBox.Show("Debe Ingresar el Usuario");
            if (txtPasswordInsert.Text == "")
                {
                MessageBox.Show("Debe Ingresar la Contrasena"); 
                }
            }
        }

        private void txtUsuarioInsert_Clicked(object sender, EventArgs e)
        {
            txtUsuarioInsert.Text = "";
        }
    }
}
