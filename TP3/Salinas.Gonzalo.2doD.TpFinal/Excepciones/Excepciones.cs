using System;

namespace Excepciones
{
    public class Excepciones : Exception
    {
        public Excepciones(string mensaje):this(mensaje,null)
        {
        }
        public Excepciones(string mensaje,Exception exception):base(mensaje,exception)
        {
        }

    }
}
