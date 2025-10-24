namespace loginUsuarios
{
    partial class FormAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPanel));
            btnDesbloquear = new Button();
            dgvUsuarios = new DataGridView();
            lblSeleccionado = new Label();
            cmbRol = new ComboBox();
            btnCambiarRol = new Button();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDesbloquear
            // 
            btnDesbloquear.FlatStyle = FlatStyle.Flat;
            btnDesbloquear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnDesbloquear.ForeColor = Color.WhiteSmoke;
            btnDesbloquear.Location = new Point(13, 225);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(186, 32);
            btnDesbloquear.TabIndex = 7;
            btnDesbloquear.Text = "Desbloquear Usuario";
            btnDesbloquear.UseVisualStyleBackColor = true;
            btnDesbloquear.Click += btnDesbloquear_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.WhiteSmoke;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.GridColor = Color.WhiteSmoke;
            dgvUsuarios.Location = new Point(244, 91);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(719, 434);
            dgvUsuarios.TabIndex = 9;           
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lblSeleccionado.Location = new Point(263, 33);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(81, 24);
            lblSeleccionado.TabIndex = 10;
            lblSeleccionado.Text = "Usuario";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.WhiteSmoke;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FlatStyle = FlatStyle.Flat;
            cmbRol.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRol.ForeColor = Color.DimGray;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(13, 329);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(186, 28);
            cmbRol.TabIndex = 11;
            // 
            // btnCambiarRol
            // 
            btnCambiarRol.FlatStyle = FlatStyle.Flat;
            btnCambiarRol.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnCambiarRol.ForeColor = Color.WhiteSmoke;
            btnCambiarRol.Location = new Point(13, 377);
            btnCambiarRol.Name = "btnCambiarRol";
            btnCambiarRol.Size = new Size(186, 32);
            btnCambiarRol.TabIndex = 12;
            btnCambiarRol.Text = "Cambiar Rol";
            btnCambiarRol.UseVisualStyleBackColor = true;
            btnCambiarRol.Click += btnCambiarRol_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCambiarRol);
            panel1.Controls.Add(cmbRol);
            panel1.Controls.Add(btnDesbloquear);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 563);
            panel1.TabIndex = 13;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(0, 523);
            button1.Name = "button1";
            button1.Size = new Size(75, 37);
            button1.TabIndex = 16;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 148);
            label1.Name = "label1";
            label1.Size = new Size(199, 24);
            label1.TabIndex = 14;
            label1.Text = "Panel Administrativo";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(940, 9);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 14;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // FormAdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(975, 563);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(lblSeleccionado);
            Controls.Add(dgvUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAdminPanel";
            Load += FormAdminPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDesbloquear;
        private DataGridView dgvUsuarios;
        private Label lblSeleccionado;
        private ComboBox cmbRol;
        private Button btnCambiarRol;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label3;
        private Button button1;
    }
}