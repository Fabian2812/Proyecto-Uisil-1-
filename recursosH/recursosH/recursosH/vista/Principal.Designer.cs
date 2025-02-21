namespace recursosH.vista
{
    partial class Principal
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
            btnGestionCaudal = new Button();
            btnCerrar = new Button();
            btnBuscar = new Button();
            btnGestionusuarios = new Button();
            btnGestionnaciente = new Button();
            btnGestionentidad = new Button();
            btnInicio = new Button();
            panelhijo = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGestionCaudal);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnGestionusuarios);
            panel1.Controls.Add(btnGestionnaciente);
            panel1.Controls.Add(btnGestionentidad);
            panel1.Controls.Add(btnInicio);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 20);
            panel1.TabIndex = 0;
            // 
            // btnGestionCaudal
            // 
            btnGestionCaudal.Dock = DockStyle.Left;
            btnGestionCaudal.FlatAppearance.BorderSize = 0;
            btnGestionCaudal.FlatStyle = FlatStyle.Flat;
            btnGestionCaudal.Location = new Point(542, 0);
            btnGestionCaudal.Name = "btnGestionCaudal";
            btnGestionCaudal.Size = new Size(142, 20);
            btnGestionCaudal.TabIndex = 7;
            btnGestionCaudal.Text = "Gestion de Caudales";
            btnGestionCaudal.UseVisualStyleBackColor = true;
            btnGestionCaudal.Click += btnGestionCaudal_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(798, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(116, 20);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar Sesion";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(684, 0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 20);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGestionusuarios
            // 
            btnGestionusuarios.Dock = DockStyle.Left;
            btnGestionusuarios.FlatAppearance.BorderSize = 0;
            btnGestionusuarios.FlatStyle = FlatStyle.Flat;
            btnGestionusuarios.Location = new Point(400, 0);
            btnGestionusuarios.Name = "btnGestionusuarios";
            btnGestionusuarios.Size = new Size(142, 20);
            btnGestionusuarios.TabIndex = 3;
            btnGestionusuarios.Text = "Gestion de Usuarios";
            btnGestionusuarios.UseVisualStyleBackColor = true;
            btnGestionusuarios.Click += btnGestionusuarios_Click;
            // 
            // btnGestionnaciente
            // 
            btnGestionnaciente.Dock = DockStyle.Left;
            btnGestionnaciente.FlatAppearance.BorderSize = 0;
            btnGestionnaciente.FlatStyle = FlatStyle.Flat;
            btnGestionnaciente.Location = new Point(251, 0);
            btnGestionnaciente.Name = "btnGestionnaciente";
            btnGestionnaciente.Size = new Size(149, 20);
            btnGestionnaciente.TabIndex = 2;
            btnGestionnaciente.Text = "Gestionar Nacientes";
            btnGestionnaciente.UseVisualStyleBackColor = true;
            btnGestionnaciente.Click += btnGestionnaciente_Click;
            // 
            // btnGestionentidad
            // 
            btnGestionentidad.Dock = DockStyle.Left;
            btnGestionentidad.FlatAppearance.BorderSize = 0;
            btnGestionentidad.FlatStyle = FlatStyle.Flat;
            btnGestionentidad.Location = new Point(106, 0);
            btnGestionentidad.Name = "btnGestionentidad";
            btnGestionentidad.Size = new Size(145, 20);
            btnGestionentidad.TabIndex = 1;
            btnGestionentidad.Text = "Gestionar Entidades";
            btnGestionentidad.UseVisualStyleBackColor = true;
            btnGestionentidad.Click += btnGestionentidad_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Left;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Location = new Point(0, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(106, 20);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // panelhijo
            // 
            panelhijo.Dock = DockStyle.Fill;
            panelhijo.Location = new Point(0, 20);
            panelhijo.Name = "panelhijo";
            panelhijo.Size = new Size(914, 472);
            panelhijo.TabIndex = 1;
            panelhijo.Paint += panelhijo_Paint;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 492);
            Controls.Add(panelhijo);
            Controls.Add(panel1);
            Name = "Principal";
            Text = "Principal";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnInicio;
        private Button btnGestionentidad;
        private Button btnGestionnaciente;
        private Button btnGestionusuarios;
        private Button btnBuscar;
        private Panel panelhijo;
        private Button btnGestionCaudal;
        private Button btnCerrar;
    }
}