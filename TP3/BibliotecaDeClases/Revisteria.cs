using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Revisteria : IAbrirGuardar<List<Revista>>, IAbrirGuardar<List<Comic>>
    {
        private List<Revista> listaRevistas;
        private List<Comic> listaComics;
        private int lastIdRevista;
        private int lastIdComic;
        private string rutaDeArchivo;

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
            set
            {
                this.listaRevistas = value;
            }
        }
        public List<Comic> ListaComics
        {
            get
            {
                return listaComics;
            }
            set
            {
                this.listaComics = value;
            }
        }

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
        /// Agrega una nueva a la lista y lo guarda en el archivo JSON especificado
        /// </summary>
        /// <param name="miRevista">Revista a agregar</param>
        /// <param name="path">Direccion para guardar el archivo JSON</param>
        /// <returns>TRUE si fue agregado con exito, FALSE si hubo un error o si el libro ya se encuentra en la lista</returns>
        public bool AgregarProducto(Revista miRevista)
        {

            if (miRevista is null || this.listaRevistas.Contains(miRevista))
            {
                return false;
            }

            try
            {
                this.lastIdRevista++;
                miRevista.Codigo = String.Format($"R{this.lastIdRevista}");

                this.listaRevistas.Add(miRevista);
                return true;
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error al agregar los datos del libro", "Revisteria", "Agregar Producto", e);
            }
        }

        /// <summary>
        /// Agrega un nuevo comic a la lista y lo guarda en el archivo JSON especificado
        /// </summary>
        /// <param name="miComic">Comic a agregar</param>
        /// <param name="path">Direccion para guardar el archivo JSON</param>
        /// <returns>TRUE si fue agregado con exito, FALSE si hubo un error o si el libro ya se encuentra en la lista</returns>
        public bool AgregarProducto(Comic miComic)
        {

            if (miComic is null || this.listaComics.Contains(miComic))
            {
                return false;
            }

            try
            {
                this.lastIdComic++;
                miComic.Codigo = String.Format($"C{lastIdComic}");

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

        /// <summary>
        /// guarda  un archivo de texto en formato JSON con datos de revistas
        /// </summary>
        /// <param name="miLista">Lista revistas a guardar</param>
        public void Guardar(List<Revista>miLista)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(this.RutaDeArchivo))
                {
                    string json = JsonSerializer.Serialize(this.ListaRevistas);
                    streamWriter.Write(json);
                }
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error al guardar la base de datos", "Revisteria", "Guardar", e);
            }
        }

        /// <summary>
        /// guarda  un archivo de texto en formato JSON con datos de comics
        /// </summary>
        /// <param name="lista">Lista comics a guardar</param>
        public void Guardar(List<Comic> lista)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(this.RutaDeArchivo))
                {
                    string json = JsonSerializer.Serialize(lista);
                    streamWriter.Write(json);
                }
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error al guardar la base de datos", "Revisteria", "Guardar", e);
            }

        }

        public List<Revista> Leer()
        {
            try
            {
                List<Revista> miLista = new List<Revista>();

                StreamReader sw = new StreamReader(this.RutaDeArchivo);
                string strAux = sw.ReadToEnd();
                sw.Close();
                miLista = JsonSerializer.Deserialize<List<Revista>>(strAux);
                return miLista;
            }
            catch (Exception e)
            {

                throw new BibliotecaException("Error en la lectura del archivo", "Revisteria,", "Leer", e);
            }

        }


        List<Comic> IAbrirGuardar<List<Comic>>.Leer()
        {
            try
            {
                List<Comic> miLista = new List<Comic>();

                StreamReader sw = new StreamReader(this.RutaDeArchivo);
                string strAux = sw.ReadToEnd();
                sw.Close();
                miLista = JsonSerializer.Deserialize<List<Comic>>(strAux);
                return miLista;
            }
            catch (Exception e)
            {

                throw new BibliotecaException("Error en la lectura del archivo", "Revisteria,", "Leer", e);
            }

        }
    }
}
