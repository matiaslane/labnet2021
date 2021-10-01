using Lab.Tp7.Common.Models;
using System.Collections.Generic;

namespace Lab.Tp7.Logic
{
    public interface IShippersLogic
    {
        List<ShippersModel> GetAll();

        void Add(ShippersModel shippersModel);

        void Delete(int id);

        void Update(ShippersModel shipperModel);
    }
}
