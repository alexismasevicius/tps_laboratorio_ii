using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        Revisteria miRevisteria = new Revisteria();
        Libreria miLibreria = new Libreria();

        CancellationTokenSource cancellationTokenSource;

        CancellationToken cancellationToken;



        /*
        Comic comic1 = new Comic("Spider-Man #230", "Stan Lee", 2001, 3, 0, 500, "no");
        Revista revista1 = new Revista("National Geographic 44", "NatGeo", 2021, 20, 0, 300);*/

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
                miLibreria.ListaVentas = miLibreria.Leer();
                miRevisteria.RutaDeArchivo = "RecibosRevisteria.txt";
                miRevisteria.ListaVentas = miRevisteria.Leer();
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
                this.lblRecaudacionInicio.Text = $"Recaudacion Total : {miLibreria.ListaVentas.Count}";
                this.lblVentasInicio.Text = $"Ventas Totales : {miLibreria.ListaVentas.Count}";
            }
        }


        /// <summary>
        /// CLick en el boton MOSTRAR CATALOGO LIBRERIA
        /// </summary>
        private void btnMostrarCatalogo_Click(object sender, EventArgs e)
        {
            FormBusqueda<Libro> miFormLibros = new FormBusqueda<Libro>(this.miLibreria.ListaLibros, this.miLibreria.ListaVentas, this.miLibreria.ListaCliente);
            miFormLibros.ShowDialog();
        }


        /// <summary>
        /// click en el boton MOSTRAR CATALOGO REVISTERIA
        /// </summary>
        private void btnMostrarRevisteria_Click(object sender, EventArgs e)
        {
            List<Producto> nuevaLista = new List<Producto>();
            nuevaLista.AddRange(this.miRevisteria.ListaComics);
            nuevaLista.AddRange(this.miRevisteria.ListaRevistas);
            FormBusqueda<Producto> miFormRevista = new FormBusqueda<Producto>(nuevaLista, miRevisteria.ListaVentas, this.miRevisteria.ListaCliente);

            miFormRevista.ShowDialog();
        }


        /// <summary>
        /// Click en el boton AGREGAR 
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar miFormAgregar = new FormAgregar(miLibreria,miRevisteria);
            miFormAgregar.ShowDialog();
        }

        /// <summary>
        /// Click en el boton MOSTRAR ESTADISTICAS
        /// </summary>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadistica miFormEstadistico = new FormEstadistica(miLibreria,miRevisteria);
            miFormEstadistico.ShowDialog();
        }

        /// <summary>
        /// Click en el boton ABRIR ARCHIVO VENTAS de la barra
        /// </summary>
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ESTO HAY QUE CAMBIARLO POR SELECCIONAR RUTA DE ARCHIVO
            /*
            if (MessageBox.Show($"¿Está seguro que desea abrir un archivo? \nPerderá todos los cambios realizados hasta el momento.",
        "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    miLibreria.RutaDeArchivo = "RecibosLibreria.txt";
                    miLibreria.ListaVentas = miLibreria.Leer();
                    miRevisteria.RutaDeArchivo = "RecibosRevisteria.txt";
                    miRevisteria.ListaVentas = miRevisteria.Leer();
                }
                catch (BibliotecaException f)
                {
                    MessageBox.Show($"{f.Message},\n En clase: {f.NombreClase}, Metodo: {f.NombreMetodo} \n {f.InnerException.Message}");
                }
            }*/
        }

        /// <summary>
        /// Click en el boton GUARDAR ARCHIVO VENTAS de la barra
        /// </summary>
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Está seguro que desea guardar las ventas?",
                    "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    miLibreria.RutaDeArchivo = "RecibosLibreria.txt";
                    miLibreria.Guardar(miLibreria.ListaVentas);
                    miRevisteria.RutaDeArchivo = "RecibosRevisteria.txt";
                    miRevisteria.Guardar(miRevisteria.ListaVentas);
                }
                catch (BibliotecaException f)
                {
                    MessageBox.Show($"{f.Message},\n En clase: {f.NombreClase}, Metodo: {f.NombreMetodo} \n {f.InnerException.Message}");
                }
            }
        }





        ////////////////////////////  BUSQUEDA  /////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Click en el boton BUSCAR
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (cmbTipo.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Error no selecciono el tipo");
                    break;
                case 0:
                    CargarListaFiltrada(this.miLibreria.ListaLibros);
                    break;
                case 1:
                    CargarListaFiltrada(this.miRevisteria.ListaComics);
                    break;
                case 2:
                    CargarListaFiltrada(this.miRevisteria.ListaRevistas);
                    break;
            }
        }

        /// <summary>
        /// Carga una lista filtrada por el criterio de busqueda
        /// </summary>
        /// <param name="miLista">Lista a filtrar</param>
        private void CargarListaFiltrada(List<Libro> miLista)
        {
            List<Libro> listaFiltrada = new List<Libro>();

            if (rbtnTitulo.Checked)
            {
                listaFiltrada = miLista.Where(libro => libro.Titulo.Contains(txtBusqueda.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else if (rbtnAutor.Checked)
            {
                listaFiltrada = miLista.Where(libro => libro.Autor.Contains(txtBusqueda.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else
            {
                listaFiltrada = miLista.Where(libro => libro.Anio.ToString() == txtBusqueda.Text).ToList();
            }
            FormBusqueda<Libro> miFormLibros = new FormBusqueda<Libro>(listaFiltrada,this.miLibreria.ListaVentas, this.miLibreria.ListaCliente);
            miFormLibros.ShowDialog();
        }

        /// <summary>
        /// Carga una lista filtrada por el criterio de busqueda
        /// </summary>
        /// <param name="miLista">Lista a filtrar</param>
        private void CargarListaFiltrada(List<Comic> miLista)
        {
            List<Comic> listaFiltrada = new List<Comic>();

            if (rbtnTitulo.Checked)
            {
                listaFiltrada = miLista.Where(comic => comic.Titulo.Contains(txtBusqueda.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else if (rbtnAutor.Checked)
            {
                listaFiltrada = miLista.Where(comic => comic.Autor.Contains(txtBusqueda.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else
            {
                listaFiltrada = miLista.Where(comic => comic.Anio.ToString() == txtBusqueda.Text).ToList();
            }
            FormBusqueda<Comic> miFormComic = new FormBusqueda<Comic>(listaFiltrada,miRevisteria.ListaVentas,this.miRevisteria.ListaCliente);
            miFormComic.ShowDialog();
        }

        /// <summary>
        /// Carga una lista filtrada por el criterio de busqueda
        /// </summary>
        /// <param name="miLista">Lista a filtrar</param>
        private void CargarListaFiltrada(List<Revista> miLista)
        {
            List<Revista> listaFiltrada = new List<Revista>();

            if (rbtnTitulo.Checked)
            {
                listaFiltrada = miLista.Where(revista => revista.Titulo.Contains(txtBusqueda.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else if (rbtnAutor.Checked)
            {
                listaFiltrada = miLista.Where(revista => revista.Autor.Contains(txtBusqueda.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            else
            {
                listaFiltrada = miLista.Where(revista => revista.Anio.ToString() == txtBusqueda.Text).ToList();
            }
            FormBusqueda<Revista> miFormComic = new FormBusqueda<Revista>(listaFiltrada,miRevisteria.ListaVentas, this.miRevisteria.ListaCliente);
            miFormComic.ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        //////////////////////  FIN DE BUSQUEDA  //////////////////////////////////////////////////////////////////


    }
}
