using DAL;
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
    public partial class PantallaModificarProducto : Form
    {
        private ProductoDAL productoDAL;
        private ProductoEntidad producto;
        public PantallaModificarProducto(ProductoEntidad producto, ProductoDAL productoDAL)
        {
            InitializeComponent();
            this.producto = producto;
            this.productoDAL = productoDAL;
            LlenarCamposProducto();
        }

        private void LlenarCamposProducto()
        {
            tboxNombre.Text = producto.Nombre;
            tboxCategoria.Text = producto.Categoria;
            tboxPrecio.Text = producto.Precio.ToString();
            tboxStock.Text = producto.Stock.ToString();
            tboxDesc.Text = producto.Descripcion;
            tboxColor.Text = producto.Color;
            tboxMarca.Text = producto.Marca;
        }

        private void PantallaModificarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
