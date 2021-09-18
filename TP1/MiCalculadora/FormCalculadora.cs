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
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        //METODOS 
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            lstOperaciones.Text = "";           ///esto se hace asi?
            cmbOperador.Text = " ";
            label1.Text = "Resultado";
        }

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

        //boton limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //boton operar
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            string resultadoStr;


            resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            resultadoStr= resultado.ToString();

            //Agrega un item a la lista
            if(cmbOperador.Text==" ")
            {
                lstOperaciones.Items.Add($"{txtNumero1.Text} + {txtNumero2.Text} = {resultadoStr}");

            }
            else
            {
                lstOperaciones.Items.Add($"{txtNumero1.Text} {cmbOperador.Text} {txtNumero2.Text} = {resultadoStr}");
            }
            
            //muestra el resultado en label
            if(resultadoStr.Length<10)
            {
                label1.Text = resultadoStr;
            }
            else
            {
                label1.Text = "Error";
            }
        }

        //boton convertir a binario
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

        //boton convertir a decimal
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string binarioStr=Operando.BinarioDecimal(label1.Text);
            label1.Text=binarioStr;
        }


        //CIERRE DEL FORMULARIO
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo)==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        
    }
}
