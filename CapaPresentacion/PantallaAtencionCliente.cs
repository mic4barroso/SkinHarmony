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
    public partial class PantallaAtencionCliente : Form
    {
        private UsuarioEntidad _usuario;

        public PantallaAtencionCliente(UsuarioEntidad usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        /*public PantallaAtencionCliente(UsuarioEntidad usuario)
        {
            this.usuario = usuario;
        }*/

        private void PlasmarRol()
        {
            label1.Text = "Rol de usuario";
            lblUsuario.Text = _usuario.Rol;
        }

        private void PantallaAtencionCliente_Load(object sender, EventArgs e)
        {
            PlasmarRol();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PantallaClientes ptallaCte = new PantallaClientes();
            ptallaCte.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PantallaVenta ptallaVenta = new PantallaVenta();
            ptallaVenta.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            PantallaHistorialVentas ptallaHistorial = new PantallaHistorialVentas();
            ptallaHistorial.Show();
        }
    }
}
