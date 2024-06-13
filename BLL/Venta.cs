using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Venta
    {
        public Venta() { }

		private int _nroVenta;

		public int NroVenta
		{
			get { return _nroVenta; }
			set { _nroVenta = value; }
		}

		private DateTime _fechayHora;

		public DateTime FechayHora
		{
			get { return _fechayHora; }
			set { _fechayHora = value; }
		}

        private int _idCliente;

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        private int _idVendedor;

        public int IdVendedor
        {
            get { return _idVendedor; }
            set { _idVendedor = value; }
        }
        private decimal _totalventa;

        public decimal TotaVenta
        {
            get { return _totalventa; }
            set { _totalventa = value; }
        }
        private string _metodoPago;

        public string MetodoPago
        {
            get { return _metodoPago; }
            set { _metodoPago = value; }
        }

        public Venta(int nroVenta, DateTime fechayHora, int idCliente, int idVendedor, decimal totalventa, string metodoPago)
        {
            _nroVenta = nroVenta;
            _totalventa= totalventa;    
            _idCliente = idCliente;
            _fechayHora = fechayHora;
            _idVendedor = idVendedor;
            _metodoPago= metodoPago;
        }
        public List<Venta> ListarVentasBD()
        {
            List<Venta> ventas = new List<Venta>();
            DAL.VentaDAL ventasDAL = new DAL.VentaDAL();

            DataTable miTabla = ventasDAL.VentasBase();

            foreach (DataRow fila in miTabla.Rows)
            {
                Venta venta = new Venta(
                    (int)fila["NroVenta"],
                    (DateTime)fila["FechaVenta"],
                    (int)fila["idCliente"],
                    (int)fila["idVendedor"],
                    (decimal)fila["TotalVenta"],
                    fila["MetodoPago"].ToString()
            );
                ventas.Add(venta);
            }

            return ventas;
        }

        //total 
        //detalleVenta
        //fechaHora ?
    }
}
