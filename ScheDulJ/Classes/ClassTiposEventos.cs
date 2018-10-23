using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ScheDulJ.Classes
{
    public class TiposEventos
    {
        private int idTipoEvento = 0;
        private string nombreTEvento = "";
        private string descripcionTEvento = "";

        public int IdTipoEvento
        {
            get { return this.idTipoEvento; }
            private set
            {
                this.idTipoEvento = value;
            }
        }

        public string NombreTEvento
        {
            get { return this.nombreTEvento; }
            private set
            {
                this.nombreTEvento = value;
            }
        }

        public string DescripcionTEvento
        {
            get { return this.descripcionTEvento; }
            private set
            {
                this.descripcionTEvento = value;
            }
        }

        public TiposEventos()
        {

        }

        public TiposEventos(int idTipoEvento)
        {
            this.IdTipoEvento = idTipoEvento;
            getAttr();
        }

        public void getAttr()
        {
            string query = "SELECT nombre, descripcion FROM TiposEventos WHERE idTipoEvento = " + IdTipoEvento;
            DataTable tabla = DBHelper.ConsultarSQL(query);
            NombreTEvento = tabla.Rows[0]["nombre"].ToString();
            DescripcionTEvento = tabla.Rows[0]["descripcion"].ToString();

        }

        public TiposEventos(string nombre, string descripcion)
        {
            nombreTEvento = nombre;
            descripcionTEvento = descripcion;
        }

        public void Save()
        {
            try
            {
                string query = "INSERT INTO TiposEventos(nombre, descripcion) " + "VALUES('" + this.nombreTEvento + "','" + this.descripcionTEvento + "')";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show(this.nombreTEvento + " cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static DataTable GetAll()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM TiposEventos";
            tabla = DBHelper.ConsultarSQL(query);
            return tabla;
        }

        public void Eliminar()
        {
            try
            {
                string consultaSQL = "DELETE FROM TiposEventos WHERE idTipoEvento = " + this.IdTipoEvento;
                DBHelper.ConsultarSQL(consultaSQL);
                MessageBox.Show("Tipo de Evento Eliminado Correctamente", "Tipo de Evento Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
    }
}
