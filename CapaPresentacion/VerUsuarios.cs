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
    public partial class VerUsuarios : Form
    {
        public VerUsuarios()
        {
            InitializeComponent();
        }

        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            BLL.ListarUsuarios usuariosDGV = new BLL.ListarUsuarios();
            List<Usuario> usuarios = usuariosDGV.UsuariosDGV();

            grillaUsuarios.DataSource = usuarios.Select(u=> new
            {
                ID = u.ID,
                Nombre = u.Nombre,
                Apellido = u.Apellido,
                DNI = u.DNI,
                User = u.User,
                Contrasenia = u.Contrasenia,
                Rol = u.Rol
            }).ToList();
        }

        }

    }
