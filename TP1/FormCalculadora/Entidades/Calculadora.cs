using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida el parametro recibio para que sea si o si un operador matematico
        /// </summary>
        /// <param name="operador">Parametro a validar</param>
        /// <returns>Retorna el operador validaddo, de no ser asi retorna un '+'</returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';
            if(operador == '-' || operador == '*' || operador == '/')
            {
                retorno = operador; 
            }
            return retorno;
        }
        /// <summary>
        /// Realiza la operacion matematica entre los operandos indicada a travez del operador.
        /// </summary>
        /// <param name="num1">Primer operando para realizar el calculo.</param>
        /// <param name="num2">Segundo operando para realizar el calculo.</param>
        /// <param name="operador">Operador matematico para realizar el calculo</param>
        /// <returns>Retorna el resultado obtenido luego de realizar la operacion correcta.</returns>
        public static double Operar(Operando num1,Operando num2,char operador)
        {
            double resultado=0;
            operador = ValidarOperador(operador);
            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':

                    double aux = num1 / num2;
                    resultado = Math.Round(aux, 2);
                    break;
            }

            return resultado;
        }


    }
}
