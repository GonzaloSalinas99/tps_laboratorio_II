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
        PuntoJson<List<Persona>> puntoJson;
        string archivo;


        public frmMenuPrincipal()
        {
            InitializeComponent();
            listaPersonas = new Procesador<Persona>();

            puntoJson = new PuntoJson<List<Persona>>();
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo JSON|*.json|Archivo XML|*.xml";

        }



        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarDatosPersonas();
            Reloj reloj = new Reloj();
            reloj.SegundoCambiado += AsignarHora;
            reloj.Iniciar();

        }

        public void AsignarHora(Reloj reloj)
        {
            if (lblHora.InvokeRequired)
            {
                Action<Reloj> delegado = AsignarHora;


                lblHora.Invoke(delegado, reloj);

            }
            else
            {
                lblHora.Text = $"Hora Actual: {reloj.ToString()}";

            }

        }

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

        private void btnGuardarPersonas_Click(object sender, EventArgs e)
        {
            frmGuardarPersonas frmGuardarPersonas = new frmGuardarPersonas(listaPersonas);
            frmGuardarPersonas.ShowDialog();
        }

        private void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {
            frmMostrarPersonas frmMostrarPersonas = new frmMostrarPersonas(listaPersonas, new Alumno());
            frmMostrarPersonas.ShowDialog();
        }


        private void btnMostrarProfesores_Click(object sender, EventArgs e)
        {
            frmMostrarPersonas frmMostrarPersonas = new frmMostrarPersonas(listaPersonas, new Profesor());
            frmMostrarPersonas.ShowDialog();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            AgregarAlumno agregarAlumno = new AgregarAlumno(listaPersonas);
            agregarAlumno.Show();
            listaPersonas = agregarAlumno.DevolverProcesador;
        }

        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            AgregarProfesor agregarProfesor = new AgregarProfesor(listaPersonas);
            agregarProfesor.Show();
            listaPersonas = agregarProfesor.DevolverProcesador;
        }

        private void btnListarDB_Click(object sender, EventArgs e)
        {
            frmMostrarPersonasDb frmMostrarPersonasDb = new frmMostrarPersonasDb(listaPersonas,new Alumno());
            frmMostrarPersonasDb.ShowDialog();
        }

        private void btnListarProfesoresDB_Click(object sender, EventArgs e)
        {
            frmMostrarPersonasDb frmMostrarPersonasDb = new frmMostrarPersonasDb(listaPersonas, new Profesor());
            frmMostrarPersonasDb.ShowDialog();
        }

        private void btnGuardarAlumnosDB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
