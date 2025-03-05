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

            txtContrase�a.Text = " Ingrese Su contrase�a";
            txtContrase�a.ForeColor = Color.Gray;
            txtContrase�a.Click += txtContrase�a_Click;
            txtContrase�a.Leave += txtContrase�a_Leave;
            txtContrase�a.PasswordChar = '\0';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int idRolUsuarioLogueado; // Variable para almacenar el Id_Rol del usuario logueado
        private void button1_Click(object sender, EventArgs e)
        {
            string correo = txtIngreso.Text;
            string contrasena = txtContrase�a.Text;

            // Validar el login
            Usuario usuarioLogueado = ValidarLogin(correo, contrasena);

            if (usuarioLogueado != null)
            {
                // Guardar el Id_Rol del usuario logueado
                idRolUsuarioLogueado = usuarioLogueado.Id_Rol;
                
                // Mostrar el formulario de gesti�n de usuarios
                Gesti�nUsuarios gestionUsuario = new Gesti�nUsuarios(idRolUsuarioLogueado);
                Gesti�nEntidades gesti�nEntidades = new Gesti�nEntidades(idRolUsuarioLogueado);
                GestionCaudal gestionCaudal = new GestionCaudal(idRolUsuarioLogueado);
                Gesti�nNacientes gesti�nNacientes = new Gesti�nNacientes(idRolUsuarioLogueado);
                gestionUsuario.Show();

                this.Hide(); // Ocultar el formulario de login
            }
            else
            {
                MessageBox.Show("Error: Correo o contrase�a incorrectos.");
            }
        }


            private Usuario ValidarLogin(string correo, string contrasena)
        {
            // Cargar la lista de usuarios desde el JSON
            var usuarios = DataInitializer.LoadData<List<Usuario>>("Usuarios");

            // Buscar el usuario por correo y contrase�a
            var usuario = usuarios.FirstOrDefault(u => u.Correo == correo && u.Contrasena == contrasena);

            if (usuario != null)
            {
                // Mensaje de depuraci�n
                MessageBox.Show($"Login exitoso. Rol del usuario: {usuario.Id_Rol}");

                return usuario; // Retorna el usuario encontrado
            }
            else
            {
                return null; // Retorna null si no se encuentra el usuario
            }
        }
        

        private void txtContrase�a_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void txtContrase�a_Click(object sender, EventArgs e)
        {
            {
                txtContrase�a.Text = "";
                txtContrase�a.ForeColor = Color.Black;
                txtContrase�a.PasswordChar = '*'; 
            }
        }
        private void txtContrase�a_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrase�a.Text))
            {
                txtContrase�a.Text = "Ingrese su contrase�a";
                txtContrase�a.PasswordChar = '\0';
                txtContrase�a.ForeColor = Color.Gray;
                
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
