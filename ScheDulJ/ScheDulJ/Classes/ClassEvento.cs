using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms; 

namespace ScheDulJ.Classes
{
    public class Evento
    {
        private string nombreEvento;
        private int tipoEvento;
        private string fechaEvento;
        private string horarioEvento;
        private string horarioEventoF; 
        private string direccionEvento;
        private int idClienteEvento;

        //CONSTRUCTOR 
        public Evento(string nombre, int idTipoEvento, string fecha , string horario , string horarioFin, string direccion , int idCliente)
        {
            nombreEvento = nombre;
            tipoEvento = idTipoEvento;
            fechaEvento = fecha;
            horarioEvento = horario;
            horarioEventoF = horarioFin; 
            direccionEvento = direccion;
            idClienteEvento = idCliente;
        }
     

        public void Save()
        {
            try
            {
                string query = "INSERT INTO Eventos (nombre,idTipoEvento,fecha,horario,direccion,idCliente,horarioFin, activo) " +
                    "VALUES ('" + nombreEvento + "'," + tipoEvento + ",'" + fechaEvento + "','" + horarioEvento + "','" + direccionEvento + "'," + idClienteEvento + ",'" + horarioEventoF + "' ," + 1 + ")" ;
                DBHelper.ConsultarSQLVoid(query);
                MessageBox.Show("Evento Cargado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public static DataTable GetAll()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT idEvento AS ID, nombre as Nombre, idTipoEvento as TipoEvento, fecha AS Fecha , horario " +
                " AS HorarioInicio, horarioFin AS HorarioFin , direccion as Direccion " +
                " , idCliente AS Cliente  FROM Eventos WHERE activo = 1";
            tabla = DBHelper.ConsultarSQL(query);
            return tabla;
        }

        public static void Baja(int idEvento)
        {
            try
            {
                string query = "UPDATE Eventos SET activo = 0 WHERE idEvento = " + idEvento; 
                DBHelper.ConsultarSQLVoid(query);
                MessageBox.Show("Evento Eliminado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
