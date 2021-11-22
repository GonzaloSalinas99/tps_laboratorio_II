using System;
using System.Collections.Generic;
using System.IO;
using Entidades;
using System.Text.Json;
using System.Text;

namespace Controlador
{
    public class Procesador<T> where T : class
    {
        private List<T> personas;

        public Procesador()
        {
            personas = new List<T>();
        }

        public List<T> Personas
        {
            get { return personas; }
            set { personas = value; }
        }


        public static bool operator ==(Procesador<T> lista, T alumno)
        {
            if (lista is not null && alumno is not null)
            {
                if (lista.personas.Count > 0)
                {
                    foreach (T alumnoAux in lista.personas)
                    {
                        if (alumno == alumnoAux)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    lista.personas.Add(alumno);
                    return true;
                }

            }
            return false;
        }

        public static bool operator !=(Procesador<T> lista, T alumno)
        {
            return !(lista == alumno);
        }

        public static bool operator +(Procesador<T> lista, T alumno)
        {
            if (lista is not null && alumno is not null && lista != alumno)
            {
                lista.personas.Add(alumno);
                return true;
            }
            return false;
        }



        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T alumnoAux in personas)
            {
                sb.AppendLine(alumnoAux.ToString());
            }

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            T alumnoAux = obj as T;
            return (alumnoAux is not null && this == alumnoAux);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }





    }
}

