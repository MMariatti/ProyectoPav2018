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

        private bool CorroborarNombre()
        {
            if (txtNuevoNombre.Text == string.Empty)
            {
                MessageBox.Show("No ha ingresado el nuevo nombre", "Error al cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNuevoNombre.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CorroborarApellido()
        {
            if (txtNuevoApellido.Text == string.Empty)
            {
                MessageBox.Show("No ha ingresado el nuevo Apellido", "Error al cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNuevoApellido.Focus();
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

       
       

        //metodo para cambiar el telefono del cliente 

        private void CambiarTelefono()
        {
            int nvoTelefono = Convert.ToInt32(txtNuevoTelefono.Text);
            Clientes cliente = new Clientes(Convert.ToInt32(txt_IdCliente.Text));
            cliente.CambiarTelefono(nvoTelefono);
        }

        //metodo para cambiar la direccion del cliente 

        private void CambiarDireccion()
        {
            string nvaDireccion = txtNuevaDireccion.Text;
            Clientes cliente = new Clientes(Convert.ToInt32(txt_IdCliente.Text));
            cliente.CambiarDireccion(nvaDireccion);
        }

        private void CambiarNombre()
        {
            string nvoNombre = txtNuevoNombre.Text;
            Clientes cliente = new Clientes(Convert.ToInt32(txt_IdCliente.Text));
            cliente.CambiarNombre(nvoNombre);
        }

        private void CambiarApellido()
        {
            string nvoApellido = txtNuevoApellido.Text;
            Clientes cliente = new Clientes(Convert.ToInt32(txt_IdCliente.Text));
            cliente.CambiarApellido(nvoApellido);
        }

        private void btnModificarTelefono_Click(object sender, EventArgs e)
        {
            if (CorroborarTelefono() == true)
            {
                if (MessageBox.Show("¿Está seguro que quiere cambiar el telefono?", "Cambiar telefono", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CambiarTelefono();
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
                    CambiarDireccion();
                    MessageBox.Show("Telefono cambiado correctamente", "Cambiar Telefono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevoNombre.Focus();
                    txtNuevaDireccion.Clear();
                    
                }
            }
            else
            {
                txtNuevaDireccion.Focus();
            }
        }
    

        private void BtnModificarNombre_Click(object sender, EventArgs e)
        {
            if (CorroborarNombre()==true)
            {
                if (MessageBox.Show("¿Está seguro que quiere cambiar el nombre?", "Cambiar nombre", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CambiarNombre();
                    MessageBox.Show("Nombre cambiado correctamente", "Cambiar Nombre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevoApellido.Focus();
                    txtNuevoNombre.Clear();
                    


                }
                else
                {
                    txtNuevoNombre.Focus();
                }
            }
            
        }

        private void BtnModificarApellido_Click(object sender, EventArgs e)
        {
            if (CorroborarApellido() == true)
            {
                if (MessageBox.Show("¿Está seguro que quiere cambiar el apellido?", "Cambiar apellido", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CambiarApellido();
                    MessageBox.Show("Apellido cambiado correctamente", "Cambiar Apellido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevoTelefono.Focus();
                   
                    txtNuevoApellido.Clear();
                    

                }
                else
                {
                    txtNuevoApellido.Focus();
                }
               
            }
            
        }

        private void txtNuevoNombre_Click(object sender, EventArgs e)
        {
            txtNuevoNombre.Clear();
        }

        private void txtNuevoApellido_TextChanged(object sender, EventArgs e)
        {
            txtNuevoApellido.Clear(); 
        }

        private void txtNuevoTelefono_Click(object sender, EventArgs e)
        {
            txtNuevoTelefono.Clear();
        }

        private void txtNuevaDireccion_Click(object sender, EventArgs e)
        {
            txtNuevaDireccion.Clear();
        }
    }   
}