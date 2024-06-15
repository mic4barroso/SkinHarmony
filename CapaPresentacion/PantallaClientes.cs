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
    public partial class PantallaClientes : Form
    {
        public PantallaClientes()
        {
            InitializeComponent();
        }

        private void PantallaClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
        private void CargarClientes()
        {
            Cliente clienteBLL = new Cliente();
            List<Cliente> listaClientes = clienteBLL.ListarClientesBD();
            dgvClientes.DataSource = listaClientes;
        }
    }
}
