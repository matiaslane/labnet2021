using Lab.Tp7.Entities;
using Lab.Tp7.Logic;
using System;

namespace Lab.Tp7.UI.ExtensionMethods
{
    public static class ShippersExtensions
    {
        public static void ShowShippers(this ShippersLogic shippersLogic)
        {
            Console.WriteLine("Listado de Comisionistas");
            foreach (Shippers shipper in shippersLogic.GetAll())
            {
                Console.WriteLine($"{shipper.ShipperID} - {shipper.CompanyName} - {shipper.Phone}");
            }
            Console.WriteLine(Environment.NewLine);
        }

        public static void AddShipper(this ILogic<Shippers> shippersLogic)
        {
            Console.WriteLine("Ingrese Nombre de la Compañia");
            string companyName = Console.ReadLine();
            Console.WriteLine("Ingrese Num Telefono");
            string telefono = Console.ReadLine();
            shippersLogic.Add(new Shippers
            {
                CompanyName = companyName,
                Phone = telefono,
            });
        }

        public static void DeleteShipper(this ShippersLogic shippersLogic)
        {
            ShowShippers(shippersLogic);
            Console.WriteLine("Ingrese ID para borrar registro");
            int idToDelete = Convert.ToInt32(Console.ReadLine());
            shippersLogic.Delete(idToDelete);
        }

        public static void UpdateShipper(this ILogic<Shippers> shippersLogic)
        {
            Console.WriteLine("Ingrese Id para modificar Valores");
            int shipperId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Nuevo Nombre de la Compañia");
            string companyName = Console.ReadLine();
            Console.WriteLine("Ingrese Nuevo Num Telefono");
            string telefono = Console.ReadLine();
            shippersLogic.Update(new Shippers
            {
                ShipperID = shipperId,
                CompanyName = companyName,
                Phone = telefono,
            });
        }
    }
}
