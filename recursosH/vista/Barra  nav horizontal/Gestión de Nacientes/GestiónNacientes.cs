﻿using System;
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
        public GestiónNacientes()
        {
            InitializeComponent();
                     

            txtNombreN.Text = "Lean Drogado";
            txtNombreN.ForeColor = Color.Gray;
            txtNombreN.Click += txtNombreN_Click;
            txtNombreN.Leave += txtNombreN_Leave;

            
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
    }
}
