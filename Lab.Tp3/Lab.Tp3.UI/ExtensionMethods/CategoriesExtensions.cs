using Lab.Tp7.Logic;
using Lab.Tp7.Common.Models;
using System;

namespace Lab.Tp7.UI.ExtensionMethods
{
    public static class CategoriesExtensions
    {
        public static void ShowCategories(this ICategoriesLogic categoriesLogic)
        {
            Console.WriteLine("Listado de Categorias");
            foreach (CategoriesModel categories in categoriesLogic.GetAll())
            {
                Console.WriteLine($"{categories.Id} - {categories.Name} - {categories.Description}");
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
