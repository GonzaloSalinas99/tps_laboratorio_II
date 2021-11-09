using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public override string Extension
        {
            get { return ".txt"; }
        }

        public void Guardar(string ruta, string contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                GuardarArchivoTxt(ruta, contenido);
            }
        }


        public void GuardarComo(string ruta, string contenido)
        {
            if (ValidarExtension(ruta))
            {
                GuardarArchivoTxt(ruta, contenido);
            }
        }


        public string Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    return streamReader.ReadToEnd();
                }
            }

            return string.Empty;
        }


        public void GuardarArchivoTxt(string ruta, string contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                streamWriter.WriteLine(contenido);
            }
        }
    }
}
