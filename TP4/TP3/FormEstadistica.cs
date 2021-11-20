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
    public partial class FormEstadistica : Form
    {

        Libreria miLibreria;


        public FormEstadistica(Libreria miLibreria)
        {
            InitializeComponent();
            this.miLibreria = miLibreria;
        }

        private void FormEstadistica_Load(object sender, EventArgs e)
        {

            MostrarEstadisticas();
            
        }

        /// <summary>
        /// Muestra las estadusticas
        /// </summary>
        private void MostrarEstadisticas()
        {

        }

    }
}
