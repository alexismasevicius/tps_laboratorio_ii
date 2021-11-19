using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Revisteria : IAbrirGuardar<List<Venta>>
    {
        private List<Revista> listaRevistas;
        private List<Comic> listaComics;
        private List<Venta> listaVentas;
        private List<Cliente> listaCliente;

        private string rutaDeArchivo;

        public Revisteria()
        {
            this.listaRevistas = new List<Revista>();
            this.listaComics = new List<Comic>();
            this.listaVentas = new List<Venta>();
            this.listaCliente = new List<Cliente>();
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

        public List<Venta> ListaVentas
        {
            get
            {
                return listaVentas;
            }

            set
            {
                listaVentas = value;
            }
        }

        public List<Cliente> ListaCliente
        {
            get
            {
                return listaCliente;
            }

            set
            {
                listaCliente = value;
            }
        }


        /// <summary>
        /// Busca el ultimo Id de la lista
        /// </summary>
        /// <returns>El ultimo Id mas uno en formato strin</returns>
        private string BuscarIdMayorMasUnoRevista()
        {
            string strAux;
            int codigo = 1;
            int codigoMayor = 0;

            if (this.ListaRevistas.Count > 0)
            {
                foreach (Revista item in this.ListaRevistas)
                {
                    strAux = item.Codigo.Trim('R');

                    int.TryParse(strAux, out codigo);

                    if (codigo > codigoMayor)
                    {
                        codigoMayor = codigo;
                    }
                }
            }

            return string.Format($"R{codigoMayor + 1}");

        }



        /// <summary>
        /// Busca el ultimo Id de la lista
        /// </summary>
        /// <returns>El ultimo Id mas uno en formato strin</returns>
        private string BuscarIdMayorMasUnoComic()
        {
            string strAux;
            int codigo = 1;
            int codigoMayor = 0;

            if (this.ListaComics.Count > 0)
            {
                foreach (Comic item in this.ListaComics)
                {
                    strAux = item.Codigo.Trim('C');

                    int.TryParse(strAux, out codigo);

                    if (codigo > codigoMayor)
                    {
                        codigoMayor = codigo;
                    }
                }
            }

            return string.Format($"C{codigoMayor + 1}");

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
                miRevista.Codigo = BuscarIdMayorMasUnoRevista();
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
                miComic.Codigo = BuscarIdMayorMasUnoComic();

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
        /// guarda  un archivo de texto en formato JSON con datos de ventas
        /// </summary>
        /// <param name="miLista">Lista ventas a guardar</param>
        public void Guardar(List<Venta>miLista)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(this.RutaDeArchivo,true))
                {
                    string json = JsonSerializer.Serialize(this.ListaVentas);
                    streamWriter.Write(json);
                }
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error al guardar las ventas en el archivo", "Revisteria", "Guardar", e);
            }
        }

        /// <summary>
        /// Lee un archivo de ventas
        /// </summary>
        /// <returns>lista con las ventas</returns>
        public List<Venta> Leer()
        {
            try
            {
                List<Venta> miLista = new List<Venta>();

                StreamReader sw = new StreamReader(this.RutaDeArchivo);
                string strAux = sw.ReadToEnd();
                sw.Close();
                miLista = JsonSerializer.Deserialize<List<Venta>>(strAux);
                return miLista;
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error en la lectura del archivo", "Revisteria,", "Leer", e);
            }

        }




        /// <summary>
        /// Busca la revista mas vendido
        /// </summary>
        /// <returns>La primer revista más vendida de la lista</returns>
        public Revista BuscarRevistaMasVendida()
        {
            Revista miRevista = null;
            bool flag = false;
            foreach (Revista item in this.ListaRevistas)
            {
                if (flag == false)
                {
                    miRevista = item;
                    flag = true;
                }
                else
                {
                    if (item.Ventas > miRevista.Ventas)
                    {
                        miRevista = item;
                    }
                }
            }
            return miRevista;
        }



        /// <summary>
        /// Busca el comic mas vendido
        /// </summary>
        /// <returns>El primer comic más vendido de la lista</returns>
        public Comic BuscarComicMasVendido()
        {
            Comic miComic = null;
            bool flag = false;
            foreach (Comic item in this.ListaComics)
            {
                if (flag == false)
                {
                    miComic = item;
                    flag = true;
                }
                else
                {
                    if (item.Ventas > miComic.Ventas)
                    {
                        miComic = item;
                    }
                }
            }
            return miComic;
        }

        /// <summary>
        /// Calcula los ingresos por ventas de revsitas
        /// </summary>
        /// <returns>Los ingresos por ventas de revistas</returns>
        public float CalcularVentasRevista()
        {
            float acumuladorVentas = 0;
            foreach (Revista item in this.listaRevistas)
            {
                if (item.Ventas > 0)
                {
                    acumuladorVentas = acumuladorVentas + (item.Ventas * item.Precio);
                }
            }
            return acumuladorVentas;
        }

        /// <summary>
        /// Calcula los ingresos por ventas de comics
        /// </summary>
        /// <returns>Los ingresos por ventas de revistas comics</returns>
        public float CalcularVentasComic()
        {
            float acumuladorVentas = 0;
            foreach (Comic item in this.listaComics)
            {
                if (item.Ventas > 0)
                {
                    acumuladorVentas = acumuladorVentas + (item.Ventas*item.Precio);
                }
            }
            return acumuladorVentas;
        }


    }
}
