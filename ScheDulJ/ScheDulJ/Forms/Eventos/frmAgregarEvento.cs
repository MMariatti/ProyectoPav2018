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
            cargarClientes();
            cargarTipoEventos();
            calendarioEvento.MaxSelectionCount = 1;
        }
        private void cargarClientes()
        {
            
            cmbClientes.DisplayMember = "nombreCompleto";
            cmbClientes.ValueMember = "idCliente";
            cmbClientes.DataSource = Clientes.GetAllConcatenado();
        }

        private void cargarTipoEventos()
        {
            cmbTipoEvento.DisplayMember = "nombre";
            cmbTipoEvento.ValueMember = "idTipoEvento";
            cmbTipoEvento.DataSource = TiposEventos.GetAll();

        }

        private void nuevoEvento()
        {
            string horaI = txtHoraI.Text;
            string horaF = txtHoraF.Text;
            string fecha = calendarioEvento.SelectionRange.Start.ToShortDateString();
            
  
         
            int tipoEvento = Convert.ToInt32(cmbTipoEvento.SelectedValue.ToString());
            int idCliente = Convert.ToInt32(cmbClientes.SelectedValue.ToString());
            Evento evento = new Evento(txtNombre.Text, tipoEvento , fecha, horaI, horaF, txtDireccion.Text, idCliente);
            evento.Save();
            this.Close(); 
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            nuevoEvento(); 
        }

        private void txtHoraI_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
