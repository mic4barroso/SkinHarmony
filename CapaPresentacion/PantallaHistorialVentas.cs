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

namespace CapaPresentacion
{
    public partial class PantallaHistorialVentas : Form
    {
        public PantallaHistorialVentas()
        {
            InitializeComponent();
        }

        private void PantallaHistorialVentas_Load(object sender, EventArgs e)
        {
            CargarVentasConDetalles();

        }
        private void CargarVentasConDetalles()
        {
            VentaDAL ventaDAL = new VentaDAL();
            DataTable dtVentasConDetalles = ventaDAL.ObtenerVentasConDetalles();
            dgvVentas.DataSource = dtVentasConDetalles;

            /*
            foreach (DataGridViewColumn column in dgvVentas.Columns)
            {
                if (column.Name != "FechaVenta" && column.Name != "NombreProducto")
                {
                    column.Visible = false;
                }
            }*/
        }
    }
}
