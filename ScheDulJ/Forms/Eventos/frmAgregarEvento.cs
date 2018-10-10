using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ScheDulJ.Forms.Eventos
{
    public partial class frmAgregarEvento : Form
    {
        public frmAgregarEvento()
        {
            InitializeComponent();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.Show(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregarEvento_Load(object sender, EventArgs e)
        {
            cmbClientes.DataSource = Clientes.GetAll();
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "Nombre"; 
        }
    }
}
