using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp1.Clases
{
    public abstract class TransportePublico
    {
        public int pasajeros { get; protected set;}

        public TransportePublico(int cantidadPasajeros)
        {
            this.pasajeros = cantidadPasajeros;
        }
        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}