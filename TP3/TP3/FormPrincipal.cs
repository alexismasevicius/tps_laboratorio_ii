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
    public partial class FormPrincipal : Form
    {

        Revisteria miRevisteria = new Revisteria();
        Libreria miLibreria = new Libreria();

        Libro libro1 = new Libro("En busca del tiempo perdido", "Proust, Marcel", 1922, 2, 0, 2000, "novela");
        Libro libro2 = new Libro("La metamorfosis", "Kafka, Franz", 1915, 5, 0, 800, "novela");
        Comic comic1 = new Comic("Spider-Man #230", "Stan Lee", 2001, 3, 0, 500, "no");
        Revista revista1 = new Revista("National Geographic 44", "NatGeo", 2021, 20, 0, 300);

        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del formulario
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            miLibreria.AgregarProducto(libro1, "sadsa");
            miLibreria.AgregarProducto(libro2, "sadsa");
            miRevisteria.AgregarProducto(comic1, "dsaad");
            miRevisteria.AgregarProducto(revista1, "dsaad");
        }


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
                    FormBusqueda miForm = new FormBusqueda(miLibreria, true);
                    miForm.ShowDialog();
                    break;
                case 1:
                    FormBusqueda miFormComic = new FormBusqueda(miRevisteria, true, false);
                    miFormComic.ShowDialog();
                    break;
                case 2:                    
                    FormBusqueda miFormRevista = new FormBusqueda(miRevisteria, true, true);
                    miFormRevista.ShowDialog();
                    break;

            }


        }


        /// <summary>
        /// CLick en el boton MOSTRAR CATALOGO LIBRERIA
        /// </summary>
        private void btnMostrarCatalogo_Click(object sender, EventArgs e)
        {
            FormBusqueda miForm = new FormBusqueda(miLibreria, false);
            miForm.ShowDialog();
        }

        /// <summary>
        /// click en el boton MOSTRAR CATALOGO REVISTERIA
        /// </summary>
        private void btnMostrarRevisteria_Click(object sender, EventArgs e)
        {
            FormBusqueda miForm = new FormBusqueda(miRevisteria, false, true);
            miForm.ShowDialog();
        }


        /// <summary>
        /// Click en el boton AGREGAR 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar miFormAgregar = new FormAgregar();
            miFormAgregar.ShowDialog();
        }


        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadistica miFormEstadistico = new FormEstadistica();
            miFormEstadistico.ShowDialog();
        }

        /// <summary>
        /// Click en el boton abrir de la barra
        /// </summary>
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Click en el boton guardar de la barra
        /// </summary>
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// click en el boton guardar como... de la barra
        /// </summary>
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
