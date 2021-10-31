using System;

namespace BibliotecaDeClases
{
    public class Libro : Producto
    {
        private string genero;




        //CONSTRUCTORES
        public Libro(string titulo, string autor, int anio, int stock,int ventas,float precio, string tema)
            :base(titulo,autor,anio,stock,ventas,precio)
        {
            this.genero = tema;
        }

        //PROPIEDADEs
        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }


        //METODOS

        /// <summary>
        /// Verifica si el libro es igual en titulo y autor
        /// </summary>
        /// <param name="libro">primer libro</param>
        /// <param name="otroLibro">otro libro</param>
        /// <returns>TRUE si es igual, FALSE si no lo es</returns>
        public static bool operator ==(Libro libro, Libro otroLibro)
        {
            if (libro.Autor == otroLibro.Autor && libro.Titulo == otroLibro.Titulo)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Libro libro, Libro otroLibro)
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
                return this == (Libro)obj;
            }
            return false;
        }

    }
}
