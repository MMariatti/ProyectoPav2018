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
        private int idItem;
        private string nombre;
        private string descripcion;
        private int costoAlquiler;

        public int IdItem
        {
            get { return this.idItem; }
            private set
            {
                this.idItem = value;
            }
        }

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

        public Items(int idItem, string nombreItem, string descripcionItem, int costoAlquilerItem)
        {
            this.IdItem = 0;
            this.Nombre = nombreItem;
            this.Descripcion = descripcionItem;
            this.costoAlquiler = costoAlquilerItem;
        }

        public Items GetItemXId(int idItemBuscado)
        {
            string query = "SELECT * FROM Items WHERE idItem = '" + idItemBuscado + "'";
            DataTable tabla = DBHelper.ConsultarSQL(query);
            DataRowCollection filas = tabla.Rows;
            DataRow fila = filas[0];
            Items item = new Items(fila.Field<int>("idItem"), fila.Field<string>("nombre"), fila.Field<string>("descripcion"), fila.Field<int>("costoAlquiler"));
            return item;
        }

        public static DataTable GetDataAllItems()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Items";
            try
            {
                tabla = DBHelper.ConsultarSQL(query);
                return tabla;
            }
            catch
            {
                MessageBox.Show("Error en la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tabla;
            }
        }

        public void Save()
        {
            try
            {
                string query = "INSERT INTO Items(nombre, apellido, direccion, telefono, activo) " + "VALUES('" + this.Nombre + "','" + this.Descripcion + "', '" + this.CostoAlquiler+ "')";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show(this.nombre + " cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarCostoAlquiler(int newCostoAlquiler)
        {
            string query = "UPDATE Items SET costoAlquiler = '" + newCostoAlquiler + "' WHERE nombre = '" + this.Nombre + "'";
            try
            {
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Costo de Alquiler cambiado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CostoAlquiler = newCostoAlquiler;
            }
            catch
            {
                MessageBox.Show("DB ERROR!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarNombre(string newNombre)
        {
            string query = "UPDATE Items SET nombre = '" + newNombre + "' WHERE nombre = '" + this.Nombre + "'";
            try
            {
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Nombre de Item cambiado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Nombre = newNombre;
            }
            catch
            {
                MessageBox.Show("DB ERROR!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarDescripcion(string newDescripcion)
        {
            string query = "UPDATE Items SET costoAlquiler = '" + newDescripcion + "' WHERE nombre = '" + this.Nombre + "'";
            try
            {
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Costo de Alquiler cambiado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Descripcion = newDescripcion;
            }
            catch
            {
                MessageBox.Show("DB ERROR!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
