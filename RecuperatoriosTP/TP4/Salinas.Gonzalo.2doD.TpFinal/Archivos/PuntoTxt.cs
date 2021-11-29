using Archivos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class PuntoTxt : Archivo,IArchivos<string>
    {
        public override string Extension
        {
            get { return ".txt"; }
        }
        /// <summary>
        /// Guarda la informacion en un archivo .txt
        /// </summary>
        /// <param name="ruta">Ruta al archivo donde se va a guardar la informacion</param>
        /// <param name="contenido">Informacion a ser guardada</param>

        public void Guardar(string ruta, string contenido)
        {
            if(ValidarExtension(ruta))
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    streamWriter.WriteLine(contenido);
                }
            }
        }

    }
}
