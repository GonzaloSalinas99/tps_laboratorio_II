using System;
using System.Collections.Generic;
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
            Limpiar();
        }

        public void Limpiar()
        {
            lstOperaciones.Items.Clear();
            lblResultado.ResetText();
            txtNumero1.ResetText();
            txtNumero2.ResetText();
            cmbOperador.ResetText();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnCerrar.DialogResult =  MessageBox.Show("Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo);
            if(btnCerrar.DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando numeroAConvertir = new Operando();
            string resultado = lblResultado.Text;

            lblResultado.Text = numeroAConvertir.DecimalBinario(resultado);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando numeroAConvertir = new Operando();
            string resultado = lblResultado.Text;
            lblResultado.Text = numeroAConvertir.BinarioDecimal(resultado);
        }
    }
}
