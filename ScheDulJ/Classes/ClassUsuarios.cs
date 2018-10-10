using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ScheDulJ.Classes
{
    class Usuarios
    {
        private string usuario;
        private string contra;
        private int activo;
        private int idUsuario;

        public Usuarios(string usuarioN, string contraN)
        {
            usuario = usuarioN;
            contraN = contraN; 

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

        public DataTable GetAll()
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

        public void Baja()
        {
            if (activo == 1)
            {
                activo = 0;
                string query = "UPDATE Usuarios SET activo = 0 WHERE idUsuario = '" + idUsuario;
                DBHelper.ConsultarSQL(query);
                MessageBox.Show("Usuario dado de baja con exito", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("El usuario ya esta dado de baja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
