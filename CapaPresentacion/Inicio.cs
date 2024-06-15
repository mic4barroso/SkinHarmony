using BLL;
using BLL.BLL;
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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tboxUser.Text;
            string password = tboxContrasenia.Text;

            Login login = new Login();
            UsuarioEntidad usuario = login.IniciarSesion(username, password);

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
                else if (usuario.Rol == "cajero")
                {
                    MostrarPantallaCajero(usuario); 
                }
                else if (usuario.Rol == "atencion_al_cliente")
                {
                    MostrarPantallaAtencionCliente(usuario); 
                }
                else if (usuario.Rol == "repositor")
                {
                    MostrarPantallaRepositor(usuario); 
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

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

        private void MostrarPantallaAdministrador(UsuarioEntidad usuario)
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

        private void MostrarPantallaGerente(UsuarioEntidad usuario)
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

        private void MostrarPantallaCajero(UsuarioEntidad usuario)
        {
            try
            {
                PantallaCajero pantalla = new PantallaCajero(usuario);
                pantalla.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la pantalla del cajero: {ex.Message}");
            }
        }

        private void MostrarPantallaAtencionCliente(UsuarioEntidad usuario)
        {
            try
            {
                PantallaAtencionCliente pantalla = new PantallaAtencionCliente(usuario);
                pantalla.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la pantalla de Atencion al cliente: {ex.Message}");
            }
        }

        private void MostrarPantallaRepositor(UsuarioEntidad usuario)
        {
            try
            {
                PantallaRepositor pantalla = new PantallaRepositor(usuario);
                pantalla.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar la pantalla del repositor: {ex.Message}");
            }
        }

        private void tboxContrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

