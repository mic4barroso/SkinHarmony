using System;
using System.Collections.Generic;
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

		public Venta(int nroVenta, DateTime fechaHora)
		{
			_nroVenta= nroVenta;
			_fechayHora= fechaHora;
		}

		//total 
		//detalleVenta
		//fechaHora ?
	}
}
