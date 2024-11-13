using Lab.Tp7.Common.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Tp7.Logic
{
    public class CategoriesLogic : BaseLogic, ICategoriesLogic
    {
        public List<CategoriesModel> GetAll()
        {
            List<CategoriesModel> categories = context.Categories.Select(c => new CategoriesModel
            {
                Id = c.CategoryID,
                Name = c.CategoryName,
                Description = c.Description
            }).ToList();

            return categories;
        }
    }
}
