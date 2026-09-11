using System;
using Negocio;

namespace Presentacion.UI
{
    public static class MenuProducto
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el codigo del producto (ej: PROD-101): ");
            string codigo = Console.ReadLine();

            ProductoNegocio negocio = new ProductoNegocio();
            Producto producto = negocio.BuscarProducto(codigo);

            if (producto != null)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}");
                Console.WriteLine($"Precio: {producto.Precio}");
            }
            else
            {
                Console.WriteLine("Producto no encontrado o codigo invalido.");
            }
        }
    }
}
