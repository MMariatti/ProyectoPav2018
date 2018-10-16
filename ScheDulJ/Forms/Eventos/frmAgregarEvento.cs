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
            MostrarClientes();
            MostrarEquipamiento();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MostrarClientes()
        {
            cmbClientes.DataSource = Clientes.GetAll();
            cmbClientes.DisplayMember = "Nombre";
            cmbClientes.ValueMember = "idCliente";
        }

        private void MostrarEquipamiento()
        {
            DataTable tabla = new DataTable();
            tabla = Items.GetDataAllItems();
            grdEquipamiento.DataSource = tabla;
            grdEquipamiento.Columns[3].Visible = false ;
            grdEquipamiento.Columns[4].Visible = false;
            grdEquipamiento.Columns[5].Visible = false;
        }

    }
}
