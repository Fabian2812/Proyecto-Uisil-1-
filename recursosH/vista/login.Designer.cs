namespace recursosH
{
    partial class Login
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
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            button1 = new Button();
            txtContraseña = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 78);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(270, 29);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Recursos";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(groupBox2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 372);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 372);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(txtContraseña);
            groupBox2.Controls.Add(txtId);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(194, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(486, 369);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acceso";
            // 
            // button1
            // 
            button1.Location = new Point(175, 246);
            button1.Name = "button1";
            button1.Size = new Size(75, 43);
            button1.TabIndex = 4;
            button1.Text = "Ingresar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 12F);
            txtContraseña.Location = new Point(101, 173);
            txtContraseña.Multiline = true;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(233, 30);
            txtContraseña.TabIndex = 3;
            txtContraseña.WordWrap = false;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(101, 103);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.Size = new Size(233, 30);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 206);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 1;
            label3.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(183, 69);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "ID USER";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private TextBox txtContraseña;
        private Button button1;
    }
}
