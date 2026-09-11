using System;
using Presentacion.UI;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Consultar Producto por Codigo");
                Console.WriteLine("2. Verificar Alumno por Legajo");
                Console.WriteLine("3. Consultar Vehiculo por Patente");
                Console.WriteLine("4. Buscar Libro por ISBN");
                Console.WriteLine("5. Consultar Empleado por ID");
                Console.WriteLine("0. Salir");
                Console.Write("Elija una opcion: ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        MenuProducto.Ejecutar();
                        break;
                    case "2":
                        MenuAlumno.Ejecutar();
                        break;
                    case "3":
                        MenuVehiculo.Ejecutar();
                        break;
                    case "4":
                        MenuLibro.Ejecutar();
                        break;
                    case "5":
                        MenuEmpleado.Ejecutar();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");
                        break;
                }
            }
        }
    }
}
