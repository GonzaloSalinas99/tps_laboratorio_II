﻿using Archivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Controlador
{
    public class PuntoXml<T> : Archivo, IArchivos <T> where T : class
    {
        public override string Extension 
        {
            get { return ".xml"; }
        }
        /// <summary>
        /// Guarda informacion en un archivo .xml
        /// </summary>
        /// <param name="ruta">Ruta al archivo donde se va a guardar la informacion</param>
        /// <param name="contenido">Informacion a ser guardada</param>
        public void Guardar(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }
        /// <summary>
        /// Serializa en formato .xml
        /// </summary>
        /// <param name="ruta">Ruta al archivo donde se va a serializar la informacion</param>
        /// <param name="contenido">Infromacion a ser serializada</param>
        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(streamWriter, contenido);
            }
        }
        /// <summary>
        /// Lee informacion de un archivo .xml
        /// </summary>
        /// <param name="ruta">Ruta al archivo donde se va a realizar la lectura</param>
        /// <returns></returns>
        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    return xmlSerializer.Deserialize(streamReader) as T;
                }
            }

            return null;
        }
    }
}
