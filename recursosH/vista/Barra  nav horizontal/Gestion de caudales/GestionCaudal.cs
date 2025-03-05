using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recursosH.vista.Barra__nav_horizontal.Gestion_de_caudales
{
    public partial class GestionCaudal : Form
    {
        private int idRolUsuarioLogueado;
        public GestionCaudal(int idRolUsuarioLogueado)
        {
            InitializeComponent();
            this.idRolUsuarioLogueado = idRolUsuarioLogueado;
            ConfigurarBotonesSegunRol();
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtidC.Text) ||
                string.IsNullOrEmpty(txtcapacidadC.Text) ||
                string.IsNullOrEmpty(txtmetodoC.Text) ||
                string.IsNullOrEmpty(txtobservacionC.Text) ||
                string.IsNullOrEmpty(dtpfechaC.Text) ||
                string.IsNullOrEmpty(txtclimaC.Text) ||
                string.IsNullOrEmpty(txtrealizadoC.Text) ||
                string.IsNullOrEmpty(txtnacienteC.Text) ||
                string.IsNullOrEmpty(txtsitioMuestreoC.Text))
            {
                MessageBox.Show("Error: Todos los campos son obligatorios.");
                return;
            }

            // Validar que los campos sean números válidos
            if (!int.TryParse(txtidC.Text, out int idCaudal) ||
                !int.TryParse(txtcapacidadC.Text, out int capacidad) ||
                !int.TryParse(txtnacienteC.Text, out int idNaciente) ||
                !int.TryParse(txtsitioMuestreoC.Text, out int idSitioMuestreo))
            {
                MessageBox.Show("Error: Los campos ID, Capacidad, Naciente y Sitio de Muestreo deben ser números válidos.");
                return;
            }

            // Obtener los datos del formulario
            var nuevaMedicion = new MedicionDeCaudal
            {
                Id = idCaudal,
                Capacidad = capacidad,
                Metodo = txtmetodoC.Text,
                Observacione = txtobservacionC.Text,
                Fecha = DateTime.Parse(dtpfechaC.Text),
                Clima = txtclimaC.Text,
                Realizado = txtrealizadoC.Text,
                Id_Naciente = idNaciente,
                Id_SitioDeMuestreo = idSitioMuestreo
            };

            // Llamar al método para guardar la nueva medición de caudal
            DataInitializer.GuardarMedicionDeCaudal(nuevaMedicion, idRolUsuarioLogueado);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtidC.Text) ||
                string.IsNullOrEmpty(txtcapacidadC.Text) ||
                string.IsNullOrEmpty(txtmetodoC.Text) ||
                string.IsNullOrEmpty(txtobservacionC.Text) ||
                string.IsNullOrEmpty(dtpfechaC.Text) ||
                string.IsNullOrEmpty(txtclimaC.Text) ||
                string.IsNullOrEmpty(txtrealizadoC.Text) ||
                string.IsNullOrEmpty(txtnacienteC.Text) ||
                string.IsNullOrEmpty(txtsitioMuestreoC.Text))
            {
                MessageBox.Show("Error: Todos los campos son obligatorios.");
                return;
            }

            // Validar que los campos sean números válidos
            if (!int.TryParse(txtidC.Text, out int idCaudal) ||
                !int.TryParse(txtcapacidadC.Text, out int capacidad) ||
                !int.TryParse(txtnacienteC.Text, out int idNaciente) ||
                !int.TryParse(txtsitioMuestreoC.Text, out int idSitioMuestreo))
            {
                MessageBox.Show("Error: Los campos ID, Capacidad, Naciente y Sitio de Muestreo deben ser números válidos.");
                return;
            }

            // Obtener los datos del formulario
            var medicionEditada = new MedicionDeCaudal
            {
                Id = idCaudal,
                Capacidad = capacidad,
                Metodo = txtmetodoC.Text,
                Observacione = txtobservacionC.Text,
                Fecha = DateTime.Parse(dtpfechaC.Text),
                Clima = txtclimaC.Text,
                Realizado = txtrealizadoC.Text,
                Id_Naciente = idNaciente,
                Id_SitioDeMuestreo = idSitioMuestreo
            };

            // Llamar al método para editar la medición de caudal
            DataInitializer.EditarMedicionDeCaudal(medicionEditada, idRolUsuarioLogueado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la medición de caudal a eliminar
            if (!int.TryParse(txtidC.Text, out int idCaudal))
            {
                MessageBox.Show("Error: El ID de la medición de caudal no es válido.");
                return;
            }

            // Llamar al método para eliminar la medición de caudal
            DataInitializer.EliminarMedicionDeCaudal(idCaudal, idRolUsuarioLogueado);
        }
    }

}
