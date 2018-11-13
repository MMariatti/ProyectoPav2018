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

namespace ScheDulJ.Forms
{
    public partial class frmAdministrarClientes : Form
    {
        public frmAdministrarClientes()
        {
            InitializeComponent();
        }

        private void mostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla =Clientes.GetAllEspecifico();
            gridClientes.DataSource = tabla;

        }

        private void btn_Salir(object sender, EventArgs e)
        {
            this.Close();
        }
        private void administrarClientes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }

      
        
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            mostrarClientes(); 
            
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.Show(); 
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                if (gridClientes.SelectedRows[0].Index != gridClientes.Rows.Count - 1)
                {
                    if (MessageBox.Show("Esta seguro que desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Clientes cliente = new Clientes(Convert.ToInt32(gridClientes.SelectedRows[0].Cells[0].Value.ToString()));
                        cliente.Baja();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            FrmModificarCliente frmModificarCliente;
            frmModificarCliente = new FrmModificarCliente();
            Clientes cliente = new Clientes(Convert.ToInt32(gridClientes.SelectedRows[0].Cells[0].Value.ToString()));
            frmModificarCliente.txt_IdCliente.Text = gridClientes.SelectedRows[0].Cells[0].Value.ToString();
            frmModificarCliente.txtNuevoNombre.Text = cliente.Nombre;
            frmModificarCliente.txtNuevoApellido.Text = cliente.Apellido ;
            frmModificarCliente.txtNuevoTelefono.Text = Convert.ToString(cliente.Telefono);
            frmModificarCliente.txtNuevaDireccion.Text = cliente.Direccion;
            frmModificarCliente.Show();

        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
