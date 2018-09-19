﻿using System;
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
        //Forzamos que los parametros sean privados para que una vez creados solo puedan ser modificados por la misma clase
        private string nombre;
        //Creamos Properties que definen los get y set de cada atributo, manteniendo el set privado para que todo el comportamiento quede dentro de la clase
        //y no exista posibilidad de manipulacion maliciosa de datos.
        public string Nombre
        {
            get { return this.nombre; }
            private set{
                if (!string.IsNullOrWhiteSpace(value)) {
                    this.nombre = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        private string apellido;
        public string Apellido
        {
            get { return this.apellido; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.apellido = value;
                }
            }
        }
        private string direccion;
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
        private int telefono;
        public int Telefono
        {
            get { return this.telefono; }
            private set
            {
                if (value >= 1000000000)
                {
                    this.telefono = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private int activo;
        public int Activo
        {
            get { return this.activo; }
            private set
            {
                if (value == 1 || value == 0 )
                {
                    this.activo = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Clientes(string nombreCliente, string apellidoCliente, string direccionCliente, int telefonoCliente, int activoCliente)
        {
            this.Nombre = nombreCliente;
            this.Apellido = apellidoCliente;
            this.Direccion = direccionCliente;
            this.Telefono = telefonoCliente;
            this.Activo = activoCliente;
        }

        public void Save()
        {
            try
            {
                string query = "INSERT INTO Clientes(nombre, apellido, direccion, telefono, activo) " + "VALUES('" + this.nombre + "','" + this.apellido + "', '" + this.direccion + "', " + this.telefono + "," + this.activo + ")";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show(this.nombre + " cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
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

