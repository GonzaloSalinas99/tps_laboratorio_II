using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    /// <summary>
    /// Clase heredada de Vehiculo
    /// </summary>
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        private ETipo tipo;

        /// <summary>
        /// Constructor de vehiculo tipo Sedan, asigna puertas.
        /// </summary>
        /// <param name="marca">Marca a asignar al vehiculo</param>
        /// <param name="chasis">Chasis a asignar al vehiculo</param>
        /// <param name="color">Color a asignar al vehiculo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis,color,marca)
        {
            tipo = ETipo.CuatroPuertas;
        }
        /// <summary>
        /// Constructor del vehiculo tipo Sedan
        /// </summary>
        /// <param name="marca">Marca a asignar al vehiculo</param>
        /// <param name="chasis">Chasis a asignar al vehiculo</param>
        /// <param name="color">Color a asignar al vehiculo</param>
        /// <param name="tipo">Cantidad de puertas a asignar al vehiculo</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color,ETipo tipo)
            : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// Muestra los datos del vehiculo tipo SEDAN
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
