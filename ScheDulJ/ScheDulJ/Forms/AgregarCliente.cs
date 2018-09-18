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
    public partial class frmAgregarCliente : Form
    {
      
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void limpiarCampos()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty; 
        }   

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
       
        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void corroborarDatos()
        {
            if(txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Nombre,Apellido y Telefono", "Error al Crear Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void agregarCliente(string nombre, string apellido, string direccion, string telefono)
        {

            string consultaSQL = "INSERT INTO Clientes (nombre,apellido,direccion,telefono,activo)" +
                " VALUES ('" + nombre + "','" + apellido + "','" + direccion +"','" + telefono + "', 1);";
           BDHelper.ConsultarSQL(consultaSQL);
            string consultaSQL = "INSERT INTO Clientes (Nombre,Apellido,Telefono,Activo)" +
                " VALUES ('" + nombre + "','" + apellido + "','" + telefono + "', 1);";
           DBHelper.ConsultarSQL(consultaSQL);

            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            corroborarDatos();
            if (MessageBox.Show("Esta seguro que desea crear el cliente?", "Confirmar Creacion Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
           
                agregarCliente(txtNombre.Text, txtApellido.Text,txtDireccion.Text, txtTelefono.Text);
                MessageBox.Show("Cliente Creado Correctamente", "Usuario Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos(); 
            }
        }

    }   
}

