using MySql.Data.MySqlClient;

namespace Datos
{
    public class VehiculoDatos
    {
        private string _conexionString =
            "Server=localhost;Database=ejercicios3capas;Uid=root;Pwd=;";

        public (string Patente, string Modelo, bool TieneDeuda)? BuscarVehiculo(string patente)
        {
            string query = "SELECT Patente, Modelo, TieneDeuda FROM vehiculos WHERE Patente = @Patente";

            using (MySqlConnection conexion = new MySqlConnection(_conexionString))
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@Patente", patente);

                conexion.Open();

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string patenteDb = reader["Patente"].ToString();
                        string modeloDb = reader["Modelo"].ToString();
                        bool tieneDeudaDb = Convert.ToBoolean(reader["TieneDeuda"]);

                        return (patenteDb, modeloDb, tieneDeudaDb);
                    }
                }
            }

            return null;
        }
    }
}