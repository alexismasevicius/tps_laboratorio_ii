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
        string sqlCommand;

        /// <summary>
        /// Constructor de formulario de busqueda. 
        /// </summary>
        /// <param name="miLibreria">libreria a mostrar</param>
        public FormBusqueda(Libreria miLibreria)
        {
            InitializeComponent();
            this.miLibreria = miLibreria;
        }

        /// <summary>
        /// Constructor de formulario de busqueda CON FILTROS.
        /// </summary>
        /// <param name="miLibreria">libreria a mostrar</param>
        /// <param name="sqlCommand">comando sql para filtrar</param>
        public FormBusqueda(Libreria miLibreria, string sqlCommand):this(miLibreria)
        {
            this.sqlCommand = sqlCommand;
        }




        /// <summary>
        /// Carga del formulario y muestra de datos de lista
        /// </summary>
        private void FormBusqueda_Load(object sender, EventArgs e)
        {
            this.dataGridBusqueda.ReadOnly = true;
            try
            {
                RefrescarDataGrid();             
            }
            catch (BibliotecaException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        /// <summary>
        /// Click en el boton VENDER. Modifica la base de datos y guarda archivo json con datos de clientes y ventas
        /// </summary>
        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (dataGridBusqueda.SelectedRows[0].Cells[0].Value is not null)
                {
                    int code = (int)dataGridBusqueda.SelectedRows[0].Cells[0].Value;
                    Libro miLibro = miLibreria.ConsultaBaseDatosLibro(code);
                    miLibro.Codigo = code;
                    if (miLibro.Stock>0)
                    {
                        FormVenta formVenta = new FormVenta(miLibro, miLibreria.ListaCliente, miLibreria.ListaVentas);
                        formVenta.ShowDialog();
                        if(formVenta.DialogResult == DialogResult.OK)
                        {
                            try
                            {                                
                                miLibreria.RutaDeArchivo = "ListaClientes.txt";
                                miLibreria.Guardar(miLibreria.ListaCliente);
                                miLibreria.RutaDeArchivo = "RecibosLibreria.txt";
                                miLibreria.Guardar(miLibreria.ListaVentas);
                                miLibreria.VenderProducto(miLibro.Codigo);
                            }
                            catch(Exception)
                            {
                                MessageBox.Show("Error al guardar los datos de la venta");
                            }

                        }
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
            if(this.sqlCommand is null)
            {
                this.dataGridBusqueda.DataSource = null;
                this.dataGridBusqueda.DataSource = miLibreria.ConsultaBaseDatos();
            }
            else
            {
                this.dataGridBusqueda.DataSource = null;
                this.dataGridBusqueda.DataSource = miLibreria.ConsultaBaseDatos(sqlCommand);
            }

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
