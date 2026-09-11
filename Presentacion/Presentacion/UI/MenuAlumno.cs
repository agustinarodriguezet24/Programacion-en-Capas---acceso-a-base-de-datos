using System;
using Negocio;

namespace Presentacion.UI
{
    public static class MenuAlumno
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese el legajo del alumno (ej: 10042): ");
            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out int legajo))
            {
                Console.WriteLine("Debe ingresar un numero valido.");
                return;
            }

            AlumnoNegocio negocio = new AlumnoNegocio();
            Alumno alumno = negocio.BuscarAlumno(legajo);

            if (alumno != null)
            {
                Console.WriteLine($"Nombre: {alumno.Nombre}");
                Console.WriteLine($"Condicion: {alumno.Condicion}");
            }
            else
            {
                Console.WriteLine("Alumno no encontrado o legajo invalido.");
            }
        }
    }
}
