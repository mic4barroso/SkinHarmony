using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        public DataTable ClientesBase()
        {
            Conexion conexion = new Conexion();

            return conexion.LeerPorComando("SELECT * FROM [TiendaTP].[dbo].[Clientes]");
        }
    }
}
