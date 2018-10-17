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
            MostrarSeleccionado();
            
        }

        private void MostrarEquipamiento()
        {
            DataTable tabla = new DataTable();
            tabla = Items.GetAll();
            grdEquipamiento.DataSource = tabla;
            grdEquipamiento.Columns[2].Visible = false;
            grdEquipamiento.Columns[3].Visible = false;
            grdEquipamiento.Columns[5].Visible = false;

        }
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //HAY QUE MODIFICAR PARA QUE NO BORRE TODO SIEMPRE Y GUARDE LOS CAMBIOS CONFIRMADOS ANTERIORMENTE!!!!
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DetalleEvento.DeleteAll(Convert.ToInt32(txtIdE.Text.ToString()));
                this.Close();
            }
           
        }

        private void grdEquipamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarEquipamiento(int idEvento , int idItem , int costoAlquiler)
        {
            DetalleEvento detalle = new DetalleEvento(idEvento, idItem, costoAlquiler);
            detalle.Save();
            MostrarSeleccionado();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idItem = Convert.ToInt32(grdEquipamiento.SelectedRows[0].Cells[0].Value.ToString());
            int costoAlquiler = Convert.ToInt32(grdEquipamiento.SelectedRows[0].Cells[4].Value.ToString());
            AgregarEquipamiento(Convert.ToInt32(txtIdE.Text.ToString()), idItem, costoAlquiler);
        }
        private void MostrarSeleccionado()
        {
            DataTable tabla = new DataTable();
            tabla = DetalleEvento.GetSeleccionadoEvento(Convert.ToInt32(txtIdE.Text.ToString()));
            gridSeleccionado.DataSource = tabla;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int idEvento = Convert.ToInt32(txtIdE.Text);
            int idItem = Convert.ToInt32(gridSeleccionado.SelectedRows[0].Cells[1].Value.ToString());
            int costoAlquiler = Convert.ToInt32(gridSeleccionado.SelectedRows[0].Cells[2].Value.ToString());
            DetalleEvento dtEvento = new DetalleEvento(idEvento, idItem, costoAlquiler);
            dtEvento.Eliminar();
            MostrarSeleccionado();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RollBack()
        {


       
        }
    }
}
