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
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Corroborar que el nombre del equipo que ingresa no sea vacio
        private bool CorroborarNombreEquipo()
        {
            if (txtNombreEquipo.Text == string.Empty)
            {
                MessageBox.Show("No ha ingresado el nombre del equipo", "Error al cargar el equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreEquipo.Focus();
                
                return false;

            }
            else
            {
                return true;
            }
        }

        //metodo para asegurarse que el usuario no trate de ingresar valores null
        private bool CorroborarDescripcion()
        {
            if(txtDescripcionEquipo.Text==string.Empty)
            {
                MessageBox.Show("No ha ingresado la descricpion del equipo", "Error al modificar equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionEquipo.Focus();
                
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CorroborarCostoAlquiler()
        {
            if (txtCostoAlquiler.Text == string.Empty)
            {
                MessageBox.Show("No ha ingresado el costo de alquiler del equipo", "Error al modificar equipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionEquipo.Focus();

                return false;
            }
            else
            {
                return true;
            }
        }
        private void ModificarDescripcion(string nombre, string descripcion)
        {
            string consulta;
            consulta = "UPDATE Items SET descripcion = '"+descripcion+"' WHERE nombre= '"+nombre+"'";
            DBHelper.ConsultarSQLVoid(consulta);

        }
        private void ModificarCostoAlquiler(string nombre, string costoAlquiler)
        {
            string consulta;
            consulta = "UPDATE Items SET costoAlquiler = '" + costoAlquiler + "' WHERE nombre= '" + nombre + "'";
            DBHelper.ConsultarSQLVoid(consulta);

        }
        //Metodo para buscar el equipo al que le queremos hacer las modificacions
        private bool BuscarEquipo(string nombre)
        {
            DataTable tabla = new DataTable();
            string consultaSql = "SELECT nombre FROM Items Where nombre = '" + nombre + "' AND activo =1";
            tabla = DBHelper.ConsultarSQL(consultaSql);
            if (tabla.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }



        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (CorroborarNombreEquipo()==true)
            {
                if (BuscarEquipo(txtNombreEquipo.Text)==true)
                {
                    txtDescripcionEquipo.Enabled = true;
                    txtCostoAlquiler.Enabled = true;
                    BtnModificarDescripcion.Enabled = true;
                    BtnCostoAlquiler.Enabled = true;
                    txtDescripcionEquipo.Focus();
                }
                else
                {
                    MessageBox.Show("El equipo que busca no existe","Buscar equipo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtNombreEquipo.Focus();
                    txtNombreEquipo.Clear();
                }
            }
        }

        private void BtnModificarDescripcion_Click(object sender, EventArgs e)
        {
            if (CorroborarDescripcion()==true)
            {
                if(MessageBox.Show("¿Esta seguro que quiere cambiar la descripcion del equipo?","Modificar Descripcion",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    ModificarDescripcion(txtNombreEquipo.Text, txtDescripcionEquipo.Text);
                    MessageBox.Show("Descripcion cambiada correctamente", "Modificar descripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcionEquipo.Clear();
                    txtCostoAlquiler.Focus();
                }
            }
            else
            {
                txtDescripcionEquipo.Focus();
            }
        }

        private void BtnCostoAlquiler_Click(object sender, EventArgs e)
        {
            if(CorroborarCostoAlquiler()==true)
            {
                if(MessageBox.Show("¿Esta seguro que quiere cambiar el costo de alquiler del equipo?", "Modificar costo de alquiler", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ModificarCostoAlquiler(txtNombreEquipo.Text, txtCostoAlquiler.Text);
                    MessageBox.Show("Costo de alquiler cambiado correctamente", "Modificar costo de alquiler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCostoAlquiler.Clear();
                    txtNombreEquipo.Focus();
                    txtNombreEquipo.Clear();
                    
                }
            }
            else
            {
                txtCostoAlquiler.Focus();
            }
        }

        private void FrmModificarEquipo_Load(object sender, EventArgs e)
        {

        }
    }
}
