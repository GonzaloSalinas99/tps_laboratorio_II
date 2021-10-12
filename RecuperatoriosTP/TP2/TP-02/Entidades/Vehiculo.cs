using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Clase abstracta, no se podra instanciar.
    /// </summary>
    public abstract class Vehiculo
    {
        private string chasis;
        private ConsoleColor color;
        private EMarca marca;
        /// <summary>
        /// Enumerado de tipo Marca de vehiculo
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }


        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}

        /// <summary>
        /// Constructor de vehiculo
        /// </summary>
        /// <param name="chasis">Chasis a asignar al vehiculo</param>
        /// <param name="color">Color a asignar al vehiculo</param>
        /// <param name="marca">Marca a asignar al vehiculo</param>
        public Vehiculo(string chasis,ConsoleColor color,EMarca marca)
        {
            this.chasis = chasis;
            this.color = color;
            this.marca = marca;
        }

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar() 
        {
            string resultado = (string)this;
            return resultado; 
        }

        /// <summary>
        /// Sobrescribe String para poder mostrar los datos necesarios
        /// </summary>
        /// <param name="p">Vehiculo a escribir sus datos</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CHASIS: { p.chasis}\r");
            sb.AppendLine($"MARCA : {p.marca.ToString()}\r");
            sb.AppendLine($"COLOR : {p.color.ToString()}\r");
            sb.AppendLine("---------------------");
            sb.AppendLine("");
            sb.AppendLine($"TAMAÑO: {p.Tamanio}");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        /// <summary>
        /// Compara el objeto recibido por parametro si es un vehiculo.
        /// </summary>
        /// <param name="obj">Objeto a ser comparado con Vehiculo</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Vehiculo;
        }


    }
}
