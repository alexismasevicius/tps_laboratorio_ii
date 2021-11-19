using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public delegate void InformacionDeVenta(object sender);

    public class Libreria : IAbrirGuardar<List<Venta>>
    {
        private List<Libro> listaLibros;
        private List<Venta> listaVentas;
        private List<Cliente> listaCliente;
        private int contadorVentas;
        public event InformacionDeVenta InformarVenta;


        private string rutaDeArchivo;

       
        public Libreria()
        {
            this.listaLibros = new List<Libro>();
            this.listaVentas = new List<Venta>();
            this.listaCliente = new List<Cliente>();
            this.contadorVentas = 0;
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

        public List<Venta> ListaVentas
        {
            get
            {
                return this.listaVentas;
            }

            set
            {
                this.listaVentas = value;
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

            return string.Format($"L{codigoMayor + 1}");

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
                throw new BibliotecaException("Error al agregar los datos del libro", "Libreria", "Agregar Producto", e);
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
        /// guarda  un archivo de texto en formato JSON con datos de ventas
        /// </summary>
        /// <param name="miLista">Lista ventas a guardar</param>
        public void Guardar(List<Venta> miLista)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(this.RutaDeArchivo, true))
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
            catch (FileNotFoundException e)
            {
                throw new BibliotecaException("El archivo no se encontro", "Libreria,", "Leer", e);
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error en la lectura del archivo", "Libreria,", "Leer", e);
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


        public void InformarVentasRealizadas(CancellationToken cancellationToken)
        {
            do
            {
                if(this.contadorVentas<this.ListaVentas.Count)
                {
                    if (this.InformarVenta is not null)
                    {
                        this.InformarVenta.Invoke(this);
                    }
                    this.contadorVentas = this.ListaVentas.Count;
                }
                System.Threading.Thread.Sleep(1000);
            }while (!cancellationToken.IsCancellationRequested);

        }



    }
}
