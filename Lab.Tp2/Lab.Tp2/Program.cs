using Lab.Tp2;
using Lab.Tp2.Extensions;
using System;

namespace Tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ingrese numero para seleccionar el ejercicio (1, 2, 3, 4)");
                int numero = Convert.ToInt32(Console.ReadLine());

                switch (numero)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Ingrese un numero");
                            int valor = Convert.ToInt32(Console.ReadLine());
                            valor.DividirPorCero();
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(String.Format("Mensaje de la Excepcion: '{0}'.", ex.Message));
                        }
                        finally
                        {
                            Console.WriteLine("Siempre muestro el resultado!");
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Ingrese dos numeros para dividir:");
                            decimal valor1 = Convert.ToInt32(Console.ReadLine());
                            decimal valor2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(valor1.Dividir(valor2));
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Solo Chuck Norris divide por cero!.");
                            Console.WriteLine(Environment.NewLine);
                            Console.WriteLine(String.Format("Mensaje de la Excepcion: '{0}'.", ex.Message));
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
                        }
                        break;

                    case 3:
                        try
                        {
                            var app = new Logic();
                            Console.WriteLine("Vamos a lanzar una excepcion:");
                            int valor = Convert.ToInt32(Console.ReadLine());
                            app.EjercicioTres(valor);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.TargetSite);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine(ex.TargetSite);
                        }
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("Vamos a lanzar una excepcion personalizada:");
                            Console.WriteLine("Presione cualquier tecla para continuar.");
                            Console.ReadLine();
                            var app = new Logic();
                            app.EjercicioCuatro();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Capturamos Custom Exception.{0}", ex.Message);
                            Console.WriteLine(ex.TargetSite);
                        }
                        break;
                }

                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Ingrese 1 para elegir otro ejercicio o cualquier otra tecla para salir.");
                var condicion = Console.ReadLine();
                if (condicion != "1")
                {
                    break;
                }
            }
        }
    }
}