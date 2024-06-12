using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;

namespace UITiendaCosmeticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = tboxNombre.Text;
            string password = tboxContrasena.Text;

            BLL.Login login = new BLL.Login();
            Usuario usuario = login.IniciarSesion(username, password);

            if (usuario != null)
            {
                MessageBox.Show("Inicio de sesión exitoso");

                if (usuario.Rol == "administrador")
                {
                    MostrarPantallaAdministrador(usuario);
                }
                else if (usuario.Rol == "gerente")
                {
                    MostrarPantallaGerente(usuario);
                }
                else
                {
                    MessageBox.Show("Rol no reconocido.");
                }
            }
            else
            {
                MessageBox.Show("Inicio de sesión incorrecto");
            }

        }

        private void IniciarPantallaAdministrador(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        private void MostrarPantallaAdministrador(Usuario usuario)
        {
            try
            {
                PantallaAdministrador pantalla = new PantallaAdministrador(usuario);
                pantalla.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la pantalla del administrador: {ex.Message}");
            }
        }

        private void MostrarPantallaGerente(Usuario usuario)
        {
            try
            {
                PantallaGerente pantalla = new PantallaGerente(usuario);
                pantalla.Show();
                this.Hide(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la pantalla del gerente: {ex.Message}");
            }
        }
    }
}
