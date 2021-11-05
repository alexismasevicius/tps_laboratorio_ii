using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Libreria: IAbrirGuardar<List<Libro>>
    {
        private List<Libro> listaLibros;
        private int lastId;
        private string rutaDeArchivo;

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
            set
            {
                this.listaLibros = value;
            }
        }

        /// <summary>
        /// Ruta donde se guarda y lee el archivo
        /// </summary>
        public string RutaDeArchivo
        {
            get
            {
                return this.rutaDeArchivo;
            }
            set
            {
                this.rutaDeArchivo = value;
            }

        }

        /// <summary>
        /// Agrega un nuevo libro a la lista y lo guarda en el archivo JSON especificado
        /// </summary>
        /// <param name="miLibro">Libro a agregar</param>
        /// <param name="path">Direccion para guardar el archivo JSON</param>
        /// <returns>TRUE si fue agregado con exito, FALSE si hubo un error o si el libro ya se encuentra en la lista</returns>
        public bool AgregarProducto(Libro miLibro)
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
                throw new BibliotecaException("Error al agregar los datos del libro","Libreria","Agregar Producto", e);
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

        /// <summary>
        /// Guarda un archivo .txt serializado en json
        /// </summary>
        public void Guardar(List<Libro> miLista)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(this.RutaDeArchivo))
                {
                    string json = JsonSerializer.Serialize(miLista);
                    streamWriter.Write(json);          
                }
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error al guardar la base de datos","Libreria","Guardar",e);
            }

        }


        /// <summary>
        /// Lee un archivo .txt serializado en json
        /// </summary>
        /// <returns>La lista de libros</returns>
        public List<Libro> Leer()
        {
            try
            {
                List<Libro> miLista = new List<Libro>();

                StreamReader sw = new StreamReader(this.RutaDeArchivo);
                string strAux = sw.ReadToEnd();
                sw.Close();
                miLista = JsonSerializer.Deserialize <List<Libro>>(strAux);
                return miLista;
            }
            catch (Exception e)
            {

                throw new BibliotecaException("Error en la lectura del archivo","Libreria,","Leer",e);
            }


        }



    }
}
