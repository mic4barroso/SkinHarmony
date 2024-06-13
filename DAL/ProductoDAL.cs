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
        private readonly string _connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TiendaTP;Data Source=MICAELA\\SQLEXPRESS";
        public DataTable ProductosBase()
        {
            Conexion conexion = new Conexion();

            return conexion.LeerPorComando("SELECT * FROM [TiendaTP].[dbo].[Productos]");
        }

        public bool AgregarProducto(ProductoEntidad producto)
        {
            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                using (SqlCommand comando = new SqlCommand("INSERT INTO Productos (Nombre, Categoria, Precio, StockCantidad, Descripcion, Color, Marca) VALUES (@Nombre, @Categoria, @Precio, @StockCantidad, @Descripcion, @Color, @Marca)", conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    comando.Parameters.AddWithValue("@Categoria", producto.Categoria);
                    comando.Parameters.AddWithValue("@Precio", producto.Precio);
                    comando.Parameters.AddWithValue("@StockCantidad", producto.Stock);
                    comando.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    comando.Parameters.AddWithValue("@Color", producto.Color);
                    comando.Parameters.AddWithValue("@Marca", producto.Marca);

                    conexion.Open();
                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

    }
}
