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
        private int idRolUsuarioLogueado;
        public GestiónUsuarios(int idRolUsuarioLogueado)
        {
            InitializeComponent();
            this.idRolUsuarioLogueado = idRolUsuarioLogueado;
            ConfigurarBotonesSegunRol();
            txtCorreoUsuario.Text = "Example@correo.com";
            txtCorreoUsuario.ForeColor = Color.Gray;
            txtCorreoUsuario.Click += txtCorreoU_Click;
            txtCorreoUsuario.Leave += txtCorreoU_Leave;

            txtNombreUsuario.Text = "Fernando";
            txtNombreUsuario.ForeColor = Color.Gray;
            txtNombreUsuario.Click += txtNombreU_Click;
            txtNombreUsuario.Leave += txtNombreU_Leave;

            txtPasswordUsuario.Text = "Ingresa tu contraseña ";
            txtPasswordUsuario.ForeColor = Color.Gray;
            txtPasswordUsuario.Click += txtPasswordU_Click;
            txtPasswordUsuario.Leave += txtPasswordU_Leave;
            txtPasswordUsuario.PasswordChar = '\0';


        }
        private void ConfigurarBotonesSegunRol()
        {
            // Obtener los permisos del rol del usuario logueado
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioLogueado.ToString());

            // Habilitar o deshabilitar botones según los permisos
            btnCrear.Enabled = permisos.Contains("create");
            btnActualizar.Enabled = permisos.Contains("update");
            btnEliminar.Enabled = permisos.Contains("delete");
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
                txtNombreUsuario.Text = "Fernando";
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
            // Obtener los datos del formulario
            var nuevoUsuario = new Usuario
            {
                Id = int.Parse(txtIdUsuario.Text),
                Nombre_Usuario = txtNombreUsuario.Text,
                PrimerApellido = txtPrimerApellidoUsuario.Text,
                SegundoApellido = txtSegundoApellidoUsuario.Text,
                Correo = txtCorreoUsuario.Text,
                Contrasena = txtPasswordUsuario.Text,
                Id_Rol = int.Parse(cbRolU.SelectedValue.ToString()),
                Id_Entidad = int.Parse(cbxUsuario.Text)
            };

            // Llamar al método para guardar el nuevo usuario
            DataInitializer.GuardarUsuarios(new List<Usuario> { nuevoUsuario }, idRolUsuarioLogueado);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            var usuarioEditado = new Usuario
            {
                Id = int.Parse(txtIdUsuario.Text),
                Nombre_Usuario = txtNombreUsuario.Text,
                PrimerApellido = txtPrimerApellidoUsuario.Text,
                SegundoApellido = txtSegundoApellidoUsuario.Text,
                Correo = txtCorreoUsuario.Text,
                Contrasena = txtPasswordUsuario.Text,
                Id_Rol = int.Parse(cbRolU.SelectedValue.ToString()),
                Id_Entidad = int.Parse(cbxUsuario.Text)
            };

            // Llamar al método para editar el usuario
            DataInitializer.EditarUsuario(usuarioEditado, idRolUsuarioLogueado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del usuario a eliminar
            int idUsuarioAEliminar = int.Parse(txtIdUsuario.Text);

            // Llamar al método para eliminar el usuario
            DataInitializer.EliminarUsuario(idUsuarioAEliminar, idRolUsuarioLogueado);
        }

        private void bntBuscarU_Click(object sender, EventArgs e)
        {
            // Obtener el ID del usuario desde un TextBox (por ejemplo, txtIdBuscar)
            if (int.TryParse(txtIdUsuario.Text, out int idUsuario))
            {
                CargarDatosUsuario(idUsuario);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }
        private void CargarDatosUsuario(int idUsuario)
        {
            // Cargar la lista de usuarios desde el JSON
            var usuarios = DataInitializer.LoadData<List<Usuario>>("Usuarios");

            // Buscar el usuario por ID
            var usuario = usuarios.FirstOrDefault(u => u.Id == idUsuario);

            if (usuario != null)
            {
                // Cargar los datos del usuario en los campos del formulario
                txtIdUsuario.Text = usuario.Id.ToString();
                txtNombreUsuario.Text = usuario.Nombre_Usuario;
                txtPrimerApellidoUsuario.Text = usuario.PrimerApellido;
                txtSegundoApellidoUsuario.Text = usuario.SegundoApellido;
                txtCorreoUsuario.Text = usuario.Correo;
                txtPasswordUsuario.Text = usuario.Contrasena;
                cbRolU.SelectedValue = usuario.Id_Rol;
                cbxUsuario.Text = usuario.Id_Entidad.ToString();
                // Bloquear el campo de ID
                txtIdUsuario.Enabled = false; // El ID no se puede editar
            }
            else
            {
                MessageBox.Show("El usuario no existe.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

