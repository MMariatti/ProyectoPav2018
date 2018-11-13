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
    public partial class frmModificarEvento : Form
    {
        public frmModificarEvento()
        {
            InitializeComponent();
        }

            

        private void MostrarTiposEvento()
        {
            cmbTipoEvento.DataSource = TiposEventos.GetAll();
            cmbTipoEvento.DisplayMember = "nombre";
            cmbTipoEvento.ValueMember = "idTipoEvento";
            cmbTipoEvento.SelectedIndex = -1;
        }

        private void frmModificarEvento_Load(object sender, EventArgs e)
        {
            MostrarTiposEvento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
