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
        private int idItem = 0;
        private string nombre = "";
        private string descripcion = "";
        private int costoAlquiler = 0;
        

        //Setters y Getters
        
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

        //Crea una Instancia de item Default. [Constructor]
        public Items()
        {

        }

        //Crea una Instancia de item en base a datos pasados como parametros. [Constructor]
        public Items(string nombreItem, string descripcionItem, int costoAlquilerItem)
        {
            this.Nombre = nombreItem;
            this.Descripcion = descripcionItem;
            this.costoAlquiler = costoAlquilerItem;
            
        }

        //Crea Instancia de Item en base a un id pasado como parametro. [Constructor]
        public Items(int idItemBuscado)
        {
            this.IdItem = idItemBuscado;
            getAttr();
        }

        //Rellena una Instancia de Item con datos de la DB
        private void getAttr()
        {
            string query = "SELECT nombre, descripcion, costoAlquiler FROM Items WHERE idItem = " + IdItem;
            DataTable tabla = DBHelper.ConsultarSQL(query);
            Nombre = tabla.Rows[0]["nombre"].ToString();
            Descripcion = tabla.Rows[0]["descripcion"].ToString();
            CostoAlquiler = Convert.ToInt32(tabla.Rows[0]["costoAlquiler"].ToString());
        }

        //Retorna todos los items en una DataTable
        public static DataTable GetAll()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Items WHERE activo = 1";
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

        //Retorna todos los items en una DataTable
        public static DataTable GetAllEspecifico()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT idItem AS ID, nombre AS Nombre, descripcion AS Descripcion , costoAlquiler AS CostoAlquiler FROM Items WHERE activo = 1";
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



        //Guarda una Instancia de Item en la DB
        public void Save()
        {
            try
            {
                string query = "INSERT INTO Items(nombre, descripcion, costoAlquiler ,activo) " + "VALUES('" + this.Nombre + "','" + this.Descripcion + "',"+ this.CostoAlquiler +"," + 1 +" )";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show(this.nombre + " cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Actualiza CostoAlquiler de un Item
        public void CambiarCostoAlquiler(int newCostoAlquiler)
        {
            string query = "UPDATE Items SET costoAlquiler = '" + newCostoAlquiler + "' WHERE idItem = " + this.IdItem;
            try
            {
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Costo de Alquiler cambiado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CostoAlquiler = newCostoAlquiler;
            }
            catch
            {
                MessageBox.Show("DB ERROR!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Actualiza Nombre de un Item
        public void CambiarNombre(string newNombre)
        {
            string query = "UPDATE Items SET nombre = '" + newNombre + "' WHERE idItem = " + this.IdItem;
            try
            {
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Nombre de Item cambiado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Nombre = newNombre;
            }
            catch
            {
                MessageBox.Show("DB ERROR!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Actualiza Descripcion de un Item
        public void CambiarDescripcion(string newDescripcion)
        {
            string query = "UPDATE Items SET costoAlquiler = '" + newDescripcion + "' WHERE idItem = " + this.IdItem;
            try
            {
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Costo de Alquiler cambiado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Descripcion = newDescripcion;
            }
            catch
            {
                MessageBox.Show("DB ERROR!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Baja(int id)
        {
            string query = "UPDATE Items SET activo = 0 WHERE idItem = " + id; 
            try
            {
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Item eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error al eliminar Item", "Error"  ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
