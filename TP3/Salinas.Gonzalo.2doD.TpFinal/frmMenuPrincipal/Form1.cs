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
using Controlador;
using Entidades;
namespace frmMenuPrincipal
{
    public partial class Form1 : Form
    {
        Procesador<Persona> listaPersonas;
        PuntoJson<string> PuntoJson;

        private string rutaEscritorio = "C:\\Users\\Gonzalo\\Desktop\\Repositorios\\tps_laboratorio_II\\TP3\\Salinas.Gonzalo.2doD.TpFinal";
        private string rutaArchivo;
        public Form1()
        {
            InitializeComponent();
            listaPersonas = new Procesador<Persona>();
            PuntoJson = new PuntoJson<string>();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            rutaArchivo = Path.Combine(rutaEscritorio, "Alumnos.json");


            dataGridView1.DataSource = listaPersonas.LeerArchivoJson(rutaArchivo);
            dataGridView1.Refresh();
            dataGridView1.Update();

        }

        private void btnCargarXml_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
