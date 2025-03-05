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
    public partial class GestiónNacientes : Form
    {
        private int idRolUsuarioLogueado;
        public GestiónNacientes(int idRolUsuarioLogueado)
        {
            InitializeComponent();
            this.idRolUsuarioLogueado = idRolUsuarioLogueado;
            ConfigurarBotonesSegunRol();
            txtNombreN.Text = "Lean ";
            txtNombreN.ForeColor = Color.Gray;
            txtNombreN.Click += txtNombreN_Click;
            txtNombreN.Leave += txtNombreN_Leave;
        }
        private void ConfigurarBotonesSegunRol()
        {
            // Obtener los permisos del rol del usuario logueado
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioLogueado);

            // Habilitar o deshabilitar botones según los permisos
            btnCrear.Enabled = permisos.Contains("create");
            btnActualizar.Enabled = permisos.Contains("update");
            btnEliminar.Enabled = permisos.Contains("delete");
        }

        private void txtNombreN_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNombreN_Click(object sender, EventArgs e)
        {
            txtNombreN.Text = "";
            txtNombreN.ForeColor = Color.Black;

        }
        private void txtNombreN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreN.Text))
            {
                txtNombreN.Text = "Lean Drogado";
                txtNombreN.ForeColor = Color.Gray;
            }
        }
        private void txtDireccionN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtIDN.Text) ||
                string.IsNullOrEmpty(txtNombreN.Text) ||
                string.IsNullOrEmpty(txtDireccionN.Text) ||
                string.IsNullOrEmpty(txtLatitudN.Text) ||
                string.IsNullOrEmpty(txtLongitudN.Text) ||
                string.IsNullOrEmpty(txtDescripcionN.Text) ||
                string.IsNullOrEmpty(txtProvinciaN.Text) ||
                string.IsNullOrEmpty(txtCantonN.Text) ||
                string.IsNullOrEmpty(txtDescripcionN.Text) ||
                string.IsNullOrEmpty(textBox2N.Text))
            {
                MessageBox.Show("Error: Todos los campos son obligatorios.");
                return;
            }
            // Validar que los campos sean números válidos
            if (!int.TryParse(txtIDN.Text, out int idNaciente) ||
                !double.TryParse(txtLatitudN.Text, out double latitud) ||
                !double.TryParse(txtLongitudN.Text, out double longitud) ||
                !int.TryParse(txtProvinciaN.Text, out int idProvincia) ||
                !int.TryParse(txtCantonN.Text, out int idCanton) ||
                !int.TryParse(txtCantonN.Text, out int idDistrito) ||
                !int.TryParse(textBox2N.Text, out int idEntidad))
            {
                MessageBox.Show("Error: Los campos ID, Latitud, Longitud y selecciones deben ser números válidos.");
                return;
            }

            // Obtener los datos del formulario
            var nuevoNaciente = new Naciente
            {
                Id = idNaciente,
                Nombre_Naciente = txtNombreN.Text,
                Direccion_Naciente = txtDireccionN.Text,
                latitud = latitud,
                longitud = longitud,
                Descripcion_Naciente = txtDescripcionN.Text,
                Id_Provincia = idProvincia,
                Id_Canton = idCanton,
                Id_Distrito = idDistrito,
                Id_Entidad = idEntidad
            };

            // Llamar al método para guardar el nuevo naciente
            DataInitializer.GuardarNaciente(nuevoNaciente, idRolUsuarioLogueado);
        }


        private void txtIDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtIDN.Text) ||
                string.IsNullOrEmpty(txtNombreN.Text) ||
                string.IsNullOrEmpty(txtDireccionN.Text) ||
                string.IsNullOrEmpty(txtLatitudN.Text) ||
                string.IsNullOrEmpty(txtLongitudN.Text) ||
                string.IsNullOrEmpty(txtDescripcionN.Text) ||
                string.IsNullOrEmpty(txtProvinciaN.Text) ||
                string.IsNullOrEmpty(txtCantonN.Text) ||
                string.IsNullOrEmpty(txtDescripcionN.Text) ||
                string.IsNullOrEmpty(textBox2N.Text))
            {
                MessageBox.Show("Error: Todos los campos son obligatorios.");
                return;
            }

            // Validar que los campos sean números válidos
            if (!int.TryParse(txtIDN.Text, out int idNaciente) ||
                !double.TryParse(txtLatitudN.Text, out double latitud) ||
                !double.TryParse(txtLongitudN.Text, out double longitud) ||
                !int.TryParse(txtProvinciaN.Text, out int idProvincia) ||
                !int.TryParse(txtCantonN.Text, out int idCanton) ||
                !int.TryParse(txtDescripcionN.Text, out int idDistrito) ||
                !int.TryParse(textBox2N.Text, out int idEntidad))
            {
                MessageBox.Show("Error: Los campos ID, Latitud, Longitud y selecciones deben ser números válidos.");
                return;
            }

            // Obtener los datos del formulario
            var nacienteEditado = new Naciente
            {
                Id = idNaciente,
                Nombre_Naciente = txtNombreN.Text,
                Direccion_Naciente = txtDireccionN.Text,
                latitud = latitud,
                longitud = longitud,
                Descripcion_Naciente = txtDescripcionN.Text,
                Id_Provincia = idProvincia,
                Id_Canton = idCanton,
                Id_Distrito = idDistrito,
                Id_Entidad = idEntidad
            };

            // Llamar al método para editar el naciente
            DataInitializer.EditarNaciente(nacienteEditado, idRolUsuarioLogueado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID del naciente a eliminar
            if (!int.TryParse(txtIDN.Text, out int idNaciente))
            {
                MessageBox.Show("Error: El ID del naciente no es válido.");
                return;
            }

            // Llamar al método para eliminar el naciente
            DataInitializer.EliminarNaciente(idNaciente, idRolUsuarioLogueado);
        }

    }
}

