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
        Revisteria miRevisteria;
        Libreria miLibreria;


        public FormEstadistica(Libreria miLibreria, Revisteria miRevisteria)
        {
            InitializeComponent();
            this.miRevisteria = miRevisteria;
            this.miLibreria = miLibreria;
        }

        private void FormEstadistica_Load(object sender, EventArgs e)
        {
            MostrarEstadisticas();
        }

        private void MostrarEstadisticas()
        {
            lstboxEstadisticas.Items.Add($"El libro más vendido es: {BuscarLibroMasVendido().ToString()} ");
        }

        /// <summary>
        /// Busca el libro mas vendido
        /// </summary>
        /// <returns>El primer libro más vendido de la lista</returns>
        private Libro BuscarLibroMasVendido()
        {
            Libro miLibro = null;
            bool flag = false;
            foreach (Libro item in miLibreria.ListaLibros)
            {
                if (flag==false)
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

    }
}
