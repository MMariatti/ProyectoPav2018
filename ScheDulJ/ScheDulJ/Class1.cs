using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheDulJ
{
    public class Clientes
    {
        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;
        private int activo;

        public Clientes(string nombreCliente, string apellidoCliente, string direccionCliente, int telefonoCliente, int activoCliente)
        {
            nombre = nombreCliente;
            apellido = apellidoCliente;
            direccion = direccionCliente;
            telefono = telefonoCliente;
            activo = activoCliente;
        }
    }
}
