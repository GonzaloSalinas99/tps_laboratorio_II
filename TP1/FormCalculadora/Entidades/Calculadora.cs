using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';
            if(operador == '-' || operador == '*' || operador == '/')
            {
                retorno = operador; 
            }
            return retorno;
        }

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
