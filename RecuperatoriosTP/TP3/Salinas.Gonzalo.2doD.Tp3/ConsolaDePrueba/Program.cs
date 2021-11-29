using Controlador;
using Entidades;
using System;
using System.IO;

namespace ConsolaDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            //Procesador<Persona> listaPersonas = new Procesador<Persona>();
            //Persona a1 = new Alumno("Gaston", "Fernandez", "12345678", 21, "123123", 2, new DateTime(2020, 7, 02));
            //Persona a2 = new Alumno("Franco", "Alvarez", "42424242", 20, "1111", 1, new DateTime(2021, 7, 10));
            //Persona a3 = new Alumno("Elias", "Troncoso", "42038608", 22, "9999", 3, new DateTime(2019, 02, 18));

            //Persona p1 = new Profesor("Mauricio", "Cerizza", "39213123", 26, 150000, new DateTime(2018, 02, 02));
            //Persona p2 = new Profesor("Lautaro", "Galarza", "40121234", 24, 98000, new DateTime(2021, 03, 11));
            //Persona p3 = new Profesor("Mauricio", "Davila", "33112233", 29, 300002, new DateTime(2010, 01, 01));

            //_ = listaPersonas + a1;
            //_ = listaPersonas + a2;
            //_ = listaPersonas + a3;

            //_ = listaPersonas + p1;
            //_ = listaPersonas + p2;
            //_ = listaPersonas + p3;

            


            //string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ////string rutaArchivo = Path.Combine(rutaEscritorio, "PruebaConsola.json");
            ////PuntoJson<Procesador<Persona>> puntoJson = new PuntoJson<Procesador<Persona>>();
            ////puntoJson.Guardar(rutaArchivo, listaPersonas);

            //string rutaArchivoXml = Path.Combine(rutaEscritorio, "ALUMNES.xml");

            ////PuntoXml<Procesador<Persona>> puntoXml = new PuntoXml<Procesador<Persona>>();
            ////puntoXml.Guardar(rutaArchivoXml, listaPersonas);

            //PuntoXml<Procesador<Persona>> puntoXml = new PuntoXml<Procesador<Persona>>();
            //listaPersonas = puntoXml.Leer(rutaArchivoXml);


            //foreach (Persona persona in listaPersonas.Personas)
            //{
            //    Console.WriteLine(persona.ToString());
            //}
        }
    }
}
