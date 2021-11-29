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
    public partial class AgregarAlumno : Form
    {
        Procesador<Persona> listaPersonas;
        public AgregarAlumno(Procesador<Persona> personas)
        {
            InitializeComponent();
            listaPersonas = personas;
        }
        /// <summary>
        /// Crea un Alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtApellido.Text != "" && txtCuatrimestreCursando.Text != "" && txtDocumento.Text != "" &&
                    txtEdad.Text != "" && txtFechaIngreso.Text != "" && txtLegajo.Text != "" &&
                    txtNombre.Text != "")
                {
                    int edadAux;
                    int cuatrimestreCursado;

                    DateTime fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
                    if (int.TryParse(txtEdad.Text,out edadAux) && int.TryParse(txtCuatrimestreCursando.Text,out cuatrimestreCursado))
                    {
                        _ = listaPersonas + new Alumno(txtNombre.Text, txtApellido.Text, txtDocumento.Text, edadAux, txtLegajo.Text, cuatrimestreCursado, fechaIngreso);
                        MessageBox.Show("Se agrego de manera correcta el alumno");
                        Close();
                    }

                }
            }
            catch (Exception)
            {

                throw new Excepciones.Excepciones("Ocurrio un error con la carga de datos");
            }
        }
        /// <summary>
        /// Devuelve los datos del procesador
        /// </summary>
        public Procesador<Persona> DevolverProcesador
        {
            get { return listaPersonas; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
