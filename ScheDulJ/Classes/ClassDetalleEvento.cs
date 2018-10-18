using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ScheDulJ.Classes
{
    public class DetalleEvento
    {
        private int idEvento;
        private int idItem;
        private int costoAlquiler; 

        public DetalleEvento(int idE, int idI,int costoA)
        {
            idEvento = idE;
            idItem = idI;
            costoAlquiler = costoA; 
        }

        public static DataTable GetAll()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM DetalleEventos";
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

        public void Save()
        {
            try
            {
                string query = "INSERT INTO DetalleEventos(idEvento, idItem , costoAlquiler) values("+ idEvento + "," + idItem + "," + costoAlquiler + ")";
                DBHelper.ConsultarSQL(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar()
        {
            try
            {
                string query = "DELETE FROM DetalleEventos WHERE idEvento = " + idEvento + " AND idItem = " +idItem;
                DBHelper.ConsultarSQL(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        
        public static DataTable GetSeleccionadoEvento(int idEvento)
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM DetalleEventos WHERE idEvento = " + idEvento;
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
    }
}
