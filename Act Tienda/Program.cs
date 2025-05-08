using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_Tienda
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrecargarDatos();

            Cliente cliente = new Cliente("valentin", "valentinnbrana@gmail.com", null);
            Carrito carrito = new Carrito(cliente);
            Orden orden = null;

            int opcion;
            do
            {
                opcion = Menu();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el producto que quiera modificar:");
                        string nombreProducto = Console.ReadLine();
                        Producto.ModificarProducto(nombreProducto);
                        break;

                    case 2:
                        GestionarCarrito(carrito);
                        break;

                    case 3:
                        Console.Write("Ingrese la dirección de entrega:");
                        string direccion = Console.ReadLine();
                        orden = carrito.RealizarOrden(direccion);
                        break;

                    case 4:
                        if (orden != null)
                        {
                            orden.ConfirmarOrden();
                        }
                        else
                        {
                            Console.WriteLine("Primero debe finalizar una compra.");
                        }
                        break;
                }

                Console.WriteLine("\n\nToque una tecla para continuar..");
                Console.ReadKey();

            } while (opcion != 0);

            Console.ReadKey();
        }

        static void PrecargarDatos()
        {
            Categoria c1 = new Categoria("Comida", "Comestible.");
            Categoria c2 = new Categoria("Bebida", "Bebible.");
            Categoria c3 = new Categoria("Cosmetico", "Cosmetologia");

            Producto p1 = new Producto("Lays", "las mas ricardas", 5000, c1, 3);
            p1.Guardar();
        }

        private static int Menu()
        {
            int opcion;

            Console.WriteLine("TIENDA");
            Console.WriteLine("1 Modificar un producto");
            Console.WriteLine("2 Gestionar carrito");
            Console.WriteLine("3 Confirmar orden");
            Console.WriteLine("4 Finalizar compra");
            Console.WriteLine("0 - Salir");

            opcion = Validaciones.LeerInt(0, 4);
            return opcion;
        }

        private static void GestionarCarrito(Carrito carrito)
        {
            Console.WriteLine("1 - Agregar producto");
            Console.WriteLine("2 - Eliminar producto");
            Console.WriteLine("3 - Ver total del carrito");
            Console.WriteLine("4 - Mostrar productos del carrito");
            Console.Write("Seleccione una opción: ");
            string opcionCarrito = Console.ReadLine();

            if (opcionCarrito == "1")
            {
                Console.Write("Ingrese el nombre del producto a agregar: ");
                string nombreAgregar = Console.ReadLine().Trim();

                Producto pAgregar = Producto.Productos.Find(p => p.Nombre.ToLower() == nombreAgregar.ToLower());
                if (pAgregar != null)
                    carrito.AgregarProdCarrito(pAgregar);
                else
                    Console.WriteLine("Producto no encontrado.");
            }
            else if (opcionCarrito == "2")
            {
                Console.Write("Ingrese el nombre del producto a eliminar: ");
                string nombreEliminar = Console.ReadLine().Trim();
                carrito.EliminarProdCarrito(nombreEliminar);
            }
            else if (opcionCarrito == "3")
            {
                Console.WriteLine("Total del carrito: " + carrito.CalcularTotal());
            }
            else if (opcionCarrito == "4")
            {
                carrito.MostrarCarrito();
            }
        }
    }
}
