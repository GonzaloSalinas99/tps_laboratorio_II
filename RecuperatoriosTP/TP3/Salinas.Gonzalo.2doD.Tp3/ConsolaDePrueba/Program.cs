using Controlador;
using Entidades;
using System;
using System.IO;
using Estadisticas;
namespace ConsolaDePrueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Procesador<Persona> listaPersonas = new Procesador<Persona>();
            //Persona a1 = new Persona("Gaston", "Fernandez", "12345678", 21, EGenero.Masculino, 22000, ESecundario.Completo, EPais.Argentina);
            //Persona a2 = new Persona("Gonzalo", "Salinas", "42038608", 22, EGenero.Masculino, 37000, ESecundario.Completo, EPais.Argentina);
            //Persona a3 = new Persona("Juan", "Fernandez", "11122233", 32, EGenero.Masculino, 10000, ESecundario.Incompleto, EPais.Venezuela);
            //Persona a4 = new Persona("Julia", "Arce", "99988877", 17, EGenero.Femenino, 70000, ESecundario.Incompleto, EPais.Colombia);
            //Persona a5 = new Persona("Raul", "Alberti", "94123123", 26, EGenero.Masculino, 150000, ESecundario.Completo, EPais.Venezuela);
            //Persona a6 = new Persona("Eliana", "Cuervo", "40123456", 24, EGenero.Femenino, 90000, ESecundario.Incompleto, EPais.Chile);
            //Persona a7 = new Persona("Facundo", "Perez", "11111111", 28, EGenero.Masculino, 120000, ESecundario.Completo, EPais.Mexico);
            //Persona a8 = new Persona("Trixie", "Tang", "99118822", 19, EGenero.Femenino, 30000, ESecundario.Incompleto, EPais.Mexico);


            //_ = listaPersonas + a1;
            //_ = listaPersonas + a2;
            //_ = listaPersonas + a3;
            //_ = listaPersonas + a4;
            //_ = listaPersonas + a5;
            //_ = listaPersonas + a6;
            //_ = listaPersonas + a7;
            //_ = listaPersonas + a8;





            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string rutaArchivo = Path.Combine(rutaEscritorio, "PruebaConsola.json");
            //PuntoJson<Procesador<Persona>> puntoJson = new PuntoJson<Procesador<Persona>>();
            //puntoJson.Guardar(rutaArchivo, listaPersonas);

            string rutaArchivoXml = Path.Combine(rutaEscritorio, "Personas.xml");

            //PuntoXml<Procesador<Persona>> puntoXml = new PuntoXml<Procesador<Persona>>();
            //puntoXml.Guardar(rutaArchivoXml, listaPersonas);

            PuntoXml<Procesador<Persona>> puntoXml = new PuntoXml<Procesador<Persona>>();
            listaPersonas = puntoXml.Leer(rutaArchivoXml);


            foreach (Persona persona in listaPersonas.Personas)
            {
                Console.WriteLine(persona.ToString());
            }

            Console.WriteLine(CalcularEstadisticas.CalcularCantidadDePersonasConEstudioSecundario(listaPersonas,0));
            Console.WriteLine(CalcularEstadisticas.CalcularCantidadDePersonasPorPais(listaPersonas));
            Console.WriteLine(CalcularEstadisticas.CalcularPersonaConMayorEdad(listaPersonas));
            Console.WriteLine(CalcularEstadisticas.CalcularPromedioDeGenerosDePersonasCargadas(listaPersonas));
            Console.WriteLine(CalcularEstadisticas.CalcularPromedio_Minimo_Maximo_DeSalarios(listaPersonas));

        }
    }
}
