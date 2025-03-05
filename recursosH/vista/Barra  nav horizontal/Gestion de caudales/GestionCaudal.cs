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
            var permisos = Validaciones.ObtenerPermisosPorRol(idRolUsuarioLogueado.ToString());

            // Habilitar o deshabilitar botones según los permisos
            btnCrear.Enabled = permisos.Contains("create");
            btnActualizar.Enabled = permisos.Contains("update");
            btnEliminar.Enabled = permisos.Contains("delete");
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
