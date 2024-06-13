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

            return conexion.LeerPorComando("SELECT * FROM [TiendaTP].[dbo].[Ventas]");
        }
        private string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TiendaTP;Data Source=MICAELA\\SQLEXPRESS";

        public DataTable ObtenerVentasConDetalles()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand("ObtenerVentasConDetalles", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    return dt;
                }
            }
        }
    }
}
