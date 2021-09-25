using Lab.Tp5.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Lab.Tp5.Logic.Tests.Unit
{
    [TestClass]
    public class CustomersLogicTests
    {
        CustomersLogic customer = new CustomersLogic();

        [TestMethod]
        public void El_metodo_GetFirstCustomers_devuelve_el_primer_objeto_de_tipo_Customers()
        {
            // arrange
            
            // act
            var result = customer.GetFirstCustomer();

            // assert
            //Assert.AreEqual(result.GetType(), typeof());
        }

        [TestMethod]
        public void El_metodo_get_customers_cegun_region_devuelve_una_lista_de_customers()
        {
            // arrange
            string regionBuscada = "WA";

            // act
            var result = customer.GetCustomersSegunRegion(regionBuscada);

            // assert 
            Assert.AreEqual(result.GetType(), typeof(List<Customers>));
        }

        [TestMethod]
        public void El_metodo_get_customer_name_devuelve_una_lista_de_nombres_en_mayus()
        {
            // arrange

            // act
            var result = customer.GetCustomersNameMayus();

            // assert
            Assert.AreEqual(result.GetType(), typeof(List<string>));
        }

        [TestMethod]
        public void El_metodo_get_customer_name_devuelve_una_lista_de_nombres_en_minus()
        {
            // arrange

            // act
            var result = customer.GetCustomersNameMin();

            // assert
            Assert.AreEqual(result.GetType(), typeof(List<string>));
        }

        [TestMethod]
        public void El_metodo_get_customer_segun_region_y_fecha_de_orden_devuelve_una_lista()
        {
            // arrange 
            var fecha = new DateTime();
            var region = "WA";
            
            // act 
            var result = customer.GetCustomersSegunRegionYFechaDeOrden(region,fecha);

            // assert
            //Assert.AreEqual(result.GetType(), typeof());
        }

        [TestMethod]
        public void El_metodo_devuelve_los_tres_primeros_registros_de_una_region()
        {
            // arrange 
            string region = "WA";

            // act 
            var result = customer.GetTopCustomersSegunRegion(region);

            // assert
            Assert.AreEqual(result.GetType(), typeof(List<Customers>));

        }
    }
}