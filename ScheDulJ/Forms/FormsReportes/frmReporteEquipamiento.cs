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
    public partial class frmReporteEquipamiento : Form
    {
        public frmReporteEquipamiento()
        {
            InitializeComponent();
        }

        private void frmReporteEquipamiento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetScheDulJ.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.dataSetScheDulJ.Items);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
