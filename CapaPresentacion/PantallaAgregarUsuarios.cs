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
    public partial class PantallaAgregarUsuarios : Form
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();
        public PantallaAgregarUsuarios()
        {
            InitializeComponent();
        }

        private void PantallaAgregarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tboxNombre.Text;
                string apellido = tboxApellido.Text;
                long dni = Convert.ToInt64(tboxDNI.Text);
                string user = tboxUser.Text;
                string contrasenia = tboxContraseña.Text;
                int id = Convert.ToInt32(tboxID.Text);
                string estado = tboxEstado.Text;

                GerenteEntidad gerente = new GerenteEntidad(id, nombre, apellido, dni, user, contrasenia, estado);

                bool exito = usuarioDAL.InsertarUsuario(gerente);

                if (exito)
                {
                    MessageBox.Show("Usuario agregado exitosamente al sistema.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
    }

        private void LimpiarCampos()
        {
            tboxNombre.Text = "";
            tboxApellido.Text = "";
            tboxDNI.Text = "";
            tboxUser.Text = "";
            tboxContraseña.Text = "";
            tboxRol.Text = "";
            tboxEstado.Text = "";
        }
    }
}