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
    public partial class ReporteClientes : Form
    {
        public ReporteClientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetScheDulJ.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.dataSetScheDulJ.Clientes);
            // TODO: This line of code loads data into the 'dataSetScheDulJ.Eventos' table. You can move, or remove it, as needed.
         
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
