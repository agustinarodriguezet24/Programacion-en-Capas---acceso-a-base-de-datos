using System;
using Negocio;

namespace Presentacion.UI
{
    public static class MenuVehiculo
    {
        public static void Ejecutar()
        {
            Console.Write("Ingrese la patente del vehiculo (ej: AA123CD): ");
            string patente = Console.ReadLine();

            VehiculoNegocio negocio = new VehiculoNegocio();
            Vehiculo vehiculo = negocio.BuscarVehiculo(patente);

            if (vehiculo != null)
            {
                Console.WriteLine("Modelo: " + vehiculo.Modelo);
                Console.WriteLine(vehiculo.TieneDeuda ? "Tiene deudas pendientes." : "No tiene deudas pendientes.");
            }
            else
            {
                Console.WriteLine("Vehiculo no encontrado o patente invalida.");
            }
        }
    }
}
