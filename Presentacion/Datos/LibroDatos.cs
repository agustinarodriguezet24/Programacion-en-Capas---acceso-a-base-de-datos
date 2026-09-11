using MySql.Data.MySqlClient;

namespace Datos
{
    public class LibroDatos
    {
        private string _conexionString =
            "Server=localhost;Database=ejercicios3capas;Uid=root;Pwd=;";

        public (string Isbn, string Titulo, string Autor, bool Disponible)? BuscarLibro(string isbn)
        {
            string query = "SELECT Isbn, Titulo, Autor, Disponible FROM libros WHERE Isbn = @Isbn";

            using (MySqlConnection conexion = new MySqlConnection(_conexionString))
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Isbn", isbn);

                conexion.Open();

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string isbnDb = reader["Isbn"].ToString();
                        string tituloDb = reader["Titulo"].ToString();
                        string autorDb = reader["Autor"].ToString();
                        bool disponibleDb = Convert.ToBoolean(reader["Disponible"]);

                        return (isbnDb, tituloDb, autorDb, disponibleDb);
                    }
                }
            }

            return null;
        }
    }
}