using System;
using Negocio;

namespace Presentacion.UI
{
    public static class MenuLibro
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el ISBN del libro: ");
            string isbn = Console.ReadLine();

            LibroNegocio negocio = new LibroNegocio();
            Libro libro = negocio.BuscarLibro(isbn);

            if (libro != null)
            {
                Console.WriteLine($"Titulo: {libro.Titulo}");
                Console.WriteLine($"Autor: {libro.Autor}");
                Console.WriteLine(libro.Disponible ? "Estado: Disponible" : "Estado: Prestado");
            }
            else
            {
                Console.WriteLine("Libro no encontrado o ISBN invalido.");
            }
        }
    }
}
