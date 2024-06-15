using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Tienda
    {
        public List<Producto> Productos { get; set; }
        public List<Venta> Ventas { get; set; }
        public Tienda() { }

    }
}
