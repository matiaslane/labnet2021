using Lab.Tp5.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lab.Tp5.Logic.Tests.Unit
{
    [TestClass]
    public class ProductsLogicTests
    {
        ProductsLogic products = new ProductsLogic();
        
        [TestMethod]
        public void El_metodo_get_productos_sin_stock_devuelve_una_lista_de_products()
        {
            // arrange

            // act
            var result = products.GetProductosSinStock();

            // assert
            Assert.AreEqual(result.GetType(), typeof(List<Products>));
        }
        
        [TestMethod]
        public void El_metodo_get_producto_segun_stock_y_precio_devuelve_una_lista_de_productos()
        {
            // arrange
            int stock = 100;
            int precio = 10;

            // act
            var result = products.GetProductosSegunStockYPrecio(stock,precio);

            // assert
            Assert.AreEqual(result.GetType(), typeof(List<Products>));
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void El_metodo_get_first_or_default_segun_id_devuelve_el_primer_objeto_encontrado()
        {
            // arrange
            int id = 768;

            // act
            var result = products.GetFirstOrDefaultSegunId(id);

            // assert
            Assert.AreEqual(result.GetType(), typeof(Products));

        }

        [TestMethod]
        public void El_metodo_get_lista_ordenada_por_nombre_devuelve_una_lista_ordenada_de_productos()
        {
            // arrange

            // act
            var result = products.GetListaOrdenadaPorNombre();

            // assert
            Assert.AreEqual(result.GetType(), typeof(List<Products>));

        }

        [TestMethod]
        public void El_metodo_get_lista_ordenada_segun_unit_in_stock_devuelve_lista_de_productos()
        {
            // arrange

            // act
            var result = products.GetListaOrdenadaPorUnitsInStock();

            //assert
            Assert.AreEqual(result.GetType(), typeof(List<Products>));
        }

        [TestMethod]
        public void El_metodo_devuelve_lista_segun_las_distintas_categorias_asociadas_a_los_productos()
        {
            // arrange

            // act 
            var result = products.GetListaSegunLasCategorias();

            // assert
            Assert.AreEqual(result.GetType(), typeof(List<Products>));
        }
    }
}
