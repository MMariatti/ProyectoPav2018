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
        private int idEvento = 0;
        private string nombreEvento = "";
        private TiposEventos tipoEvento = new TiposEventos();
        private string fechaEvento;
        private string horarioEvento = "";
        private string horarioEventoF = "";
        private string direccionEvento = "";
        private Clientes clienteEvento = new Clientes();

        public int IdEvento
        {
            get { return this.idEvento; }
            private set
            {
                this.idEvento = value;
            }
        }

        public string NombreEvento
        {
            get { return this.nombreEvento; }
            private set
            {
                this.nombreEvento = value;
            }
        }

        public TiposEventos TipoEvento
        {
            get { return this.tipoEvento; }
            private set
            {
                this.tipoEvento = value;
            }
        }

        public string FechaEvento
            {
            get { return this.fechaEvento; }
            private set
            {
                this.fechaEvento = value;
            }
        }

        public string HorarioEvento
        {
            get { return this.horarioEvento; }
            private set
            {
                this.horarioEvento = value;
            }
        }

        public string HorarioEventoF
        {
            get { return this.horarioEventoF; }
            private set
            {
                this.horarioEventoF = value;
            }
        }

        public string DireccionEvento
        {
            get { return this.direccionEvento; }
            private set
            {
                this.direccionEvento = value;
            }
        }

        public Clientes ClienteEvento
        {
            get { return this.clienteEvento; }
            private set
            {
                this.clienteEvento = value;
            }
        }

        //CONSTRUCTOR 
        public Evento(string nombre, TiposEventos tipoEvento , string fecha, string horario, string horarioFin, string direccion, Clientes clienteEvento)
        {
            this.nombreEvento = nombre;
            this.tipoEvento = tipoEvento;
            this.fechaEvento = fecha;
            this.horarioEvento = horario;
            this.horarioEventoF = horarioFin;
            this.direccionEvento = direccion;
            this.clienteEvento = clienteEvento;
        }

        public Evento()
        {

        }

        public Evento(int idEvento)
        {
            this.IdEvento = idEvento;
            getAttr();
        }

        public void getAttr()
        {
            string query = "SELECT nombre, idTipoEvento, fecha, horario, direccion, idCliente FROM Eventos WHERE idEvento = " + idEvento;
            DataTable tabla = DBHelper.ConsultarSQL(query);
            NombreEvento = tabla.Rows[0]["nombre"].ToString();
            TipoEvento = new TiposEventos((int)tabla.Rows[0]["idTipoEvento"]);
            FechaEvento = tabla.Rows[0]["fecha"].ToString();
            HorarioEvento = tabla.Rows[0]["horario"].ToString();
            DireccionEvento = tabla.Rows[0]["direccion"].ToString();
            ClienteEvento = new Clientes((int)tabla.Rows[0]["idCliente"]);
        }

        public void Save()
        {
            try
            {
                string query = "INSERT INTO Eventos (nombre,idTipoEvento,fecha,horario,direccion,idCliente,horarioFin, activo) " +
                    "VALUES ('" + nombreEvento + "'," + TipoEvento.IdTipoEvento + ", '" + fechaEvento.ToString() + "' ,'" + horarioEvento + "','" + direccionEvento + "'," + ClienteEvento.IdCliente + ",'" + horarioEventoF + "' ," + 1 + ")";
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
