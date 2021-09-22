using Lab.Tp3.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Tp3.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers>
    {
        public List<Shippers>GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);

            context.SaveChanges();
        } 
        public void Delete(int id)
        {
            var shipperAEliminar = context.Shippers.Find(id);

            context.Shippers.Remove(shipperAEliminar);

            context.SaveChanges();
        }
        public void Update(Shippers shipper)
        {
            var shipperUpdate = context.Shippers.Find(shipper.ShipperID);
            shipperUpdate.CompanyName = shipper.CompanyName;
            shipperUpdate.Phone = shipper.Phone;
            context.SaveChanges();
        }
    }
}
