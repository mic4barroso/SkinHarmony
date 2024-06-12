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
    public partial class PantallaAdministrador : Form
    {
        private Usuario _usuario;
        public PantallaAdministrador(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            //PlasmarRol();
        }

        private void PlasmarRol()
        {
            label1.Text = "Rol de usuario";
            tboxROL.Text = _usuario.Rol;
        }

        private void PantallaAdministrador_Load(object sender, EventArgs e)
        {
            PlasmarRol();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
