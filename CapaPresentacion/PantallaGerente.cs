using BLL;
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
    public partial class PantallaGerente : Form
    {
        private UsuarioEntidad _usuario;

        public PantallaGerente(UsuarioEntidad usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        /*public PantallaGerente(UsuarioEntidad usuario)
        {
            this.usuario = usuario;
        }*/

        private void PlasmarRol()
        {
            label1.Text = "Rol de usuario";
            label2.Text = _usuario.Rol;
        }

        private void PantallaGerente_Load(object sender, EventArgs e)
        {
            PlasmarRol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PantallaInformes ptallaInforme = new PantallaInformes();
            ptallaInforme.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }
    }
}
