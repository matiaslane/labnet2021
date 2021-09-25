using Lab.Tp5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Tp5.Logic
{
    public class CustomersLogic : BaseLogic
    {
        // 1) Query para devolver objeto customer
        public Customers GetFirstCustomer()
        {
            var query = context.Customers.First();

            return query;
        }

        // 4) Query para devolver todos los customers de la Región WA

        public List<Customers> GetCustomersSegunRegion(string region)
        {
            var query = context.Customers
                        .Where(c => c.Region == region)
                        .ToList();

            return query;
        }

        // 6) Query para devolver los nombre de los Customers.Mostrarlos en Mayuscula y en Minuscula.

        public List<string> GetCustomersNameMayus()
        {
            var query = context.Customers.Select(
                        c => c.CompanyName.ToUpper());

            return query.ToList(); 
        }

        public List<string> GetCustomersNameMin()
        {
            var query = context.Customers.Select(
                        c => c.CompanyName.ToLower()).ToList();

            return query;
        }

        // 7) Query para devolver Join entre Customers y Orders donde los customers sean de la región WA y la fecha de orden sea mayor a 1/1/1997.
        public IQueryable<object> GetCustomersSegunRegionYFechaDeOrden(string region, DateTime fecha)
        {
            var query = from c in context.Customers
                        join o in context.Orders on c.CustomerID equals o.CustomerID
                        where c.Region == region
                        where o.OrderDate > fecha
                        select new {c.CompanyName, c.Region, o.OrderDate };

            return query;

        }

        // 8) Query para devolver los primeros 3 Customers de la Región WA
        public List<Customers> GetTopCustomersSegunRegion(string region)
        {
            var query = context.Customers
                        .Where(c => c.Region == region)
                        .Take(3)
                        .ToList();

            return query;
        }
    }
}
