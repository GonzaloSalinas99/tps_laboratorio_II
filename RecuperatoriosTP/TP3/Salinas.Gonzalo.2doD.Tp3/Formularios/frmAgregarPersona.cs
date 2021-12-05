using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmAgregarPersona : Form
    {
        Procesador<Persona> listaPersonas;
        public frmAgregarPersona(Procesador<Persona> personas)
        {
            InitializeComponent();
            listaPersonas = personas;
        }
        /// <summary>
        /// Crea un profesor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtDocumento.Text != "" &&
                    txtEdad.Text != "" && txtSalario.Text != "" && cmbPais is not null &&
                    txtApellido.Text != "" && cmbEstudioSecundario.SelectedItem is not null && cmbGenero.SelectedItem is not null)
                {
                    EGenero genero;
                    ESecundario secundario;
                    if (cmbGenero.SelectedItem.ToString() == "Masculino")
                    {
                        genero = EGenero.Masculino;
                    }
                    else
                    {
                        genero = EGenero.Femenino;
                    }

                    if (cmbEstudioSecundario.SelectedItem.ToString() == "Completo")
                    {
                        secundario = ESecundario.Completo;
                    }
                    else
                    {
                        secundario = ESecundario.Incompleto;
                    }

                    _ = listaPersonas + new Persona(txtNombre.Text, txtApellido.Text, txtDocumento.Text, int.Parse(txtEdad.Text), genero, int.Parse(txtSalario.Text), secundario, VerificarPaisNacido(cmbPais));
                    MessageBox.Show("Se agrego de manera correcta a la persona");
                    Close();

                }
                else
                {
                    MessageBox.Show("Revise la informacion ingresada. Deben estar todos los campos completos.", "Error en la carga.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw new Excepciones.Excepciones("Ocurrio un error con la carga de datos", ex);
            }
        }
        /// <summary>
        /// Devuelve el procesador
        /// </summary>
        public Procesador<Persona> DevolverProcesador
        {
            get { return listaPersonas; }
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Carga los combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgregarProfesor_Load(object sender, EventArgs e)
        {
            cmbGenero.Items.Add("Masculino");
            cmbGenero.Items.Add("Femenino");

            cmbEstudioSecundario.Items.Add("Completo");
            cmbEstudioSecundario.Items.Add("Incompleto");

            cmbPais.Items.Add("Argentina");
            cmbPais.Items.Add("Chile");
            cmbPais.Items.Add("Colombia");
            cmbPais.Items.Add("Venezuela");
            cmbPais.Items.Add("Mexico");
        }

        /// <summary>
        /// Verifica el pais seleccionado en un comboBox
        /// </summary>
        /// <param name="combo">Combobox a leer sus datos</param>
        /// <returns></returns>
        private EPais VerificarPaisNacido(ComboBox combo)
        {
            EPais pais;
            if (combo.SelectedItem.ToString() == "Argentina")
            {
                pais = EPais.Argentina;
            }
            else
            {
                if (combo.SelectedItem.ToString() == "Chile")
                {
                    pais = EPais.Chile;
                }
                else
                {
                    if (combo.SelectedItem.ToString() == "Venezuela")
                    {
                        pais = EPais.Venezuela;
                    }
                    else
                    {
                        if (combo.SelectedItem.ToString() == "Colombia")
                        {
                            pais = EPais.Colombia;
                        }
                        else
                        {
                            pais = EPais.Mexico;
                        }
                    }
                }
            }
            return pais;
        }
        /// <summary>
        /// Solo permite escribir letras
        /// </summary>
        /// <param name="pE">Evento de tecla para validar que solo sea letra</param>
        private void SoloLetras(KeyPressEventArgs pE)
        {
            if (char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                if (char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else
                {
                    if (char.IsSeparator(pE.KeyChar))
                    {
                        pE.Handled = false;
                    }
                    else
                    {
                        pE.Handled = true;
                    }
                }
            }
        }
        /// <summary>
        /// Solo permite escribir numeros
        /// </summary>
        /// <param name="pE">Evento de tecla para validar que solo sea numero</param>
        private void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                if (char.IsControl(pE.KeyChar))
                {
                    pE.Handled = false;
                }
                else
                {
                    pE.Handled = true;
                }
            }
        }
        /// <summary>
        /// TextBox a verificar la informacion que se escribe para que sea solo letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
        /// <summary>
        /// TextBox a verificar la informacion que se escribe para que sea solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }/// <summary>
         /// TextBox a verificar la informacion que se escribe para que sea solo letras
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
        /// <summary>
        /// TextBox a verificar la informacion que se escribe para que sea solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
        /// <summary>
        /// TextBox a verificar la informacion que se escribe para que sea solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }
    }
}
