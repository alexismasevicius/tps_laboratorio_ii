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

        /// <summary>
        /// Muestra las estadusticas
        /// </summary>
        private void MostrarEstadisticas()
        {
            Libro miLibroMasVendido = miLibreria.BuscarLibroMasVendido();
            Revista miRevistaMasVendida = miRevisteria.BuscarRevistaMasVendida();
            Comic miComicMasVendido = miRevisteria.BuscarComicMasVendido();
            float ingresosLibros = miLibreria.CalcularVentasLibros();
            float ingresosComics = miRevisteria.CalcularVentasComic();
            float ingresosRevistas = miRevisteria.CalcularVentasRevista();

            lstboxEstadisticas.Items.Add($"Los ingresos TOTALES fueron de: {ingresosComics+ingresosLibros+ingresosRevistas}");
            lstboxEstadisticas.Items.Add($"Los ingresos por ventas de libros fueron de: {ingresosLibros}");
            lstboxEstadisticas.Items.Add($"Los ingresos por ventas de revistas fueron de: {ingresosRevistas}");
            lstboxEstadisticas.Items.Add($"Los ingresos por ventas de comics fueron de: {ingresosComics}");

            if (ingresosLibros > (ingresosComics + ingresosRevistas))
            {
                lstboxEstadisticas.Items.Add($"El puesto de mayor recaudacion fue la libreria");
            }
            else if(ingresosLibros < (ingresosComics + ingresosRevistas))
            {
                lstboxEstadisticas.Items.Add($"El puesto de mayor recaudacion fue la revisteria");
            }

            if (miLibroMasVendido is not null)
            {
                lstboxEstadisticas.Items.Add($"El libro más vendido es: {miLibroMasVendido.ToString()}, con {miLibroMasVendido.Ventas} unidades");
            }
            if(miRevistaMasVendida is not null)
            {
                lstboxEstadisticas.Items.Add($"La revista más vendida es: {miRevistaMasVendida.ToString()}, con {miRevistaMasVendida.Ventas} unidades");
            }
            if (miComicMasVendido is not null)
            {
                lstboxEstadisticas.Items.Add($"El comic más vendido es: {miComicMasVendido.ToString()}, con {miComicMasVendido.Ventas} unidades");
            }

        }

    }
}
