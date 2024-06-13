using BLL;
using Entidades;
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
    public partial class PantallaCajero : Form
    {
        private UsuarioEntidad _usuario;

        public PantallaCajero(UsuarioEntidad usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        /*public PantallaCajero(UsuarioEntidad usuario)
        {
            this._usuario = usuario;
        }*/

        private void PlasmarRol()
        {
            label1.Text = "Rol de usuario";
            lblUsuario.Text = _usuario.Rol;
        }

        private void PantallaCajero_Load(object sender, EventArgs e)
        {
            PlasmarRol();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
