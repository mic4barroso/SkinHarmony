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
    public partial class PantallaAdministrador : Form
    {
        Usuario _usuario;
        public PantallaAdministrador(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario; 
        }

        private void PlasmarRol()
        {
            label1.Text = "Rol de usuario";
            label2.Text = _usuario.Rol;
        }

        private void PantallaAdministrador_Load(object sender, EventArgs e)
        {
            PlasmarRol();

            /*BLL.Producto productos = new BLL.Producto();

            grillaProductos.DataSource = productos.ListarProductosBD();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerProductos verProductos = new VerProductos();

            verProductos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerUsuarios verUsuarios = new VerUsuarios();

            verUsuarios.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
