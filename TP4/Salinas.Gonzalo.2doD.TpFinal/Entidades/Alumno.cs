using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Entidades
{
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

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        public string Legajo
        {
            get { return this.legajo; }
            set { this.legajo = value; }
        }

        public int CuatrimestreActual
        {
            get { return this.cuatrimestreActual; }
            set { cuatrimestreActual = value; }
        }

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