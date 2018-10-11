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
    public partial class frmUserAdmin : Form
    {
        public frmUserAdmin()
        {
            InitializeComponent();
        }

        private void frmUserAdmin_Load(object sender, EventArgs e)
        {
            mostrarListaUsuarios();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mostrarListaUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = Classes.Usuarios.GetAll(); 
            gridUsuarios.DataSource = tabla; 
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario frmAgregarUsuario;
            frmAgregarUsuario = new frmAgregarUsuario();
            frmAgregarUsuario.Show(); 
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario(); 
        }
        private void EliminarUsuario()
        {

            try
            {
                if (gridUsuarios.SelectedRows[0].Index != gridUsuarios.Rows.Count - 1)
                {
                    if (MessageBox.Show("Esta seguro que desea eliminar el usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Classes.Usuarios usuario = new Classes.Usuarios(gridUsuarios.SelectedRows[0].Cells[1].Value.ToString(), gridUsuarios.SelectedRows[0].Cells[1].Value.ToString());
                        int id = System.Convert.ToInt32(gridUsuarios.SelectedRows[0].Cells[0].Value.ToString()); 
                        usuario.Baja(id); 
                        usuario = null;
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            mostrarListaUsuarios();
        }

        private void btnModificarPassword_Click(object sender, EventArgs e)
        {
            


        }
    }   
}
