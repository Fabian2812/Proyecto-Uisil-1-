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

            txtContrase�a.Text = " Ingrese Su contrase�a";
            txtContrase�a.ForeColor = Color.Gray;
            txtContrase�a.Click += txtContrase�a_Click;
            txtContrase�a.Leave += txtContrase�a_Leave;
            txtContrase�a.PasswordChar = '\0';
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
