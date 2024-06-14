using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CapaPresentacion
{
    public partial class PantallaGestionProductos : Form
    {
        private ProductoDAL productoDAL = new ProductoDAL();
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

            CargarProductos();
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            if (grillaProductos.SelectedRows.Count > 0)
            {
                int idProducto = Convert.ToInt32(grillaProductos.SelectedRows[0].Cells["IdProducto"].Value);
                try
                {
                    bool exito = productoDAL.EliminarProducto(idProducto);
                    if (exito)
                    {
                        MessageBox.Show("Producto eliminado con éxito.");
                        grillaProductos.Rows.RemoveAt(grillaProductos.SelectedRows[0].Index);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }

        private void CargarProductos()
        {
            BLL.Producto producto = new BLL.Producto();
            grillaProductos.DataSource = producto.ListarProductosBD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grillaProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaProductos.MultiSelect = false; 

            int idProducto;
            if (int.TryParse(tboxID.Text, out idProducto))
            {
                DataTable productoData = productoDAL.ObtenerProductoPorId(idProducto);
                if (productoData.Rows.Count > 0)
                {
                    grillaProductos.DataSource = productoData;
                }
                else
                {
                    MessageBox.Show("No se encontró un producto con ese ID.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
            }
        }

        private void tboxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void grillaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificarProductos_Click(object sender, EventArgs e) {


            //PantallaModificarProducto pantallaModificarProd = new PantallaModificarProducto();
    }

        private void btnProductosProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}

