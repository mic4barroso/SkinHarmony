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
    public partial class PantallaGestionProductos : Form
    {
        public PantallaGestionProductos()
        {
            InitializeComponent();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            PantallaAgregarProducto pantallaAgregarProd = new PantallaAgregarProducto();
            pantallaAgregarProd.ShowDialog();

        }

        private void PantallaGestionProductos_Load(object sender, EventArgs e)
        {
            BLL.Producto producto = new BLL.Producto();

            grillaProductos.DataSource = producto.ListarProductosBD();
        }
    }
}
