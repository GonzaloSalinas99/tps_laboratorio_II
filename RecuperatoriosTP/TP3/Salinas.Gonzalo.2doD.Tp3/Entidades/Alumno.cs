using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Entidades
{

    [XmlInclude(typeof(Persona))]
    public class Alumno : Persona
    {
        private string legajo;
        private int cuatrimestreActual;
        private DateTime fechaIngreso;

        public Alumno(string nombre, string apellido, string dni, int edad, string legajo, int cuatrimestreActual, DateTime fechaIngreso) : this(nombre, apellido, dni, edad)
        {
            Legajo = legajo;
            CuatrimestreActual = cuatrimestreActual;
            FechaIngreso = fechaIngreso;
        }

        public Alumno(string nombre, string apellido, string dni, int edad) : base(nombre, apellido, dni, edad)
        {
        }

        public Alumno()
        {
        }

        /// <summary>
        /// Propiedad de lectura y escritura de FechaIngreso
        /// </summary>
        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de Legajo
        /// </summary>
        public string Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de CuatrimestreActual
        /// </summary>
        public int CuatrimestreActual
        {
            get { return this.cuatrimestreActual; }
            set { cuatrimestreActual = value; }
        }
        /// <summary>
        /// Sobrescritura del metodo ToString() que devuelve info sobre el Alumno
        /// </summary>
        /// <returns>String con los datos del alumno</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine($"Nº Legajo: {Legajo}");
            stringBuilder.AppendLine($"Cuatrimestre Cursando: {CuatrimestreActual}");
            stringBuilder.AppendLine($"Fecha de Ingreso: {FechaIngreso.ToShortDateString()}"); stringBuilder.AppendLine("---------------------------");

            return stringBuilder.ToString();
        }
    }
}