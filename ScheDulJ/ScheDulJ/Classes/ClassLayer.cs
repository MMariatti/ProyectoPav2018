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
        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;
        private int activo;

        public Clientes(string nombreCliente, string apellidoCliente, string direccionCliente, int telefonoCliente, int activoCliente)
        {
            nombre = nombreCliente;
            apellido = apellidoCliente;
            direccion = direccionCliente;
            telefono = telefonoCliente;
            activo = activoCliente;
        }

        private void Save() {
            try
            { 
                string query = "INSERT INTO Clientes(nombre, apellido, direccion, telefono, activo) "+"VALUES('" + this.nombre + "','" + this.apellido+ "'," + this.telefono + "," + this.activo + ")";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show(this.nombre+" cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static DataTable GetAll(){
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Clientes C WHERE C.activo = 1";
            tabla = DBHelper.ConsultarSQL(query);
            return tabla;
        }

        public Clientes GetClientes(string nombreCliente, string apellidoCliente, int telefonoCliente, int activoCliente)
        {
            string query = "SELECT * FROM Clientes WHERE nombre = '" + nombreCliente + "' AND apellido = '" + apellidoCliente + "' AND telefono = " + telefonoCliente + " AND activo = " + activoCliente;
            DataTable tabla = DBHelper.ConsultarSQL(query);
            DataRowCollection filas = tabla.Rows;
            DataRow fila = filas[0];
            Clientes cliente = new Clientes(fila.Field<string>("nombre"), fila.Field<string>("apellido"), fila.Field<string>("direccion"), fila.Field<int>("telefono"), fila.Field<int>("activo"));
            return cliente;
        }
    }
}
