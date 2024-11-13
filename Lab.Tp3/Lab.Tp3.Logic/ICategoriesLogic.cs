using Lab.Tp7.Common.Models;
using System.Collections.Generic;

namespace Lab.Tp7.Logic
{
    public interface ICategoriesLogic
    {
        List<CategoriesModel> GetAll();
    }
}
