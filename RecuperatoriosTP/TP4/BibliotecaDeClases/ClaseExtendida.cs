using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public static class ClaseExtendida
    {
        /// <summary>
        /// Calcula el porcentaje de un numero en base al total y devuelve un string
        /// </summary>
        /// <param name="miNumero">El numero</param>
        /// <param name="total">El total</param>
        /// <returns>string con el porcentaje</returns>
        public static string CalcularPorcentaje(this int miNumero, int total)
        {
            return string.Format($"{(miNumero * 100) / total}%");
        }

    }
}
