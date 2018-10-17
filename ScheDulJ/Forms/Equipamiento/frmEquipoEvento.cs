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

        private DataTable tablaMain = new DataTable();

        public frmEquipoEvento()
        {
            InitializeComponent();
        }

        private void frmEquipoEvento_Load(object sender, EventArgs e)
        {
            CargarEquipamiento();
            CrearTabla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir? Los cambios no confirmados seran borrados", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void grdEquipamiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            AgregarEquipo();
        }
       
        private void AgregarEquipo()
        {
            int idItem = Convert.ToInt32(cmbEquipamientoEvento.SelectedValue.ToString());
            Items item = new Items(idItem);
            tablaMain.Rows.Add(item.IdItem, item.Nombre, item.CostoAlquiler);

        }


        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Quitar();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {



            this.Close();
        }


        private void gridSeleccionado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarEquipamiento()
        {
            cmbEquipamientoEvento.DataSource = Items.GetAll();
            cmbEquipamientoEvento.DisplayMember = "nombre";
            cmbEquipamientoEvento.ValueMember = "idItem";
        }

        private void CrearTabla()
        {
            tablaMain.Columns.Add("ID", typeof(int));
            tablaMain.Columns.Add("Nombre", typeof(string));
            tablaMain.Columns.Add("Costo Alquiler", typeof(int));
            gridSeleccionado.DataSource = tablaMain;
        } 

        private void Quitar()
        {
            gridSeleccionado.Rows.RemoveAt(gridSeleccionado.CurrentRow.Index);

        }


    }
}
