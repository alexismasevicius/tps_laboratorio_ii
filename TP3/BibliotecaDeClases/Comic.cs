using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Comic:Producto
    {
        string esManga;

        
        // CONSTRUCTOR
        public Comic(string titulo, string autor, int anio, int stock, int ventas, float precio, string esManga)
        : base(titulo, autor, anio, stock, ventas, precio)
        {
            this.EsManga = esManga;
        }

        // PROPIEDADES
        public string EsManga { get => esManga; set => esManga = value; }


        // METODOS
        /// <summary>
        /// Verifica si el libro es igual
        /// </summary>
        /// <param name="libro">primer libro</param>
        /// <param name="otroLibro">otro libro</param>
        /// <returns>TRUE si es igual, FALSE si no lo es</returns>
        public static bool operator ==(Comic libro, Comic otroLibro)
        {
            if (libro.Codigo == otroLibro.Codigo)
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
        /// Sobrecarga de Equals.
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
