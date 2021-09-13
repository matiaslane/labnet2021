using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Tp2.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() : base("Mensaje de error custom")
        {

        }

    }
}
