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
    public partial class PantallaAgregarProducto : Form
    {

        private ProductoDAL productoDAL = new ProductoDAL();

        public PantallaAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoEntidad producto = new ProductoEntidad
                {
                    Nombre = tboxNombre.Text,
                    Categoria = tboxCategoria.Text,
                    Precio = decimal.Parse(tboxPrecio.Text),
                    Stock = int.Parse(tboxStock.Text),
                    Descripcion = tboxDesc.Text,
                    Color = tboxColor.Text,
                    Marca = tboxMarca.Text
                };

                bool exito = productoDAL.InsertarProducto(producto);

                if (exito)
                {
                    MessageBox.Show("Producto agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al agregar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void PantallaAgregarProducto_Load(object sender, EventArgs e)
        {

        }

        private void tboxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

