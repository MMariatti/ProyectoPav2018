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
    public partial class FrmAdministrarEquipamiento : Form
    {
        public FrmAdministrarEquipamiento()
        {
            InitializeComponent();
        }

        private void mostrarEquipamiento()
        {
            DataTable tabla = new DataTable();
            tabla = DBHelper.ConsultarSQL("SELECT nombre, descripcion, costoAlquiler FROM Items");
            GridItems.DataSource = tabla;
        }
       
        private void FrmAdministrarEquipamiento_Load(object sender, EventArgs e)
        {
            mostrarEquipamiento();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            mostrarEquipamiento();
        }

        private void BtnAgregarEquipo_Click(object sender, EventArgs e)
        {

        }

        private void BtnModficarEquipo_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminarEquipo_Click(object sender, EventArgs e)
        {

        }
    }
}
