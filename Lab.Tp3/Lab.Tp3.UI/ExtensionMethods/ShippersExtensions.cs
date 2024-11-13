using Lab.Tp7.Logic;
using Lab.Tp7.Common.Models;
using System;

namespace Lab.Tp7.UI.ExtensionMethods
{
    public static class ShippersExtensions
    {
        public static void ShowShippers(this IShippersLogic shippersLogic)
        {
            Console.WriteLine("Listado de Comisionistas");
            foreach (ShippersModel shipper in shippersLogic.GetAll())
            {
                Console.WriteLine($"{shipper.Id} - {shipper.Name} - {shipper.Phone}");
            }
            Console.WriteLine(Environment.NewLine);
        }

        public static void AddShipper(this IShippersLogic shippersLogic)
        {
            Console.WriteLine("Ingrese Nombre de la Compañia");
            string companyName = Console.ReadLine();
            Console.WriteLine("Ingrese Num Telefono");
            string telefono = Console.ReadLine();
            shippersLogic.Add(new ShippersModel
            {
                Name = companyName,
                Phone = telefono,
            });
        }

        public static void DeleteShipper(this IShippersLogic shippersLogic)
        {
            ShowShippers(shippersLogic);
            Console.WriteLine("Ingrese ID para borrar registro");
            int idToDelete = Convert.ToInt32(Console.ReadLine());
            shippersLogic.Delete(idToDelete);
        }

        public static void UpdateShipper(this IShippersLogic shippersLogic)
        {
            Console.WriteLine("Ingrese Id para modificar Valores");
            int shipperId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Nuevo Nombre de la Compañia");
            string companyName = Console.ReadLine();
            Console.WriteLine("Ingrese Nuevo Num Telefono");
            string telefono = Console.ReadLine();
            shippersLogic.Update(new ShippersModel
            {
                Id = shipperId,
                Name = companyName,
                Phone = telefono,
            });
        }
    }
}
