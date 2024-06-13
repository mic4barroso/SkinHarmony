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
    public partial class PantallaRepositor : Form
    {
        private UsuarioEntidad _usuario;

        public PantallaRepositor(UsuarioEntidad usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        /*public PantallaRepositor(UsuarioEntidad usuario)
        {
            this.usuario = usuario;
        }*/

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

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
