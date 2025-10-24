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
using System.Security.Cryptography;
using loginUsuarios.LoginApp.Utils;
using loginUsuarios.Data;

namespace loginUsuarios
{
    public partial class registroUsuarios : Form
    {
        public registroUsuarios()
        {
            InitializeComponent();
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Usuario");
            cmbRol.SelectedIndex = 0; // opción por defecto
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string usuario = txtUserRegister.Text.Trim();
            string password = txtPasswordRegister.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            else if (password != txtValidarPassword.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden!! Reintentar nuevamente");
                return;
            }

            try
            {
                using (SqlConnection conn = SqlConnectionHelper.GetOpenConnection())
                {
                    string hash = HashGenerator.GenerateSHA256(txtPasswordRegister.Text);

                    string insert = @"
                    INSERT INTO Usuarios (Nombre, PasswordHash,Rol, IntentosFallidos, Bloqueado)
                    VALUES (@nombre, @hash, @Rol, 0, 0)";


                    using (SqlCommand cmd = new SqlCommand(insert, conn))
                    {
                        cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 50).Value = txtUserRegister.Text.Trim();
                        cmd.Parameters.Add("@hash", SqlDbType.NVarChar, 64).Value = hash;
                        cmd.Parameters.Add("@rol", SqlDbType.NVarChar, 20).Value = cmbRol.SelectedItem?.ToString() ?? "Usuario";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario registrado correctamente.");
                        txtUserRegister.Clear();
                        txtPasswordRegister.Clear();
                        txtValidarPassword.Clear();
                        FormLogin frmLogin = new FormLogin();
                        frmLogin.Show();
                        this.Hide();
                    }
                }

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Violación de clave única
                    MessageBox.Show("El nombre de usuario ya existe.");
                else
                    MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPasswordRegister.PasswordChar = showPass.Checked ? '\0' : '*';
            txtValidarPassword.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void btnRgistV_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}





