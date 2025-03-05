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
            txtCorreoUsuario.Text = "Example@correo.com";
            txtCorreoUsuario.ForeColor = Color.Gray;
            txtCorreoUsuario.Click += txtCorreoU_Click;
            txtCorreoUsuario.Leave += txtCorreoU_Leave;

            txtNombreUsuario.Text = "Tomas Turbado";
            txtNombreUsuario.ForeColor = Color.Gray;
            txtNombreUsuario.Click += txtNombreU_Click;
            txtNombreUsuario.Leave += txtNombreU_Leave;

            txtPasswordUsuario.Text = "Ingresa tu contraseña ";
            txtPasswordUsuario.ForeColor = Color.Gray;
            txtPasswordUsuario.Click += txtPasswordU_Click;
            txtPasswordUsuario.Leave += txtPasswordU_Leave;
            txtPasswordUsuario.PasswordChar = '\0';


        }
        private void txtCorreoU_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreoUsuario.Text))
            {
                txtCorreoUsuario.Text = "Example@correo.com";
                txtCorreoUsuario.ForeColor = Color.Gray;
            }
        }
        private void txtCorreoU_Click(object sender, EventArgs e)
        {
            {
                txtCorreoUsuario.Text = "";
                txtCorreoUsuario.ForeColor = Color.Black;
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
                txtNombreUsuario.Text = "";
                txtNombreUsuario.ForeColor = Color.Black;
            }
        }
        private void txtNombreU_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                txtNombreUsuario.Text = "Tomas Turbado";
                txtNombreUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtPasswordU_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPasswordU_Click(object sender, EventArgs e)
        {
            {
                txtPasswordUsuario.Text = "";
                txtPasswordUsuario.ForeColor = Color.Black;
                txtPasswordUsuario.PasswordChar = '*';

            }
        }
        private void txtPasswordU_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasswordUsuario.Text))
            {
                txtPasswordUsuario.Text = "Ingrese su contraseña";
                txtPasswordUsuario.PasswordChar = '\0';
                txtPasswordUsuario.ForeColor = Color.Gray;

            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void bntBuscarU_Click(object sender, EventArgs e)
        {
            private void CargarDatosUsuario(int idUsuario)
        {
            // Cargar la lista de usuarios desde el JSON
            var usuarios = DataInitializer.LoadData<List<Usuario>>("Usuarios");

            // Buscar el usuario por ID
            var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);

            if (usuario != null)
            {
                // Cargar los datos del usuario en los campos del formulario
                txtId.Text = usuario.Id.ToString();
                txtNombre.Text = usuario.Nombre_Usuario;
                txtPrimerApellido.Text = usuario.PrimerApellido;
                txtSegundoApellido.Text = usuario.SegundoApellido;
                txtCorreo.Text = usuario.Correo;
                txtContrasena.Text = usuario.Contrasena;
                cmbRoles.SelectedValue = usuario.Id_Rol;
                txtIdEntidad.Text = usuario.Id_Entidad.ToString();

                // Bloquear el campo de ID
                txtId.Enabled = false; // El ID no se puede editar
            }
            else
            {
                MessageBox.Show("El usuario no existe.");
            }
        }
    }
    }
}
