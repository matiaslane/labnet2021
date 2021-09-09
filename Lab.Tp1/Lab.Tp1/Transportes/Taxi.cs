using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp1.Clases
{
    public class Taxi : TransportePublico
    {
        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {
        }
        public override void Avanzar() { }
        public override void Detenerse() { }
    }
}
