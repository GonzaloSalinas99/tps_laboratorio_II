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
        public Operando(double numero):this()
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor que asgina el valor al atributo recibido por el parametro
        /// </summary>
        /// <param name="strNumero">Parametro de tipo string a ser asignado</param>
        public Operando(string strNumero):this()
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
        /// <summary>
        /// Convierte el numero binario recibido por parametro a numero decimal. Se valida que el parametro sea si o si un numero binario.
        /// </summary>
        /// <param name="binario">Parametro de tipo string que contendra el numero binario a ser convertido en decimal.</param>
        /// <returns>Retorna el numero decimal, si pudo ser convertido, en tipo string. De lo contrario retorna "Valor invalido".</returns>
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
        /// <summary>
        /// Convierte el numero decimal recibido por parametro a numero binario. Se valida que el parametro sea si o si un numero.
        /// </summary>
        /// <param name="binario">Parametro de tipo double que contendra el numero decimal a ser convertido en binario.</param>
        /// <returns>Retorna el numero binario, si pudo ser convertido, en tipo string. De lo contrario retorna "Valor invalido".</returns>
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
        /// <summary>
        /// Convierte el numero binario recibido por parametro a numero decimal. Se valida que el parametro sea si o si un numero binario.
        /// </summary>
        /// <param name="binario">Parametro de tipo string que contendra el numero binario a ser convertido a decimal.</param>
        /// <returns>Retorna el numero decimal, si pudo ser convertido, en tipo string. De lo contrario retorna "Valor invalido".</returns>
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
        /// <summary>
        /// Sobrecarga del operador '+' para realizar la suma entre dos operandos.
        /// </summary>
        /// <param name="n1">Primer operando para realizar el calculo.</param>
        /// <param name="n2">Segundo operando para realizar el calculo.</param>
        /// <returns>Retorna el resultado de la suma entre los operandos.</returns>
        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador '-' para realizar la resta entre dos operandos.
        /// </summary>
        /// <param name="n1">Primer operando para realizar el calculo.</param>
        /// <param name="n2">Segundo operando para realizar el calculo.</param>
        /// <returns>Retorna el resultado de la resta entre los operandos.</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador '*' para realizar la multiplicacion entre dos operandos.
        /// </summary>
        /// <param name="n1">Primer operando para realizar el calculo.</param>
        /// <param name="n2">Segundo operando para realizar el calculo.</param>
        /// <returns>Retorna el resultado de la multiplicacion entre los operandos.</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga del operador '/' para realizar la division entre dos operandos.Validando que el segundo operador no sea 0 (ya que no se puede realizar)
        /// </summary>
        /// <param name="n1">Primer operando para realizar el calculo.</param>
        /// <param name="n2">Segundo operando para realizar el calculo.</param>
        /// <returns>Retorna el resultado de la division entre los operandos.
        ///          Si el segundo operando es 0, retorna el valor minimo del tipo Double.</returns>
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

        public static bool ValidarNumeroIngresado(string numeroAValidar)
        {
            char[] cadena = numeroAValidar.ToCharArray();

            for(int i=0;i<cadena.Length;i++)
            {
                if(cadena[i] <= '0' || cadena[i]>='9')
                {
                    return false;
                }
            }
            return true;
        }


    }
}
