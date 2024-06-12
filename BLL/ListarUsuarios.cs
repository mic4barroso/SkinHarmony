using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ListarUsuarios
    {
        public List<Usuario> UsuariosDGV()
        {
            List<Usuario> usuarios = new List<Usuario>();
            UsuarioDAL usuarioDal = new UsuarioDAL();
            DataTable miTabla = usuarioDal.UsuariosBase();

            foreach (DataRow fila in miTabla.Rows)
            {
                Usuario usuario = null;
                string rol = fila["rol"].ToString();

                switch (rol)
                {
                    case "gerente":
                        usuario = new Gerente(
                            (int)fila["id_usuario"],
                            fila["nombre"].ToString(),
                            fila["apellido"].ToString(),
                            (long)fila["DNI"],
                            fila["userUsuario"].ToString(),
                            fila["contrasenia"].ToString(),
                            rol
                        );
                        break;
                    case "administrador":
                        usuario = new Administrador(
                            (int)fila["id_usuario"],
                            fila["nombre"].ToString(),
                            fila["apellido"].ToString(),
                            (long)fila["DNI"],
                            fila["userUsuario"].ToString(),
                            fila["contrasenia"].ToString(),
                            rol
                        );
                        break;
                    case "atencion_al_cliente":
                        usuario = new AtencionAlCliente(
                            (int)fila["id_usuario"],
                            fila["nombre"].ToString(),
                            fila["apellido"].ToString(),
                            (long)fila["DNI"],
                            fila["userUsuario"].ToString(),
                            fila["contrasenia"].ToString(),
                            rol
                        );
                        break;
                    case "repositor":
                        usuario = new Repositor(
                           (int)fila["id_usuario"],
                           fila["nombre"].ToString(),
                           fila["apellido"].ToString(),
                           (long)fila["DNI"],
                           fila["userUsuario"].ToString(),
                           fila["contrasenia"].ToString(),
                           rol
                        );
                        break;
                    case "cajero":
                        usuario = new Cajero(
                           (int)fila["id_usuario"],
                           fila["nombre"].ToString(),
                           fila["apellido"].ToString(),
                           (long)fila["DNI"],
                           fila["userUsuario"].ToString(),
                           fila["contrasenia"].ToString(),
                           rol
                        );
                        break;
                }

                if (usuario != null)
                {
                    usuarios.Add(usuario);
                }
            }

            return usuarios;
        }
    }
}

