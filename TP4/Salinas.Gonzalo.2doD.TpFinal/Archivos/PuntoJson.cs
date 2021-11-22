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
        
        public void Guardar(string ruta, T contenido)
        {
            if(ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                string json = JsonSerializer.Serialize(contenido);
                streamWriter.Write(json);
            }
        }


        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {

                    string json = streamReader.ReadToEnd();
                    T contenido = JsonSerializer.Deserialize<T>(json);
                    return contenido;
                    
                }

            }
            return null;
        }
    }
}
