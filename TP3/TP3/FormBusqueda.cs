using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClases;

namespace TP3
{
    public partial class FormBusqueda : Form
    {
        Libreria miLibreria;
        Revisteria miRevisteria;
        bool esBusqueda;
        bool esLibreria;
        bool esRevista;
        public FormBusqueda(Revisteria miRevisteria, bool esBusqueda, bool esRevista)
        {
            InitializeComponent();
            this.miRevisteria = miRevisteria;
            this.esBusqueda = esBusqueda;
            this.esLibreria = false;
            this.esRevista = esRevista;
        }

        public FormBusqueda(Libreria miLibreria, bool esBusqueda)
        {
            InitializeComponent();
            this.miLibreria = miLibreria;
            this.esBusqueda = esBusqueda;
            this.esLibreria = true;
        }

        private void FormBusqueda_Load(object sender, EventArgs e)
        {
            if (esLibreria)
            {
                CargarDatosLibreria();
            }
            else
            {
                rbtnCatComics.Show();
                rbtnCatRevistas.Show();
                CargarDatosRevisteria();
            }

        }

        /// <summary>
        /// Carga los datos de la libreria al dataGrid
        /// </summary>
        private void CargarDatosLibreria()
        {
            this.dataGridBusqueda.DataSource = miLibreria.ListaLibros;
        }

        /// <summary>
        /// Carga los datos de la Revisteria al datagrid
        /// </summary>
        private void CargarDatosRevisteria()
        {
            this.dataGridBusqueda.DataSource = miRevisteria.ListaRevistas;
        }

        private void rbtnCatComics_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridBusqueda.DataSource = miRevisteria.ListaComics;
        }

        private void rbtnCatRevistas_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridBusqueda.DataSource = miRevisteria.ListaRevistas;
        }
    }
}
