using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ScheDulJ.Classes
{
    public class Usuarios
    {
        private string usuario;
        private string contra;

        public Usuarios(string usuarioN, string contraN)
        {
            usuario = usuarioN;
            contra = contraN; 
        }

        public void Save()
        {
            try
            {
                string query = "INSERT INTO Usuarios(usuario,contra, activo) " + "VALUES('" + this.usuario + "','" + this.contra + "', " + 1 + ")";
                DBHelper.ConsultarSQL(query);
                MessageBox.Show(this.usuario + " cargado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable GetAll()
        {
            DataTable tabla = new DataTable();
            string query = "SELECT * FROM Usuarios U WHERE U.activo = 1";
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

        public void Baja(int id)
        {

            try { 
                string query = "UPDATE Usuarios SET activo = 0 WHERE idUsuario =" + id;
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Usuario dado de baja con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    
        public void CambiarContraseña()
        {


        }
    }
}
