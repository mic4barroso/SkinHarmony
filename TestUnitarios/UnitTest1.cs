using BLL;
using BLL.BLL;
using DAL;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

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

        [TestMethod]
        public void ObtenerTodosLosProductos_DeberiaRetornarTodosLosProductos()
        {
            ProductoDAL productoDAL = new ProductoDAL();

            DataTable resultado = productoDAL.ProductosBase();

            Assert.IsNotNull(resultado, "Se esperaba que el DataTable no fuera nulo.");
            Assert.IsTrue(resultado.Rows.Count > 0, "Se esperaba que el DataTable contuviera uno o más productos.");
        }

        [TestMethod]
        public void VerificarContraseña_Correcta()
        {
            string usuario = "anaUser";
            string contraseñaCorrecta = "ana123";
            Login login = new Login();

            var usuarioEntidad = login.IniciarSesion(usuario, contraseñaCorrecta);

            Assert.IsNotNull(usuarioEntidad, "Se esperaba que el usuario fuera autenticado correctamente.");
        }

        [TestMethod]
        public void VerificarContraseña_Incorrecta()
        {
            string usuario = "anaUser";
            string contraseñaIncorrecta = "ana";
            Login login = new Login();

            var usuarioEntidad = login.IniciarSesion(usuario, contraseñaIncorrecta);

            Assert.IsNull(usuarioEntidad, "Se esperaba que el usuario no fuera autenticado con una contraseña incorrecta.");
        }
        [TestMethod]
        public void BuscarProductoPorId_DeberiaRetornarProductoCorrecto()
        {
            ProductoDAL productoDAL = new ProductoDAL();
            int idProducto = 1;  

            DataTable dtProducto = productoDAL.ObtenerProductoPorId(idProducto);

            Assert.IsNotNull(dtProducto, "Se esperaba que el DataTable no fuera nulo.");
            Assert.AreEqual(1, dtProducto.Rows.Count, "Se esperaba que hubiera exactamente un producto en el DataTable.");

            DataRow filaProducto = dtProducto.Rows[0];
            Assert.AreEqual(idProducto, (int)filaProducto["IdProducto"], "Se esperaba que el ID del producto fuera el mismo que el ID buscado.");
        }

        [TestMethod]
        public void TestObtenerTodosLosProductos()
        {
            ProductoDAL productoDAL = new ProductoDAL();

            DataTable dataTable = productoDAL.ProductosBase();

            Assert.IsNotNull(dataTable, "El DataTable de productos no debe ser nulo");
            Assert.IsTrue(dataTable.Rows.Count > 0, "Se esperaba al menos un producto en el DataTable.");
            Assert.IsTrue(dataTable.Columns.Contains("IdProducto"), "El DataTable debería contener la columna 'IdProducto'.");
            Assert.IsTrue(dataTable.Columns.Contains("Nombre"), "El DataTable debería contener la columna 'Nombre'.");
        }
    }
}


