﻿using recursosH.Modelo;
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
   
    public partial class GestiónEntidades : Form
    {
        private int idRolUsuarioLogueado;
        public GestiónEntidades(int idRolUsuarioLogueado)
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCantones_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbDistritos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEntidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
