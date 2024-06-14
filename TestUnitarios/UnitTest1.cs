using DAL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertarProducto_DeberiaInsertarProductoEnBD()
        {
            ProductoDAL productoDAL = new ProductoDAL();
            ProductoEntidad producto = new ProductoEntidad
            {
                Nombre = "Crema",
                Categoria = "Cuidado Personal",
                Precio = 8000,
                Stock = 10,
                Descripcion = "crema humectante",
                Color = "-",
                Marca = "Avon"
            };

            bool resultado = productoDAL.InsertarProducto(producto);

            Assert.IsTrue(resultado, "Se esperaba que el producto fuera insertado correctamente.");
        }
    }
}
