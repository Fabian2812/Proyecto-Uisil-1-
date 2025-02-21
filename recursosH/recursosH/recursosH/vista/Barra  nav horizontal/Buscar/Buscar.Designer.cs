using System.Windows.Controls;

namespace recursosH.vista.Barra_de_navegacion
{
    partial class Buscar
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
            checkedListBox1 = new CheckedListBox();
            panel1 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            checkedListBox2 = new CheckedListBox();
            txtSearch = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            panelhijo = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Usuarios ", "Entidades ", "Nacientes ", "Sitios de muestreo", "Mediciones " });
            checkedListBox1.Location = new Point(13, 146);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(207, 172);
            checkedListBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(checkedListBox2);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 551);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 3;
            label2.Text = "Filtros";
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Sitios de muestreo", "Metodo", "Municipalidades", "Nacientes", "ASADA ", "Usuarios", "Administradores ", "Super User ", "Digitatores", "Ubicacion" });
            checkedListBox2.Location = new Point(3, 145);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(176, 202);
            checkedListBox2.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(8, 59);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(199, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // panelhijo
            // 
            panelhijo.Dock = DockStyle.Fill;
            panelhijo.Location = new Point(210, 0);
            panelhijo.Name = "panelhijo";
            panelhijo.Size = new Size(1105, 551);
            panelhijo.TabIndex = 1;
            panelhijo.Paint += panelhijo_Paint;
            // 
            // Buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 551);
            Controls.Add(panelhijo);
            Controls.Add(panel1);
            Name = "Buscar";
            Text = "Buscar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private CheckedListBox checkedListBox2;
        private System.Windows.Forms.Panel panelhijo;
    }
}