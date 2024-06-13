using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL
{
    public class Usuario
    {
        public List<UsuarioEntidad> ListarUsuariosBase()
        {
            List<UsuarioEntidad> usuarios = new List<UsuarioEntidad>();
            DAL.UsuarioDAL usuarioDal = new DAL.UsuarioDAL();
            //Conexion conexion = new Conexion();

            DataTable miTabla = usuarioDal.UsuariosBase();

            foreach (DataRow fila in miTabla.Rows)
            {
                UsuarioEntidad usuario = null;
                string rol = fila["Rol"].ToString();

                if (rol == "Gerente")
                {
                    usuario = new GerenteEntidad(
                        (int)fila["id_usuario"],
                                fila["nombre"].ToString(),
                                fila["apellido"].ToString(),
                                (long)fila["DNI"],
                                fila["userUsuario"].ToString(),
                                fila["contrasenia"].ToString(),
                                rol,
                                fila["Estado"].ToString());
                }
                else if (rol == "Administrador")
                {
                    usuario = new AdministradorEntidad(
                        (int)fila["id_usuario"],
                                fila["nombre"].ToString(),
                                fila["apellido"].ToString(),
                                (long)fila["DNI"],
                                fila["userUsuario"].ToString(),
                                fila["contrasenia"].ToString(),
                                rol,
                                fila["Estado"].ToString());
                }
                else if (rol == "atencion_al_cliente")
                {
                    usuario = new AtencionAlClienteEntidad(
                        (int)fila["id_usuario"],
                                fila["nombre"].ToString(),
                                fila["apellido"].ToString(),
                                (long)fila["DNI"],
                                fila["userUsuario"].ToString(),
                                fila["contrasenia"].ToString(),
                                rol,
                                fila["Estado"].ToString());
                }
                else if (rol == "repositor")
                {
                    usuario = new RepositorEntidad(
                       (int)fila["id_usuario"],
                                fila["nombre"].ToString(),
                                fila["apellido"].ToString(),
                                (long)fila["DNI"],
                                fila["userUsuario"].ToString(),
                                fila["contrasenia"].ToString(),
                                rol,
                                fila["Estado"].ToString());
                }
                else if (rol == "cajero")
                {
                    usuario = new CajeroEntidad(
                       (int)fila["id_usuario"],
                                fila["nombre"].ToString(),
                                fila["apellido"].ToString(),
                                (long)fila["DNI"],
                                fila["userUsuario"].ToString(),
                                fila["contrasenia"].ToString(),
                                rol,
                                fila["Estado"].ToString());
                }
                if (usuario != null)
                {
                    usuarios.Add(usuario);
                }
            }

            return usuarios;
        }


        //public abstract string ObtenerRol(string user, string password);

    }
}


