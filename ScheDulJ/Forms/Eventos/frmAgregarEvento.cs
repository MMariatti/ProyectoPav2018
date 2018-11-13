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
            MostrarTiposEvento();
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

      
        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearEvento(txtNombre.Text, calendarioEvento.SelectionRange.Start.ToString(), txtHoraI.Text.ToString() , txtHoraF.Text.ToString(), txtDireccion.Text.ToString()); 
        }

        private void CrearEvento(string nombre, string fecha , string horaInicio , string horaFin , string direccion)
        {
            try
            {
                TiposEventos tipoEvento = new TiposEventos(System.Convert.ToInt32(cmbTipoEvento.SelectedValue.ToString()));
                Clientes cliente = new Clientes(System.Convert.ToInt32(cmbClientes.SelectedValue.ToString()));
                Evento evento = new Evento(nombre, tipoEvento, fecha, horaInicio, horaFin, direccion, cliente);
                evento.Save();
                Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void cmbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MostrarTiposEvento()
        {
            cmbTipoEvento.DataSource = TiposEventos.GetAll();
            cmbTipoEvento.DisplayMember = "nombre";
            cmbTipoEvento.ValueMember = "idTipoEvento"; 
        }
    }
}
