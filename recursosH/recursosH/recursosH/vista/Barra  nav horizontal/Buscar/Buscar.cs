using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace recursosH.vista.Barra_de_navegacion
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
            txtSearch.Text = "Busqueda ";
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Leave += textsearch_Leave;
            txtSearch.Click += textsearch_Click;
        }
        private void AbrirFormHija(Form formHija)
        {

            // Si ya hay un formulario cargado en el panel, lo elimina
            if (this.panelhijo.Controls.Count > 0)
                this.panelhijo.Controls.RemoveAt(0);

            // Configura el formulario hijo sin bordes y ocupando todo el panel
            formHija.TopLevel = false;
            formHija.FormBorderStyle = FormBorderStyle.None;
            formHija.Dock = DockStyle.Fill;

            // Agrega el formulario hijo al panel y lo muestra
            this.panelhijo.Controls.Add(formHija);
            this.panelhijo.Tag = formHija;
            formHija.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void textsearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Busqueda ";
            txtSearch.ForeColor = Color.Gray;



        }
        private void textsearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.ForeColor = Color.Black;
        }

        private void panelhijo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
