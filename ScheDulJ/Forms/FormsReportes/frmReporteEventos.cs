using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using ScheDulJ.DataSetScheDulJTableAdapters; 

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
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtAño.Text != "")
            {
                var myDataTable = new DataSetScheDulJ.EventosDataTable();
                var myTableAdapter = new EventosTableAdapter();
                myTableAdapter.Fill(myDataTable, Convert.ToInt32(txtAño.Text));
                var rds = new ReportDataSource("ReporteEventos", myDataTable as DataTable);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Ingrese fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.None); 
            }
        }

       

    }
}
