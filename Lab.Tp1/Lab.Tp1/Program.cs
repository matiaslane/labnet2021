using Lab.Tp1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Omnibus> listaOmnibus = new List<Omnibus>();
            List<Taxi> listaTaxi = new List<Taxi>();

            while (true)
            {
                Console.WriteLine("Ingrese que Transporte desea cargar: \na)Omnibus \nb)Taxi");
                var transporte = Console.ReadLine();
                for(; ; ) {
                    if(transporte != "a" && transporte != "b"){
                        Console.WriteLine("Ingrese 'a' para Omnibus o 'b' para taxi.");
                        transporte =Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
                
                Console.WriteLine("Ingrese cantidad de pasajeros");
                var cantidad = Console.ReadLine();
              
                int c;
                while (!int.TryParse(cantidad, out c))
                {
                    Console.WriteLine("Ingrese cantidad de pasajeros en numero");
                    cantidad = Console.ReadLine();
                }

                int cantidadPasajeros = Convert.ToInt32(cantidad);
                //int cantidadPasajeros = Convert.ToInt32(Console.ReadLine());

                if (transporte == "a")
                {
                    var tipoTransporte = new Omnibus(cantidadPasajeros);
                    listaOmnibus.Add(tipoTransporte);
                }
                else
                {
                    var tipoTransporte = new Taxi(cantidadPasajeros);
                    listaTaxi.Add(tipoTransporte);
                }

                Console.WriteLine("Ingrese 1 para listar o cualquier otra tecla para seguir ingresando.");
                var condicion = Console.ReadLine();
                if (condicion == "1")
                {
                    break;
                }
            }

            int indexOmnibus = 1;
            foreach (var omnibus in listaOmnibus)
            {
                Console.WriteLine("Omnibus " + indexOmnibus + ": " + omnibus.pasajeros + " pasajeros.");
                indexOmnibus++;
            }

            int indexTaxi = 1;
            foreach (var taxi in listaTaxi)
            {
                Console.WriteLine("Taxi " + indexTaxi + ": " + taxi.pasajeros + " pasajeros.");
                indexTaxi++;
            }

            Console.ReadLine();
        }
    }
}
