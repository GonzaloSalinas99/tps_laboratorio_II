using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private double salario;
        private DateTime fechaIngreso;

        public Profesor(string nombre, string apellido, string dni, int edad) : base(nombre, apellido, dni, edad)
        {
        }

        public Profesor(string nombre, string apellido, string dni, int edad, double salario, DateTime fechaIngreso) : this(nombre, apellido, dni, edad)
        {
            Salario = salario;
            FechaIngreso = fechaIngreso;
        }

        public Profesor()
        {
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(base.ToString());
            stringBuilder.AppendLine($"Salario: {Salario}");
            stringBuilder.AppendLine($"Fecha de Ingreso: {FechaIngreso}");
            stringBuilder.AppendLine("---------------------------");

            return stringBuilder.ToString();
        }
    }
}
