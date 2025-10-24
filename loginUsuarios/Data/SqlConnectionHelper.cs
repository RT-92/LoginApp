using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;

namespace loginUsuarios.Data;


/// Clase auxiliar para manejar la conexión a la base de datos SQL Server.

public static class SqlConnectionHelper
{
    // 🔐 Cadena de conexión centralizada
    private static readonly string connectionString = " ";

    /// Obtiene una nueva instancia de SqlConnection abierta.
    public static SqlConnection GetOpenConnection()
    {
        SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        return conn;
    }

    /// Cierra y libera una conexión SQL si está abierta.
    public static void CloseConnection(SqlConnection conn)
    {
        if (conn != null && conn.State != System.Data.ConnectionState.Closed)
        {
            conn.Close();
            conn.Dispose();
        }
    }
}
