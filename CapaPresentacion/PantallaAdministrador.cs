using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PantallaAdministrador : Form
    {
        private UsuarioEntidad _usuario;

        public PantallaAdministrador(UsuarioEntidad usuario)
        {
            InitializeComponent();
            _usuario = usuario; 
        }

        /*public PantallaAdministrador(UsuarioEntidad usuario)
        {
            this._usuario = usuario;
        }*/

        private void PlasmarRol()
        {
            label1.Text = "Rol de usuario";
            label2.Text = _usuario.Rol;
        }

        private void PantallaAdministrador_Load(object sender, EventArgs e)
        {
            PlasmarRol();

            /*BLL.Producto productos = new BLL.Producto();

            grillaProductos.DataSource = productos.ListarProductosBD();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerProductos ptallaProd = new VerProductos();
            ptallaProd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerUsuarios verUsuarios = new VerUsuarios();

            verUsuarios.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PantallaHistorialVentas ptallaHistorialVentas = new PantallaHistorialVentas();
            ptallaHistorialVentas.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Estas seguro de cerrar sesion?",
                                     "Salir",
                                     MessageBoxButtons.YesNo);
            if (confirmar == DialogResult.Yes)
            {
                this.Close();

                Inicio pantallaInicio = new Inicio();
                pantallaInicio.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantallaClientes ptallaCliente = new PantallaClientes();   
            ptallaCliente.ShowDialog();
        }
    }
}
