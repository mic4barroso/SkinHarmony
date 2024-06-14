using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductoDAL
    {
        private Conexion conexion = new Conexion();

        public DataTable ProductosBase()
        {
            Conexion conexion = new Conexion();

            return conexion.LeerPorComando("SELECT * FROM [TiendaTP].[dbo].[Productos]");
        }

        public bool InsertarProducto(ProductoEntidad producto)
        {
            string comandoSQL = $"INSERT INTO [TiendaTP].[dbo].[Productos] (Nombre, Categoria, Precio, StockCantidad, Descripcion, Color, Marca) " +
                                $"VALUES ('{producto.Nombre}', '{producto.Categoria}', {producto.Precio}, {producto.Stock}, '{producto.Descripcion}', '{producto.Color}', '{producto.Marca}')";
            int filasAfectadas = conexion.EscribirPorComando(comandoSQL);
            return filasAfectadas > 0;
        }

        public DataTable ObtenerProductoPorId(int idProducto)
        {
            string comandoSQL = $"SELECT * FROM [TiendaTP].[dbo].[Productos] WHERE IdProducto = {idProducto}";
            return conexion.LeerPorComando(comandoSQL);
        }

        public bool EliminarProducto(int idProducto)
        {
            string comandoSQL = $"DELETE FROM [TiendaTP].[dbo].[Productos] WHERE IdProducto = {idProducto}";
            int filasAfectadas = conexion.EscribirPorComando(comandoSQL);
            return filasAfectadas > 0;
        }

    }
}
