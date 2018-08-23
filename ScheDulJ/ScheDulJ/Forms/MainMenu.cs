using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheDulJ
{
    //El form MainMenu va a ser el principal de todo el programa. Este se iniciara cuando se loguee y 
    //se mantendra abierto hasta que se termine de utilizar el programa. 
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de cerrar la aplicacion", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //El enviroment cierra toda la aplicacion sin tener que pasar por el evento de frmLogin_Closing 
                //Sino se ejecuta dos veces la misma ventana 
                Environment.Exit(1);
            } 
            else
                e.Cancel = true;
        }

        private void btnExitMainMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar la aplicacion?", "Cerrar Aplicacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }
    }
}
