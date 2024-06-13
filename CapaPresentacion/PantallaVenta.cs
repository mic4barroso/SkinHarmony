using Entidades;
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
    public partial class PantallaVenta : Form
    {
        ProductoEntidad producto;
        public PantallaVenta()
        {
            InitializeComponent();
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {
            lblPrecio.Text = producto.Precio.ToString();
        }

        private void PantallaVenta_Load(object sender, EventArgs e)
        {
            BLL.Producto producto = new BLL.Producto();

            dgvProductos.DataSource = producto.ListarProductosBD();

            BLL.Usuario usuario = new BLL.Usuario();

            dgvUsuarios.DataSource = usuario.ListarUsuariosBase();

        }
    }
}
