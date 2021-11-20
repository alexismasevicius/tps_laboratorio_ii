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
    public partial class FormVenta : Form
    {
        Producto miProducto;
        List<Cliente> listaClientes;
        List<Venta> listaVentas;
        Cliente miCliente;

        public FormVenta(Producto miProducto, List<Cliente> lista, List<Venta> listaVentas)
        {
            InitializeComponent();
            this.miProducto = miProducto;
            this.listaClientes = lista;
            this.listaVentas = listaVentas;
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            this.rchtxtProducto.Text = $"PRODUCTO:{miProducto.Titulo}\nPRECIO: ${miProducto.Precio}\nIngrese un DNI y haga click en el boton buscar...";
            foreach (var item in Enum.GetValues(typeof(Genero)))
            {
                cbmGenero.Items.Add(item);
            }
        }

        /// <summary>
        /// Click en el boton VENDER. Concreta la venta. Crea un cliente si no existia en la DB. Guarda recibo en Escritorio
        /// </summary>
        private void btnAgregar_Click(object sender, EventArgs e)
        {       
            if (ValidarCliente())
            {
                if(this.miCliente == null)
                {
                    int.TryParse(this.txtDNI.Text, out int dniValido);
                    this.miCliente = new Cliente(dniValido, txtNombre.Text, txtApellido.Text, (Genero)cbmGenero.SelectedItem, (int)numEdad.Value);
                    listaClientes.Add(this.miCliente);
                }
                MessageBox.Show($"El total a pagar por el producto: --{miProducto.Titulo}-- es de: ${miProducto.Precio} ");
               
                Venta miVenta = new Venta((Libro)miProducto, this.miCliente);
                
                this.listaVentas.Add(miVenta);
                miVenta.Guardar();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error el cliente cargado no es valido\n");
            }

        }


        /// <summary>
        /// Cierra el formulario
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Click en el boton buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente unCliente = esCliente();
            if (unCliente != null)
            {
                this.miCliente = unCliente;
                this.txtNombre.Text = miCliente.Nombre;
                this.txtApellido.Text = miCliente.Apellido;
                this.numEdad.Value = miCliente.Edad;
                this.cbmGenero.Text = miCliente.Genero.ToString();
                btnAgregar.Enabled = true;
            }
            else
            {
                MessageBox.Show("El cliente no se encontró en la base de datos\nIngrese los datos para agregarlo.");                
                HabilitarCargaCliente();
            }
        }

        /// <summary>
        /// Valida si el cliente está instanciado, 
        /// o si los datos cargados son correctos para crear un nuevo cliente
        /// </summary>
        /// <returns>true si es valido, false si no</returns>
        private bool ValidarCliente()
        {
            bool retorno = true;
            if (this.miCliente == null)
            {
                if(this.cbmGenero.SelectedIndex == -1)
                {
                    retorno = false;
                }
                if(this.numEdad.Value<1 || this.numEdad.Value > 200)
                {
                    retorno = false;
                }
                if(!int.TryParse(this.txtDNI.Text, out int dniValido))
                {
                    retorno = false;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Hablilita la carga de un cliente
        /// </summary>
        private void HabilitarCargaCliente()
        {
            this.txtDNI.Enabled = false;
            this.txtNombre.Enabled = true;
            this.txtApellido.Enabled = true;
            this.numEdad.Enabled = true;
            this.cbmGenero.Enabled = true;
            btnAgregar.Enabled = true;
        }

        /// <summary>
        /// Verifica si el cliente se encuentra en la base de datos
        /// </summary>
        /// <returns>el cliente si lo encuentra, si no lo encuentra null</returns>
        private Cliente esCliente()
        {
            int.TryParse(this.txtDNI.Text, out int dni);

            if (listaClientes != null)
            {
                foreach (Cliente item in listaClientes)
                {
                    if (dni == item.Dni)
                    {
                        return item;
                    }
                }
            }

            return null;
        }

    }
}
