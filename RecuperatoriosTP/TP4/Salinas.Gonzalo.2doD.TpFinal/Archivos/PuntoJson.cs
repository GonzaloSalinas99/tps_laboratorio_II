using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using Archivos;

namespace Controlador
{
    
    public class PuntoJson<T> : Archivo, IArchivos<T>
    where T : class
    {
        public override string Extension
        {
            get { return ".json"; }
        }

        /// <summary>
        /// Guarda informacion en el archivo
        /// </summary>
        /// <param name="ruta">Ruta al archivo</param>
        /// <param name="contenido">Informacion a guardar</param>

        public void Guardar(string ruta, T contenido)
        {
            if(ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }
        /// <summary>
        /// Serializa en formato .Json
        /// </summary>
        /// <param name="ruta">Ruta al archivo donde se va a guardar la informacion</param>
        /// <param name="contenido">Informacion a serializar</param>

        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                string json = JsonSerializer.Serialize(contenido);
                streamWriter.Write(json);
            }
        }
    }
}
