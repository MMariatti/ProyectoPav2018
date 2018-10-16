using ScheDulJ.Classes;
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
    public partial class FrmModificarEquipo : Form
    {
        public FrmModificarEquipo()
        {
            InitializeComponent();
            CargarItems();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void BtnModificarDescripcion_Click(object sender, EventArgs e)
        {
            string nuevaDesc = txtDescripcionEquipo.Text;
            Items equipo = new Items((int)cmbItemsModificar.SelectedValue);
            equipo.CambiarDescripcion(nuevaDesc);
        }

        private void BtnCostoAlquiler_Click(object sender, EventArgs e)
        {
            string nuevoCost = txtCostoAlquiler.Text;
            Items equipo = new Items((int)cmbItemsModificar.SelectedValue);
            equipo.CambiarCostoAlquiler(Int32.Parse(nuevoCost));
        }

        private void FrmModificarEquipo_Load(object sender, EventArgs e)
        {

        }

        private void lblNombreEquipo_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        public void CargarItems()
        {
            DataTable tabla = Items.GetAll();
            cmbItemsModificar.DataSource = tabla;
            cmbItemsModificar.ValueMember = "idItem";
            cmbItemsModificar.DisplayMember = "nombre";
        }
        private void cmbItemsModificar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
