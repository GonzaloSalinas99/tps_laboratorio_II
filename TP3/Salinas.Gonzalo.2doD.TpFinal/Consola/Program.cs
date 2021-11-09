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
            string rutaArchivo = Path.Combine(rutaEscritorio, "Alumno.txt");

            using (StreamWriter streamWriter = new StreamWriter(rutaArchivo))
            {
                foreach (Alumno item in lista)
                {
                    streamWriter.WriteLine(item.ToString());
                }
            }


            using (StreamReader streamReader = new StreamReader(rutaArchivo))
            {
                string lectura = streamReader.ReadToEnd();
            }

        }

        public static List<Alumno> CARGA()
        {
            Control c1 = new Control();
            Alumno a1 = new Alumno("gonzalo", "salinas", "42038608", 21, "123123", 2, new DateTime(2020, 7, 02));
            Alumno a2 = new Alumno("quimey", "espinosa", "42038629", 21, "123456", 3, new DateTime(2020, 2, 10));

            c1.AgregarAlumno(a1);
            c1.AgregarAlumno(a2);


            return c1.ListaAlumnos;

        }

        
    }
}
