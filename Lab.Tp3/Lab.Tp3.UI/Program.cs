using Lab.Tp3.Logic;
using Lab.Tp3.UI.ExtensionMethods;
using System;

namespace Lab.Tp3.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            
            int condicion = 0;
            do
            {
                Console.WriteLine("Ingrese:\n1)Mostrar Categorias \n2)Mostrar Shippers \n3)Agregar nuevo Shiiper \n4)Modificar Shipper \n5)Eliminar Shipper \nCualquier otro numero para salir.");
                Console.WriteLine(Environment.NewLine);

                int valor;
                valor = (Console.ReadLine().Validar_Numero_Para_Switch());
                switch (valor)
                {
                    case 1:
                        categoriesLogic.ShowCategories();
                        break;

                    case 2:
                        shippersLogic.ShowShippers();
                        break;

                    case 3:
                        shippersLogic.AddShipper();
                        break;

                    case 4:
                        shippersLogic.UpdateShipper();
                        break;

                    case 5:
                        shippersLogic.DeleteShipper();
                        break;
                    default:
                        return;
                }

                Console.WriteLine("Desea hacer otra operacion?\n1- No\nOtro numero - Si");
                condicion = (Console.ReadLine().Validar_Numero());
            } while (condicion != 1);

            Console.ReadLine();
        }
    }
}
