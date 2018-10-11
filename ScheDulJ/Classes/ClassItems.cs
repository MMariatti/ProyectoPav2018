using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ScheDulJ.Classes
{
    class Items
    {
        private string nombre;
        private string descripcion;
        private int costoAlquiler;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
                else
                {
                    MessageBox.Show("Tenes que ingresar algo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.descripcion = value;
                }
                else
                {
                    MessageBox.Show("Tenes que ingresar algo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int CostoAlquiler
        {
            get
            {
                return this.costoAlquiler;
            }
            set
            {
                if (value>=0)
                {
                    this.costoAlquiler = value;
                }
                else
                {
                    MessageBox.Show("Tenes que ingresar algo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Items(string nombreItem, string descripcionItem, int costoAlquilerItem)
        {
            this.Nombre = nombreItem;
            this.Descripcion = descripcionItem;
            this.costoAlquiler = costoAlquilerItem;

        }

        public static DataTable GetAll()
        {
            DataTable tabla = new DataTable();
            try
            {
                tabla = DBHelper.ConsultarSQL("SELECT idItem, nombre, descripcion, costoAlquiler FROM Items WHERE activo=1");
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tabla;
            }
        }
        public static void Baja(int id)
        {
            try
            {
                string query = "UPDATE Items SET activo = 0 WHERE idItem = " + id;
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Equipamiento dado de baja con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de baja equipamiento" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void Save()
        {
            try
            {
                string query = "INSERT INTO Items(nombre, descripcion, costoAlquiler, activo) " + "VALUES('" + nombre + "','" + descripcion + "'," + costoAlquiler +"," +1+ ")";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show(nombre + " cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

    }
}
