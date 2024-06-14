using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Cliente
    {
		private int _idCliente;

		public int IdCliente
		{
			get { return _idCliente; }
			set { _idCliente = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private long _dni;

		public long DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}
		public Cliente() { }

		public Cliente(int id, string nombre, string apellido, long dni)
		{
			_idCliente= id;
			_nombre= nombre;
			_apellido= apellido;
			_dni= dni;
		}

        public List<Cliente> ListarClientesBD()
        {
            List<Cliente> clientes = new List<Cliente>();
            ClienteDAL clienteDAL = new ClienteDAL();
			Conexion objConexion  = new Conexion();

            DataTable miTabla = clienteDAL.ClientesBase();

            foreach (DataRow fila in miTabla.Rows)
            {
                Cliente cliente = new Cliente(
                    (int)fila["id"],
                    fila["nombre"].ToString(),
                    fila["apellido"].ToString(),
                    (long)fila["dni"]
                );

                clientes.Add(cliente);
            }

            return clientes;
        }
    }
}

