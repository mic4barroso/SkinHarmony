using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleVenta
    {
        public DetalleVenta()
        {
        }

        private int _idDetalleVenta;

        public int IdDetalleVenta
        {
            get { return _idDetalleVenta; }
            set { _idDetalleVenta = value; }
        }

        private int _idVenta;

        public int IdVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }

        private int _idProducto;

        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private decimal _precioUnitario;

        public decimal precioUnitario
        {
            get { return _precioUnitario; }
            set { _precioUnitario = value; }
        }

        /*private decimal _subtotal;

        public decimal subTotal
        {
            get { return _subtotal; }
            set { _subtotal = value; }
        }*/

        public DetalleVenta(int id, int idVenta, int idProducto, int cantidad, int precioUnitario)
        {
            _idDetalleVenta = id;
            _idProducto = idProducto;
            _cantidad = cantidad;
            _idVenta = idVenta;
            _precioUnitario = precioUnitario;  
            //_subtotal = subTotal;
        }



        public List<DetalleVenta> ListarDetVentasBD()
        {
            List<DetalleVenta> detVentas = new List<DetalleVenta>();
            DAL.DetalleVenta detVentasDAL = new DAL.DetalleVenta();

            DataTable miTabla = detVentasDAL.DetVentasBase();

            foreach (DataRow fila in miTabla.Rows)
            {
                DetalleVenta detalleVenta = new DetalleVenta(
                    (int)fila["IdDetalleVenta"],
                    (int)fila["IdVenta"],
                    (int)fila["IdProducto"],
                    (int)fila["Cantidad"],
                    (int)(decimal)fila["PrecioUnitario"]
                    );
                detVentas.Add(detalleVenta);
            }

            return detVentas;
        }

        public List<Producto> Productos { get; set; }
    }
}
