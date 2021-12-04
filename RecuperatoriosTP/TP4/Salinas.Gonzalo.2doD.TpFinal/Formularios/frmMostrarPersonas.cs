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



        public frmMostrarPersonas(Procesador<Persona> personas)
        {
            InitializeComponent();
            listaPersonas = personas;


        }

        /// <summary>
        /// Carga la lista de personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMostrarPersonas_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        
        }

        /// <summary>
        /// Actualiza la lista de personas
        /// </summary>
        private void ActualizarLista()
        {
            dtgInfoPersonas.DataSource = listaPersonas.Personas;
            dtgInfoPersonas.Update();
            dtgInfoPersonas.Refresh();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



