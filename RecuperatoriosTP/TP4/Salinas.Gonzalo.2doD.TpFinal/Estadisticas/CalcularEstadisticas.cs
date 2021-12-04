using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estadisticas
{
    public static class CalcularEstadisticas
    {
        /// <summary>
        /// Calcula la personas con mayor edad en el sistema
        /// </summary>
        /// <param name="listaPersonas">lista a leer los datos</param>
        /// <returns>retorna los datos de la persona</returns>
        public static string CalcularPersonaConMayorEdad(Procesador<Persona> listaPersonas)
        {
            Persona persona = null;
            if (listaPersonas is not null && listaPersonas.Personas.Count > 0)
            {


                for (int i = 0; i < listaPersonas.Personas.Count; i++)
                {
                    if (i == 0 || listaPersonas.Personas[i].Edad > persona.Edad)
                    {
                        persona = listaPersonas.Personas[i];
                    }
                }
            }
            StringBuilder respuesta = new StringBuilder();
            respuesta.AppendLine("La Persona Con Mayor Edad Es: ");
            respuesta.AppendLine(persona.ToString());
            return respuesta.ToString();
        }
        /// <summary>
        /// Calcula la cantidad de personas que hay en el sistema de todos los paises
        /// </summary>
        /// <param name="listaPersonas">lista a leer los datos</param>
        /// <returns>retorna la cantidad de personas que hay en el sistemas de todos los paises en un string</returns>
        public static string CalcularCantidadDePersonasPorPais(Procesador<Persona> listaPersonas)
        {
            StringBuilder respuesta = new StringBuilder();
            if (listaPersonas is not null && listaPersonas.Personas.Count > 0)
            {
                int contadorArgentina = 0;
                int contadorChile = 0;
                int contadorColombia = 0;
                int contadorVenezuela = 0;
                int contadorMexico = 0;

                foreach (Persona personas in listaPersonas.Personas)
                {
                    if (personas.PaisNacido == EPais.Argentina)
                    {
                        contadorArgentina++;
                    }
                    else
                    {
                        if (personas.PaisNacido == EPais.Chile)
                        {
                            contadorChile++;
                        }
                        else
                        {
                            if (personas.PaisNacido == EPais.Colombia)
                            {
                                contadorColombia++;
                            }
                            else
                            {
                                if (personas.PaisNacido == EPais.Mexico)
                                {
                                    contadorMexico++;
                                }
                                else
                                {
                                    contadorVenezuela++;
                                }
                            }
                        }
                    }
                }
                respuesta.AppendLine($"En Argentina hay un total de {contadorArgentina} personas cargadas.");
                respuesta.AppendLine($"En Chile hay un total de {contadorChile} personas cargadas.");
                respuesta.AppendLine($"En Colombia hay un total de {contadorColombia} personas cargadas.");
                respuesta.AppendLine($"En Mexico hay un total de {contadorMexico} personas cargadas.");
                respuesta.AppendLine($"En Venezuela hay un total de {contadorVenezuela} personas cargadas.");

            }

            return respuesta.ToString();
        }
        /// <summary>
        /// Calcula el promedio de genero de personas cargadas en el sistema
        /// </summary>
        /// <param name="listaPersonas">lista a leer los datos</param>
        /// <returns>retorna el promedio de genero de personas cargadas en el sistema en un string</returns>
        public static string CalcularPromedioDeGenerosDePersonasCargadas(Procesador<Persona> listaPersonas)
        {
            StringBuilder respuesta = new StringBuilder();
            if (listaPersonas is not null && listaPersonas.Personas.Count > 0)
            {
                int contadorMasculino = 0;
                int contadorFemenino = 0;

                foreach (Persona persona in listaPersonas.Personas)
                {
                    if (persona.Genero == EGenero.Masculino)
                    {
                        contadorMasculino++;
                    }
                    else
                    {
                        contadorFemenino++;
                    }
                }

                respuesta.AppendLine($"El promedio de personas con genero Masculino es de {((float)contadorMasculino / listaPersonas.Personas.Count) * 100}.");
                respuesta.AppendLine($"El promedio de personas con genero Femenino es de {((float)contadorFemenino / listaPersonas.Personas.Count) * 100}.");
            }
            else
            {
                respuesta.AppendLine("No hay personas cargadas en el sistema.");
            }
            return respuesta.ToString();
        }
        /// <summary>
        /// Ordena la lista por salario dependiendo el orden que se le pase
        /// </summary>
        /// <param name="listaPersona">lista a leer los datos a calcular</param>
        /// <param name="orden">orden de como se ordena la lista</param>
        /// <returns>Retorna la lista ordenada</returns>
        public static IEnumerable<Persona> OrdenarListaPorSalario(Procesador<Persona> listaPersona, int orden)
        {
            IEnumerable<Persona> listaOrdenada = null;
            if (listaPersona is not null && listaPersona.Personas.Count > 0)
            {

                if (orden == 0)
                {
                    listaOrdenada = listaPersona.Personas.OrderBy(personas => personas.Salario);
                }
                else
                {
                    listaOrdenada = listaPersona.Personas.OrderByDescending(personas => personas.Salario);
                }
            }

            return listaOrdenada;
        }
        /// <summary>
        /// Calcula la cantidad de personas con estudio secundario en el sistema
        /// </summary>
        /// <param name="listaPersona">lista a leer los datos a calcular</param>
        /// <param name="orden">opcion para filtrar los datos</param>
        /// <returns>La cantidad de personas con estudio secundario en el sistema dependiendo la opcion</returns>
        public static string CalcularCantidadDePersonasConEstudioSecundario(Procesador<Persona> listaPersonas, int opcion)
        {
            StringBuilder respuesta = new StringBuilder();
            int contadorSecundarioCompleto = 0;
            int contadorSecundarioIncompleto = 0;
            if (listaPersonas is not null && listaPersonas.Personas.Count > 0)
            {
                foreach (Persona persona in listaPersonas.Personas)
                {
                    if (persona.EstudioSecundario == ESecundario.Completo)
                    {
                        contadorSecundarioCompleto++;
                    }
                    else
                    {
                        if (persona.EstudioSecundario == ESecundario.Incompleto)
                        {
                            contadorSecundarioIncompleto++;
                        }
                    }

                }
            }
            if (opcion == 0)
            {
                respuesta.AppendLine($"En el sistema hay un total de {contadorSecundarioCompleto} personas con el secundario completo.");
            }
            else
            {
                respuesta.AppendLine($"En el sistema hay un total de {contadorSecundarioIncompleto} personas con el secundario incompleto.");
            }
            return respuesta.ToString();
        }
        /// <summary>
        /// Calcula el promedio,minimo,maximo de salarios de las personas cargadas en el sistema
        /// </summary>
        /// <param name="listaPersona">lista a leer los datos a calcular</param>
        /// <returns>Retorna el promedio,minimo,maximo de salarios de las personas cargadas en el sistema en un string</returns>
        public static string CalcularPromedio_Minimo_Maximo_DeSalarios(Procesador<Persona> listaPersonas)
        {
            int acumulador = 0;
            Persona personaSalarioMaximo = null;
            Persona personaSalarioMinimo = null;
            StringBuilder respuesta = new StringBuilder();
            if (listaPersonas is not null && listaPersonas.Personas.Count > 0)
            {
                for (int i = 0; i < listaPersonas.Personas.Count; i++)
                {
                    if (i == 0)
                    {
                        personaSalarioMaximo = listaPersonas.Personas[i];
                        personaSalarioMinimo = listaPersonas.Personas[i];
                    }
                    if (personaSalarioMaximo.Salario < listaPersonas.Personas[i].Salario)
                    {
                        personaSalarioMaximo = listaPersonas.Personas[i];
                    }
                    if (personaSalarioMinimo.Salario > listaPersonas.Personas[i].Salario)
                    {
                        personaSalarioMinimo = listaPersonas.Personas[i];
                    }
                    acumulador += listaPersonas.Personas[i].Salario;
                }

                respuesta.AppendLine($"{personaSalarioMaximo.Nombre} tiene el mayor salario que es de ${personaSalarioMaximo.Salario}.");
                respuesta.AppendLine($"{personaSalarioMinimo.Nombre} tiene el menor salario que es de ${personaSalarioMinimo.Salario}.");
                respuesta.AppendLine($"El promedio total de salarios es de {acumulador / listaPersonas.Personas.Count}.");
            }
            else
            {
                respuesta.AppendLine("No hay personas cargadas en el sistema.");
            }

            return respuesta.ToString();
        }
    }
}
