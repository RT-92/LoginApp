using loginUsuarios.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginUsuarios
{
    public partial class FormAdminPanel : Form
    {
        private int usuarioIdSeleccionado;

        public FormAdminPanel()
        {
            InitializeComponent();
        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
            lblSeleccionado.Text = "Usuario seleccionado: ninguno";
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Usuario");
            cmbRol.SelectedIndex = 0; // opción por defecto
        }

        //Funcion para cargar usuarios
        private void CargarUsuarios()
        {
            using (SqlConnection conn = SqlConnectionHelper.GetOpenConnection())
            {
                string query = "SELECT Id, Nombre, Rol, IntentosFallidos, Bloqueado FROM Usuarios";
                SqlDataAdapter adapter = new SqlDataAdapter(query,conn );
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvUsuarios.DataSource = dt;

                SqlConnectionHelper.CloseConnection(conn);
            }
            

        }

        //Funcion para desbloquear usuarios

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {

            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario.");

                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["Id"].Value);

                using (SqlConnection conn = SqlConnectionHelper.GetOpenConnection())
                {
                    string query = "UPDATE Usuarios SET IntentosFallidos = 0, Bloqueado = 0 WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario desbloqueado.");
                    CargarUsuarios(); // refrescar tabla
                
                    SqlConnectionHelper.CloseConnection(conn);
            }
        }



        //Cambia el Rol de Usuario
        private void btnCambiarRol_Click(object sender, EventArgs e)
        {

            if (usuarioIdSeleccionado == 0 || cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Selecciona un usuario y un rol.");
                return;
            }

            string nuevoRol = cmbRol.SelectedItem.ToString();
            
            using (SqlConnection conn = SqlConnectionHelper.GetOpenConnection())
            {
                string query = "UPDATE Usuarios SET Rol = @rol WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@rol", SqlDbType.NVarChar, 20).Value = nuevoRol;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = usuarioIdSeleccionado;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Rol actualizado.");
                CargarUsuarios();

                SqlConnectionHelper.CloseConnection(conn);
            }


        }
        //Muestra información sobre el Usuario seleccionado de la tabla.
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                var fila = dgvUsuarios.SelectedRows[0];
                usuarioIdSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string rol = fila.Cells["Rol"].Value.ToString();
                int intentos = Convert.ToInt32(fila.Cells["IntentosFallidos"].Value);
                bool bloqueado = Convert.ToBoolean(fila.Cells["Bloqueado"].Value);

                lblSeleccionado.Text = $"👤 {nombre} | Rol: {rol} | Intentos: {intentos} | Bloqueado: {(bloqueado ? "Sí" : "No")}";
                cmbRol.SelectedItem = rol;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Close();

        }
    }
}
