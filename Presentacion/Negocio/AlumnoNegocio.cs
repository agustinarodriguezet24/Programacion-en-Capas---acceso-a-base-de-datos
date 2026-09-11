using Datos;

namespace Negocio
{
    public class AlumnoNegocio
    {
        private AlumnoDatos datos = new AlumnoDatos();

        public Alumno BuscarAlumno(int legajo)
        {
            
            if (legajo <= 0)
            {
                return null;
            }

            var datoAlumno = datos.BuscarAlumno(legajo);

            if (datoAlumno == null)
            {
                return null;
            }

            
            return new Alumno
            {
                Legajo = datoAlumno.Value.Legajo,
                Nombre = datoAlumno.Value.Nombre,
                Condicion = datoAlumno.Value.Condicion
            };
        }
    }
}
