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
        private int idTipoItems = 0;
        private string nombre = "";
        private string descripcion = "";

        public int IdTipoItems
        {
            get { return this.idTipoItems; }
            private set
            {
                this.idTipoItems = value;
            } 
        }

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

        public TipoItems()
        {

        }

        public TipoItems(string nombreTipoItem, string descripcionTipoItem)
        {
            this.Nombre = nombreTipoItem;
            this.Descripcion = descripcionTipoItem;
        }

        public TipoItems(int idTipoItem)
        {
            this.IdTipoItems = idTipoItem;
            getAttr();
        }

        private void getAttr()
        {
            string query = "SELECT nombre, descripcion FROM TiposItems WHERE idTipoItem = " + IdTipoItems;
            DataTable tabla = DBHelper.ConsultarSQL(query);
            nombre = tabla.Rows[0]["nombre"].ToString();
            descripcion = tabla.Rows[0]["descripcion"].ToString();
        }

        public void Save()
        {
            try
            {
                string query = "INSERT INTO TiposItems(nombre, descripcion) values('" + this.Nombre + "', '" + this.Descripcion + "')";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Tipo de Item: " + this.Nombre + " cargado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
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

        public void CambiarNombre(string nombreNuevo)
        {
            string query = "UPDATE TiposItems SET nombre = '" + nombreNuevo + "' WHERE idTipoItem = '" + this.IdTipoItems + "'";
            try
            {
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Tipo de Item: " + this.Nombre + " cambiado a " + nombreNuevo + ".", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarDescripcion(string descripcionNueva)
        {
            string query = "UPDATE TiposItems SET descripcion = '" + descripcionNueva + "' WHERE idTipoItem = '" + this.IdTipoItems + "'";
            try
            {
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Descripcion: " + this.Descripcion + " cambiado a " + descripcionNueva + ".", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
