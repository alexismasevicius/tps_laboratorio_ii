using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Libreria
    {
        private List<Libro> listaLibros;
        private int lastId;

        public Libreria()
        {
            this.listaLibros = new List<Libro>();
            this.lastId = 0;
        }

        public List<Libro> ListaLibros
        {
            get
            {
                return this.listaLibros;
            }
        }

        /// <summary>
        /// Agrega un nuevo libro a la lista y lo guarda en el archivo JSON especificado
        /// </summary>
        /// <param name="miLibro">Libro a agregar</param>
        /// <param name="path">Direccion para guardar el archivo JSON</param>
        /// <returns>TRUE si fue agregado con exito, FALSE si hubo un error o si el libro ya se encuentra en la lista</returns>
        public bool AgregarProducto(Libro miLibro, string path)
        {

            if (miLibro is null || this.listaLibros.Contains(miLibro))
            {  
                return false;
            }
            
            try
            {
                this.lastId++;
                miLibro.Codigo = String.Format($"L{lastId}");
                this.listaLibros.Add(miLibro);              
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar los datos del libro", e);
            }
        }

        /// <summary>
        /// Elimina un objeto libro de la lista
        /// </summary>
        /// <param name="miLibro">objeto libro a eliminar</param>
        /// <returns>TRUE si fue exitoso, FALSE si fallo</returns>
        public bool EliminarProducto(Libro miLibro)
        {
            if (miLibro is not null && this.listaLibros.Contains(miLibro))
            {
                this.listaLibros.Remove(miLibro);
                return true;
            }
            return false;
        }

    }
}
