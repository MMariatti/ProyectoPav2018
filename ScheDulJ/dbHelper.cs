using System.Data.SqlClient;

public class DbHelper
{
    public DbHelper()
	{
    }

    //Unica Instancia de la clase
    private static DbHelper instance; 
    //Variable String de Conexion
    private string string_conexion; 
    //Metodo para crear String de Conexion a DB
    private void New()
    {
        string_conexion = "Password=$$$;Persist Security Info=True;User ID=$$$;Initial Catalog=ScheDulJ_DB;Data Source=$$$";
    }

    public static DbHelper getDBHelper()
    {
        if (isNothing(instance)) {
            instance = new DbHelper();
            return instance; 
        }
    }
    public static int EjecutarSQL(string strSQL)
    {
        conexion SqlConnection();
        cmd SqlCommand(); 
        try
        {
            //Establece Conexion a Usar
            conexion.ConnectionString = string_conexion;
            //Abre conexion
            conexion.open();

            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            //Retorna el resultado de ejecutar el comando
            return cmd.ExecuteNonQuery();
         }
        catch(Exception ex)
        {
            throw ex; 
        }
        finally
        {
             //Cierra La Conexion
            if (conexion.State = ConnectionState.Open)
            {
                conexion.Close();
                conexion.Dispose(); 
            }
        }
        }

    public static DataTable ConsultaSQL(string strSql)
    {
        //Se Utiliza para sentencias SQL de tipo SELECT
        //La funcion recibe por valor una sentencia sql como string,devuelve un objeto de tipo DataTable
        SqlConnection conexion;
        SqlCommand cmd;
        DataTable tabla;
        try
        {
            conexion.ConnectionString = string_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;
            //DataTable se carga con el resultado de la sentencia
            tabla.Load(cmd.ExecuteReader);
            //LA funcion retorna el objeto datable con 0, 1 o mas registros
            return tabla;
        }
        catch(Exception ex)
        {
            throw ex; 
        }
        finally
        {
            if (connection.State = ConnectionState.Open)
            {
                conexion.Close();
                //Libera los recursos asociados a la conexion
                conexion.Dispose(); 
            }
        }
       
    }
    public static DataTable ConsultarConParametros(string sqlStr, object param)
    {
        //Se utiliza para sentencias SQL del tipo SELECT con parametros recibidos
        SqlConnection conexion;
        SqlCommand cmd;
        DataTable tabla;
        string n_param; 
    try
        {
            conexion.ConnectionString = string_conexion;
            conexion.Open();
            cmd.Connection = conexion; 
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            //Agregamos a la coleccion de parametros del comando los filtros recibiods
            //IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN

            for ( i = 0; param.Length - 1; i + 1)
            {
                if (!IsNothing(param(i)))
                {
                    n_param = "param" + Convert.ToString(i + 1);
                    cmd.Parameters.AddWithVale(n_param, param(i));
                }
            }
            //El datatable se carga con el resultado de ejecutar la sentencia
            tabla.Load(cmd.ExecuteReader);
            return tabla;
        }
        catch (Exception ex)
        {
            throw ex; 
        }
        finally
        {
            if (conexion.State = ConnectionState.Open)
            {
                conexion.Dispose(); 
            }
        }
        }
    }
