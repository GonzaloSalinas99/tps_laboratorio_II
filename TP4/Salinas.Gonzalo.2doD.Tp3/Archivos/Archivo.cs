using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;


namespace Archivos
{
    public abstract class Archivo
    {
        public abstract string Extension { get; }

        public bool ValidarExtension(string ruta)
        {
            if (!String.IsNullOrWhiteSpace(ruta) && Path.GetExtension(ruta) == Extension)
            {
                return true;
            }
            else
            {
                throw new Excepciones.Excepciones($"El archivo no tiene la extension {Extension}");

            }
        }

        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if (File.Exists(ruta))
            {
                return true;
            }
            else
            {
                throw new Excepciones.Excepciones("El archivo no se encontro");

            }
        }

    }
}