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
    public partial class VerProductos : Form
    {
        public VerProductos()
        {
            InitializeComponent();
        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            BLL.Producto productos = new BLL.Producto();

            grillaProductos.DataSource = productos.ListarProductosBD();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            PantallaGestionProductos pantallaGestionProductos = new PantallaGestionProductos();

            pantallaGestionProductos.ShowDialog();
        }
    }
}
