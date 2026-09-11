using Datos;

namespace Negocio
{
    public class LibroNegocio
    {
        private LibroDatos datos = new LibroDatos();

        public Libro BuscarLibro(string isbn)
        {
            
            if (string.IsNullOrWhiteSpace(isbn))
            {
                return null;
            }

            var datoLibro = datos.BuscarLibro(isbn);

            if (datoLibro == null)
            {
                return null;
            }

            return new Libro
            {
                Isbn = datoLibro.Value.Isbn,
                Titulo = datoLibro.Value.Titulo,
                Autor = datoLibro.Value.Autor,
                Disponible = datoLibro.Value.Disponible
            };
        }
    }
}
