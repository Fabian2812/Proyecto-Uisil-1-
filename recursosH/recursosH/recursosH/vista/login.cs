using recursosH.vista;

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
            txtId.Text = "ID = a correo";
            txtId.ForeColor = Color.Gray;
            txtId.Click += txtId_Click;
            txtId.Leave += txtId_Leave;

            txtContraseña.Text = " Ingrese Su contraseña";
            txtContraseña.ForeColor = Color.Gray;
            txtContraseña.Click += txtContraseña_Click;
            txtContraseña.Leave += txtContraseña_Leave;
            txtContraseña.PasswordChar = '\0';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal form = new Principal();


            this.Hide();


            form.Show();
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
                txtId.Text = "";
                txtId.ForeColor = Color.Black;
            }
        }
        private void txtId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                txtId.Text = "ID = Correo ";
                txtId.ForeColor = Color.Gray;
            }
        }
    }
}
