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
           
            reportViewer1.LocalReport.DataSources.Clear();

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
