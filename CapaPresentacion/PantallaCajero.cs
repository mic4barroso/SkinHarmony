using BLL;
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
        Usuario _usuario;
        public PantallaCajero(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

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
    }
}
