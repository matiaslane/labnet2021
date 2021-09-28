using Lab.Tp7.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Tp7.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}
