namespace loginUsuarios
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            showPass_inicio = new CheckBox();
            btnRegister = new Button();
            label3 = new Label();
            btnLogin = new Button();
            txtPasswordLogin = new TextBox();
            txtUserLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(showPass_inicio);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPasswordLogin);
            panel1.Controls.Add(txtUserLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(85, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 314);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(164, 35);
            label4.Name = "label4";
            label4.Size = new Size(160, 24);
            label4.TabIndex = 10;
            label4.Text = "Inicio de Sesión";
            // 
            // showPass_inicio
            // 
            showPass_inicio.AutoSize = true;
            showPass_inicio.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPass_inicio.Location = new Point(265, 189);
            showPass_inicio.Name = "showPass_inicio";
            showPass_inicio.Size = new Size(101, 17);
            showPass_inicio.TabIndex = 9;
            showPass_inicio.Text = "Show password";
            showPass_inicio.UseVisualStyleBackColor = true;
            showPass_inicio.CheckedChanged += showPass_inicio_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.WhiteSmoke;
            btnRegister.Location = new Point(137, 243);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(464, 11);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 5;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(291, 243);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.Location = new Point(164, 150);
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.PasswordChar = '*';
            txtPasswordLogin.Size = new Size(202, 23);
            txtPasswordLogin.TabIndex = 3;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Location = new Point(164, 104);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(202, 23);
            txtUserLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(81, 152);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(81, 106);
            label1.Name = "label1";
            label1.Size = new Size(64, 17);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(678, 470);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogin;
        private TextBox txtPasswordLogin;
        private TextBox txtUserLogin;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnRegister;
        private CheckBox showPass_inicio;
        private Label label4;
    }
}
