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

        public string Leer(string ruta)
        {
            if(ValidarExtension(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return streamReader.ReadToEnd();
                }
            }
            return null;
        }
    }
}
