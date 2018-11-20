using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheDulJ.DataSetScheDulJTableAdapters;
using Microsoft.Reporting.WinForms;

namespace ScheDulJ.Forms.FormsReportes
{
    public partial class frmReporteTipoEventos : Form
    {
        public frmReporteTipoEventos()
        {
            InitializeComponent();
        }

        private void frmReporteTipoEventos_Load(object sender, EventArgs e)
        {
            var myDataTable = new DataSetScheDulJ.TiposEventosDataTable();
            var myTableAdapter = new TiposEventosTableAdapter();
            myTableAdapter.Fill(myDataTable);
            var rds = new ReportDataSource("TiposEventos", myDataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            
        }
    }
}
