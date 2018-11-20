using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ScheDulJ.DataSetScheDulJTableAdapters;

namespace ScheDulJ.Forms
{
    public partial class frmREquipamientoMSolicitado : Form
    {
        public frmREquipamientoMSolicitado()
        {
            InitializeComponent();
        }

        private void frmREquipamientoMSolicitado_Load(object sender, EventArgs e)
        {
            var myDataTable = new DataSetScheDulJ.EquipamientoMasUtilizadoDataTable();
            var myTableAdapter = new EquipamientoMasUtilizadoTableAdapter();
            myTableAdapter.Fill(myDataTable);
            var rds = new ReportDataSource("EquipamientoMasSolicitado", myDataTable as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
