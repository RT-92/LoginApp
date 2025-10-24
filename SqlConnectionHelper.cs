using System;
using System.Data.SqlClient;

namespace LoginApp.Data
{
    /// <summary>
    /// Clase auxiliar para manejar la conexión a la base de datos SQL Server.
    /// </summary>
    public static class SqlConnectionHelper
    {
        // 🔐 Cadena de conexión centralizada
        private static readonly string connectionString = "Server=.;Database=LoginDB;Trusted_Connection=True;TrustServerCertificate=True;";

        /// <summary>
        /// Obtiene una nueva instancia de SqlConnection abierta.
        /// </summary>
        /// <returns>SqlConnection abierta</returns>
        public static SqlConnection GetOpenConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        /// <summary>
        /// Cierra y libera una conexión SQL si está abierta.
        /// </summary>
        /// <param name="conn">Conexión a cerrar</param>
        public static void CloseConnection(SqlConnection conn)
        {
            if (conn != null && conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
