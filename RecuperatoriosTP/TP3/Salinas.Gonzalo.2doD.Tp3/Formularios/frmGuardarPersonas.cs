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

        private void btnGuardarAlumnos_Click(object sender, EventArgs e)
        {
            Alumno alumnoAux = new Alumno();
            FiltroParaGuardarPersonas<Alumno>(alumnoAux);
        }

        private void FiltroParaGuardarPersonas<T>(T persona)
        {
            Procesador<Persona> personasAux = new Procesador<Persona>();
            foreach (Persona personaAux in personasAGuardar.Personas)
            {
                if (personaAux.GetType() == typeof(T))
                {
                    personasAux.Personas.Add(personaAux);
                }
            }
            GuardarDatos(personasAux);
            MessageBox.Show("Se agregaron exitosamente");
            Close();
        }

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

        private void btnGuardarProfesores_Click(object sender, EventArgs e)
        {
            Profesor profesorAux = new Profesor();
            FiltroParaGuardarPersonas<Profesor>(profesorAux);
        }

        private void btnGuardarPersonas_Click(object sender, EventArgs e)
        {
            GuardarDatos(personasAGuardar);
            MessageBox.Show("Se agregaron las personas exitosamente");
            Close();
        }

        private void frmGuardarPersonas_Load(object sender, EventArgs e)
        {

        }
    }
}
