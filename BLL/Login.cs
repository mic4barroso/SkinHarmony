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
        public class Login
        {
            public UsuarioEntidad IniciarSesion(string usuario, string clave)
            {
                Conexion objConexion = new Conexion();
                DataTable dt = objConexion.LeerPorComando("select [nombre], [apellido], [DNI], [userUsuario], [rol], [contrasenia], [id_usuario], [Estado] from [TiendaTP].[dbo].[Usuarios]");

                foreach (DataRow fila in dt.Rows)
                {
                    if (fila["userUsuario"].ToString() == usuario && fila["contrasenia"].ToString() == clave)
                    {
                        string rol = fila["rol"].ToString();
                        UsuarioEntidad user = null;

                        if (rol == "gerente")
                        {
                            user = new GerenteEntidad(
                                (int)fila["id_usuario"],
                                fila["nombre"].ToString(),
                                fila["apellido"].ToString(),
                                (long)fila["DNI"],
                                fila["userUsuario"].ToString(),
                                fila["contrasenia"].ToString(),
                                rol,
                                fila["Estado"].ToString()) ;
                        }
                        else if (rol == "administrador")
                        {
                            user = new AdministradorEntidad(
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
                            user = new AtencionAlClienteEntidad(
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
                            user = new CajeroEntidad(
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
                            user = new RepositorEntidad(
                                (int)fila["id_usuario"],
                                fila["nombre"].ToString(),
                                fila["apellido"].ToString(),
                                (long)fila["DNI"],
                                fila["userUsuario"].ToString(),
                                fila["contrasenia"].ToString(),
                                rol,
                                fila["Estado"].ToString());
                        }
                        return user;
                    }
                }

                return null;
            }
        }
    }
}


