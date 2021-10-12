using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        /// <summary>
        /// Constructor de vehiculo tipo SUV, llamando al constructor de Vehiculo
        /// </summary>
        /// <param name="marca">Marca a asignar al vehiculo</param>
        /// <param name="chasis">Chasis a asignar al vehiculo</param>
        /// <param name="color">Color a asignar al vehiculo</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis,color,marca)
        {
        }
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        /// <summary>
        /// Muestra los datos del tipo SUV
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
