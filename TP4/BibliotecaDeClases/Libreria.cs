using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        private List<Venta> listaVentas;
        private List<Cliente> listaCliente;
        private int contadorVentas;
        public event InformacionDeVenta InformarVenta;
        private string rutaDeArchivo;
        SqlConnection conn;
        SqlCommand command;






       
        public Libreria()
        {
            this.listaVentas = new List<Venta>();
            this.listaCliente = new List<Cliente>();
            this.contadorVentas = 0;

            string connString = @"Data Source=.; Initial Catalog=Libreria; Integrated Security=True";
            conn = new SqlConnection(connString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = conn;

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
        /// Hace una consulta de todos los elementos de la base de datos
        /// </summary>
        /// <returns>DataTable con los datos</returns>
        public DataTable ConsultaBaseDatos()
        {
            try
            {
                command.CommandText = "SELECT * FROM dbo.Libros";
                conn.Open();
                SqlDataAdapter data = new SqlDataAdapter(command);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new BibliotecaException("Error al consultar Base de datos", "Libreria", "ConsultaBaseDatos", ex);
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Consulta un libro especifico de la base de datos por el codigo
        /// </summary>
        /// <param name="codigo">Codigo del libro</param>
        /// <returns></returns>
        public Libro ConsultaBaseDatosLibro(int codigo)
        {
            try
            {
                Libro miLibro = null;
                command.CommandText = $"SELECT * FROM dbo.Libros WHERE Codigo={codigo}";
                conn.Open();
                SqlDataReader sqlReader = command.ExecuteReader();
                while (sqlReader.Read())
                {
                    string titulo = sqlReader["titulo"].ToString();
                    string autor = sqlReader["autor"].ToString();
                    int anio = Convert.ToInt32(sqlReader["anio"]);
                    int stock = Convert.ToInt32(sqlReader["stock"]);
                    int ventas = Convert.ToInt32(sqlReader["ventas"]);
                    float precio = (float)Convert.ToDouble(sqlReader["precio"]);
                    string genero = sqlReader["genero"].ToString();

                   

                    miLibro = new Libro(titulo,autor,anio,stock,ventas,precio,genero);
                    miLibro.Codigo = codigo;
                }


                return miLibro;
            }
            catch (Exception ex)
            {
                throw new BibliotecaException("Error al consultar Base de datos", "Libreria", "ConsultaBaseDatos", ex);
            }
            finally
            {
                conn.Close();
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

            if (miLibro is null)
            {
                return false;
            }

            command.CommandText =
            $"INSERT INTO Libros (titulo,autor,anio,stock,ventas,precio,genero) VALUES ('{miLibro.Titulo}','{miLibro.Autor}','{miLibro.Anio}','{miLibro.Stock}','{miLibro.Ventas}','{miLibro.Precio}','{miLibro.Genero}')";

            try
            {
                conn.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error al agregar el libro", "Libreria", "Agregar Producto", e);
            }
            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// guarda  un archivo de texto en formato JSON con datos de ventas
        /// </summary>
        /// <param name="miLista">Lista ventas a guardar</param>
        public void Guardar(List<Venta> miLista)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(this.RutaDeArchivo))
                {
                    string json = JsonSerializer.Serialize(this.ListaVentas);
                    streamWriter.Write(json);
                }
            }
            catch (Exception e)
            {
                throw new BibliotecaException("Error al guardar las ventas en el archivo", "Libreria", "Guardar", e);
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
