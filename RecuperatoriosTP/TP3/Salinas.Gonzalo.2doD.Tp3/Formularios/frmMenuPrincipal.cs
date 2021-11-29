using Controlador;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmMenuPrincipal : Form
    {
        Procesador<Persona> listaPersonas;


        OpenFileDialog openFileDialog;
        PuntoXml<Procesador<Persona>> puntoXml;
        string archivo;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            listaPersonas = new Procesador<Persona>();
            puntoXml = new PuntoXml<Procesador<Persona>>();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo XML|*.xml";

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //CargarDatosPersonas();
        }
        /// <summary>
        /// Hardcodeo de personas
        /// </summary>
        private void CargarDatosPersonas()
        {
            Persona a1 = new Alumno("Gaston", "Fernandez", "12345678", 21, "123123", 2, new DateTime(2020, 7, 02));
            Persona a2 = new Alumno("Franco", "Alvarez", "42424242", 20, "1111", 1, new DateTime(2021, 7, 10));
            Persona a3 = new Alumno("Elias", "Troncoso", "42038608", 22, "9999", 3, new DateTime(2019, 02, 18));

            Persona p1 = new Profesor("Mauricio", "Cerizza", "39213123", 26, 150000, new DateTime(2018, 02, 02));
            Persona p2 = new Profesor("Lautaro", "Galarza", "40121234", 24, 98000, new DateTime(2021, 03, 11));
            Persona p3 = new Profesor("Mauricio", "Davila", "33112233", 29, 300002, new DateTime(2010, 01, 01));

            _ = listaPersonas + a1;
            _ = listaPersonas + a2;
            _ = listaPersonas + a3;

            _ = listaPersonas + p1;
            _ = listaPersonas + p2;
            _ = listaPersonas + p3;
        }
        /// <summary>
        /// Abre el formulario para guardar los datos de las personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarPersonas_Click(object sender, EventArgs e)
        {
            frmGuardarPersonas frmGuardarPersonas = new frmGuardarPersonas(listaPersonas);
            frmGuardarPersonas.ShowDialog();
        }
        /// <summary>
        /// Abre el formulario para mostrar los datos de los alumnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {
            frmMostrarPersonas frmMostrarPersonas = new frmMostrarPersonas(listaPersonas, new Alumno());
            frmMostrarPersonas.ShowDialog();
        }

        /// <summary>
        /// Abre el formulario para mostrar los datos de los alumnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarProfesores_Click(object sender, EventArgs e)
        {
            frmMostrarPersonas frmMostrarPersonas = new frmMostrarPersonas(listaPersonas, new Profesor());
            frmMostrarPersonas.ShowDialog();
        }
        /// <summary>
        /// Abre el formulario para dar de alta a un alumno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            AgregarAlumno agregarAlumno = new AgregarAlumno(listaPersonas);
            agregarAlumno.Show();
            listaPersonas = agregarAlumno.DevolverProcesador;
        }
        /// <summary>
        /// Abre el formulario para dar de alta a un profesor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            AgregarProfesor agregarProfesor = new AgregarProfesor(listaPersonas);
            agregarProfesor.Show();
            listaPersonas = agregarProfesor.DevolverProcesador;
        }

        /// <summary>
        /// Carga los datos de un archivo con extension .xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Solo se va a poder cargar datos de un archivo con la extension .XML", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    archivo = openFileDialog.FileName;
                    if(Path.GetExtension(archivo) == ".xml")
                    {
                        listaPersonas = puntoXml.Leer(archivo);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Excepciones.Excepciones(ex.Message,ex);
            }
        }
    }
}
