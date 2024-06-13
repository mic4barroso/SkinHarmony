using DAL;
using Entidades;
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
            public List<UsuarioEntidad> UsuariosDGV()
            {
                List<UsuarioEntidad> usuarios = new List<UsuarioEntidad>();
                UsuarioDAL usuarioDal = new UsuarioDAL();
                DataTable miTabla = usuarioDal.UsuariosBase();

                foreach (DataRow fila in miTabla.Rows)
                {
                    UsuarioEntidad usuario = null;
                    string rol = fila["rol"].ToString();

                    int idUsuario = Convert.ToInt32(fila["id_usuario"]);
                    string nombre = fila["nombre"].ToString();
                    string apellido = fila["apellido"].ToString();
                    long dni = Convert.ToInt64(fila["DNI"]);
                    string userUsuario = fila["userUsuario"].ToString();
                    string contrasenia = fila["contrasenia"].ToString();
                    string estado = fila["Estado"].ToString();

                switch (rol)
                    {
                        case "gerente":
                            usuario = new GerenteEntidad(idUsuario, nombre, apellido, dni, userUsuario, contrasenia, rol, estado);
                            break;
                        case "administrador":
                            usuario = new AdministradorEntidad(idUsuario, nombre, apellido, dni, userUsuario, contrasenia, rol, estado);
                            break;
                        case "atencion_al_cliente":
                            usuario = new AtencionAlClienteEntidad(idUsuario, nombre, apellido, dni, userUsuario, contrasenia, rol, estado);
                            break;
                        case "repositor":
                            usuario = new RepositorEntidad(idUsuario, nombre, apellido, dni, userUsuario, contrasenia, rol, estado);
                            break;
                        case "cajero":
                            usuario = new CajeroEntidad(idUsuario, nombre, apellido, dni, userUsuario, contrasenia, rol, estado);
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


