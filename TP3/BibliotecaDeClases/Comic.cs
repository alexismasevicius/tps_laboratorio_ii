using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Comic:Producto
    {

        public Comic(int codigo, string titulo, string autor, int anio, int stock, int ventas, float precio, string tema)
        : base(codigo, titulo, autor, anio, stock, ventas, precio)
        {
            
        }



        /// <summary>
        /// Verifica si el libro es igual en titulo y autor
        /// </summary>
        /// <param name="libro">primer libro</param>
        /// <param name="otroLibro">otro libro</param>
        /// <returns>TRUE si es igual, FALSE si no lo es</returns>
        public static bool operator ==(Comic libro, Comic otroLibro)
        {
            if (libro.Autor == otroLibro.Autor && libro.Titulo == otroLibro.Titulo)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Comic libro, Comic otroLibro)
        {
            return !(libro == otroLibro);
        }

        /// <summary>
        /// Sobrecarga de Equals. Si tienen el mismo autor y titulo son iguales
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns>True si es igual, FALSE si no lo es</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                return this == (Comic)obj;
            }
            return false;
        }


    }
}
