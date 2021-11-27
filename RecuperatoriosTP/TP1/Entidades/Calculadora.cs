using System;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza la operacion entre dos Operando, en caso de no recibir un operando +,-,* o /, realiza una suma
        /// </summary>
        /// <param name="num1">Primer numero</param>
        /// <param name="num2">Segundo numero</param>
        /// <param name="operador">Operador +,-,* o /</param>
        /// <returns>Resultado de la operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double retorno;

            operador = ValidarOperador(operador);

            switch (operador)
            {
                case '+':
                    retorno = num1 + num2;
                    break;
                case '-':
                    retorno = num1 - num2;
                    break;
                case '*':
                    retorno = num1 * num2;
                    break;
                case '/':
                    retorno = num1 / num2;      
                    break;
                default: 
                    retorno = 0;
                    break;
            }

            return retorno;
        }


        /// <summary>
        /// Valida que el operador sea +,-,* o /, en caso contrario retorna +
        /// </summary>
        /// <param name="operador">Operador a validar</param>
        /// <returns>Operador validado</returns>
        private static char ValidarOperador(char operador)
        {
            if(operador=='+'|| operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }
    }
}
