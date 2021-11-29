using Entidades;
using System;
using System.Collections.Generic;

namespace Extension
{
    public static class ExtensoraRandom
    {
        /// <summary>
        /// Metodo de extension de la clase Persona, genera un numero aleatorio entre 0 y el tamaño de la lista
        /// </summary>
        /// <param name="listaPersonas">lista para generar el numero random</param>
        /// <returns>numero aleatorio entre 0 y el tamaño de la lista recibida por parametro</returns>
        public static int GenerarNumeroRandom(this List<Persona> listaPersonas)
        {
            Random random = new Random();
            return random.Next(0, listaPersonas.Count);
        }

    }
}
