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
    public partial class frmMostrarPersonas : Form
    {
        Procesador<Persona> listaPersonas;
        public Persona MiPersona;
        public frmMostrarPersonas(Procesador<Persona> personas, Persona personaAux)
        {
            InitializeComponent();
            listaPersonas = personas;
            MiPersona = personaAux;
        }
        /// <summary>
        /// Devuelve el tipo de persona 
        /// </summary>
        /// <typeparam name="T">Tipo de objeto</typeparam>
        /// <param name="persona">Persona a ser analizada</param>
        /// <returns></returns>
        private Type DevolverTipoAtributo<T>(T persona)
        {
            return persona.GetType();
        }
        /// <summary>
        /// Muestra la lista de personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMostrarPersonas_Load(object sender, EventArgs e)
        {
            Procesador<Alumno> alumnos = new Procesador<Alumno>();
            Procesador<Profesor> profesores = new Procesador<Profesor>();

            foreach (Persona personaAux in listaPersonas.Personas)
            {
                if (MiPersona is Alumno)
                {
                    if (personaAux.GetType() == DevolverTipoAtributo<Persona>(MiPersona))
                    {
                        alumnos.Personas.Add((Alumno)personaAux);
                    }
                }
                else
                {
                    if (MiPersona is Profesor)
                    {
                        if (personaAux.GetType() == DevolverTipoAtributo<Persona>(MiPersona))
                        {
                            profesores.Personas.Add((Profesor)personaAux);

                        }
                    }
                }
            }

                if (MiPersona is Alumno)
                {
                    dtgInfoPersonas.DataSource = alumnos.Personas;
                }
                else
                {
                    if (MiPersona is Profesor)
                    {
                        dtgInfoPersonas.DataSource = profesores.Personas;
                    }
                }
                dtgInfoPersonas.Update();
                dtgInfoPersonas.Refresh();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



