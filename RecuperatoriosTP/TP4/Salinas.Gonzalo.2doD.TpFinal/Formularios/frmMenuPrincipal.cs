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
        private Manejador manejador;

        SaveFileDialog guardarArchivo;
        OpenFileDialog openFileDialog;

        PuntoXml<Procesador<Persona>> puntoXml;
        PuntoJson<Procesador<Persona>> PuntoJson;

        string archivo;


        public frmMenuPrincipal()
        {
            InitializeComponent();
            listaPersonas = new Procesador<Persona>();
            manejador = new Manejador();

            puntoXml = new PuntoXml<Procesador<Persona>>();
            PuntoJson = new PuntoJson<Procesador<Persona>>();

            openFileDialog = new OpenFileDialog();
            guardarArchivo = new SaveFileDialog();
            guardarArchivo.Filter = "Archivo de texto|*.txt|Archivo JSON|*.json|Archivo XML|*.xml";
            openFileDialog.Filter = "Archivo JSON|*.json|Archivo XML|*.xml";
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

            Persona a1 = new Persona("Gaston", "Fernandez", "12345678", 21, EGenero.Masculino, 22000, ESecundario.Completo, EPais.Argentina);
            Persona a2 = new Persona("Gonzalo", "Salinas", "42038608", 22, EGenero.Masculino, 37000, ESecundario.Completo, EPais.Argentina);
            Persona a3 = new Persona("Juan", "Fernandez", "11122233", 32, EGenero.Masculino, 10000, ESecundario.Incompleto, EPais.Venezuela);
            Persona a4 = new Persona("Julia", "Arce", "99988877", 17, EGenero.Femenino, 70000, ESecundario.Incompleto, EPais.Colombia);
            Persona a5 = new Persona("Raul", "Alberti", "94123123", 26, EGenero.Masculino, 150000, ESecundario.Completo, EPais.Venezuela);
            Persona a6 = new Persona("Eliana", "Cuervo", "40123456", 24, EGenero.Femenino, 90000, ESecundario.Incompleto, EPais.Chile);
            Persona a7 = new Persona("Facundo", "Perez", "11111111", 28, EGenero.Masculino, 120000, ESecundario.Completo, EPais.Mexico);
            Persona a8 = new Persona("Trixie", "Tang", "99118822", 19, EGenero.Femenino, 30000, ESecundario.Incompleto, EPais.Mexico);


            _ = listaPersonas + a1;
            _ = listaPersonas + a2;
            _ = listaPersonas + a3;
            _ = listaPersonas + a4;
            _ = listaPersonas + a5;
            _ = listaPersonas + a6;
            _ = listaPersonas + a7;
            _ = listaPersonas + a8;

        }
        /// <summary>
        /// Abre el formulario para guardar los datos de las personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarPersonas_Click(object sender, EventArgs e)
        {
            if (listaPersonas.Personas.Count > 0)
            {
                if (GuardarDatos(listaPersonas))
                {
                    MessageBox.Show("Se agregaron exitosamente");
                }
            }
            else
            {
                MessageBox.Show("No hay personas cargadas en el sistema");
            }
        }

        /// <summary>
        /// Guarda los datos en el sistema en archivos
        /// </summary>
        /// <param name="personas">lista de personas a guardar</param>
        /// <returns>True si salio todo bien y pudo guardar, false si no pudo guardar</returns>
        private bool GuardarDatos(Procesador<Persona> personas)
        {
            try
            {
                if (guardarArchivo.ShowDialog() == DialogResult.OK)
                {
                    archivo = guardarArchivo.FileName;
                    if (archivo != "")
                    {
                        PuntoTxt puntoTxt = new PuntoTxt();
                        PuntoJson<Procesador<Persona>> puntoJson = new PuntoJson<Procesador<Persona>>();
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
                        return true;
                    }

                }
            }
            catch (Excepciones.Excepciones ex)
            {

                throw new Excepciones.Excepciones(ex.Message, ex);
            }
            return false;
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
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    archivo = openFileDialog.FileName;

                    if (archivo != "")
                    {
                        switch (Path.GetExtension(archivo))
                        {
                            case ".json":
                                listaPersonas = PuntoJson.Leer(archivo);
                                break;
                            case ".xml":
                                listaPersonas = puntoXml.Leer(archivo);
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Excepciones.Excepciones(ex.Message, ex);
            }
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
                int indice = listaPersonas.Personas.GenerarNumeroRandom();
                Persona personaAux = listaPersonas.Personas[indice];
                double aumento = (float)personaAux.Salario * 0.30;
                personaAux.Salario += (int)aumento;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"-La Persona con Apellido: {personaAux.Apellido} ha sido seleccionado para el premio de un aumento de salario de 30%");
                sb.AppendLine($"-El se le aumento ${aumento} a su sueldo.");
                sb.AppendLine("-Felicitamos a todos los que participaron del sorteo");

                MessageBox.Show(sb.ToString(), "SUPER SORTEO");
            }
            else
            {
                MessageBox.Show("No hay personas cargadas en el sistema.");
            }

        
        }
        /// <summary>
        /// Abre el formulario para mostrar los datos de las personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarPersonasCargadas_Click(object sender, EventArgs e)
        {
            if (listaPersonas.Personas.Count > 0)
            {
                frmMostrarPersonas frmMostrarPersonas = new frmMostrarPersonas(listaPersonas);
                frmMostrarPersonas.Show();
            }
            else
            {
                MessageBox.Show("No hay personas cargadas en el sistema");
            }
        }
        /// <summary>
        /// Abre el formulario para agregar una persona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            frmAgregarPersona frmAgregarPersona = new frmAgregarPersona(listaPersonas);
            frmAgregarPersona.Show();
            listaPersonas = frmAgregarPersona.DevolverProcesador;
        }
        /// <summary>
        /// Abre el formulario para mostrar las estadisticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            if (listaPersonas.Personas.Count > 0)
            {
                frmEstadisticas frmEstadisticas = new frmEstadisticas(listaPersonas);
                frmEstadisticas.Show();
            }
            else
            {
                MessageBox.Show("No hay personas cargadas en el sistema");
            }
        }
        /// <summary>
        /// Verifica si quiere salir de la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicacion?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Abre el formulario para listar los Alumnos cargados en la Base de Datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarPersonasDB_Click(object sender, EventArgs e)
        {
            frmMostrarPersonasDb frmMostrarPersonasDb = new frmMostrarPersonasDb();
            frmMostrarPersonasDb.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
