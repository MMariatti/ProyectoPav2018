using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ScheDulJ.Classes
{
    public class TipoItems
    {
        private string nombre;
        private string descripcion;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.descripcion = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        public TipoItems(string nombreTipoItem, string descripcionTipoItem)
        {
            this.Nombre = nombreTipoItem;
            this.Descripcion = descripcionTipoItem;
        }

        public void Save()
        {
            try
            {
                string query = "INSERT INTO TiposItems(nombre, descripcion) values('" + this.Nombre + "', '" + this.Descripcion + "')";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Tipo de Item: " + this.Nombre + " cargado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable GetAll()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM TiposItems";
            try
            {
                tabla = DBHelper.ConsultarSQL(query);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tabla;
            }
        }
    }
}
