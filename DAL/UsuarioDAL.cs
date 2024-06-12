using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class UsuarioDAL
    {
        public DataTable UsuariosBase()
        {
            Conexion conexion = new Conexion();

            //List<UsuarioDAL> usuarios = new List<UsuarioDAL>();

            return conexion.LeerPorComando("SELECT * FROM [TiendaTP].[dbo].[Usuarios]");
        }
    }
}

