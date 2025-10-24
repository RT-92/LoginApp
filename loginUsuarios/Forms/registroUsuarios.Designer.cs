namespace loginUsuarios
{
    partial class registroUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            cmbRol = new ComboBox();
            label5 = new Label();
            btnRgistV = new Button();
            showPass = new CheckBox();
            txtValidarPassword = new TextBox();
            label3 = new Label();
            btnRegister = new Button();
            txtPasswordRegister = new TextBox();
            txtUserRegister = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnRgistV);
            panel1.Controls.Add(showPass);
            panel1.Controls.Add(txtValidarPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtPasswordRegister);
            panel1.Controls.Add(txtUserRegister);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(64, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 380);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(90, 222);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 13;
            label6.Text = "Seleccionar Rol";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.WhiteSmoke;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FlatStyle = FlatStyle.Flat;
            cmbRol.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRol.ForeColor = Color.DimGray;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(90, 240);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(260, 23);
            cmbRol.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(90, 50);
            label5.Name = "label5";
            label5.Size = new Size(204, 24);
            label5.TabIndex = 11;
            label5.Text = "Registro de Usuarios";
            // 
            // btnRgistV
            // 
            btnRgistV.BackColor = Color.SteelBlue;
            btnRgistV.FlatAppearance.BorderSize = 0;
            btnRgistV.FlatStyle = FlatStyle.Flat;
            btnRgistV.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnRgistV.ForeColor = Color.WhiteSmoke;
            btnRgistV.Location = new Point(90, 313);
            btnRgistV.Name = "btnRgistV";
            btnRgistV.Size = new Size(75, 23);
            btnRgistV.TabIndex = 9;
            btnRgistV.Text = "Volver";
            btnRgistV.UseVisualStyleBackColor = false;
            btnRgistV.Click += btnRgistV_Click;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPass.ForeColor = Color.Black;
            showPass.Location = new Point(240, 197);
            showPass.Name = "showPass";
            showPass.Size = new Size(108, 17);
            showPass.TabIndex = 8;
            showPass.Text = "Show password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtValidarPassword
            // 
            txtValidarPassword.Location = new Point(90, 168);
            txtValidarPassword.Name = "txtValidarPassword";
            txtValidarPassword.PasswordChar = '*';
            txtValidarPassword.PlaceholderText = "Confirmar contraseña";
            txtValidarPassword.Size = new Size(258, 23);
            txtValidarPassword.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(417, 9);
            label3.Name = "label3";
            label3.Size = new Size(19, 21);
            label3.TabIndex = 5;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.Location = new Point(275, 313);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPasswordRegister
            // 
            txtPasswordRegister.Location = new Point(90, 128);
            txtPasswordRegister.Name = "txtPasswordRegister";
            txtPasswordRegister.PasswordChar = '*';
            txtPasswordRegister.PlaceholderText = "Contraseña";
            txtPasswordRegister.Size = new Size(258, 23);
            txtPasswordRegister.TabIndex = 3;
            // 
            // txtUserRegister
            // 
            txtUserRegister.Location = new Point(90, 90);
            txtUserRegister.Name = "txtUserRegister";
            txtUserRegister.PlaceholderText = "Usuario";
            txtUserRegister.Size = new Size(258, 23);
            txtUserRegister.TabIndex = 2;
            // 
            // registroUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(588, 502);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registroUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "registroUsuarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button btnRegister;
        private TextBox txtPasswordRegister;
        private TextBox txtUserRegister;
        private TextBox txtValidarPassword;
        private CheckBox showPass;
        private Button btnRgistV;
        private Label label5;
        private ComboBox cmbRol;
        private Label label6;
    }
}