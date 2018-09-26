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
        private string nombreTEvento;
        private string descripcionTEvento;

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
            string consultaSQL = "DELETE FROM TiposEventos WHERE nombre ='" + this.nombreTEvento + "'";
            DBHelper.ConsultarSQL(consultaSQL);
            MessageBox.Show("Tipo de Evento Eliminado Correctamente", "Tipo de Evento Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
