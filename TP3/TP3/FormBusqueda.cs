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
    public partial class FormBusqueda<T>: Form
    {
        List<T> miLista;


        /// <summary>
        /// Constructor de formulario de busqueda. Muestra los objetos de una lista pasada por parametros
        /// </summary>
        /// <param name="miLista">Lista generica</param>
        public FormBusqueda(List<T> miLista)
        {
            InitializeComponent();
            this.miLista = miLista;
            
        }



        /// <summary>
        /// Carga del formulario y muestra de datos de lista
        /// </summary>
        private void FormBusqueda_Load(object sender, EventArgs e)
        {
            this.dataGridBusqueda.DataSource = miLista;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                Producto miProducto = (Producto)this.dataGridBusqueda.SelectedRows[0].DataBoundItem;
                if (miProducto.Vender())
                {
                    MessageBox.Show($"Venta Exitosa. El total a pagar por el producto: --{miProducto.Titulo}-- es de: ${miProducto.Precio} ");
                }
                else
                {
                    MessageBox.Show($"No hay stock del producto seleccionado");
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
            this.dataGridBusqueda.DataSource = this.miLista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
