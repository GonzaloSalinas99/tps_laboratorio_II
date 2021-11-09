using System;
using System.Collections.Generic;
using Entidades;

namespace Controlador
{
    public class Control
    {
        private List<Alumno> listaAlumnos;

        public Control()
        {
            listaAlumnos = new List<Alumno>();
        }

        public List<Alumno> ListaAlumnos
        {
            get { return listaAlumnos; }
        }

        public bool AgregarAlumno(Alumno alumno)
        {
            if(alumno is not null)
            {
                if(listaAlumnos.Count > 0)
                {
                    foreach (Alumno alumnoAux in listaAlumnos)
                    {
                        if (alumno != alumnoAux)
                        {
                            listaAlumnos.Add(alumno);
                            return true;
                        }

                    }
                }
                else
                {
                    listaAlumnos.Add(alumno);
                    return true;
                }
                
            }
            return false;
        }


        public string CalcularAlumnoMasAntiguo()
        {
            Alumno alumnoAux = null;
            if(listaAlumnos.Count > 0)
            {
                for (int i = 0; i < listaAlumnos.Count; i++)
                {
                    if(i == 0 || listaAlumnos[i].FechaIngreso.CompareTo(alumnoAux.FechaIngreso) == -1)
                    {
                        alumnoAux = listaAlumnos[i];

                    }
                }
            }
            return alumnoAux.ToString();
        }



    }
}
