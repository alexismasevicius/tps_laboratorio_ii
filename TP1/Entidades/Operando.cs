using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;


        //CONSTRUCTORES

        public Operando()
        {
            this.numero = 0;
        }
        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            
            this.Numero = strNumero;
            
        }

        ///PROPIEDAD
        public string Numero 
        { 
            set 
            { 
                this.numero = ValidarOperando(value);
            } 
        }

        //VALIDACIONES
        
        /// <summary>
        /// Valida si un string se encuentra en formato binario
        /// </summary>
        /// <param name="binario">numero a validar</param>
        /// <returns>True si es binario, False si no lo es</returns>
        private static bool EsBinario(string binario)
        {
            foreach (char item in binario)
            {
                if (item !='0' && item!='1')
                {
                    return false;
                }
            }

            return true;

        }

        /// <summary>
        /// Valida si es numerico, en caso contrario devuelve 0
        /// </summary>
        /// <param name="strNumero">string a validar</param>
        /// <returns>El numero en formato Double. Si no es numerico devuelve 0</returns>
        private static double ValidarOperando(string strNumero)
        {
            double aux;

            if(!Double.TryParse(strNumero, out aux))
            {
                return 0;
            }
            

            return aux;
        }


        //OPERACIONES DE CONVERSION

        /// <summary>
        /// Convierte un numero binario a Decimal
        /// </summary>
        /// <param name="binario">string del numero</param>
        /// <returns>El numero convertido a decimal. En caso de no recibir un numero binario, devuelve "Valor invalido"</returns>
        public static string BinarioDecimal(string binario)
        {
            if (EsBinario(binario)==true)
            {
                int auxInt = Convert.ToInt32(binario,2);

                return auxInt.ToString(); 
            }
            else
            {
                return "Valor Invalido";
            }

            
        }

        /// <summary>
        /// Convierte un numero decimal positivo en binario
        /// </summary>
        /// <param name="numero">numero a convertir</param>
        /// <returns>El numero convertido en string. En caso de ser negativo devuelve "Error"</returns>
        public static string DecimalBinario(double numero)
        {
                string auxStr;
                int auxInt;
            if(numero>0)
            {
                auxInt = Convert.ToInt32(numero); 
                auxStr=Convert.ToString(auxInt, 2);
            }
            else
            {
                auxStr = "Error";
            }


            return auxStr;
        }
        

        /// <summary>
        /// Convierte un string numerico decimal en un string en binario
        /// </summary>
        /// <param name="numero">string numerico a convertir</param>
        /// <returns>El numero convertido a binario. En caso de no ser numerico devuelve "Error"</returns>
        public static string DecimalBinario(string numero)
        {
            double auxDouble;
            string resultado = "Error";

            if(Double.TryParse(numero, out auxDouble))
            {
                resultado=DecimalBinario(auxDouble);
            }


            return resultado;
        }
        

        //SOBRECARGA DE OPERADORES

        /// <summary>
        /// Suma dos objetos de tipo operando
        /// </summary>
        /// <param name="n1">primer Operando</param>
        /// <param name="n2">segundo Operando</param>
        /// <returns>El resultado de suma de los dos objetos tipo operando</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            double retorno = n1.numero + n2.numero;
            return retorno;
        }
        /// <summary>
        /// Resta dos objetos de tipo operando

        /// </summary>
        /// <param name="n1">primer Operando</param>
        /// <param name="n2">segundo Operando</param>
        /// <returns>El resultado de la resta de los dos objetos tipo operando</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            double retorno = n1.numero - n2.numero;
            return retorno;
        }
        /// <summary>
        /// Multiplica dos objetos de tipo operando
        /// </summary>
        /// <param name="n1">primer Operando</param>
        /// <param name="n2">segundo Operando</param>
        /// <returns>Resultado de la multiplicación de los dos objetos tipo operando</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            double retorno = n1.numero * n2.numero;
            return retorno;
        }
        /// <summary>
        /// Divide dos objetos de tipo operando
        /// </summary>
        /// <param name="n1">primer Operando</param>
        /// <param name="n2">segundo Operando</param>
        /// <returns>El resultado de la división de los dos objetos tipo operando. En caso de dividir por 0 devuelve el minimo valor</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double retorno;
            if (n2.numero!=0)
            {
                retorno = n1.numero / n2.numero;
            }
            else
            {
                retorno = double.MinValue;
            }
            
            return retorno;
        }


    }
}
