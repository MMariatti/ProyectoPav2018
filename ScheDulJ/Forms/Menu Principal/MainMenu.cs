using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheDulJ.Forms;
using ScheDulJ.Forms.Eventos;
using ScheDulJ.Classes;
using ScheDulJ.Forms.Equipamiento;

namespace ScheDulJ
{
    //El form MainMenu va a ser el principal de todo el programa. Este se iniciara cuando se loguee y 
    //se mantendra abierto hasta que se termine de utilizar el programa. 
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            MostrarEventos(); 
            
        }
        private void btnExitMainMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la aplicacion?", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdministrarUsuarios_Click(object sender, EventArgs e)
        {
            frmUserAdmin frmUserAdmin = new frmUserAdmin();
            frmUserAdmin.Show(); 
        }

        private void administrarClientes_Click(object sender, EventArgs e)
        {
            frmAdministrarClientes frmAdministrarClientes = new frmAdministrarClientes();
            frmAdministrarClientes.Show(); 
        }

        private void btnAdministrarEquipamiento_Click(object sender, EventArgs e)
        {
            FrmAdministrarEquipamiento equipamiento;
            equipamiento = new FrmAdministrarEquipamiento();
            equipamiento.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoEvento_Click(object sender, EventArgs e)
        {
            frmAgregarEvento frmAgregarEvento = new frmAgregarEvento();
            frmAgregarEvento.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAdministrarTipoEventos frmAdministrarTipoEventos = new frmAdministrarTipoEventos();
            frmAdministrarTipoEventos.Show(); 
        }

        private void btnTipoItems_Click(object sender, EventArgs e)
        {

        }

        public void MostrarEventos()
        {
            DataTable tabla = new DataTable();
            tabla = Evento.GetAll();
            gridEventos.DataSource = tabla; 

        }

        private void btnRefrescarE_Click(object sender, EventArgs e)
        {
            MostrarEventos();
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            frmEquipoEvento frmEquipoEvento = new frmEquipoEvento();
            frmEquipoEvento.txtNombreEvento.Text = gridEventos.SelectedRows[0].Cells[1].Value.ToString();
            frmEquipoEvento.txtIdE.Text = gridEventos.SelectedRows[0].Cells[0].Value.ToString();
            frmEquipoEvento.Show(); 
        }
    }
}

