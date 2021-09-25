using Lab.Tp5.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Tp5.Logic
{
    public class ProductsLogic : BaseLogic
    {

        // 2) Query para devolver todos los productos sin stock

        public List<Products> GetProductosSinStock()
        {
            var query = from p in context.Products
                        where p.UnitsInStock == 0
                        select p;

            return query.ToList();
        }

        // 3) Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad

        public List<Products> GetProductosSegunStockYPrecio(int stock , int precio)
        {
            var query = context.Products
                        .Where(p => p.UnitsInStock > stock)
                        .Where(p => p.UnitPrice > precio)
                        .ToList();

            return query;
        }

        // 5 ) Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789
        public Products GetFirstOrDefaultSegunId(int id)
        {
            var query = context.Products.FirstOrDefault(
                        p => p.ProductID == id);

            return query;
        }

        // 9) Query para devolver lista de productos ordenados por nombre
        public List<Products> GetListaOrdenadaPorNombre()
        {
            var query = from p in context.Products
                        orderby p.ProductName ascending
                        select p;

            return query.ToList();
        }

        // 10) Query para devolver lista de productos ordenados por unit in stock de mayor a menor.
        public List<Products> GetListaOrdenadaPorUnitsInStock()
        {
            var query = from p in context.Products
                        orderby p.UnitsInStock descending
                        select p;

            return query.ToList();
        }

        // 11) Query para devolver las distintas categorías asociadas a los productos
        public List<Products> GetListaSegunLasCategorias()
        {
            var query = context.Products
                .GroupBy(p => p.CategoryID)
                .Select(x => x.FirstOrDefault())
                .ToList();

            return query;
        }
    }
}
