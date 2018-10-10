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
    public partial class FrmModificarCliente : Form
    {
        public FrmModificarCliente()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCambiarTelefono_Load(object sender, EventArgs e)
        {

        }

        // Corroborar que el usuario que ingresa no sea vacio 
        private bool CorroborarClientes()
        {
            if (txtClienteNombre.Text == string.Empty || txtClienteApellido.Text ==string.Empty)
            {
                MessageBox.Show("No ha ingresado el nombre del cliente o su apellido", "Error al cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClienteNombre.Focus();
                txtClienteNombre.Clear();
                return false;

            }
            else
            {
                return true;
            }
        }
        //con este metodo nos aseguramos que el usuario no vaya a cargar valores null 
        private bool CorroborarTelefono()
        {
            if (txtNuevoTelefono.Text == string.Empty)
            {
                MessageBox.Show("No ha ingresado el nuevo telefono", "Error al cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNuevoTelefono.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CorroborarDireccion()
        {
            if (txtNuevaDireccion.Text == string.Empty)
            {
                MessageBox.Show("No ha ingresado el nuevo telefono", "Error al cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNuevaDireccion.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //Metodo para buscar el usuario al que le vamos a cambiar los datos
        private bool BuscarCliente(string nombre, string apellido)
        {
            DataTable tabla = new DataTable();
            string consultaSql = "SELECT nombre, apellido FROM Clientes Where nombre = '" + nombre + "' AND apellido = '"+ apellido +"' AND activo =1";
            tabla = DBHelper.ConsultarSQL(consultaSql);
            if (tabla.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //metodo para cambiar el telefono del cliente 

        private void CambiarTelefono(string apellido, string nombre, string telefono)
        {
            string consultaSql = "UPDATE Clientes SET telefono = '" + telefono + "' WHERE nombre = '" + nombre + "'"+" AND apellido = '"+ apellido +"'";
            DBHelper.ConsultarSQLVoid(consultaSql);
        }

        //metodo para cambiar la direccion del cliente 

        private void CambiarDireccion(string apellido, string nombre, string direccion)
        {
            string consultaSql = "UPDATE Clientes SET direccion = '" + direccion + "' WHERE nombre = '" + nombre + "'" + " AND apellido = '" + apellido + "'";
            DBHelper.ConsultarSQLVoid(consultaSql);
        }

            private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (CorroborarClientes() == true)
            {
                if (BuscarCliente(txtClienteNombre.Text,txtClienteApellido.Text) == true)
                {
                    txtNuevoTelefono.Enabled = true;
                    txtNuevaDireccion.Enabled = true;
                    BtnModificarDireccion.Enabled = true;
                    btnModificarTelefono.Enabled = true; 
                    txtNuevoTelefono.Focus();
                }
                else
                {
                    MessageBox.Show("El cliente ingresado no existe", "Busqueda de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtClienteNombre.Focus();
                    txtClienteNombre.Clear();
                    txtClienteApellido.Clear();
                }
            }
        }

        private void btnModificarTelefono_Click(object sender, EventArgs e)
        {
            if (CorroborarTelefono() == true)
            {
                if (MessageBox.Show("¿Está seguro que quiere cambiar el telefono?", "Cambiar telefono", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CambiarTelefono(txtClienteApellido.Text, txtClienteNombre.Text, txtNuevoTelefono.Text);
                    MessageBox.Show("Telefono cambiado correctamente", "Cambiar Telefono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevoTelefono.Clear();
                    txtNuevaDireccion.Focus();
                }
            }
            else
            {
                txtNuevoTelefono.Focus();
            }
            
        }

        private void BtnModificarDireccion_Click(object sender, EventArgs e)
        {
            if (CorroborarDireccion() == true)
            {
                if (MessageBox.Show("¿Está seguro que quiere cambiar la direccion?", "Cambiar direccion", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CambiarDireccion(txtClienteApellido.Text, txtClienteNombre.Text, txtNuevaDireccion.Text);
                    MessageBox.Show("Telefono cambiado correctamente", "Cambiar Telefono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtClienteNombre.Focus();
                    txtClienteNombre.Clear();
                    txtClienteApellido.Clear();
                    txtNuevaDireccion.Clear();
                    
                }
            }
            else
            {
                txtNuevaDireccion.Focus();
            }
        }
    }   
}