﻿using Controlador;
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
    public partial class AgregarProfesor : Form
    {
        Procesador<Persona> listaPersonas;
        public AgregarProfesor(Procesador<Persona> personas)
        {
            InitializeComponent();
            listaPersonas = personas;
        }
        /// <summary>
        /// Crea un profesor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtApellido.Text != "" &&  txtDocumento.Text != "" &&
                    txtEdad.Text != "" && txtFechaIngreso.Text != "" && txtSalario.Text != "" &&
                    txtNombre.Text != "")
                {
                    int edadAux;
                    float salarioAux;

                    DateTime fechaIngreso = Convert.ToDateTime(txtFechaIngreso.Text);
                    if (int.TryParse(txtEdad.Text, out edadAux) && float.TryParse(txtSalario.Text,out salarioAux))
                    {
                        _ = listaPersonas + new Profesor(txtNombre.Text, txtApellido.Text, txtDocumento.Text, edadAux, salarioAux, fechaIngreso);
                        MessageBox.Show("Se agrego de manera correcta el alumno");
                        Close();
                    }

                }
            }
            catch (Exception ex)
            {

                throw new Excepciones.Excepciones("Ocurrio un error con la carga de datos",ex);
            }
        }
        /// <summary>
        /// Devuelve el procesador
        /// </summary>
        public Procesador<Persona> DevolverProcesador
        {
            get { return listaPersonas; }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
