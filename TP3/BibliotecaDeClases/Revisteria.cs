using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Revisteria
    {
        private List<Revista> listaRevistas;
        private List<Comic> listaComics;
        private int lastIdRevista;
        private int lastIdComic;

        public Revisteria()
        {
            this.listaRevistas = new List<Revista>();
            this.listaComics = new List<Comic>();
            this.lastIdComic = 0;
            this.lastIdRevista = 0;
        }

        public List<Revista> ListaRevistas
        {
            get
            {
                return listaRevistas;
            }
        }
        public List<Comic> ListaComics
        {
            get
            {
                return listaComics;
            }
        }

        /// <summary>
        /// Agrega una nueva a la lista y lo guarda en el archivo JSON especificado
        /// </summary>
        /// <param name="miRevista">Revista a agregar</param>
        /// <param name="path">Direccion para guardar el archivo JSON</param>
        /// <returns>TRUE si fue agregado con exito, FALSE si hubo un error o si el libro ya se encuentra en la lista</returns>
        public bool AgregarProducto(Revista miRevista, string path)
        {

            if (miRevista is null || this.listaRevistas.Contains(miRevista))
            {
                return false;
            }

            try
            {
                this.lastIdRevista++;
                miRevista.Codigo = String.Format($"L{this.lastIdRevista}");

                this.listaRevistas.Add(miRevista);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar los datos de la revista", e);
            }
        }

        /// <summary>
        /// Agrega un nuevo comic a la lista y lo guarda en el archivo JSON especificado
        /// </summary>
        /// <param name="miComic">Comic a agregar</param>
        /// <param name="path">Direccion para guardar el archivo JSON</param>
        /// <returns>TRUE si fue agregado con exito, FALSE si hubo un error o si el libro ya se encuentra en la lista</returns>
        public bool AgregarProducto(Comic miComic, string path)
        {

            if (miComic is null || this.listaComics.Contains(miComic))
            {
                return false;
            }

            try
            {
                this.lastIdComic++;
                miComic.Codigo = String.Format($"L{lastIdComic}");

                this.listaComics.Add(miComic);

                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar los datos del comic", e);
            }
        }

        /// <summary>
        /// Elimina un objeto revista de la lista
        /// </summary>
        /// <param name="miRevista">elemento a eliminar</param>
        /// <returns>TRUE si fue exitoso, FALSE si fallo</returns>
        public bool EliminarProducto(Revista miRevista)
        {
            if (miRevista is not null && this.listaRevistas.Contains(miRevista))
            {
                this.listaRevistas.Remove(miRevista);
                return true;
            }
            return false;
        }


        /// <summary>
        /// Elimina un objeto comic de la lista
        /// </summary>
        /// <param name="miComic">comic a eliminar</param>
        /// <returns>TRUE si fue exitoso, FALSE si fallo</returns>
        public bool EliminarProducto(Comic miComic)
        {
            if (miComic is not null && this.listaComics.Contains(miComic))
            {
                this.listaComics.Remove(miComic);
                return true;
            }
            return false;
        }


    }
}
