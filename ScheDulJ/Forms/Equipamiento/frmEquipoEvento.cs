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
namespace ScheDulJ.Forms.Equipamiento
{
    public partial class frmEquipoEvento : Form
    {
        
        public frmEquipoEvento()
        {
            InitializeComponent();
        }

        private void frmEquipoEvento_Load(object sender, EventArgs e)
        {
            MostrarEquipamiento();
            
        }

        private void MostrarEquipamiento()
        {
            DataTable tabla = new DataTable();
            tabla = Items.GetAll();
            grdEquipamiento.DataSource = tabla;
            grdEquipamiento.Columns[0].Visible = false;
            grdEquipamiento.Columns[2].Visible = false;
            grdEquipamiento.Columns[3].Visible = false;
            grdEquipamiento.Columns[5].Visible = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdEquipamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
