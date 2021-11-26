using Controlador;
using Entidades;
using Excepciones;
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
            guardarArchivo.Filter = "Archivos de texto|*.txt";
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

                        if (Path.GetExtension(archivo) == ".txt")
                        {
                            puntoTxt.Guardar(archivo, personas.Mostrar());
                        }
                    }
                }
            }
            catch (Excepciones.Excepciones ex)
            {

                throw new Excepciones.Excepciones(ex.ToString());
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
