using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoEntidad
    {
        //public Proovedor Proveedor { get; set; }
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

        public ProductoEntidad()
        {
        }

        public ProductoEntidad(string elNombre, string laCategoria, decimal elPrecio, int elStock, int ID, string desc, string elColor, string laMarca)
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
    }
}
