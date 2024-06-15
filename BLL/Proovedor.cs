using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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

		public Proovedor()
		{
		}

		public Proovedor(int id, string razonSocial, string mail)
		{
			_idProveedor= id;
			_razonSocial= razonSocial;
			_mail= mail;
			Productos = new List<Producto>();	
		}

        public List<Proovedor> ListarProveedores()
        {
            List<Proovedor> proveedores = new List<Proovedor>();
            ProveedorDAL proveedorDAL = new ProveedorDAL(); 

            DataTable miTabla = proveedorDAL.ProveedorBase();

            foreach (DataRow fila in miTabla.Rows)
            {
                Proovedor proveedor = new Proovedor(
                    (int)fila["idProveedor"],
                    fila["RazonSocial"].ToString(),
                    fila["email"].ToString()
                );

                proveedores.Add(proveedor);
            }

            return proveedores;
        }

    }
}
