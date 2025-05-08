using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Tienda
{
    public class Orden
    {
        private List<Producto> productosComprados = new List<Producto>();
        private Cliente cliente;
        private int precioTotal;
        private string direccionEnvio;

        public List<Producto> ProductosComprados { get => productosComprados; set => productosComprados = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string DireccionEnvio { get => direccionEnvio; set => direccionEnvio = value; }

        public Orden(Cliente cliente, int precioTotal, string direccionEnvio)
        {
            this.cliente = cliente;
            this.precioTotal = precioTotal;
            this.direccionEnvio = direccionEnvio;
        }

        public Orden()
        {
            cliente = null;
            precioTotal = 0;
            direccionEnvio = "";
        }

        public void CalcularPrecioTotal()
        {
            int total = 0;
            foreach (Producto p in productosComprados)
            {
                total += p.Precio;
            }
            precioTotal = total;
        }

        public void ConfirmarOrden()
        {
            CalcularPrecioTotal();
            Console.WriteLine("\n--- Orden confirmada ---");
            Console.WriteLine("Cliente: " + this.cliente.Nombre);
            Console.WriteLine("Total: " + this.precioTotal);
            Console.WriteLine("Envio: " + this.direccionEnvio);
            Console.WriteLine("------------------------");
        }
    }
}
