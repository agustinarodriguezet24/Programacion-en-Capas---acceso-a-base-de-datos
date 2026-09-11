using MySql.Data.MySqlClient;

namespace Datos
{
    public class ProductoDatos
    {
        private string _conexionString =
            "Server=localhost;Database=ejercicios3capas;Uid=root;Pwd=;";

        public (string Codigo, string Nombre, double Precio)? BuscarProducto(string codigo)
        {
            string query = "SELECT Codigo, Nombre, Precio FROM productos WHERE Codigo = @Codigo";

            using (MySqlConnection conexion = new MySqlConnection(_conexionString))
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Codigo", codigo);

                conexion.Open();

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string codigoDb = reader["Codigo"].ToString();
                        string nombreDb = reader["Nombre"].ToString();
                        double precioDb = Convert.ToDouble(reader["Precio"]);

                        return (codigoDb, nombreDb, precioDb);
                    }
                }
            }

            return null;
        }
    }
}