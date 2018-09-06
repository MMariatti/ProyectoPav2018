﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ScheDulJ.Forms
{
    public partial class frmUserAdmin : Form
    {
        public frmUserAdmin()
        {
            InitializeComponent();
        }

        private void frmUserAdmin_Load(object sender, EventArgs e)
        {
            mostrarListaUsuarios();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mostrarListaUsuarios()
        {
           
            DataTable tabla = new DataTable();
            tabla = BDHelper.ConsultarSQL("SELECT Usuario FROM Usuarios U WHERE U.Activo = 1"); 
            gridUsuarios.DataSource = tabla; 
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario frmAgregarUsuario;
            frmAgregarUsuario = new frmAgregarUsuario();
            frmAgregarUsuario.Show(); 
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario(); 
        }
        private void EliminarUsuario()
        {

            try
            {
                if (gridUsuarios.SelectedRows[0].Index != gridUsuarios.Rows.Count - 1)
                {
                    if (MessageBox.Show("Esta seguro que desea eliminar el usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string consultaSQL = "UPDATE Usuarios SET Activo = 0 WHERE Usuario ='" + gridUsuarios.SelectedRows[0].Cells[0].Value.ToString() + "'";
                        BDHelper.ConsultarSQLVoid(consultaSQL);
                        MessageBox.Show("Usuario Eliminado Correctamente", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mostrarListaUsuarios();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            mostrarListaUsuarios();
        }
       
    }   
}
