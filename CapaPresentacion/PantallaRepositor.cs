﻿using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PantallaRepositor : Form
    {
        Usuario _usuario;
        public PantallaRepositor(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
        private void PlasmarRol()
        {
            label1.Text = "Rol de usuario";
            lblUsuario.Text = _usuario.Rol;
        }


        private void PantallaRepositor_Load(object sender, EventArgs e)
        {
            PlasmarRol();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaGestionProductos pantallaGestionProductos = new PantallaGestionProductos();
            pantallaGestionProductos.ShowDialog();
        }
    }
}