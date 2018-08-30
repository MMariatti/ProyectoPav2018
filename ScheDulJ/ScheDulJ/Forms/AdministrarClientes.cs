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
    public partial class frmAdministrarClientes : Form
    {
        public frmAdministrarClientes()
        {
            InitializeComponent();
        }

        private void btn_Salir(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AdministrarClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }
        private void MostrarClientes()
        {
            BDHelper bdHelper = new BDHelper();
            DataTable tabla = new DataTable();
            tabla = bdHelper.ConsultarSQL("SELECT * FROM Clientes");
            gridClientes.DataSource = tabla;
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            MostrarClientes(); 
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.Show(); 
        }
    }
}
