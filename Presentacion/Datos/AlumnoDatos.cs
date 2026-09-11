using MySql.Data.MySqlClient;

namespace Datos
{
    public class AlumnoDatos
    {
        private string _conexionString =
            "Server=localhost;Database=ejercicios3capas;Uid=root;Pwd=;";

        public (int Legajo, string Nombre, string Condicion)? BuscarAlumno(int legajo)
        {
            string query = "SELECT Legajo, Nombre, Condicion FROM alumnos WHERE Legajo = @Legajo";

            using (MySqlConnection conexion = new MySqlConnection(_conexionString))
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Legajo", legajo);

                conexion.Open();

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int legajoDb = Convert.ToInt32(reader["Legajo"]);
                        string nombreDb = reader["Nombre"].ToString();
                        string condicionDb = reader["Condicion"].ToString();

                        return (legajoDb, nombreDb, condicionDb);
                    }
                }
            }

            return null;
        }
    }
}