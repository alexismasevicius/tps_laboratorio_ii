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

        /// <summary>
        /// Constructor del form estadistico
        /// </summary>
        /// <param name="miLibreria"></param>
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
            GeneroDeClientes();
            HorarioDeVentas();
            RecaudacionDelDia();
            RangoDeEdades();
            LibrosMasVendidos();
            GastoPromedioJovenesMenores25();
            GastoPromedioMayores25();
            LibrosMasElegidosPorMujeres();
            ClienteMasFiel();
        }

        /// <summary>
        /// Libro Mas elegido por Mujeres
        /// </summary>
        private void LibrosMasElegidosPorMujeres()
        {
            List<Venta> listaComprasDeMujeres = new List<Venta>();
            foreach (Venta item in miLibreria.ListaVentas)
            {
                if(item.Cliente.Genero == Genero.femenino)
                {
                    listaComprasDeMujeres.Add(item);
                }
            }

            int codigoLibro = listaComprasDeMujeres.GroupBy(venta => venta.Libro.Codigo).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();

            Libro libro = miLibreria.ConsultaBaseDatosLibro(codigoLibro);

            this.richTextLibroMasCompradoPorMujeres.Text = $"LIBRO MAS COMPRADO POR MUJERES:\n{libro.Titulo}, {libro.Autor}";

        }

        /// <summary>
        /// Busca el cliente con mas compras
        /// </summary>
        private void ClienteMasFiel()
        {
            Cliente miCliente = null;
            int dniClienteMasFiel = miLibreria.ListaVentas.GroupBy(venta => venta.Cliente.Dni).OrderByDescending(grp => grp.Count()).Select(grp => grp.Key).First();
            foreach (Cliente item in miLibreria.ListaCliente)
            {
                if (dniClienteMasFiel == item.Dni)
                {
                    miCliente = item;
                }
            }
            this.richTextBoxClienteMasfiel.Text = $"CLIENTE QUE MAS COMPRAS REALIZO:\n{miCliente.Apellido}, {miCliente.Nombre}";
           
        }


        /// <summary>
        /// Calcula y muestra el gasto promedio por libro de los menores a 25
        /// </summary>
        private void GastoPromedioJovenesMenores25()
        {
            float acumulador = 0;
            int contador = 0;
            foreach (Venta item in miLibreria.ListaVentas)
            {
                if (item.Cliente.Edad <= 25)
                {
                    contador++;
                    acumulador += item.Libro.Precio;
                }
            }
            this.richTextGastoPromedioMenores.Text = $"COMPRA PROMEDIO DE CLIENTES MENORES DE 25:\n{(acumulador / contador):F2}$";
        }

        /// <summary>
        /// Calcula el gasto promedio en mayores a 25 
        /// </summary>
        private void GastoPromedioMayores25()
        {
            float acumulador = 0;
            int contador = 0;
            foreach (Venta item in miLibreria.ListaVentas)
            {
                if (item.Cliente.Edad >= 25)
                {
                    contador++;
                    acumulador += item.Libro.Precio;
                }
            }
            this.richTextGastoPromedioMayores.Text = $"COMPRA PROMEDIO DE CLIENTES MAYORES DE 25:\n{(acumulador / contador):F2}$";
        }


        /// <summary>
        /// Busca los 3 libros mas vendidos en la base de datos
        /// </summary>
        private void LibrosMasVendidos()
        {
            string sqlCommand = "SELECT TOP 3 titulo,autor,ventas FROM Libros ORDER BY ventas DESC;";
            this.dataGridMasVendidos.DataSource = miLibreria.ConsultaBaseDatos(sqlCommand);
            this.dataGridMasVendidos.ReadOnly = true;
        }

        /// <summary>
        /// Calcula la recaudacion del dia
        /// </summary>
        private void RecaudacionDelDia()
        {
            float total= 0;
            foreach(Venta item in miLibreria.ListaVentas)
            {
                if(item.Fecha.Date == DateTime.Now.Date)
                {
                    total = total + item.Libro.Precio;
                }
            }
            this.richtxtRecaudacionDia.Text = $"RECAUDACION DEL DIA:\n   {total}$";
        }

        /// <summary>
        /// Calcula los porcentajes del genero de los clientes
        /// </summary>
        private void GeneroDeClientes()
        {
            int masc = 0;
            int fem = 0;
            int nb = 0;
            int total;
            foreach (Cliente item in miLibreria.ListaCliente)
            {
                if(item.Genero == Genero.masculino)
                {
                    masc++;
                }
                else
                {
                    if (item.Genero == Genero.femenino)
                    {
                        fem++;
                    }
                    else
                    {
                        nb++;
                    }
                }
            }
            total = masc + fem + nb;
            this.richtxtGeneroClientes.Text = $"GENERO DE CLIENTES:\nMasculino: {masc.CalcularPorcentaje(total)}\nFemenino: {fem.CalcularPorcentaje(total)}\nNo binario: {nb.CalcularPorcentaje(total)}";
        }


        /// <summary>
        /// Calcula el horario promedio de las ventas
        /// </summary>
        private void HorarioDeVentas()
        {
            int man = 0;
            int tar = 0;
            int noc = 0;
            int total;
            
            foreach (Venta item in miLibreria.ListaVentas)
            {
                if (item.Fecha.Hour>18)
                {
                    noc++;
                }
                else
                {
                    if (item.Fecha.Hour <= 18 && item.Fecha.Hour > 12)
                    {
                        tar++;
                    }
                    else
                    {
                        man++;
                    }
                }
            }
            total = man + tar + noc;
            this.richtxtHorarioVentas.Text = $"HORARIO DE VENTAS:\nMañana: {man.CalcularPorcentaje(total)}\nTarde: {tar.CalcularPorcentaje(total)}\nNoche: {noc.CalcularPorcentaje(total)}";
        }

        /// <summary>
        /// Calcula el rango de edades de los clientes
        /// </summary>
        private void RangoDeEdades()
        {
            int menos18 = 0;
            int mas18 = 0;
            int mas30 = 0;
            int mas50 = 0;
            int mas70 = 0;
            int total;

            foreach (Venta item in miLibreria.ListaVentas)
            {
                if(item.Cliente.Edad>0 && item.Cliente.Edad < 18)
                {
                    menos18++;
                }
                else if (item.Cliente.Edad > 18 && item.Cliente.Edad < 30)
                {
                    mas18++;
                }
                else if (item.Cliente.Edad > 30 && item.Cliente.Edad < 50)
                {
                    mas30++;
                }
                else if (item.Cliente.Edad > 50 && item.Cliente.Edad < 70)
                {
                    mas50++;
                }
                else if (item.Cliente.Edad > 70)
                {
                    mas70++;
                }
            }
            total = menos18 + mas18 + mas30 + mas50 + mas70;
            this.richTextEdadesVentas.Text = $"RANGO DE EDAD POR\nCADA VENTA:\nMenor 18: {(menos18*100) / total}%\n18-30: {(mas18*100) / total}%\n30-50: {(mas30*100) / total}%\n50-70: {(mas50*100) / total}%\nMayor 70: {(mas70*100) / total}%";

        }


    }
}
