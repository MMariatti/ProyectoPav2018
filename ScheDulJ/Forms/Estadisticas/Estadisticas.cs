using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheDulJ.Forms.Estadisticas
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            CargarChartEquipamiento();
            CargarChartEventos(); 
        }
        private void CargarChartEquipamiento()
        {
            DataTable tabla = new DataTable();
            tabla = DBHelper.ConsultarSQL("SELECT TOP 5 I.idItem , I.nombre AS Nombre , COUNT(I.idItem) AS Cantidad " +
                " FROM DetalleEventos DE JOIN Items I ON(DE.idItem = I.idItem) GROUP BY  I.idItem, I.nombre ORDER BY Cantidad DESC");
            chartItemsPorAño.DataSource = tabla; 
        }
        private void CargarChartEventos()
        {
            DataTable tabla = new DataTable();
            tabla = DBHelper.ConsultarSQL("SELECT MONTH(fecha) AS Mes, COUNT(idEvento) AS Cantidad FROM Eventos" +
                " GROUP BY MONTH(fecha)");
            chartEventosMensuales.DataSource = tabla; 
        }

        private void chartItemsPorAño_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
