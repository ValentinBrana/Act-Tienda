using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Tienda
{
    public class Cliente
    {
        private string nombre;
        private string email;
        private Producto producto;

        public Cliente(string nombre, string email, Producto producto)
        {
            this.nombre = nombre;
            this.email = email;
            this.producto = producto;
        }
        public Cliente()
        {
            nombre = string.Empty;
            email = string.Empty;
            Producto producto = null;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Email { get => email; set => email = value; }
        public Producto Producto { get => producto; set => producto = value; }
    }
}
