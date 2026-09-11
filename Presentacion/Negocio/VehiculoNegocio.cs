using Datos;

namespace Negocio
{
    public class VehiculoNegocio
    {
        private VehiculoDatos datos = new VehiculoDatos();

        public Vehiculo BuscarVehiculo(string patente)
        {
            
            if (string.IsNullOrWhiteSpace(patente) || patente.Length < 6)
            {
                return null;
            }

            var datoVehiculo = datos.BuscarVehiculo(patente);

            if (datoVehiculo == null)
            {
                return null;
            }

            return new Vehiculo
            {
                Patente = datoVehiculo.Value.Patente,
                Modelo = datoVehiculo.Value.Modelo,
                TieneDeuda = datoVehiculo.Value.TieneDeuda
            };
        }
    }
}
