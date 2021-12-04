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
        public frmMostrarPersonas(Procesador<Persona> personas)
        {
            InitializeComponent();
            listaPersonas = personas;
        }

        /// <summary>
        /// Muestra la lista de personas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMostrarPersonas_Load(object sender, EventArgs e)
        {
            dtgInfoPersonas.Update();
            dtgInfoPersonas.Refresh();
            dtgInfoPersonas.DataSource = listaPersonas.Personas;

        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    
    
    }

}



