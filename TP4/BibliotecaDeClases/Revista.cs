using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Revista : Producto
    {

        public Revista(string titulo, string autor, int anio, int stock, int ventas, float precio)
        : base(titulo, autor, anio, stock, ventas, precio)
        {

        }

        /// <summary>
        /// Verifica si el libro es igual
        /// </summary>
        /// <param name="libro">primer libro</param>
        /// <param name="otroLibro">otro libro</param>
        /// <returns>TRUE si es igual, FALSE si no lo es</returns>
        public static bool operator ==(Revista libro, Revista otroLibro)
        {
            if (libro.Codigo == otroLibro.Codigo)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Revista libro, Revista otroLibro)
        {
            return !(libro == otroLibro);
        }

        /// <summary>
        /// Sobrecarga de Equals. Si el codigo es igual son iguales
        /// </summary>
        /// <param name="obj">objeto a comparar</param>
        /// <returns>True si es igual, FALSE si no lo es</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType())
            {
                return this == (Revista)obj;
            }
            return false;
        }

    }
}
