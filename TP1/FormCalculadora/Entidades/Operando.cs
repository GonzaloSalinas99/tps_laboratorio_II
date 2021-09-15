using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;
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

        private string Numero
        {
            set { this.numero = ValidarOperando(value); }
        }



        private double ValidarOperando(string strNumero)
        {
            double numeroValidado;
            if(double.TryParse(strNumero, out numeroValidado))
            {
                return numeroValidado;
            }
            return 0;
        }


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
