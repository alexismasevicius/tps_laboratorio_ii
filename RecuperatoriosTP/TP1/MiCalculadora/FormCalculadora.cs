using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        //INICIALIZACION
        /// <summary>
        /// Constructor
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// carga del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        //METODOS 

        /// <summary>
        /// borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lstOperaciones.Text = "";
            cmbOperador.Text = " ";
            label1.Text = "Resultado";
        }

        /// <summary>
        /// calcula el resultado de la operacion segun el operador pasado por parametro
        /// </summary>
        /// <param name="numero1">primer numero</param>
        /// <param name="numero2">segundo numero</param>
        /// <param name="operador">operador *,-,+ o /</param>
        /// <returns></returns>
        private static double Operar (string numero1, string numero2, string operador)
        {
            char operadorAux;
            double ret;

            Operando op1 = new Operando(numero1);
            Operando op2 = new Operando(numero2);

            operadorAux = Convert.ToChar(operador);
            ret = Calculadora.Operar(op1, op2, operadorAux);

            return ret;
        }


        //BOTONES

        /// <summary>
        /// Evento lick en Boton limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Evento click en el boton operar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string resultadoStr;


            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            resultadoStr= resultado.ToString();

            if(cmbOperador.Text==" ")
            {
                cmbOperador.Text = "+";
                lstOperaciones.Items.Add($"{txtNumero1.Text} + {txtNumero2.Text} = {resultadoStr}");

            }
            else
            {
                lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {resultadoStr}");
            }
            
            if(resultadoStr.Length<10)
            {
                label1.Text = resultadoStr;
            }
            else
            {
                label1.Text = "Resultado muy largo";
            }
        }

        /// <summary>
        /// Evento click Convertir a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (label1.Text != "Resultado" && 
                label1.Text.Length < 10
                )
            {
                string binarioStr = Operando.DecimalBinario(label1.Text);
                label1.Text = binarioStr;
            }
            else
            {
                label1.Text = "Error.";
            }
            
        }

        /// <summary>
        /// Evento click en boton convertir a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string binarioStr=Operando.BinarioDecimal(label1.Text);
            label1.Text=binarioStr;
        }

        /// <summary>
        /// Evento click en el boton cerrar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// Evento previo al cierre del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        
    }
}
