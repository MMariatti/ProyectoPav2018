using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ScheDulJ
{
    public class BDHelper
    {
        //CONSTRUCTOR DE LA CLASE 
        private static BDHelper instance; 

        public static BDHelper getBDHelper()
        {
            if (instance != null)
                instance = new BDHelper();
            return instance; 
        }
       
        private string cadenaConexion = @"Data Source=FRANNOTEBOOK\TESTSERVER;Initial Catalog=ScheDulJ;Integrated Security=True";
        private SqlConnection conexion;
        private SqlCommand comando; 
        //PROPIEDAD QUE IMPLEMENTA SET Y GET DE CADA ATRIBUTO
        public SqlConnection Conexion { get => conexion; set => conexion = value; }
        public SqlCommand Comando { get => comando; set => comando = value; }
         
        //METODO CONECTAR
        private void Conectar()
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = this.cadenaConexion;
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
        //METODO CONSULTA ESPECIFICA
        public DataTable ConsultarSQL(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            Conectar();
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());
            Desconectar();
            return tabla;
        }
        //METODO CARGAR VOID (AGREGAR DATOS A BD) 
        public void ConsultarSQLVoid(string consultaSQL)
        {
            Conectar();
            comando.CommandText = consultaSQL;
            comando.ExecuteReader();
            Desconectar();
        }


    }
}
