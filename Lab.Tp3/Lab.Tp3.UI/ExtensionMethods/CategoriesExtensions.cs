using Lab.Tp7.Entities;
using Lab.Tp7.Logic;
using System;

namespace Lab.Tp7.UI.ExtensionMethods
{
    public static class CategoriesExtensions
    {
        public static void ShowCategories(this CategoriesLogic categoriesLogic)
        {
            Console.WriteLine("Listado de Categorias");
            foreach (Categories categories in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{categories.CategoryID} - {categories.CategoryName} - {categories.Description}");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
