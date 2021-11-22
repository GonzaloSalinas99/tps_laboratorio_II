using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Entidades;
using Logueo;
namespace Formularios
{
    public partial class frmMostrarPersonasDb : Form
    {
        LogDB logueo;
        Procesador<Persona> listaPersonas;
        Persona persona;

        public frmMostrarPersonasDb(Procesador<Persona> personas, Persona personaAux)
        {
            InitializeComponent();
            logueo = new LogDB("Server=DESKTOP-2HKT4SF\\SQLEXPRESS;Database=TP4;Trusted_Connection=True;MultipleActiveResultSets=true;");
            listaPersonas = personas;
            persona = personaAux;

        
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(persona is Alumno)
            {
                Alumno alumnoAux = new Alumno(dtgvPersonas.SelectedRows[0].Cells[3].Value.ToString(), dtgvPersonas.SelectedRows[0].Cells[4].Value.ToString(), dtgvPersonas.SelectedRows[0].Cells[5].Value.ToString(),
                    Convert.ToInt32(dtgvPersonas.SelectedRows[0].Cells[6].Value), dtgvPersonas.SelectedRows[0].Cells[2].Value.ToString(),Convert.ToInt32(dtgvPersonas.SelectedRows[0].Cells[1].Value),
                    Convert.ToDateTime( dtgvPersonas.SelectedRows[0].Cells[0].Value));

                logueo.Eliminar(alumnoAux);
                Actualizar();

            }
            else
            {
                if (persona is Profesor)
                {
                    Profesor profesorAux = new Profesor(dtgvPersonas.SelectedRows[0].Cells[2].Value.ToString(), dtgvPersonas.SelectedRows[0].Cells[3].Value.ToString(), dtgvPersonas.SelectedRows[0].Cells[4].Value.ToString(),
                   Convert.ToInt32(dtgvPersonas.SelectedRows[0].Cells[5].Value), Convert.ToSingle(dtgvPersonas.SelectedRows[0].Cells[0].Value), Convert.ToDateTime(dtgvPersonas.SelectedRows[0].Cells[1].Value));
                    logueo.Eliminar(profesorAux);
                    Actualizar();
                }

            }
        }

        private void frmMostrarPersonasDb_Load(object sender, EventArgs e)
        {
            Actualizar();
        }


        private void Actualizar()
        {
            
            Procesador<Alumno> alumnos = logueo.LeerAlumnos();
            Procesador<Profesor> profesores = logueo.LeerProfesores();

            if (persona is Alumno)
            {
                dtgvPersonas.DataSource = alumnos.Personas;
            }
            else
            {
                if (persona is Profesor)
                {
                    dtgvPersonas.DataSource = profesores.Personas;
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
