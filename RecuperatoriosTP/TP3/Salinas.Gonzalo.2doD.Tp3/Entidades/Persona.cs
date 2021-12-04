using System;
using System.Text;
using System.Xml.Serialization;
namespace Entidades
{
    /// <summary>
    /// Enumerado de Genero
    /// </summary>
    public enum EGenero
    {
        Masculino,
        Femenino,
    }
    /// <summary>
    /// Enumerado de Estudio Secundario
    /// </summary>
    public enum ESecundario
    {
        Completo,
        Incompleto,
    }
    /// <summary>
    /// Enumerado de Pais
    /// </summary>
    public enum EPais
    {
        Argentina,
        Chile,
        Venezuela,
        Colombia,
        Mexico,
    }

    public class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        private int edad;
        private EGenero genero;
        private int salario;
        private ESecundario estudioSecundario;
        private EPais paisNacido;

        /// <summary>
        /// Propiedad de lectura y escritura de Nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }


        /// <summary>
        /// Propiedad de lectura y escritura de Apellido
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Dni
        /// </summary>
        public string Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Edad
        /// </summary>
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Genero
        /// </summary>
        public EGenero Genero
        {
            get { return genero; }
            set { genero = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de Salario
        /// </summary>
        public int Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de EstudioSecundario
        /// </summary>
        public ESecundario EstudioSecundario
        {
            get { return estudioSecundario; }
            set { estudioSecundario = value; }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de PaisNacido
        /// </summary>
        public EPais PaisNacido
        {
            get { return paisNacido; }
            set { paisNacido = value; }
        }
        /// <summary>
        /// constructor sin parametro
        /// </summary>
        public Persona()
        {
        }

        
        public Persona(string nombre, string apellido, string dni, int edad, EGenero genero, int salario, ESecundario secundarioCompleto, EPais paisNacido)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Edad = edad;
            Genero = genero;
            Salario = salario;
            EstudioSecundario = secundarioCompleto;
            PaisNacido = paisNacido;
        }
        /// <summary>
        /// sobrescritura del metodo GetHashCode
        /// </summary>
        /// <returns>Retorna el numero de dni</returns>
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
        /// <summary>
        /// Verfica si dos personas son iguales por su dni
        /// </summary>
        /// <param name="p1">persona a verificar</param>
        /// <param name="p2">persona a verificar</param>
        /// <returns>true si tienen el mismo numero de documento, false si no lo son</returns>
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
        /// <summary>
        /// Verifica que dos personas no tengan el mismo Dni
        /// </summary>
        /// <param name="p1">persoan a verificar</param>
        /// <param name="p2">persona a verificar</param>
        /// <returns>true si no lo tiene, false si si</returns>
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Sobrescritura del metodo ToString() que devuelve info sobre la Persona
        /// </summary>
        /// <returns>string con los datos de la persona</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            

            stringBuilder.AppendLine($"Nombre: {Nombre}");
            stringBuilder.AppendLine($"Apellido: {Apellido}");
            stringBuilder.AppendLine($"DNI: {Dni}");
            stringBuilder.AppendLine($"Edad: {Edad}");
            stringBuilder.AppendLine($"Genero: {Genero}");
            stringBuilder.AppendLine($"Secundario: {EstudioSecundario}");
            stringBuilder.AppendLine($"Salario: ${Salario}");
            stringBuilder.AppendLine($"Nacionalidad: {PaisNacido}");
            
            return stringBuilder.ToString();
        }


    }
}
