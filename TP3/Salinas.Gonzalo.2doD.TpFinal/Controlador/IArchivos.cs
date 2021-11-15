using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    interface IArchivos<T>
    {
        public void Guardar(string ruta, T contenido);
        public T Leer(string ruta);


    }
}
