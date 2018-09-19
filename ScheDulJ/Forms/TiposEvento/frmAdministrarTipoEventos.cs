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

namespace ScheDulJ.Forms
{
    public partial class frmAdministrarTipoEventos : Form
    {
        public frmAdministrarTipoEventos()
        {
            InitializeComponent();
        }


        private void gridTipoEventos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Refrescar()
        {
            gridTipoEventos.DataSource = ClassTiposEventos.GetAll();
        }

        private void frmAdministrarTipoEventos_Load(object sender, EventArgs e)
        {
            Refrescar();   
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnNuevoTEvento_Click(object sender, EventArgs e)
        {
            frmAgregarTipoEvento frmAgregarTipoEvento = new frmAgregarTipoEvento();
            frmAgregarTipoEvento.Show(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try { 
            if (gridTipoEventos.SelectedRows[0].Index != gridTipoEventos.Rows.Count - 1)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el tipo de evento?", "Eliminar Tipo de Evento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ClassTiposEventos tipoEvento = new ClassTiposEventos(gridTipoEventos.SelectedRows[0].Cells[1].Value.ToString() , gridTipoEventos.SelectedRows[0].Cells[1].Value.ToString());
                    tipoEvento.Eliminar();
                    tipoEvento = null;
                    
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un tipo de evento para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   catch(Exception)
            {
                MessageBox.Show("Debe seleccionar un tipo de evento para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Refrescar();
        }
    }
}
