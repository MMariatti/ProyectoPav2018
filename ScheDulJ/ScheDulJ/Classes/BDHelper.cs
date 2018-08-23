using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ScheDulJ
{
    class BDHelper
    {
        //CONSTRUCTOR DE LA CLASE 
        public BDHelper()
        {
            cadenaConexion = "";
            conexion = new SqlConnection();
            comando = null; 
        }
        //CONSTRUCTOR ALTERNATIVO
        public BDHelper(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
            conexion = new SqlConnection();
            comando = new SqlCommand(); 
        }
        //ATRIBUTOS DE LA CLASE
        private string cadenaConexion;
        private SqlConnection conexion;
        private SqlCommand comando; 
        //PROPIEDAD QUE IMPLEMENTA SET Y GET DE CADA ATRIBUTO
        public SqlConnection Conexion { get => conexion; set => conexion = value; }
        public SqlCommand Comando { get => comando; set => comando = value; }
        public string CadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        //METODO CONECTAR
        public void Conectar()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = this.CadenaConexion;
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text; 
        }
       //METODO DESCONECTAR 
        private void Desconectar()
        {
            conexion.Close();
        }
        //METODO CONSULTA GENERAL
        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla; 
        }
        //METODO CONSULTA GENERAL
        public DataTable ConsultarSQL(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }


    }
}
