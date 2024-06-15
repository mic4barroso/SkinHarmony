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

namespace CapaPresentacion
{
    public partial class PantallaVerProveedores : Form
    {
        private Proovedor proovedorBLL = new Proovedor();
        public PantallaVerProveedores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarProveedores()
        {
            try
            {
                List<Proovedor> proveedores = proovedorBLL.ListarProveedores();

                dgvP.DataSource = proveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}");
            }
        }

        private void PantallaVerProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
    }
}
