using recursosH.vista;
using recursosH.vista.Barra__nav_horizontal.Gestion_de_caudales;
using recursosH.vista.Barra_de_navegacion;

namespace recursosH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtIngreso.Text = "ID = a correo";
            txtIngreso.ForeColor = Color.Gray;
            txtIngreso.Click += txtId_Click;
            txtIngreso.Leave += txtId_Leave;

            txtContraseña.Text = " Ingrese Su contraseña";
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Click += txtContraseña_Click;
            txtContraseña.Leave += txtContraseña_Leave;
            txtContraseña.PasswordChar = '\0';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int idRolUsuarioLogueado; // Variable para almacenar el Id_Rol del usuario logueado
        private void button1_Click(object sender, EventArgs e)
        {
            string correo = txtIngreso.Text;
            string contrasena = txtContraseña.Text;

            // Validar el login
            Usuario usuarioLogueado = ValidarLogin(correo, contrasena);

            if (usuarioLogueado != null)
            {
                // Guardar el Id_Rol del usuario logueado
                idRolUsuarioLogueado = usuarioLogueado.Id_Rol;
                
                // Mostrar el formulario de gestión de usuarios
                GestiónUsuarios gestionUsuario = new GestiónUsuarios(idRolUsuarioLogueado);
                GestiónEntidades gestiónEntidades = new GestiónEntidades(idRolUsuarioLogueado);
                GestionCaudal gestionCaudal = new GestionCaudal(idRolUsuarioLogueado);
                GestiónNacientes gestiónNacientes = new GestiónNacientes(idRolUsuarioLogueado);
                gestionUsuario.Show();

                this.Hide(); // Ocultar el formulario de login
            }
            else
            {
                MessageBox.Show("Error: Correo o contraseña incorrectos.");
            }
        }


            private Usuario ValidarLogin(string correo, string contrasena)
        {
            // Cargar la lista de usuarios desde el JSON
            var usuarios = DataInitializer.LoadData<List<Usuario>>("Usuarios");

            // Buscar el usuario por correo y contraseña
            var usuario = usuarios.FirstOrDefault(u => u.Correo == correo && u.Contrasena == contrasena);

            if (usuario != null)
            {
                // Mensaje de depuración
                MessageBox.Show($"Login exitoso. Rol del usuario: {usuario.Id_Rol}");

                return usuario; // Retorna el usuario encontrado
            }
            else
            {
                return null; // Retorna null si no se encuentra el usuario
            }
        }
        

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void txtContraseña_Click(object sender, EventArgs e)
        {
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.PasswordChar = '*'; 
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                txtContraseña.Text = "Ingrese su contraseña";
                txtContraseña.PasswordChar = '\0';
                txtContraseña.ForeColor = Color.Gray;
                
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtId_Click(object sender, EventArgs e)
        {
            {
                txtIngreso.Text = "";
                txtIngreso.ForeColor = Color.Black;
            }
        }
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIngreso.Text))
            {
                txtIngreso.Text = "ID = Correo ";
                txtIngreso.ForeColor = Color.Gray;
            }
        }
    }
}
