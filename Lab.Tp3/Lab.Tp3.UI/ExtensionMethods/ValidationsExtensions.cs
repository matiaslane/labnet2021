using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp3.UI.ExtensionMethods
{
    public static class ValidationsExtensions
    {
        public static int Validar_Numero(this string valorIngresado)
        {
            int c;
            while (!int.TryParse(valorIngresado, out c))
            {
                Console.WriteLine("Ingrese valor numerico.");
                valorIngresado = Console.ReadLine();
            }
            int numero = Convert.ToInt32(valorIngresado);
            return numero;
        }

        public static int Validar_Numero_Para_Switch(this string valorIngresado)
        {
            int c;
            while (!int.TryParse(valorIngresado, out c))
            {
                Console.WriteLine("Ingrese valor numerico entre 1 y 5.");
                valorIngresado = Console.ReadLine();
            }
            int numero = Convert.ToInt32(valorIngresado);
            return numero;
        }
    }
}
