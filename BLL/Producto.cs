using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class Producto
    {
        public List<ProductoEntidad> ListarProductosBD()
		{
			List<ProductoEntidad> productos = new List<ProductoEntidad>();
			DAL.ProductoDAL productoDAL = new DAL.ProductoDAL();

			DataTable miTabla = productoDAL.ProductosBase();

			foreach(DataRow fila in miTabla.Rows) 
			{
				ProductoEntidad producto = new ProductoEntidad(

                    fila["Nombre"].ToString(),
                    fila["Categoria"].ToString(),
                    (decimal)fila["Precio"],
                    (int)fila["StockCantidad"],
                    (int)fila["IdProducto"],
                    fila["Descripcion"].ToString(),
                    fila["Color"].ToString(),
                    fila["Marca"].ToString()
            );
                productos.Add(producto);
			}

			return productos;
		}
	}
}
