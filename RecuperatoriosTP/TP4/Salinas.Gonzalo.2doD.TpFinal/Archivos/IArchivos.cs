using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    interface IArchivos<T>
    {
        /// <summary>
        /// Guarda informacion en archivos
        /// </summary>
        /// <param name="ruta">Ruta al archivo donde se va a guardar la informacion</param>
        /// <param name="contenido">Informacion a ser guardada</param>

        public void Guardar(string ruta, T contenido);
    }
}
