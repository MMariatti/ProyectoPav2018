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
    public partial class FrmEventosXMes : Form
    {
        public FrmEventosXMes()
        {
            InitializeComponent();
        }

        private void FrmEventosXMes_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (txtAño.Text != "")
            {
                var myDataTable = new DataSetScheDulJ.EventosXMesDataTable();
                var myTableAdapter = new EventosXMesTableAdapter();
                myTableAdapter.Fill(myDataTable, Convert.ToInt32(txtAño.Text));
                var rds = new ReportDataSource("EventosXMes", myDataTable as DataTable);

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
