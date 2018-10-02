using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheDulJ;
using ScheDulJ.Classes; 

namespace ScheDulJ.Forms
{
    public partial class frmAgregarTipoEvento : Form
    {
        public frmAgregarTipoEvento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarTEvento()
        {
            txtDescripcion.Clear();
            txtNombre.Clear();
        }

        private bool CorroborarDatos()
        {
            if (txtNombre.Text == string.Empty || txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Nombre y/o Descripcion", "Error al Crear Tipo de Evento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (CorroborarDatos()){

                TiposEventos tEvento = new TiposEventos(txtNombre.Text , txtDescripcion.Text); 
                tEvento.Save();
                this.Close(); 
            }
            {
                

            }
        }
    }
}
