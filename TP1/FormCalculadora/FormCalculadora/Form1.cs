using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Entidades;
namespace FormCalculadora
{
    public partial class FormCalculadora : Form
    {   
        /// <summary>
        /// Crea y configura los controles del formulario.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carga con los valores asignados los controladores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
        }
        /// <summary>
        /// Realiza la operacion indicada por el usuario y valida que los txtBox tengan un valor ingresado. Agrega la operacion realizada a un listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1;
            string numero2;
            char operador;
            double resultado;
            
            if(txtNumero1.Text== "" || txtNumero2.Text== "" || cmbOperador.Text == "")
            {
                MessageBox.Show("Error al iniciar el calculo", "Error de ingreso");
            }
            else
            {

                if(ValidarCadenaIngresada(txtNumero1.Text) == false)
                {
                    MessageBox.Show("Ingreso letras en el primer operando, se le asignara el valor 0");
                    txtNumero1.Text = "0";
                }

                if (ValidarCadenaIngresada(txtNumero2.Text) == false)
                {
                    MessageBox.Show("Ingreso letras en el segundo operando, se le asignara el valor 0");
                    txtNumero2.Text="0";
                }


                Console.Beep();
                numero1 = txtNumero1.Text;
                numero2 = txtNumero2.Text;
                operador = char.Parse( cmbOperador.Text);

                Operando num1 = new Operando(numero1);
                Operando num2 = new Operando(numero2);
                
                resultado = Calculadora.Operar(num1, num2, operador);
                lblResultado.Text = resultado.ToString();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{numero1} {operador} {numero2} = {resultado}");

                lstOperaciones.Items.Add(sb.ToString());
            }
        }
        /// <summary>
        /// Valida que la cadena recibida por parametro, sea un numero y no contenga ninguna letra.
        /// </summary>
        /// <param name="numeroAValidar">Cadena a ser validada</param>
        /// <returns>Retorna TRUE si la cadena no contiene ninguna letra
        ///         Retorna FALSE si la cadena contiene al menos una letra</returns>
        public static bool ValidarCadenaIngresada(string numeroAValidar)
        {
            double validacion;
            if(double.TryParse(numeroAValidar,out validacion)==false)
            {
                return false;
            }
            return true;

        }


        /// <summary>
        /// LLama al metodo Limpiar().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Limpiar();
        }
        /// <summary>
        /// Resetea el listBox,txtBox,cmbBox y el lblResultado.
        /// </summary>
        public void Limpiar()
        {
            lstOperaciones.Items.Clear();
            lblResultado.ResetText();
            txtNumero1.ResetText();
            txtNumero2.ResetText();
            cmbOperador.ResetText();
        }
        /// <summary>
        /// Consulta al usuario si quiere cerrar el formulario. Si elige la opcion SI, cierra dicho formulario, de lo contrario sigue abierto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Console.Beep();
            btnCerrar.DialogResult =  MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);
            if(btnCerrar.DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Al resultado obtenido luego de una operacion, convierte ese numero a Binario si se puede, sino retorna una Valor Invalido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Operando numeroAConvertir = new Operando();
            string resultado = lblResultado.Text;

            lblResultado.Text = numeroAConvertir.DecimalBinario(resultado);
        }

        /// <summary>
        /// Al resultado obtenido luego de una operacion, convierte ese numero a Decimal si se puede, sino retorna una Valor Invalido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Operando numeroAConvertir = new Operando();
            string resultado = lblResultado.Text;

            lblResultado.Text = numeroAConvertir.BinarioDecimal(resultado);
        }
    }
}
