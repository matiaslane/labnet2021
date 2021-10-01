using Lab.Tp7.Logic;
using Lab.Tp7.Common.Models;
using Lab.Tp7.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Tp7.Logic
{
    public class ShippersLogic : BaseLogic, IShippersLogic
    {
        public List<ShippersModel>GetAll()
        {
            List<ShippersModel> shippers = context.Shippers.Select ( s => new ShippersModel
            {
                Id = s.ShipperID,
                Name = s.CompanyName,
                Phone = s.Phone
            }).ToList();
            return shippers;
        }

        public void Add(ShippersModel shippersModel)
        {
            Shippers shipper = new Shippers
            {
                CompanyName = shippersModel.Name,
                Phone = shippersModel.Phone
            };
            context.Shippers.Add(shipper);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            try
            {
                var shipperAEliminar = context.Shippers.Find(id);
                context.Shippers.Remove(shipperAEliminar);
                context.SaveChanges();
            }
            catch (Exception)
            {
                return;
            }
        }

        public void Update(ShippersModel shipperModel)
        {
            var shipperUpdate = context.Shippers.Find(shipperModel.Id);
            shipperUpdate.CompanyName = shipperModel.Name;
            shipperUpdate.Phone = shipperModel.Phone;
            context.SaveChanges();
        }
    }
}
