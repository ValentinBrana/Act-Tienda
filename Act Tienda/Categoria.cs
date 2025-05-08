using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Tienda
{
    public class Categoria
    {
        private static List<Categoria> categorias = new List<Categoria>();
        private string nombre;
        private string descripcion;

        internal static List<Categoria> Categorias { get => categorias; set => categorias = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public Categoria(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public Categoria()
        {
            nombre = "";
            descripcion = "";
        }

        public void Guardar()
        {
            Categoria.Categorias.Add(this);
        }
    }
}
