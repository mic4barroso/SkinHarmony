using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Proovedor
    {
        public List<Producto> Productos { get; set; }

        private int _idProveedor;

		public int IdProveedor
		{
			get { return _idProveedor; }
			set { _idProveedor = value; }
		}

		private string _razonSocial;

		public string RazonSocial
		{
			get { return _razonSocial; }
			set { _razonSocial = value; }
		}

		private string _mail;

		public string Mail
		{
			get { return _mail; }
			set { _mail = value; }
		}

		private long _telefono;

		public long Telefono
		{
			get { return _telefono; }
			set { _telefono = value; }
		}

		public Proovedor()
		{
		}

		public Proovedor(int id, string razonSocial, string mail, long telefono)
		{
			_idProveedor= id;
			_razonSocial= razonSocial;
			_mail= mail;
			_telefono= telefono;
			Productos = new List<Producto>();	
		}

        //agregarProducto
        public void AgregarProductos(Producto producto)
        {
            Productos.Add(producto);
        }
        //eliminarProducto
		/*public bool EliminarProductos()
		{

		}*/
        //obtenerProducto
        public List<Producto> ObtenerProductos()
		{
			return Productos;
		}

	}
}
