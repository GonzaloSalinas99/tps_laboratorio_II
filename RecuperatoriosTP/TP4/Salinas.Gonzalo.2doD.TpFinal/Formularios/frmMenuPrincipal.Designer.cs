
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
            this.lblHora = new System.Windows.Forms.Label();
            this.btnGuardarPersonasDB = new System.Windows.Forms.Button();
            this.btnSortearPremio = new System.Windows.Forms.Button();
            this.lblInformacionSorteo = new System.Windows.Forms.Label();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnMostrarPersonasCargadas = new System.Windows.Forms.Button();
            this.btnListarPersonasDB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarPersonas
            // 
            this.btnGuardarPersonas.Location = new System.Drawing.Point(107, 263);
            this.btnGuardarPersonas.Name = "btnGuardarPersonas";
            this.btnGuardarPersonas.Size = new System.Drawing.Size(178, 39);
            this.btnGuardarPersonas.TabIndex = 0;
            this.btnGuardarPersonas.Text = "Guardar Datos En Archivos";
            this.btnGuardarPersonas.UseVisualStyleBackColor = true;
            this.btnGuardarPersonas.Click += new System.EventHandler(this.btnGuardarPersonas_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(106, 422);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 15);
            this.lblHora.TabIndex = 8;
            // 
            // btnGuardarPersonasDB
            // 
            this.btnGuardarPersonasDB.Location = new System.Drawing.Point(213, 469);
            this.btnGuardarPersonasDB.Name = "btnGuardarPersonasDB";
            this.btnGuardarPersonasDB.Size = new System.Drawing.Size(178, 39);
            this.btnGuardarPersonasDB.TabIndex = 11;
            this.btnGuardarPersonasDB.Text = "Guardar Personas En DB";
            this.btnGuardarPersonasDB.UseVisualStyleBackColor = true;
            this.btnGuardarPersonasDB.Click += new System.EventHandler(this.btnGuardarPersonasDB_Click);
            // 
            // btnSortearPremio
            // 
            this.btnSortearPremio.Location = new System.Drawing.Point(106, 328);
            this.btnSortearPremio.Name = "btnSortearPremio";
            this.btnSortearPremio.Size = new System.Drawing.Size(178, 52);
            this.btnSortearPremio.TabIndex = 12;
            this.btnSortearPremio.Text = "¡¡¡Sortear Premio!!!";
            this.btnSortearPremio.UseVisualStyleBackColor = true;
            this.btnSortearPremio.Click += new System.EventHandler(this.btnSortearPremio_Click);
            // 
            // lblInformacionSorteo
            // 
            this.lblInformacionSorteo.AutoSize = true;
            this.lblInformacionSorteo.Location = new System.Drawing.Point(115, 383);
            this.lblInformacionSorteo.Name = "lblInformacionSorteo";
            this.lblInformacionSorteo.Size = new System.Drawing.Size(160, 15);
            this.lblInformacionSorteo.TabIndex = 13;
            this.lblInformacionSorteo.Text = "(Para personas en el Sistema)";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(12, 24);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(177, 39);
            this.btnCargarDatos.TabIndex = 14;
            this.btnCargarDatos.Text = "Cargar Datos De Archivos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(107, 82);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(177, 39);
            this.btnAgregarPersona.TabIndex = 15;
            this.btnAgregarPersona.Text = "Agregar Persona";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Location = new System.Drawing.Point(106, 205);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(178, 39);
            this.btnEstadisticas.TabIndex = 16;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnMostrarPersonasCargadas
            // 
            this.btnMostrarPersonasCargadas.Location = new System.Drawing.Point(107, 143);
            this.btnMostrarPersonasCargadas.Name = "btnMostrarPersonasCargadas";
            this.btnMostrarPersonasCargadas.Size = new System.Drawing.Size(177, 39);
            this.btnMostrarPersonasCargadas.TabIndex = 17;
            this.btnMostrarPersonasCargadas.Text = "Mostrar Personas En Sistema";
            this.btnMostrarPersonasCargadas.UseVisualStyleBackColor = true;
            this.btnMostrarPersonasCargadas.Click += new System.EventHandler(this.btnMostrarPersonasCargadas_Click);
            // 
            // btnListarPersonasDB
            // 
            this.btnListarPersonasDB.Location = new System.Drawing.Point(12, 469);
            this.btnListarPersonasDB.Name = "btnListarPersonasDB";
            this.btnListarPersonasDB.Size = new System.Drawing.Size(177, 39);
            this.btnListarPersonasDB.TabIndex = 18;
            this.btnListarPersonasDB.Text = "Listar Personas Base de Datos";
            this.btnListarPersonasDB.UseVisualStyleBackColor = true;
            this.btnListarPersonasDB.Click += new System.EventHandler(this.btnListarPersonasDB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "Cargar Datos De Base De Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(421, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListarPersonasDB);
            this.Controls.Add(this.btnMostrarPersonasCargadas);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.lblInformacionSorteo);
            this.Controls.Add(this.btnSortearPremio);
            this.Controls.Add(this.btnGuardarPersonasDB);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnGuardarPersonas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPersonas;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnGuardarPersonasDB;
        private System.Windows.Forms.Button btnSortearPremio;
        private System.Windows.Forms.Label lblInformacionSorteo;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnMostrarPersonasCargadas;
        private System.Windows.Forms.Button btnListarPersonasDB;
        private System.Windows.Forms.Button button1;
    }
}