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

           
        private void frmModificarEvento_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento(Convert.ToInt32(lblNombre.Text));
            evento.CambiarFecha(calendarioNuevaFecha.SelectionRange.Start.ToString());
        }

        private void btnModifcarHI_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento(Convert.ToInt32(lblNombre.Text));
            evento.CambiarHorarioInicio(txtHoraI.Text.ToString());
        }

        private void btnModificarHF_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento(Convert.ToInt32(lblNombre.Text));
            evento.CambiarFecha(txtHoraF.Text.ToString());
        }

   
    }
}
