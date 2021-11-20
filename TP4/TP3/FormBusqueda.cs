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
    //IMPLEMENTACION DE GENERICS
    public partial class FormBusqueda<T>: Form
    {
        Libreria miLibreria;

        /// <summary>
        /// Constructor de formulario de busqueda. Muestra los objetos de una lista pasada por parametros
        /// </summary>
        /// <param name="miLista">Lista generica</param>
        public FormBusqueda(Libreria miLibreria)
        {
            InitializeComponent();
            this.miLibreria = miLibreria;
        }



        /// <summary>
        /// Carga del formulario y muestra de datos de lista
        /// </summary>
        private void FormBusqueda_Load(object sender, EventArgs e)
        {
            try
            {
                this.dataGridBusqueda.DataSource = miLibreria.ConsultaBaseDatos();
                this.dataGridBusqueda.ReadOnly = true;
            }
            catch (BibliotecaException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        /// <summary>
        /// Click en el boton VENDER
        /// </summary>
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridBusqueda.SelectedRows[0].Cells[0].Value is not null)
                {
                    Libro miLibro = miLibreria.ConsultaBaseDatosLibro((int)dataGridBusqueda.SelectedRows[0].Cells[0].Value);
                    if (miLibro.Stock>0)
                    {
                        FormVenta formVenta = new FormVenta(miLibro, miLibreria.ListaCliente, miLibreria.ListaVentas);
                    }
                    else
                    {
                        MessageBox.Show($"No hay stock del producto seleccionado");
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show($"Error al acceder a la base de datos");
            }
            RefrescarDataGrid();
        }


        private void RefrescarDataGrid()
        {
            this.dataGridBusqueda.DataSource = null;
            this.dataGridBusqueda.DataSource = miLibreria.ConsultaBaseDatos();
        }

        /// <summary>
        /// Click en el boton SALIR
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
