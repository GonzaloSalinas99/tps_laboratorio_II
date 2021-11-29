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
using Extension;

namespace Formularios
{
    public partial class frmMenuPrincipal : Form
    {
        private Procesador<Persona> listaPersonas;
        private OpenFileDialog openFileDialog;
        private PuntoXml<Procesador<Persona>> puntoXml;
        private Manejador manejador;
        string archivo;

        public frmMenuPrincipal()
        {
            InitializeComponent();
            listaPersonas = new Procesador<Persona>();

            puntoXml = new PuntoXml<Procesador<Persona>>();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo XML|*.xml";
            manejador = new Manejador();
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
        /// Abre el formulario para listar los Alumnos cargados en la Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarDB_Click(object sender, EventArgs e)
        {
            frmMostrarPersonasDb frmMostrarPersonasDb = new frmMostrarPersonasDb(listaPersonas,new Alumno());
            frmMostrarPersonasDb.ShowDialog();
        }
        /// <summary>
        /// Abre el formulario para listar los Profesores cargados en la Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarProfesoresDB_Click(object sender, EventArgs e)
        {
            frmMostrarPersonasDb frmMostrarPersonasDb = new frmMostrarPersonasDb(listaPersonas, new Profesor());
            frmMostrarPersonasDb.ShowDialog();
        }

        /// <summary>
        /// guarda todas las personas cargadas en el sistema a la base de datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarPersonasDB_Click(object sender, EventArgs e)
        {
            manejador.AgregarPersonaADB += MoverPersonasADB;
            manejador.IniciarManejador(listaPersonas.Personas);
        }
        /// <summary>
        /// metodo para agregar las personas a la base de datos
        /// </summary>
        /// <param name="persona">persona a agregar</param>
        private void MoverPersonasADB(Persona persona)
        {
            
            string mensaje = $"Se agrego {persona.Apellido} exitosamente a la Base de Datos";

            if (InvokeRequired)
            {
                Action<Label, string> delegado = MensajeExitosoPersonaAgregada;
                object[] parametrosDelegado = new object[] { lblHora, mensaje };
                this.Invoke(delegado, parametrosDelegado);
                
            }
            else
            {
                MensajeExitosoPersonaAgregada(lblHora, mensaje);
            }
            listaPersonas.Personas.Remove(persona);

        }
        /// <summary>
        /// mensaje a mostrar cuando se guarda una persona en la base de datos
        /// </summary>
        /// <param name="label">label donde se va a escribir el mensaje</param>
        /// <param name="mensaje">mensaje a escribir</param>
        private void MensajeExitosoPersonaAgregada(Label label ,string mensaje)
        {
            label.Text = mensaje;
        }
        /// <summary>
        /// metodo para sortear un premio para alumnos y profesores, a travez de un numero aleatorio 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortearPremio_Click(object sender, EventArgs e)
        {
            if(listaPersonas.Personas.Count > 0)
            {
                List<Persona> listaAlumnosAux = new List<Persona>();
                List<Persona> listaProfesoresAux = new List<Persona>();

                foreach (Persona persona in listaPersonas.Personas)
                {
                    if (persona is Alumno)
                    {
                        listaAlumnosAux.Add((Alumno)persona);
                    }
                    else
                    {
                        if (persona is Profesor)
                        {
                            listaProfesoresAux.Add((Profesor)persona);
                        }
                    }

                }

                int indiceAlumno = listaAlumnosAux.GenerarNumeroRandom();
                int indiceProfesor = listaProfesoresAux.GenerarNumeroRandom();

                MessageBox.Show($"-El alumno {listaAlumnosAux[indiceAlumno].Apellido} ha sido seleccionado para el premio de UN CUATRIMESTRE GRATIS!!! \n" +
                    $"-El profesor {listaProfesoresAux[indiceProfesor].Apellido} ha sido seleccionado para el premio de UN VIAJE A LAS CATARATAS!!! \n" +
                    $"-Felicitamos a todos los que participaron del sorteo", "SUPER SORTEO");
            }
            else
            {
                MessageBox.Show("No hay personas cargadas en el sistema.");
            }

        
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
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    archivo = openFileDialog.FileName;
                    if (Path.GetExtension(archivo) == ".xml")
                    {
                        listaPersonas = puntoXml.Leer(archivo);
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Excepciones.Excepciones(ex.Message, ex);
            }
        }
    }
}
