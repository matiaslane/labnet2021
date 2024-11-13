using Lab.Tp7.Common.Models;
using System.Collections.Generic;

namespace Lab.Tp7.Logic
{
    public interface IShippersLogic
    {
        ShippersModel Get(int id);
        List<ShippersModel> GetAll();

        void Add(ShippersModel shippersModel);

        void Delete(int id);

        void Update(int id, ShippersModel shipperModel);
    }
}
