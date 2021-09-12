using System;
using System.Text;
using System.Windows.Forms;
using Entidades;
namespace FormCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
        }

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



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstOperaciones.Items.Clear();
        }
    }
}
