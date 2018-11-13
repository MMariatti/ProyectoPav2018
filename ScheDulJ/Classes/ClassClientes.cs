using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheDulJ
{
    public class Clientes
    {
        private int idCliente = 0;
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }

            private set
            {
                this.idCliente = value;
            }
        }
        //Forzamos que los parametros sean privados para que una vez creados solo puedan ser modificados por la misma clase
        private string nombre = "";
        //Creamos Properties que definen los get y set de cada atributo, manteniendo el set privado para que todo el comportamiento quede dentro de la clase
        //y no exista posibilidad de manipulacion maliciosa de datos.
        public string Nombre
        {
            get { return this.nombre; }
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
        private string apellido = "";
        public string Apellido
        {
            get { return this.apellido; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.apellido = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        private string direccion = "";
        public string Direccion
        {
            get { return this.direccion; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.direccion = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        private int telefono = 0;
        public int Telefono
        {
            get { return this.telefono; }
            private set
            {
                if (value >= 1000000)
                {
                    this.telefono = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private int activo = 1;
        public int Activo
        {
            get { return this.activo; }
            private set
            {
                if (value == 1 || value == 0)
                {
                    this.activo = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Clientes()
        {

        }

        public Clientes(string nombreCliente, string apellidoCliente, string direccionCliente, int telefonoCliente, int activoCliente)
        {
            this.Nombre = nombreCliente;
            this.Apellido = apellidoCliente;
            this.Direccion = direccionCliente;
            this.Telefono = telefonoCliente;
            this.Activo = activoCliente;
        }

        public Clientes(int idCliente)
        {
            this.IdCliente = idCliente;
            getAttr();
        }

        private void getAttr()
        {
            string query = "SELECT * FROM Clientes WHERE idCliente = " + IdCliente;
            DataTable tabla = DBHelper.ConsultarSQL(query);
            Nombre = tabla.Rows[0]["nombre"].ToString();
            Apellido = tabla.Rows[0]["apellido"].ToString();
            Direccion = tabla.Rows[0]["direccion"].ToString();
            Telefono = (int)tabla.Rows[0]["telefono"];
            Activo  = 1;
        }

        public void Save()
        {
            try
            {
                string query = "INSERT INTO Clientes(nombre, apellido, direccion, telefono, activo) " + "VALUES('" + this.Nombre + "','" + this.Apellido + "', '" + this.Direccion + "', " + this.Telefono + "," + this.Activo + ")";
                DBHelper.ConsultarSQL(query);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable GetAll()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Clientes C WHERE C.activo = 1";
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

        public static DataTable GetAllEspecifico()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT idCliente AS ID,nombre AS Nombre, apellido AS Apellido FROM Clientes C WHERE C.activo = 1";
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


        public Clientes GetCliente(int idC)
        {
            string query = "SELECT * FROM Clientes WHERE idCliente = " + idC + " AND activo = 1 ";
            DataTable tabla = DBHelper.ConsultarSQL(query);
            DataRowCollection filas = tabla.Rows;
            DataRow fila = filas[0];
            Clientes cliente = new Clientes(fila.Field<string>("nombre"), fila.Field<string>("apellido"), fila.Field<string>("direccion"), fila.Field<int>("telefono"), fila.Field<int>("activo"));
            return cliente;
        }

        public void Baja()
        {
            if (this.Activo == 1)
            {
                this.Activo = 0;
                string query = "UPDATE Clientes SET activo = 0 WHERE nombre = '" + this.Nombre + "' AND telefono = " + this.Telefono + "";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Cliente dado de baja con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
           
            
               
        }

        public void CambiarNombre(string newNombre)
        {
            try
            {
                string query = "UPDATE Clientes SET nombre = '" + newNombre + "' WHERE nombre = '" + this.Nombre + "' AND telefono = " + this.Telefono + "";
                DBHelper.ConsultarSQL(query);
                this.Nombre = newNombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error al cambiar nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarApellido(string newApellido)
        {
            try
            {
                string query = "UPDATE Clientes SET apellido = '" + newApellido + "' WHERE nombre = '" + this.Nombre + "' AND apellido = '" + this.Apellido + "' AND telefono = " + this.Telefono + "";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Apellido cambiado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Apellido = newApellido;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarTelefono(int newTelefono)
        {
            try
            {
                string query = "UPDATE Clientes SET telefono = " + newTelefono + " WHERE nombre = '" + this.Nombre + "' AND apellido = '" + this.Apellido + "' AND telefono = " + this.Telefono + "";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Telefono cambiado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CambiarDireccion(string newDireccion)
        {
            try
            {
                string query = "UPDATE Clientes SET telefono = " + newDireccion + " WHERE nombre = '" + this.Nombre + "' AND apellido = '" + this.Apellido + "' AND telefono = " + this.Telefono + "";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Direccion cambiado con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}





