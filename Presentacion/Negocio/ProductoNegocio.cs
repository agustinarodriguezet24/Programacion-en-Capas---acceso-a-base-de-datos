using Datos;

namespace Negocio
{
    public class ProductoNegocio
    {
        private ProductoDatos datos = new ProductoDatos();

        public Producto BuscarProducto(string codigo)
        {
            
            if (string.IsNullOrWhiteSpace(codigo))
            {
                return null;
            }

            if (!codigo.StartsWith("PROD-"))
            {
                return null;
            }

            var datoProducto = datos.BuscarProducto(codigo);

            if (datoProducto == null)
            {
                return null;
            }

            return new Producto
            {
                Codigo = datoProducto.Value.Codigo,
                Nombre = datoProducto.Value.Nombre,
                Precio = datoProducto.Value.Precio
            };
        }
    }
}
