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
using Estadisticas;
namespace Formularios
{
    public partial class frmEstadisticas : Form
    {
        Procesador<Persona> listaPersonas;

        /// <summary>
        /// Constructor del formulario que recibe una lista
        /// </summary>
        /// <param name="listaAux"></param>
        public frmEstadisticas(Procesador<Persona> listaAux)
        {
            InitializeComponent();
            listaPersonas = listaAux;

            cmbOrdenLista.Items.Add("Ascendente");
            cmbOrdenLista.Items.Add("Descendente");

            cmbOpcionEstudiosSecundarios.Items.Add("Secundario Completo");
            cmbOpcionEstudiosSecundarios.Items.Add("Secundario Incompleto");
        }
        /// <summary>
        /// Escribe en el richTextBox la persona con mayor edad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcularPersonaMAyorEdad_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = "";
            rtbEstadisticas.Text = CalcularEstadisticas.CalcularPersonaConMayorEdad(listaPersonas);
        }

        /// <summary>
        /// Escribe en el richTextBox el promedio de generos de personas cargadas en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGeneroConMasPersonasCargadas_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = "";
            rtbEstadisticas.Text = CalcularEstadisticas.CalcularPromedioDeGenerosDePersonasCargadas(listaPersonas);
        }
        /// <summary>
        /// Llama al formulario MostrarPersonas y lo carga con la lista ordenada por el salario Ascendente o Descendente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenarListaPorSalario_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = "";
            if(cmbOrdenLista.SelectedItem is not null)
            {
                IEnumerable<Persona> listaAux = CalcularEstadisticas.OrdenarListaPorSalario(listaPersonas, VerificarOrdenDeLista(cmbOrdenLista));
                Procesador<Persona> personasAux = new Procesador<Persona>();
                foreach (Persona persona in listaAux)
                {
                    personasAux.Personas.Add(persona);
                }
                frmMostrarPersonas frmMostrarPersonas = new frmMostrarPersonas(personasAux);
                frmMostrarPersonas.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opcion para ordenar la lista.");
            }
        }
        /// <summary>
        /// Verifica la opcion seleccionada en el combobox 
        /// </summary>
        /// <param name="comboBox">combobox a leer la opcion seleccionada</param>
        /// <returns>0 si eligo Ascendente o 1 si eligio Descendente</returns>
        private int VerificarOrdenDeLista(ComboBox comboBox)
        {
            if (comboBox.SelectedItem.ToString() == "Ascendente")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        /// <summary>
        /// Escribe en el richTextBox la cantidad de personas con estudio secundario, si lo terminaron o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcularCantidadDePersonasConEstudioSecundario_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = "";
            if(cmbOpcionEstudiosSecundarios.SelectedItem is not null)
            {
                rtbEstadisticas.Text = CalcularEstadisticas.CalcularCantidadDePersonasConEstudioSecundario(listaPersonas, VerificarEleccionEstudioSecundario(cmbOpcionEstudiosSecundarios));
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opcion para calcular la cantidad de personas con estudios secundarios.");
            }
        }
        /// <summary>
        /// Lee la opcion la opcion seleccionada en el combobox
        /// </summary>
        /// <param name="comboBox">combobox a leer la opcion seleccionada</param>
        /// <returns>0 si selecciono Secundario Completo o 1 si selecciono Secundario Incompleto</returns>
        private int VerificarEleccionEstudioSecundario(ComboBox comboBox)
        {
            if(comboBox.SelectedItem.ToString() == "Secundario Completo")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        /// <summary>
        /// Escribe en el richTextBox la cantidad de personas que hay de cada pais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcularCantidadPersonasEnPais_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = "";
            rtbEstadisticas.Text = CalcularEstadisticas.CalcularCantidadDePersonasPorPais(listaPersonas);

        }
        /// <summary>
        /// Escribe en el richTextBox el promedio-minimo-maximo de salarios de las personas cargadas en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcularPromedioMinimoMaximoSalarios_Click(object sender, EventArgs e)
        {
            rtbEstadisticas.Text = "";
            rtbEstadisticas.Text = CalcularEstadisticas.CalcularPromedio_Minimo_Maximo_DeSalarios(listaPersonas);

        }
    }
}
