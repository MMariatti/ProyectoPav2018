using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheDulJ.Forms.FormsReportes
{
    public partial class frmReporteEventos : Form
    {
        public frmReporteEventos()
        {
            InitializeComponent();
        }

        private void frmReporteEventos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetScheDulJ.EquipamientoMasUtilizado' table. You can move, or remove it, as needed.
            this.equipamientoMasUtilizadoTableAdapter.Fill(this.dataSetScheDulJ.EquipamientoMasUtilizado);
            // TODO: This line of code loads data into the 'dataSetScheDulJ.Eventos' table. You can move, or remove it, as needed.
            this.eventosTableAdapter.Fill(this.dataSetScheDulJ.Eventos);

            this.reportViewer1.RefreshReport();
        }
    }
}
