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
using Logueo;

namespace Formularios
{
    public partial class frmMostrarPersonas : Form
    {
        Procesador<Persona> listaPersonas;
        public Persona MiPersona;
        LogDB logueo;


        public frmMostrarPersonas(Procesador<Persona> personas, Persona personaAux)
        {
            InitializeComponent();
            listaPersonas = personas;
            MiPersona = personaAux;
            logueo = new LogDB("Server=DESKTOP-2HKT4SF\\SQLEXPRESS;Database=TP4;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        private Type DevolverTipoAtributo<T>(T persona)
        {
            return persona.GetType();
        }

        private void frmMostrarPersonas_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void btnAgregarADB_Click(object sender, EventArgs e)
        {
            if (dtgInfoPersonas.SelectedRows.Count > 0)
            {
                if (MiPersona is Alumno)
                {
                    Alumno alumnoAux = new Alumno(dtgInfoPersonas.SelectedRows[0].Cells[3].Value.ToString(), dtgInfoPersonas.SelectedRows[0].Cells[4].Value.ToString(), dtgInfoPersonas.SelectedRows[0].Cells[5].Value.ToString(),
                        Convert.ToInt32(dtgInfoPersonas.SelectedRows[0].Cells[6].Value), dtgInfoPersonas.SelectedRows[0].Cells[2].Value.ToString(), Convert.ToInt32(dtgInfoPersonas.SelectedRows[0].Cells[1].Value),
                        Convert.ToDateTime(dtgInfoPersonas.SelectedRows[0].Cells[0].Value));

                    logueo.InsertarInfoEnDB(alumnoAux);
                    EliminarPersona(alumnoAux);
                    ActualizarLista();

                }
                else
                {
                    if (MiPersona is Profesor)
                    {
                        Profesor profesorAux = new Profesor(dtgInfoPersonas.SelectedRows[0].Cells[2].Value.ToString(), dtgInfoPersonas.SelectedRows[0].Cells[3].Value.ToString(), dtgInfoPersonas.SelectedRows[0].Cells[4].Value.ToString(),
                        Convert.ToInt32(dtgInfoPersonas.SelectedRows[0].Cells[5].Value), Convert.ToSingle(dtgInfoPersonas.SelectedRows[0].Cells[0].Value), Convert.ToDateTime(dtgInfoPersonas.SelectedRows[0].Cells[1].Value));
                        logueo.InsertarInfoEnDB(profesorAux);
                        EliminarPersona(profesorAux);
                        ActualizarLista();
                    }

                }
                //dtgInfoPersonas.Rows.Remove(dtgInfoPersonas.CurrentRow);

                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento");
            }
        }

        private void EliminarPersona(Persona persona)
        {
            //foreach (Persona personaAux in listaPersonas.Personas)
            //{
            //    if(persona.Dni == personaAux.Dni)
            //    {
            //        int indice = listaPersonas.Personas.IndexOf(personaAux);
            //        listaPersonas.Personas.RemoveAt(indice);
            //    }
            //}

            for (int i = 0; i < listaPersonas.Personas.Count; i++)
            {
                if(listaPersonas.Personas[i].Dni == persona.Dni)
                {
                    listaPersonas.Personas.RemoveAt(i);
                }
            }

        }


        private void ActualizarLista()
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
    }
}



