using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ScheDulJ
{
    public class DBHelper
    {
        //CONSTRUCTOR DE LA CLASE 

        private static string cadenaConexion = @"Data Source=MARKY\PAV1;Initial Catalog=dbNormalizada;Integrated Security=True";
        //private static string cadenaConexion = @"Data Source=NICOB\NICODB;Initial Catalog = ScheDulJ; Integrated Security = True";
        private static SqlConnection conexion;
        private static SqlCommand comando; 
        //PROPIEDAD QUE IMPLEMENTA SET Y GET DE CADA ATRIBUTO
        public SqlConnection Conexion { get => conexion; set => conexion = value; }
        public SqlCommand Comando { get => comando; set => comando = value; }
         
        //METODO CONECTAR
        public static void Conectar()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text; 
        }
       //METODO DESCONECTAR 
        public static void Desconectar()
        {
            conexion.Close();
        }
        //METODO CONSULTA GENERAL
        public static DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla; 
        }
        //METODO CONSULTA ESPECIFICA
        public static DataTable ConsultarSQL(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
        //METODO CARGAR VOID (AGREGAR DATOS A BD) 
        public static void ConsultarSQLVoid(string consultaSQL)
        {
            Conectar();
            comando.CommandText = consultaSQL;
            comando.ExecuteReader();
            Desconectar();
        }


    }
}
