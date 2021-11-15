using System;
using Entidades;
using Controlador;
using System.IO;

using System.Collections.Generic;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> lista = CARGA();

            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "Alumnoss.json");

            //using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            //{
            //    foreach (Alumno item in lista)
            //    {
            //        streamWriter.WriteLine(item.ToString());
            //    }
            //}


            //using (StreamReader streamReader = new StreamReader(rutaArchivo))
            //{
            //    string lectura;
            //    while ((lectura = streamReader.ReadLine()) != null)
            //    {
            //        char[] separador = new char[] { ',' };
            //        string[] informacion = lectura.Split(separador, StringSplitOptions.RemoveEmptyEntries);

            //        try
            //        {
            //            if (informacion.Length == 7)
            //            {
            //                lista.Add(new Alumno(informacion[0], informacion[1], informacion[2],
            //                    int.Parse(informacion[3]), informacion[4], int.Parse(informacion[5]), Convert.ToDateTime(informacion[6])));
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            throw new Excepciones.Excepciones("No contiene los 7 campos requeridos");
            //        }
            //    }
            //}
            //Alumno a1 = new Alumno("facundo", "salinas", "40038608", 21, "123123", 2, new DateTime(2020, 7, 02));

            PuntoJson<Alumno> puntoJson = new PuntoJson<Alumno>();
            //Alumno alumno; 
            //alumno = puntoJson.Leer(rutaArchivo);

            foreach (Alumno item in lista)
            {
                puntoJson.GuardarComo(rutaArchivo, item);

            }

            Console.WriteLine("Carge el json");


            foreach (Alumno item in lista)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static List<Alumno> CARGA()
        {
            Procesador c1 = new Procesador();
            Alumno a1 = new Alumno("Gonzalo", "Fernandez", "12345678", 21, "123123", 2, new DateTime(2020, 7, 02));
            Alumno a2 = new Alumno("quimey", "espinosa", "42038629", 21, "123456", 3, new DateTime(2020, 2, 10));

            c1.AgregarAlumno(a1);
            c1.AgregarAlumno(a2);


            return c1.ListaAlumnos;

        }

        
    }
}
