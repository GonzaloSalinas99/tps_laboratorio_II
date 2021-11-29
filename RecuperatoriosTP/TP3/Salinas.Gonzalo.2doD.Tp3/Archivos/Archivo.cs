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
        /// <summary>
        /// Valida la extension del archivo recibido
        /// </summary>
        /// <param name="ruta">Archivo a validar su extension</param>
        /// <returns> true si coincide la extensio del archivo con la de la clase, false si no lo hace</returns>
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
        /// <summary>
        /// Valida si existe el archivo recibido
        /// </summary>
        /// <param name="ruta">Archivo a validar</param>
        /// <returns> true si existe el archivo, false si no lo hace</returns>
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