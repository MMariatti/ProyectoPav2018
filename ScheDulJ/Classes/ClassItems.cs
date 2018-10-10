using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ScheDulJ.Classes
{
    class Items
    {
        private string nombre;
        private string descripcion;
        private int costoAlquiler;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
                else
                {
                    MessageBox.Show("Tenes que ingresar algo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.descripcion = value;
                }
                else
                {
                    MessageBox.Show("Tenes que ingresar algo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public int CostoAlquiler
        {
            get
            {
                return this.costoAlquiler;
            }
            set
            {
                if (value != null && (value.GetType() == Int))
                {
                    this.costoAlquiler = value;
                }
                else
                {
                    MessageBox.Show("Tenes que ingresar algo!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Items(string nombreItem, string descripcionItem, int costoAlquilerItem)
        {
            this.Nombre = nombreItem;
            this.Descripcion = descripcionItem;
            this.costoAlquiler = costoAlquilerItem;

        }

    }
}
