using Datos;

namespace Negocio
{
    public class EmpleadoNegocio
    {
        private EmpleadoDatos datos = new EmpleadoDatos();

        public Empleado BuscarEmpleado(int id)
        {
            
            if (id < 100 || id > 999)
            {
                return null;
            }

            var datoEmpleado = datos.BuscarEmpleado(id);

            if (datoEmpleado == null)
            {
                return null;
            }

            return new Empleado
            {
                Id = datoEmpleado.Value.Id,
                Nombre = datoEmpleado.Value.Nombre,
                Puesto = datoEmpleado.Value.Puesto,
                Departamento = datoEmpleado.Value.Departamento
            };
        }
    }
}
