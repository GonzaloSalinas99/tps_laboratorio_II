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

        /// <summary>
        /// Verifica que una persona no este en la lista
        /// </summary>
        /// <param name="lista">lista a ser verificada</param>
        /// <param name="alumno">persona a buscar en la lista</param>
        /// <returns>true si esta en la lista, false si no lo esta</returns>
        public static bool operator ==(Procesador<T> lista, T persona)
        {
            if (lista is not null && persona is not null)
            {
                if (lista.personas.Count > 0)
                {
                    foreach (T alumnoAux in lista.personas)
                    {
                        if (persona == alumnoAux)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    lista.personas.Add(persona);
                    return true;
                }

            }
            return false;
        }
        /// <summary>
        /// Verifica que una persona no este en la lista
        /// </summary>
        /// <param name="lista">lista a ser verificada</param>
        /// <param name="persona">persona a ser buscada</param>
        /// <returns></returns>
        public static bool operator !=(Procesador<T> lista, T persona)
        {
            return !(lista == persona);
        }
        /// <summary>
        /// Agrega una persona a la lista
        /// </summary>
        /// <param name="lista">lista a agregar la persona</param>
        /// <param name="persona">persona a ser agregada</param>
        /// <returns></returns>
        public static bool operator +(Procesador<T> lista, T persona)
        {
            if (lista is not null && persona is not null && lista != persona)
            {
                lista.personas.Add(persona);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Muestra los datos de las personas
        /// </summary>
        /// <returns>String con los datos</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T persona in personas)
            {
                sb.AppendLine(persona.ToString());
            }

            return sb.ToString();
        }
        /// <summary>
        /// Verifica si el obj es del mismo tipo que T
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            T persona = obj as T;
            return (persona is not null && this == persona);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

