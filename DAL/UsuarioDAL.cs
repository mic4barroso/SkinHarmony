using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;

namespace DAL
{
    public class UsuarioDAL
    {
        private Conexion conexion = new Conexion();
        public DataTable UsuariosBase()
        {
            Conexion conexion = new Conexion();

            return conexion.LeerPorComando("SELECT * FROM [TiendaTP].[dbo].[Usuarios]");
        }
        public bool InsertarUsuario(UsuarioEntidad usuario)
        {
            try
            {
                string comandoSQL = $"INSERT INTO [TiendaTP].[dbo].[Usuarios] " +
                                    $"(nombre, apellido, DNI, userUsuario, rol, contrasenia, id_usuario, Estado) " +
                                    $"VALUES (@nombre, @apellido, @dni, @user, @rol, @contrasenia, @id, @estado)";

                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand(comandoSQL, conn);
                    cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                    cmd.Parameters.AddWithValue("@dni", usuario.DNI);
                    cmd.Parameters.AddWithValue("@user", usuario.User);
                    cmd.Parameters.AddWithValue("@rol", usuario.Rol);
                    cmd.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
                    cmd.Parameters.AddWithValue("@id", usuario.ID);
                    cmd.Parameters.AddWithValue("@estado", usuario.Estado);

                    conn.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al insertar usuario: {ex.Message}");
                return false;
            }
        }
    }
    }

