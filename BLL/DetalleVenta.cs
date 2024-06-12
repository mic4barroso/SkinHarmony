using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleVenta
    {
        public DetalleVenta() { }

        public List<Producto> Productos { get; set; }

        //no se si iba
        private decimal _totalVenta;

        public decimal TotalVenta
        {
            get { return _totalVenta; }
            set { _totalVenta = value; }
        }

        //agregarProductoVendido


        //subtotal
        //obtenerDetalleVenta
    }
}
