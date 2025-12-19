using Microsoft.Data.Sqlite;

namespace MiProyectoWeb
{
    public static class DatabaseInitializer
    {
        public static void Initialize(string connectionString)
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS productos (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    titulo TEXT NOT NULL,
                    url_imagen TEXT NOT NULL,
                    precio REAL NOT NULL
                );
            ";

            command.ExecuteNonQuery();
        }
    }
}
