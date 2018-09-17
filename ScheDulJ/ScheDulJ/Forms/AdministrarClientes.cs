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
        private void administrarClientes_Load(object sender, EventArgs e)
        {
            mostrarClientes();
        }
        private void mostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = BDHelper.ConsultarSQL("SELECT nombre, apellido, telefono FROM Clientes WHERE activo = 1");
            gridClientes.DataSource = tabla;
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
                        string consultaSQL = "UPDATE Clientes SET Activo = 0 WHERE Nombre ='" + gridClientes.SelectedRows[0].Cells[0].Value.ToString() + "'";
                        BDHelper.ConsultarSQL(consultaSQL);
                        MessageBox.Show("Cliente Eliminado Correctamente", "Cliente Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarClientes();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception)
            {
                MessageBox.Show("Debe seleccionar un cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
