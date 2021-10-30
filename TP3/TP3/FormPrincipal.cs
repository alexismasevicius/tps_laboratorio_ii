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

        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga del formulario
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Click en el boton BUSCAR
        /// </summary>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormBusqueda miForm = new FormBusqueda();
            miForm.ShowDialog();
        }


        /// <summary>
        /// CLick en el boton MOSTRAR CATALOGO
        /// </summary>
        private void btnMostrarCatalogo_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Click en el boton AGREGAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {

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
