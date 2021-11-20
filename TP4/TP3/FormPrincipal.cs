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

        private OpenFileDialog openFileDialog;

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

            }
            catch (BibliotecaException f)
            {
                MessageBox.Show($"{f.Message},\n En clase: {f.NombreClase}, Metodo: {f.NombreMetodo} \n {f.InnerException.Message}");
            }

            this.miLibreria.InformarVenta += ActualizarVentas;
            cancellationTokenSource = new CancellationTokenSource();
            this.cancellationToken = cancellationTokenSource.Token;
            Task.Run(() => miLibreria.InformarVentasRealizadas(cancellationToken));

            openFileDialog = new OpenFileDialog();

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
                this.lblRecaudacionInicio.Text = $"Recaudacion Total : {00000000000}";
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




        /// <summary>
        /// Click en el boton ABRIR ARCHIVO VENTAS de la barra
        /// </summary>
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Está seguro que desea abrir un archivo? \nPerderá todos los cambios realizados hasta el momento.",
                "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        miLibreria.RutaDeArchivo = openFileDialog.FileName;
                        miLibreria.ListaVentas = miLibreria.Leer();
                    }
                    catch (BibliotecaException f)
                    {
                        MessageBox.Show($"{f.Message},\n En clase: {f.NombreClase}, Metodo: {f.NombreMetodo} \n {f.InnerException.Message}");
                    }
                }
            }
        }



        /// <summary>
        /// Click en el boton GUARDAR ARCHIVO VENTAS de la barra
        /// </summary>
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"¿Está seguro que desea guardar las ventas realizadas?",
                    "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    miLibreria.RutaDeArchivo = "RecibosLibreria.txt";
                    miLibreria.Guardar(miLibreria.ListaVentas);
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
            //CargarListaFiltrada(this.miLibreria.ListaLibros);
        }

   /*     /// <summary>
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
            FormBusqueda<Libro> miFormLibros = new FormBusqueda<Libro>(listaFiltrada);
            miFormLibros.ShowDialog();
        }*/



        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        //////////////////////  FIN DE BUSQUEDA  //////////////////////////////////////////////////////////////////


    }
}
