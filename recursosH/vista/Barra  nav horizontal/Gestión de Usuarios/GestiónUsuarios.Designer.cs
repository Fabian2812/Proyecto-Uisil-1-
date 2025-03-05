namespace recursosH.vista.Barra_de_navegacion
{
    partial class GestiónUsuarios
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
            btnLista = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnCrear = new Button();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            txtIdUsuario = new TextBox();
            label7 = new Label();
            cbxUsuario = new ComboBox();
            cbRolU = new ComboBox();
            txtPasswordUsuario = new TextBox();
            txtCorreoUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bntBuscarU = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bntBuscarU);
            panel1.Controls.Add(btnLista);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnCrear);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1139, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(123, 797);
            panel1.TabIndex = 0;
            // 
            // btnLista
            // 
            btnLista.Dock = DockStyle.Top;
            btnLista.FlatAppearance.BorderSize = 0;
            btnLista.FlatStyle = FlatStyle.Flat;
            btnLista.Location = new Point(0, 180);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(123, 60);
            btnLista.TabIndex = 3;
            btnLista.Text = "Lista de Usuarios";
            btnLista.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Dock = DockStyle.Top;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(0, 120);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(123, 60);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Dock = DockStyle.Top;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Location = new Point(0, 60);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(123, 60);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Dock = DockStyle.Top;
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Location = new Point(0, 0);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(123, 60);
            btnCrear.TabIndex = 0;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1139, 797);
            panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImageLayout = ImageLayout.None;
            groupBox1.Controls.Add(txtIdUsuario);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cbxUsuario);
            groupBox1.Controls.Add(cbRolU);
            groupBox1.Controls.Add(txtPasswordUsuario);
            groupBox1.Controls.Add(txtCorreoUsuario);
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(1139, 797);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Formulario ";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            txtIdUsuario.Location = new Point(226, 130);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(371, 29);
            txtIdUsuario.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 138);
            label7.Name = "label7";
            label7.Size = new Size(24, 21);
            label7.TabIndex = 12;
            label7.Text = "Id";
            // 
            // cbxUsuario
            // 
            cbxUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            cbxUsuario.FormattingEnabled = true;
            cbxUsuario.Items.AddRange(new object[] { "ASADA:", "Municipalidad:" });
            cbxUsuario.Location = new Point(229, 328);
            cbxUsuario.Name = "cbxUsuario";
            cbxUsuario.Size = new Size(368, 29);
            cbxUsuario.TabIndex = 10;
            // 
            // cbRolU
            // 
            cbRolU.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            cbRolU.FormattingEnabled = true;
            cbRolU.Items.AddRange(new object[] { "Superadministrador:", "Administrador:", "Digitador:" });
            cbRolU.Location = new Point(229, 283);
            cbRolU.Name = "cbRolU";
            cbRolU.Size = new Size(368, 29);
            cbRolU.TabIndex = 9;
            // 
            // txtPasswordUsuario
            // 
            txtPasswordUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            txtPasswordUsuario.Location = new Point(226, 241);
            txtPasswordUsuario.Name = "txtPasswordUsuario";
            txtPasswordUsuario.Size = new Size(371, 29);
            txtPasswordUsuario.TabIndex = 8;
            txtPasswordUsuario.TextChanged += txtPasswordU_TextChanged;
            // 
            // txtCorreoUsuario
            // 
            txtCorreoUsuario.BackColor = SystemColors.Window;
            txtCorreoUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            txtCorreoUsuario.ForeColor = SystemColors.WindowFrame;
            txtCorreoUsuario.Location = new Point(226, 201);
            txtCorreoUsuario.Name = "txtCorreoUsuario";
            txtCorreoUsuario.Size = new Size(371, 29);
            txtCorreoUsuario.TabIndex = 7;
            txtCorreoUsuario.Text = "Example@correo.com";
            txtCorreoUsuario.TextChanged += txtCorreoU_TextChanged;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            txtNombreUsuario.Location = new Point(226, 166);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(371, 29);
            txtNombreUsuario.TabIndex = 6;
            txtNombreUsuario.TextChanged += txtNombreU_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(40, 328);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 4;
            label5.Text = "Entidad ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 286);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 3;
            label4.Text = "Rol Asignado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 244);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 2;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 208);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 1;
            label2.Text = "Correo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 166);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido:  ";
            // 
            // bntBuscarU
            // 
            bntBuscarU.Dock = DockStyle.Top;
            bntBuscarU.FlatAppearance.BorderSize = 0;
            bntBuscarU.FlatStyle = FlatStyle.Flat;
            bntBuscarU.Location = new Point(0, 240);
            bntBuscarU.Name = "bntBuscarU";
            bntBuscarU.Size = new Size(123, 60);
            bntBuscarU.TabIndex = 4;
            bntBuscarU.Text = "Buscar Usuario";
            bntBuscarU.UseVisualStyleBackColor = true;
            bntBuscarU.Click += bntBuscarU_Click;
            // 
            // GestiónUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 797);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GestiónUsuarios";
            Text = "GestiónUsuarios";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLista;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnCrear;
        private Panel panel2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbRolU;
        private TextBox txtPasswordUsuario;
        private TextBox txtCorreoUsuario;
        private TextBox txtNombreUsuario;
        private Label label5;
        private ComboBox cbxUsuario;
        private Label label7;
        private TextBox txtIdUsuario;
        private Button bntBuscarU;
    }
}