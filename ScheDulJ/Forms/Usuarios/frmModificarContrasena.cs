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

namespace ScheDulJ.Forms.Usuarios
{
    public partial class frmModificarContrasena : Form
    {
        public frmModificarContrasena()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmModificarContrasena_Load(object sender, EventArgs e)
        {
           
        }
    }
}
