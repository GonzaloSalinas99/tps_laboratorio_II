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
    public partial class frmGuardarPersonas : Form
    {
        SaveFileDialog guardarArchivo;
        Procesador<Persona> personasAGuardar;
        string archivo;
        public frmGuardarPersonas(Procesador<Persona> personas)
        {
            InitializeComponent();
            guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            personasAGuardar = personas;
        }
        /// <summary>
        /// Guarda los datos de los alumnos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarAlumnos_Click(object sender, EventArgs e)
        {
            Alumno alumnoAux = new Alumno();
            FiltroParaGuardarPersonas<Alumno>(alumnoAux);
        }
        /// <summary>
        /// Metodo para guardar en una lista dependiendo el tipo de la persona por parametro
        /// </summary>
        /// <typeparam name="T">Tipo del objeto</typeparam>
        /// <param name="persona">persona para validar su tipo</param>
        private void FiltroParaGuardarPersonas<T>(T persona)
        {
            Procesador<Persona> personasAux = new Procesador<Persona>();
            foreach (Persona personaAux in personasAGuardar.Personas)
            {

                if(personaAux is Alumno && personaAux.GetType() == typeof(T))
                {
                    personasAux.Personas.Add((Alumno)personaAux);
                }
                else
                {
                    if(personaAux is Profesor && personaAux.GetType() == typeof(T))
                    {
                        personasAux.Personas.Add((Profesor)personaAux);
                    }
                }
            }
            GuardarDatos(personasAux);
            MessageBox.Show("Se agregaron exitosamente");
            Close();
        }
        /// <summary>
        /// Metodo que guarda la informacion pasada por parametros en archivos
        /// </summary>
        /// <param name="personas">lista de personas a ser guardadas en archivos</param>
        private void GuardarDatos(Procesador<Persona> personas)
        {
            try
            {
                if (!File.Exists(archivo))
                {
                    if (guardarArchivo.ShowDialog() == DialogResult.OK)
                    {
                        archivo = guardarArchivo.FileName;
                        PuntoTxt puntoTxt = new PuntoTxt();
                        PuntoJson<Procesador<Persona>> puntoJson = new Controlador.PuntoJson<Procesador<Persona>>();
                        PuntoXml<Procesador<Persona>> puntoXml = new PuntoXml<Procesador<Persona>>();
                        switch (Path.GetExtension(archivo))
                        {
                            case ".json":
                                puntoJson.Guardar(archivo, personas);
                                break;

                            case ".xml":
                                puntoXml.Guardar(archivo, personas);
                                break;

                            case ".txt":
                                puntoTxt.Guardar(archivo, personas.Mostrar());
                                break;
                        }
                    }
                }
            }
            catch (Excepciones.Excepciones ex)
            {

                throw new Excepciones.Excepciones(ex.Message,ex);
            }
        }
        /// <summary>
        /// Guarda la informacion de los profesores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarProfesores_Click(object sender, EventArgs e)
        {
            Profesor profesorAux = new Profesor();
            FiltroParaGuardarPersonas<Profesor>(profesorAux);
        }
        /// <summary>
        /// Guarda la informacion de las personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarPersonas_Click(object sender, EventArgs e)
        {
            GuardarDatos(personasAGuardar);
            MessageBox.Show("Se agregaron las personas exitosamente");
            Close();
        }

        private void frmGuardarPersonas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
