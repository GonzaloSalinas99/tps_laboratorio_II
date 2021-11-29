using Entidades;
using Extension;
using Logueo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Controlador
{
    public delegate void DelegadoPersonas(Persona persona);
    public class Manejador
    {

        public event DelegadoPersonas AgregarPersonaADB;

        /// <summary>
        /// recibe una lista de personas y ejecuta el metodo MoverPersonas en un hilo paralelo
        /// </summary>
        /// <param name="listaPersonas">lista a ser usada</param>
        public void IniciarManejador(List<Persona> listaPersonas)
        {
            Task hilo = new Task(() => MoverPersonas(listaPersonas));
            hilo.Start();
        }

        /// <summary>
        /// Recibe una lista de personas, la itera y va agregando a la persona a la base de datos, suspende el hilo 1500 milisegundos y si el evento tiene suscriptores, lo lanza
        /// </summary>
        /// <param name="listaPersonas">lista a ser iterada</param>
        private void MoverPersonas(List<Persona> listaPersonas)
        {
            Alumno alumnoAux;
            Profesor profesorAux;
            for (int i = 0; i < listaPersonas.Count; i++)
            {
                if (listaPersonas[i] is Alumno)
                {
                    alumnoAux = (Alumno)listaPersonas[i];
                    LogDB.InsertarInfoEnDB(alumnoAux);
                    Thread.Sleep(1500);
                }
                else
                {
                    if (listaPersonas[i] is Profesor)
                    {
                        profesorAux = (Profesor)listaPersonas[i];
                        LogDB.InsertarInfoEnDB(profesorAux);
                        Thread.Sleep(1500);
                    }
                }

                if (AgregarPersonaADB is not null)
                {
                    AgregarPersonaADB.Invoke(listaPersonas[i]);
                }
                i--;
            }
        }

    }
}
