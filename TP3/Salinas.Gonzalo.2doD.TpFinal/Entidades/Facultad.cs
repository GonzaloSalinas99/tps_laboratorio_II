using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Facultad<T> where T : class
    {
        private List<T> listaIngresados;

        public Facultad()
        {
            listaIngresados = new List<T>();
        }

        public List<T> ListaIngresados
        {
            get { return listaIngresados; }
        }

        public bool Agregar(T ingresante)
        {
            if(ingresante is not null)
            {
                foreach (T ingresado in listaIngresados)
                {
                    if(ingresado != ingresante)
                    {
                        listaIngresados.Add(ingresante);
                        return true;
                    }
                }
            }
            return false;
        }

        public List<T> MostrarLista()
        {
            if(listaIngresados.Count>0)
            {
                return ListaIngresados;
            }
            return null;
        }
    }
}
