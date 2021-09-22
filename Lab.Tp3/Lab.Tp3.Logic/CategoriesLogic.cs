using Lab.Tp3.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Tp3.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }
    }
}
