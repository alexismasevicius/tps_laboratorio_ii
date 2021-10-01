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
        /// Constructor de SUV
        /// </summary>
        /// <param name="marca">marca del SUV</param>
        /// <param name="chasis">chasis del SUV</param>
        /// <param name="color">color del SUV</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
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
        /// Muestra los datos del SUV
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString() ;
        }
    }
}
