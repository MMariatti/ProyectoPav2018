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
using System.Data.SqlClient; 


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
            CrearTabla();
            CargarSeleccionados();
            CargarEquipamiento(); 
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
            if (CorroborarAgregado(idItem) == 0)
            {
                Items item = new Items(idItem);
                tablaMain.Rows.Add(item.IdItem, item.Nombre, item.CostoAlquiler);
            }
        }

        private void CargarSeleccionados()
        {
            DataTable tabla = new DataTable();
            tabla = DetalleEvento.GetSeleccionadoEvento(Convert.ToInt32(txtIdE.Text.ToString()));
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                int idItem = Convert.ToInt32(tabla.Rows[i][1].ToString());
                Items item = new Items(idItem);
                tablaMain.Rows.Add(item.IdItem, item.Nombre, item.CostoAlquiler);
            }



        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Quitar();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarEquipo();

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

        private void ConfirmarEquipo()
        {
            DataManager dm = new DataManager();
            string queryI = "DELETE FROM DetalleEventos WHERE idEvento =" + Convert.ToInt32(txtIdE.Text.ToString());
            DBHelper.ConsultarSQLVoid(queryI); 
            dm.Open();
            dm.BeginTransaction();
            try
            {
                for (int i = 0; i < gridSeleccionado.Rows.Count - 1; i++)
                {
                    try
                    {
                        string query = "INSERT INTO DetalleEventos(idEvento, idItem, costoAlquiler)" + "VALUES(" + Convert.ToInt32((txtIdE.Text.ToString())) + "," + Convert.ToInt32(gridSeleccionado.Rows[i].Cells[0].Value.ToString()) + "," + Convert.ToInt32(gridSeleccionado.Rows[i].Cells[2].Value.ToString()) + ");";
                        List<SqlParameter> parametrosvacio = new List<SqlParameter>();
                        dm.EjecutarSQL(query, parametrosvacio);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                dm.Commit();
                MessageBox.Show("Equipo Cargado Satisfactoriamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                dm.Rollback();
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dm.Close();
            }
        }

        private int CorroborarAgregado(int idItem)
        {
            int resultado = 0;
            for (int i = 0; i < gridSeleccionado.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(gridSeleccionado.Rows[i].Cells[0].Value.ToString()) == idItem)
                {
                    MessageBox.Show("El equipo ya se encuentra agregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultado = 1;
                    return resultado; 
                }
            }
            return resultado; 

        }
    }
}
