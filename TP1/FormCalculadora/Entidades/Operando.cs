using System;

namespace Entidades
{
    public class Operando
    {   
        /// <summary>
        /// Atributo de la clase tipo double
        /// </summary>
        private double numero;

        /// <summary>
        /// Constructor sin parametro que asigna el valor 0 al atributo.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Constructor que asgina el valor al atributo recibido por el parametro
        /// </summary>
        /// <param name="numero">Parametro de tipo double a ser asignado</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que asgina el valor al atributo recibido por el parametro
        /// </summary>
        /// <param name="strNumero">Parametro de tipo string a ser asignado</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        /// <summary>
        /// Propiedad solamente de escritura, que asigna el valor al atributo, previamente validado.
        /// </summary>
        private string Numero
        {
            set { this.numero = ValidarOperando(value); }
        }


        /// <summary>
        /// Valida el operando recibido por parametro para que sea si o si un numero.
        /// </summary>
        /// <param name="strNumero">Parametro de tipo string a ser validado.</param>
        /// <returns></returns>
        private double ValidarOperando(string strNumero)
        {
            double numeroValidado;
            if(double.TryParse(strNumero, out numeroValidado))
            {
                return numeroValidado;
            }
            return 0;
        }

        /// <summary>
        /// Valida el parametro recibido para que sea si o si un numero binario.
        /// </summary>
        /// <param name="binario">Parametro de tipo string a ser validado.</param>
        /// <returns>Retorna TRUE si la cadena recibida es un numero binario.
        ///          Retorna FALSE si la cadena recibida no es un numero binario.</returns>
        private bool EsBinario(string binario)
        {
            
            char[] validacion = binario.ToCharArray();

            for(int i=0;i<validacion.Length;i++)
            {
                if(validacion[i] != '1' && validacion[i]!='0')
                {
                    return false;
                }
            }
            return true;
        }

        public string BinarioDecimal(string binario)
        {
            string retorno = "Valor inválido";
            double numDecimal = 0;                                      
            int incrementoPotencia = 0;
            if (binario !="" && binario is not null)
            { 
                if(EsBinario(binario))
                {           
                    for (int i = binario.Length - 1; i >= 0; i--)           
                    {                                                      
                        if (binario[i] == '1')                             
                        {                                                  
                            numDecimal += Math.Pow(2, incrementoPotencia);  
                        }                                                   
                        incrementoPotencia++;                              
                    }                                                                             
                    retorno = numDecimal.ToString();
                }
            }
            return retorno;
        }

        public string DecimalBinario(double numero)
        {
            string retorno = "Valor Invalido";
            int numeroAConvertir = (int)Math.Abs(numero);
            string numeroBinario = Convert.ToString(numeroAConvertir, 2); 
            if(EsBinario(numeroBinario))
            {
                retorno = numeroBinario;
            }
            return retorno;
        }

        public string DecimalBinario(string numero)
        {
            string retorno = "Valor Invalido";
            double numeroAValidar;
            if(double.TryParse(numero, out numeroAValidar))
            {
                retorno = DecimalBinario(numeroAValidar);
            }
            return retorno;
        }

        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            double resultado;
            if(n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }
            return resultado;
        }
    }
}
