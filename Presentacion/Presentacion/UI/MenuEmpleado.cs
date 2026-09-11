using System;
using Negocio;

namespace Presentacion.UI
{
    public static class MenuEmpleado
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el ID del empleado (ej: 501): ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int id))
            {
                Console.WriteLine("Debe ingresar un numero valido.");
                return;
            }

            EmpleadoNegocio negocio = new EmpleadoNegocio();
            Empleado empleado = negocio.BuscarEmpleado(id);

            if (empleado != null)
            {
                Console.WriteLine($"Nombre: {empleado.Nombre}");
                Console.WriteLine($"Puesto: {empleado.Puesto}");
                Console.WriteLine($"Departamento: {empleado.Departamento}");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado o ID fuera de rango (100-999).");
            }
        }
    }
}
