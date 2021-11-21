using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace TP3
{
    public partial class FormPrincipal : Form
    {

        Libreria miLibreria = new Libreria();

        CancellationTokenSource cancellationTokenSource;

        CancellationToken cancellationToken;


        public FormPrincipal()
        {
            InitializeComponent();
        }
         
        /// <summary>
        /// Carga del formulario
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                miLibreria.RutaDeArchivo = "RecibosLibreria.txt";
                miLibreria.ListaVentas = miLibreria.Leer<Venta>();
                miLibreria.RutaDeArchivo = "ListaClientes.txt";
                miLibreria.ListaCliente = miLibreria.Leer<Cliente>();
            }
            catch (BibliotecaException f)
            {
                MessageBox.Show($"{f.Message},\n En clase: {f.NombreClase}, Metodo: {f.NombreMetodo} \n {f.InnerException.Message}");
            }

            this.miLibreria.InformarVenta += ActualizarVentas;
            cancellationTokenSource = new CancellationTokenSource();
            this.cancellationToken = cancellationTokenSource.Token;
            Task.Run(() => miLibreria.InformarVentasRealizadas(cancellationToken));


        }

        /// <summary>
        /// Actualiza los label inferiores con nuevos valores
        /// </summary>
        /// <param name="sender"></param>
        public void ActualizarVentas(object sender)
        {
            if (this.InvokeRequired)
            {
                InformacionDeVenta callback = new InformacionDeVenta(this.ActualizarVentas);
                object[] objs = new object[] { sender };
                this.Invoke(callback, objs);
            }
            else
            {
                this.lblVentasInicio.Text = $"Ventas Totales : {miLibreria.ListaVentas.Count}";
            }
        }


        /// <summary>
        /// CLick en el boton MOSTRAR CATALOGO LIBRERIA
        /// </summary>
        private void btnMostrarCatalogo_Click(object sender, EventArgs e)
        {
            FormBusqueda<Libro> miFormLibros = new FormBusqueda<Libro>(this.miLibreria);
            miFormLibros.ShowDialog();
        }

        /// <summary>
        /// Click en el boton AGREGAR 
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar miFormAgregar = new FormAgregar(miLibreria);
            miFormAgregar.ShowDialog();
        }

        /// <summary>
        /// Click en el boton MOSTRAR ESTADISTICAS
        /// </summary>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadistica miFormEstadistico = new FormEstadistica(miLibreria);
            miFormEstadistico.ShowDialog();
        }







        ////////////////////////////  BUSQUEDA  /////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Click en el boton BUSCAR
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListaFiltrada();
        }

       /// <summary>
        /// Carga una lista filtrada por el criterio de busqueda
        /// </summary>
        /// <param name="miLista">Lista a filtrar</param>
        private void CargarListaFiltrada()
        {
            if (rbtnTitulo.Checked)
            {
                FormBusqueda<Libro> miFormLibros = new FormBusqueda<Libro>(this.miLibreria, $"SELECT * FROM Libros WHERE titulo LIKE '%{txtBusqueda.Text}%'");
                miFormLibros.ShowDialog();
            }
            else if (rbtnAutor.Checked)
            {
                FormBusqueda<Libro> miFormLibros = new FormBusqueda<Libro>(this.miLibreria, $"SELECT * FROM Libros WHERE autor LIKE '%{txtBusqueda.Text}%'");
                miFormLibros.ShowDialog();
            }
            else
            {
                int numero = 1;
                int.TryParse(txtBusqueda.Text, out numero);
                FormBusqueda<Libro> miFormLibros = new FormBusqueda<Libro>(this.miLibreria, $"SELECT * FROM Libros WHERE anio = {numero}");
                miFormLibros.ShowDialog();
            }
        }



        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        //////////////////////  FIN DE BUSQUEDA  //////////////////////////////////////////////////////////////////


    }
}
