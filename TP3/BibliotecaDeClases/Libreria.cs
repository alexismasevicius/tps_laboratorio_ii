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
        private string rutaDeArchivo;

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
        /// Busca el ultimo Id de la lista
        /// </summary>
        /// <returns>El ultimo Id mas uno en formato strin</returns>
        private string BuscarIdMayorMasUno()
        {
            string strAux;
            int codigo = 1;
            int codigoMayor = 0;

            if (this.ListaLibros.Count > 0)
            {
                foreach (Libro item in this.listaLibros)
                {
                    strAux = item.Codigo.Trim('L');

                    int.TryParse(strAux, out codigo);

                    if (codigo > codigoMayor)
                    {
                        codigoMayor = codigo;
                    }
                }
            }

            return string.Format($"L{codigoMayor+1}");

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
                miLibro.Codigo = BuscarIdMayorMasUno();
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
        /// Guarda un archivo .txt serializado en json // IMPLEMENTACION DE EXCEPCIONES y DE ARCHIVOS Y SERIALIZACION
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
            catch (FileNotFoundException e)
            {
                throw new BibliotecaException("El archivo no se encontro", "Libreria,", "Leer", e);
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error en la lectura del archivo","Libreria,","Leer",e);
            }


        }


        /// <summary>
        /// Busca el libro mas vendido
        /// </summary>
        /// <returns>El primer libro más vendido de la lista</returns>
        public Libro BuscarLibroMasVendido()
        {
            Libro miLibro = null;
            bool flag = false;
            foreach (Libro item in this.ListaLibros)
            {
                if (flag == false)
                {
                    miLibro = item;
                    flag = true;
                }
                else
                {
                    if (item.Ventas > miLibro.Ventas)
                    {
                        miLibro = item;
                    }
                }

            }
            return miLibro;
        }

        /// <summary>
        /// Calcula los ingresos por ventas de libros
        /// </summary>
        /// <returns>Los ingresos por ventas de libros</returns>
        public float CalcularVentasLibros()
        {
            float acumuladorVentas = 0;
            foreach (Libro item in this.listaLibros)
            {
                if (item.Ventas > 0)
                {
                    acumuladorVentas = acumuladorVentas + (item.Ventas * item.Precio);
                }
            }
            return acumuladorVentas;
        }

    }
}
