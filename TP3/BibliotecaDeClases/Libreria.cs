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

        public Libreria()
        {
            this.listaLibros = new List<Libro>();
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
        public bool AgregarLibro(Libro miLibro, string path)
        {

            if (miLibro is null || this.listaLibros.Contains(miLibro))
            {  
                return false;
            }
            
            try
            {
                this.listaLibros.Add(miLibro);
                string jsonString = JsonSerializer.Serialize(miLibro);
                using (StreamWriter archivo = new StreamWriter(path, true))
                {
                    archivo.WriteLine(jsonString);
                }
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar los datos", e);
            }
        }

    }
}
