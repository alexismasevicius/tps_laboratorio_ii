using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo { CuatroPuertas, CincoPuertas }
        ETipo tipo;


        /// <summary>
        /// Constructor de Sedan.
        /// </summary>
        /// <param name="marca">Marca del Sedan</param>
        /// <param name="chasis">Chasis del Sedan</param>
        /// <param name="color">Color del Sedan</param>
        /// <param name="tipo">ETipo del Sedan</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
        : base( chasis, marca,color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Constructor de Sedan. Es por defecto del tipo 4 puertas
        /// </summary>
        /// <param name="marca">Marca del Sedan</param>
        /// <param name="chasis">Chasis del Sedan</param>
        /// <param name="color">Color del Sedan</param>
        public Sedan(EMarca marca,string chasis, ConsoleColor color)
            : this( marca,chasis, color, ETipo.CuatroPuertas)
        {
        }


        /// <summary>
        /// Solo lectura. Sedan es de tamanio mediano
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }

        /// <summary>
        /// Muestra los datos de un vehiculo de clase Sedan
        /// </summary>
        /// <returns>String con los datos</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TIPO: {this.tipo}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");
            
            return sb.ToString();
        }
    }
}
