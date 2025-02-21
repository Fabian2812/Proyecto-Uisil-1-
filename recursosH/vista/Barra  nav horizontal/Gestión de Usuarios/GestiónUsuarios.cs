using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recursosH.vista.Barra_de_navegacion
{
    public partial class GestiónUsuarios : Form
    {
        public GestiónUsuarios()
        {
            InitializeComponent();
            txtCorreoU.Text = "Example@correo.com";
            txtCorreoU.ForeColor = Color.Gray;
            txtCorreoU.Click += txtCorreoU_Click;
            txtCorreoU.Leave += txtCorreoU_Leave;

            txtNombreU.Text = "Tomas Turbado";
            txtNombreU.ForeColor = Color.Gray;
            txtNombreU.Click += txtNombreU_Click;
            txtNombreU.Leave += txtNombreU_Leave;

            txtPasswordU.Text = "Ingresa tu contraseña ";
            txtPasswordU.ForeColor = Color.Gray;
            txtPasswordU.Click += txtPasswordU_Click;
            txtPasswordU.Leave += txtPasswordU_Leave;
            txtPasswordU.PasswordChar = '\0';


        }
        private void txtCorreoU_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreoU.Text))
            {
                txtCorreoU.Text = "Example@correo.com";
                txtCorreoU.ForeColor = Color.Gray;
            }
        }
        private void txtCorreoU_Click(object sender, EventArgs e)
        {
            {
                txtCorreoU.Text = "";
                txtCorreoU.ForeColor = Color.Black;
            }

        }
        private void txtCorreoU_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreU_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNombreU_Click(object sender, EventArgs e)
        {
            {
                txtNombreU.Text = "";
                txtNombreU.ForeColor = Color.Black;
            }
        }
        private void txtNombreU_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreU.Text))
            {
                txtNombreU.Text = "Tomas Turbado";
                txtNombreU.ForeColor = Color.Gray;
            }
        }

        private void txtPasswordU_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPasswordU_Click(object sender, EventArgs e)
        {
            {
                txtPasswordU.Text = "";
                txtPasswordU.ForeColor = Color.Black;
                txtPasswordU.PasswordChar = '*';

            }
        }
        private void txtPasswordU_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasswordU.Text))
            {
                txtPasswordU.Text = "Ingrese su contraseña";
                txtPasswordU.PasswordChar = '\0';
                txtPasswordU.ForeColor = Color.Gray;

            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
