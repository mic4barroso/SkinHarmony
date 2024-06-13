using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VentaDAL
    {
        public DataTable VentasBase()
        {
            Conexion conexion = new Conexion();

            return conexion.LeerPorComando("SELECT * FROM [TiendaTP].[dbo].[Venta]");
        }
        //private string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TiendaTP;Data Source=MICAELA\\SQLEXPRESS";

        public DataTable ObtenerVentasConDetalles()
        {
            Conexion conexion = new Conexion();

            return conexion.LeerPorStoreProcedure("sp_ObtenerVentaConDetalle");
        }
    }
}
