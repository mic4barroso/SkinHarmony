using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PantallaGerente : Form
    {
        Usuario _usuario;
        public PantallaGerente(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void PlasmarRol()
        {
            label1.Text = "Rol de usuario";
            label2.Text = _usuario.Rol;
        }

        private void PantallaGerente_Load(object sender, EventArgs e)
        {
            PlasmarRol();
        }
    }
}
