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

namespace UITiendaCosmeticos
{
    public partial class PantallaGerente : Form
    {
        private Usuario _usuario;
        public PantallaGerente(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            PlasmarRol();
        }

        private void PlasmarRol()
        {
            tboxROLG.Text = _usuario.Rol;
        }

        private void PantallaGerente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
