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
    public partial class PantallaAtencionCliente : Form
    {
        Usuario _usuario;
        public PantallaAtencionCliente(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void PlasmarRol()
        {
            label1.Text = "Rol de usuario";
            lblUsuario.Text = _usuario.Rol;
        }

        private void PantallaAtencionCliente_Load(object sender, EventArgs e)
        {
            PlasmarRol();
        }
    }
}
