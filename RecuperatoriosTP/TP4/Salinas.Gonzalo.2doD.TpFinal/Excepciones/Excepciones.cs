using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class Excepciones : Exception
    {
        public Excepciones(string mensaje) : this(mensaje, null)
        {
        }
        public Excepciones(string mensaje, Exception exception) : base(mensaje, exception)
        {
        }


    }
}
