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
            BLL.Producto producto = new BLL.Producto();

            grillaProductos.DataSource = producto.ListarProductosBD();
        }

        private void btnGestionProductos_Click(object sender, EventArgs e)
        {
            PantallaGestionProductos pantallaGestionProductos = new PantallaGestionProductos();

            pantallaGestionProductos.ShowDialog();
        }

        private void grillaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
