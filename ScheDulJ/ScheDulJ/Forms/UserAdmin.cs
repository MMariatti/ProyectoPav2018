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
    public partial class frmUserAdmin : Form
    {
        public frmUserAdmin()
        {
            InitializeComponent();
        }
        //INICIAR BDHELPER
        BDHelper bdHelper = new BDHelper(@"Data Source=FRANNOTEBOOK\TESTSERVER;Initial Catalog=ScheDulJ;Integrated Security=True"); 
        private void frmUserAdmin_Load(object sender, EventArgs e)
        {
            mostrarListaUsuarios();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mostrarListaUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = bdHelper.ConsultarSQL("SELECT Usuario FROM Usuarios U"); 
            gridUsuarios.DataSource = tabla; 
        }


    }
}
