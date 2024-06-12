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
        public Proovedor Proveedor { get; set; }
        private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _categoria;

		public string Categoria
		{
			get { return _categoria; }
			set { _categoria = value; }
		}

		private decimal _precio;

		public decimal Precio
		{
			get { return _precio; }
			set { _precio = value; }
		}

		private int _stock;

		public int Stock
		{
			get { return _stock; }
			set { _stock = value; }
		}

		private int _idProducto;

		public int IdProducto
		{
			get { return _idProducto; }
			set { _idProducto = value; }
		}

		private string _descripcion;

		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}

		private string _color;

		public string Color
		{
			get { return _color; }
			set { _color = value; }
		}

		private string _marca;

		public string Marca
		{
			get { return _marca; }
			set { _marca = value; }
		}

		public Producto()
		{
		}

		public Producto(string elNombre, string laCategoria, decimal elPrecio, int elStock, int ID, string desc, string elColor, string laMarca)
		{
			_nombre = elNombre;
			_categoria = laCategoria;
			_precio = elPrecio;
			_stock = elStock;
			_idProducto = ID;
			_descripcion = desc;
			_color = elColor;
			_marca = laMarca;
		}

        public List<Producto> ListarProductosBD()
		{
			List<Producto> productos = new List<Producto>();
			DAL.ProductoDAL productoDAL = new DAL.ProductoDAL();

			DataTable miTabla = productoDAL.ProductosBase();

			foreach(DataRow fila in miTabla.Rows) 
			{
				Producto producto = new Producto();

				producto._idProducto = (int)fila["IdProducto"];
				producto._nombre = fila["Nombre"].ToString();
				producto._categoria = fila["Categoria"].ToString();
				producto._precio = (decimal)fila["Precio"];
				producto._stock = (int)fila["StockCantidad"];
				producto._descripcion = fila["Descripcion"].ToString();
                producto._color = fila["Color"].ToString();
                producto._marca = fila["Marca"].ToString();

				productos.Add(producto);
			}

			return productos;
		}
	}
}
