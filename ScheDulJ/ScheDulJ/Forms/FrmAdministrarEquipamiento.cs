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
            tabla = DBHelper.ConsultarSQL("SELECT nombre, descripcion, costoAlquiler FROM Items WHERE activo=1");
            GridEquipamiento.DataSource = tabla;
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
            FrmAgregarEquipo frmAgregarEquipo;
            frmAgregarEquipo = new FrmAgregarEquipo();
            frmAgregarEquipo.Show();
        }

        private void BtnModficarEquipo_Click(object sender, EventArgs e)
        {
            FrmModificarEquipo frmModificarEquipo;
            frmModificarEquipo = new FrmModificarEquipo();
            frmModificarEquipo.Show();
        }

        private void BtnEliminarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridEquipamiento.SelectedRows[0].Index != GridEquipamiento.Rows.Count - 1)
                {
                    if (MessageBox.Show("Esta seguro que desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string consultaSQL = "UPDATE Items SET activo = 0 WHERE nombre ='" + GridEquipamiento.SelectedRows[0].Cells[0].Value.ToString() + "'";
                        DBHelper.ConsultarSQL(consultaSQL);
                        MessageBox.Show("Equipo Eliminado Correctamente", "Equipo Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Equipo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un Equipo para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
