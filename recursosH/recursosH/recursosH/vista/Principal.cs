using recursosH.vista.Barra__nav_horizontal.Gestion_de_caudales;
using recursosH.vista.Barra_de_navegacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recursosH.vista
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
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
        private void btnInicio_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();


            this.Hide();


            form.Show();
        }

        private void btnGestionentidad_Click(object sender, EventArgs e)
        {
            GestiónEntidades form = new GestiónEntidades();
            AbrirFormHija(form);
        }

        private void btnGestionnaciente_Click(object sender, EventArgs e)
        {
            GestiónNacientes form = new GestiónNacientes();
            AbrirFormHija(form);
        }

        private void btnGestionusuarios_Click(object sender, EventArgs e)
        {
            GestiónUsuarios form = new GestiónUsuarios();
            AbrirFormHija(form);
        }



       
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar form = new Buscar();
            AbrirFormHija(form);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login form = new Login();


            this.Close();


            form.Show();
        }

        private void panelhijo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGestionCaudal_Click(object sender, EventArgs e)
        {
            GestionCaudal  form = new GestionCaudal();
            AbrirFormHija(form);
        }
    }
}
