﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; 

namespace ScheDulJ.Classes
{
    public class DataManager
    {
        private SqlConnection dbConnection;
        private SqlTransaction dbTransaction;

        //private string string_conexion = @"Data Source=FRANNOTEBOOK\TESTSERVER;Initial Catalog=ScheDulJ2;Integrated Security=True";
        private static string string_conexion = @"Data Source=MARKY\PAV1;Initial Catalog=ScheDulJ2; Integrated Security=True";

        public DataManager()
        {
            dbConnection = new SqlConnection();
            dbConnection.ConnectionString = string_conexion;
        }

        public void BeginTransaction()
        {
            if (dbConnection.State == ConnectionState.Open)
                dbTransaction = dbConnection.BeginTransaction();
        }

        public void Commit()
        {
            if (dbTransaction != null)
                dbTransaction.Commit();
        }

        public void Rollback()
        {
            if (dbTransaction != null)
                dbTransaction.Rollback();
        }
        public void Open()
        {
            if (dbConnection.State != ConnectionState.Open)
                dbConnection.Open();
        }

        public void Close()
        {
            if (dbConnection.State != ConnectionState.Closed)
                dbConnection.Close();
        }


        public DataTable ConsultaSQL(string strSql)
        {


            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                //  El datatable se carga con el resultado de ejecutar la sentencia en el motor de base de datos

                tabla.Load(cmd.ExecuteReader());
                //  La función retorna el objeto datatable con 0, 1 o mas registros
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ConsultaSQLConParametros(string strSql, List<object> sqlParam)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;

                var indice = 0;
                foreach (var param in sqlParam)
                {
                    if (param != null)
                    {
                        var n_param = "param" + Convert.ToString(indice + 1);
                        cmd.Parameters.AddWithValue(n_param, param);
                    }
                    indice++;
                }

                tabla.Load(cmd.ExecuteReader());

                //  La función retorna el objeto datatable con 0, 1 o mas registros
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int EjecutarSQL(string strSql, List<SqlParameter> parametros = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”

            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                cmd.Connection = dbConnection;
                cmd.Transaction = dbTransaction;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                if (parametros != null)
                    cmd.Parameters.AddRange(parametros.ToArray());

                // Retorna el resultado de ejecutar el comando
                rtdo = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
                // oBug.id_bug = dm.EjecutarSQL(sql_con_parametros, parametros);


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }

    }
}
