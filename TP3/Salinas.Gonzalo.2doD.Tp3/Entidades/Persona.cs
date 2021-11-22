using System;
using System.Text;
using System.Xml.Serialization;
namespace Entidades
{
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Profesor))]

    public class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        private int edad;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, string dni, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Edad = edad;
        }

        public override int GetHashCode()
        {
            return int.Parse(dni);
        }

        public override bool Equals(object obj)
        {
            if (obj is not null && obj is Persona)
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1 is not null && p2 is not null)
            {
                if (p1.GetHashCode() == p2.GetHashCode())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Nombre: {Nombre}");
            stringBuilder.AppendLine($"Apellido: {Apellido}");
            stringBuilder.AppendLine($"DNI: {Dni}");
            stringBuilder.AppendLine($"Edad: {Edad}");

            return stringBuilder.ToString();
        }


    }
}
