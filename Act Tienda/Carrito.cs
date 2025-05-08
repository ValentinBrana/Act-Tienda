using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Tienda
{
    public class Carrito
    {
        private Cliente cliente;
        private static List<Producto> productosCliente = new List<Producto>();

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public static List<Producto> ProductosCliente { get => productosCliente; set => productosCliente = value; }

        public Carrito(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public Carrito()
        {
            Cliente = null;
        }

        public void AgregarProdCarrito(Producto producto)
        {
            ProductosCliente.Add(producto);
            Console.WriteLine("Producto " + producto.Nombre + " agregado al carrito.");
        }

        public void EliminarProdCarrito(string nombre)
        {
            Producto productoAEliminar = ProductosCliente.FirstOrDefault(p => p.Nombre.ToLower() == nombre.ToLower());
            if (productoAEliminar != null)
            {
                ProductosCliente.Remove(productoAEliminar);
                Console.WriteLine("Producto " + productoAEliminar.Nombre + " eliminado del carrito.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado en el carrito.");
            }
        }

        public int CalcularTotal()
        {
            int total = 0;
            foreach (Producto p in ProductosCliente)
            {
                total += p.Precio;
            }
            return total;
        }

        public void MostrarCarrito()
        {
            if (ProductosCliente.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
            }
            else
            {
                foreach (var producto in ProductosCliente)
                {
                    Console.WriteLine(producto.ToString());
                }
            }
        }

        public Orden RealizarOrden(string direccion)
        {
            Orden nueva = new Orden(cliente, 0, direccion);
            nueva.ProductosComprados = new List<Producto>(ProductosCliente);
            nueva.CalcularPrecioTotal();
            Console.WriteLine("Orden realizada con éxito.");
            return nueva;
        }
    }
}
