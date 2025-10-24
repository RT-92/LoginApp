using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;


using loginUsuarios.LoginApp.Utils;
using loginUsuarios.Data;




namespace loginUsuarios
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string usuario = txtUserLogin.Text.Trim();
            string password = txtPasswordLogin.Text;
            
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            using (SqlConnection conn = SqlConnectionHelper.GetOpenConnection())
            {
                string query = @"
                SELECT Id, PasswordHash, Rol, IntentosFallidos, Bloqueado 
                FROM Usuarios 
                WHERE Nombre = @usuario";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                
                try
                {
                      
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string hashEnBD = reader["PasswordHash"].ToString();
                            string rol = reader["Rol"].ToString();
                            int intentos = Convert.ToInt32(reader["IntentosFallidos"]);
                            bool bloqueado = Convert.ToBoolean(reader["Bloqueado"]);

                            reader.Close();

                            if (bloqueado)
                            {
                                MessageBox.Show("Tu cuenta está bloqueada. Contacta al administrador.");
                                return;
                            }

                            // Validar contraseña
                            
                            bool esValido = HashGenerator.VerifySHA256(password, hashEnBD);
                           
                            if (esValido)
                            {
                                string resetQuery = "UPDATE Usuarios SET IntentosFallidos = 0 WHERE Id = @id";
                                using (SqlCommand resetCmd = new SqlCommand(resetQuery, conn))
                                {
                                    resetCmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                                    resetCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show($"Bienvenido {usuario} (Rol: {rol})");
                                new FormAdminPanel().Show();

                                this.Hide();

                            }
                            else
                            {
                             intentos++;
                                string updateQuery = @"
                                UPDATE Usuarios 
                                SET IntentosFallidos = @intentos, 
                                Bloqueado = CASE WHEN @intentos >= 3 THEN 1 ELSE 0 END 
                                WHERE Nombre = @usuario";

                                SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                                updateCmd.Parameters.AddWithValue("@intentos", intentos);
                                updateCmd.Parameters.AddWithValue("@usuario", usuario);
                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show("Contraseña incorrecta. Intentos: " + intentos + "/3");   
                            }
                       

                            SqlConnectionHelper.CloseConnection(conn);
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado.");
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            registroUsuarios frm = new registroUsuarios();
            frm.Show();
            this.Hide();
        }

        private void showPass_inicio_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswordLogin.PasswordChar = showPass_inicio.Checked ? '\0' : '*';
        }
    }

}
















