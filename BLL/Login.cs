using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Login
    {
        public Usuario IniciarSesion(string usuario, string clave)
        {
            Conexion objConexion = new Conexion();
            DataTable dt = objConexion.LeerPorComando("select [nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario] from [TiendaTP].[dbo].[Usuarios]");

            foreach (DataRow fila in dt.Rows)
            {
                if (fila["userUsuario"].ToString() == usuario && fila["contrasenia"].ToString() == clave)
                {
                    string rol = fila["rol"].ToString();
                    Usuario user = null;

                    if (rol == "gerente")
                    {
                        user = new Gerente(
                            (int)fila["id_usuario"],
                            fila["nombre"].ToString(),
                            fila["apellido"].ToString(),
                            (long)fila["DNI"],
                            fila["userUsuario"].ToString(),
                            fila["contrasenia"].ToString(),
                            rol
                        );
                    }
                    else if (rol == "administrador")
                    {
                        user = new Administrador(
                            (int)fila["id_usuario"],
                            fila["nombre"].ToString(),
                            fila["apellido"].ToString(),
                            (long)fila["DNI"],
                            fila["userUsuario"].ToString(),
                            fila["contrasenia"].ToString(),
                            rol
                        );
                    }
                    else if(rol == "atencion_al_cliente")
                    {
                            user = new Gerente(
                                (int)fila["id_usuario"],
                                fila["nombre"].ToString(),
                                fila["apellido"].ToString(),
                                (long)fila["DNI"],
                                fila["userUsuario"].ToString(),
                                fila["contrasenia"].ToString(),
                                rol
                            );
                    }
                    else if (rol == "cajero")
                    {
                        user = new Gerente(
                            (int)fila["id_usuario"],
                            fila["nombre"].ToString(),
                            fila["apellido"].ToString(),
                            (long)fila["DNI"],
                            fila["userUsuario"].ToString(),
                            fila["contrasenia"].ToString(),
                            rol
                        );
                    }
                    else if (rol == "repositor")
                    {
                        user = new Gerente(
                            (int)fila["id_usuario"],
                            fila["nombre"].ToString(),
                            fila["apellido"].ToString(),
                            (long)fila["DNI"],
                            fila["userUsuario"].ToString(),
                            fila["contrasenia"].ToString(),
                            rol
                        );
                    }
                    return user;
                }
            }

            return null; 
        }
        /*private string _usuario;
        private string _clave;
        public bool IniciarSesion(string usuario, string clave)
        {

            Conexion objConexion = new Conexion();

            DataTable dt = objConexion.LeerPorComando("select [nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario] from [TiendaTP].[dbo].[Usuarios]");

            foreach (DataRow fila in dt.Rows)
            {
                if (fila[3].ToString() == usuario && fila["contrasenia"].ToString() == clave)
                {
                    return true;
                }

            }
            return false;
        }*/
    }
}


