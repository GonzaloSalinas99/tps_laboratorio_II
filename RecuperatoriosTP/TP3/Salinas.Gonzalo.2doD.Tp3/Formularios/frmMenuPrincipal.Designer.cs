
namespace Formularios
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGuardarPersonas = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnMostrarPersonasCargadas = new System.Windows.Forms.Button();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarPersonas
            // 
            this.btnGuardarPersonas.Location = new System.Drawing.Point(78, 223);
            this.btnGuardarPersonas.Name = "btnGuardarPersonas";
            this.btnGuardarPersonas.Size = new System.Drawing.Size(136, 23);
            this.btnGuardarPersonas.TabIndex = 0;
            this.btnGuardarPersonas.Text = "Guardar En Archivos";
            this.btnGuardarPersonas.UseVisualStyleBackColor = true;
            this.btnGuardarPersonas.Click += new System.EventHandler(this.btnGuardarPersonas_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(78, 34);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(136, 23);
            this.btnCargarDatos.TabIndex = 6;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnMostrarPersonasCargadas
            // 
            this.btnMostrarPersonasCargadas.Location = new System.Drawing.Point(78, 173);
            this.btnMostrarPersonasCargadas.Name = "btnMostrarPersonasCargadas";
            this.btnMostrarPersonasCargadas.Size = new System.Drawing.Size(136, 23);
            this.btnMostrarPersonasCargadas.TabIndex = 7;
            this.btnMostrarPersonasCargadas.Text = "Mostrar Personas";
            this.btnMostrarPersonasCargadas.UseVisualStyleBackColor = true;
            this.btnMostrarPersonasCargadas.Click += new System.EventHandler(this.btnMostrarPersonasCargadas_Click);
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(78, 77);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarPersona.TabIndex = 8;
            this.btnAgregarPersona.Text = "Agregar Persona";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(78, 125);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(136, 23);
            this.btnEstadisticas.TabIndex = 9;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(291, 258);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.btnMostrarPersonasCargadas);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.btnGuardarPersonas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPersonas;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnMostrarPersonasCargadas;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}