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
    public partial class FrmAgregarEquipo : Form
    {
        public FrmAgregarEquipo()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool CorroborarDatos()
        {
            if (txtNombreEquipo.Text == string.Empty || txtDescripcionEquipo.Text == string.Empty || txtCostoAlquiler.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Nombre,Descripcion y Costo del Alquiler", "Error al Cargar Equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AgregarEquipo(int id, string nombre, string descripcion, string costoAlquiler)
        {
            int costoAlquilerN = System.Convert.ToInt32(costoAlquiler);
            try
            {
                Items item = new Items(0,nombre, descripcion, costoAlquilerN);
                item.Save(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void LimpiarEquipo() {
            txtNombreEquipo.Clear();
            txtDescripcionEquipo.Clear();
            txtCostoAlquiler.Clear();
            txtNombreEquipo.Focus();
        }


        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if(CorroborarDatos() == true)
            {
                if (MessageBox.Show("¿Esta seguro que quiere agregar este equipo?","Agregar equipo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                   // AgregarEquipo(txtNombreEquipo.Text, txtDescripcionEquipo.Text, txtCostoAlquiler.Text);
                    this.Close();
                }
            }
            else
            {
                LimpiarEquipo(); 
            }
        }

        private void FrmAgregarEquipo_Load(object sender, EventArgs e)
        {

        }
    }

}
