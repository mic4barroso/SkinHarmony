using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DetalleVenta { 
    public DataTable DetVentasBase()
    {
        Conexion conexion = new Conexion();

        return conexion.LeerPorComando("SELECT * FROM [TiendaTP].[dbo].[DetalleVenta]");
    }
}
}
