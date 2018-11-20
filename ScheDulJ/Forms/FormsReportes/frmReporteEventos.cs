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
            
            string sql = "SELECT Eventos.* FROM Eventos WHERE YEAR(fecha) =" + Convert.ToInt32(txtAño.Text); 
            DataSet ds = DBHelper.generarDataSet(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource("dsEventos", ds.Tables[0]);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
        }

       

    }
}
