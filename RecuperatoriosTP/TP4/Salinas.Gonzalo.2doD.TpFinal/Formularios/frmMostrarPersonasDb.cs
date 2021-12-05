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
        

        public frmMostrarPersonasDb()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Elimina una persona seleccionada en el listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if(dtgvPersonas.SelectedRows.Count >0)
            {
                EGenero genero = EGenero.Masculino;
                if (dtgvPersonas.SelectedRows[0].Cells[4].Value.ToString() == "Femenino")
                {
                    genero = EGenero.Femenino;
                }
                ESecundario secundario = ESecundario.Incompleto;
                if (dtgvPersonas.SelectedRows[0].Cells[6].Value.ToString() == "Completo")
                {
                    secundario = ESecundario.Completo;
                }

                Persona persona = new Persona(dtgvPersonas.SelectedRows[0].Cells[0].Value.ToString(),
                                              dtgvPersonas.SelectedRows[0].Cells[1].Value.ToString(),
                                              dtgvPersonas.SelectedRows[0].Cells[2].Value.ToString(),
                                              Convert.ToInt32(dtgvPersonas.SelectedRows[0].Cells[3].Value),
                                              genero, Convert.ToInt32(dtgvPersonas.SelectedRows[0].Cells[5].Value),
                                              secundario, VerificarPais(dtgvPersonas.SelectedRows[0].Cells[7].Value.ToString()));
                LogDB.Eliminar(persona);
                Actualizar();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila", "Error");
            }
        }

        /// <summary>
        /// Verifica el pais recibido en string
        /// </summary>
        /// <param name="pais">pais a verificar</param>
        /// <returns>el nombre del pais en tipo Enum</returns>
        private static EPais VerificarPais(string pais)
        {
            EPais aux;
            if (pais == "Argentina")
            {
                aux = EPais.Argentina;
            }
            else
            {
                if (pais == "Chile")
                {
                    aux = EPais.Chile;
                }
                else
                {
                    if (pais == "Venezuela")
                    {
                        aux = EPais.Venezuela;
                    }
                    else
                    {
                        if (pais == "Colombia")
                        {
                            aux = EPais.Colombia;
                        }
                        else
                        {
                            aux = EPais.Mexico;
                        }
                    }
                }
            }
            return aux;
        }


        /// <summary>
        /// Carga la lista actualizada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMostrarPersonasDb_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        /// <summary>
        /// Actualiza la lista de personas en la base de datos
        /// </summary>
        private void Actualizar()
        {
            Procesador<Persona> personas = LogDB.LeerPersonas();
            dtgvPersonas.DataSource = personas.Personas;
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
