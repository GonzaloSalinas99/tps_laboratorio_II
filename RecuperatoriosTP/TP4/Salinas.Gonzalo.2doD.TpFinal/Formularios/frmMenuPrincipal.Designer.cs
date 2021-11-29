
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
            this.btnMostrarAlumnos = new System.Windows.Forms.Button();
            this.btnMostrarProfesores = new System.Windows.Forms.Button();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.btnListarAlumnosDB = new System.Windows.Forms.Button();
            this.btnListarProfesoresDB = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnGuardarPersonasDB = new System.Windows.Forms.Button();
            this.btnSortearPremio = new System.Windows.Forms.Button();
            this.lblInformacionSorteo = new System.Windows.Forms.Label();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarPersonas
            // 
            this.btnGuardarPersonas.Location = new System.Drawing.Point(145, 147);
            this.btnGuardarPersonas.Name = "btnGuardarPersonas";
            this.btnGuardarPersonas.Size = new System.Drawing.Size(136, 23);
            this.btnGuardarPersonas.TabIndex = 0;
            this.btnGuardarPersonas.Text = "Guardar En Archivos";
            this.btnGuardarPersonas.UseVisualStyleBackColor = true;
            this.btnGuardarPersonas.Click += new System.EventHandler(this.btnGuardarPersonas_Click);
            // 
            // btnMostrarAlumnos
            // 
            this.btnMostrarAlumnos.Location = new System.Drawing.Point(21, 176);
            this.btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            this.btnMostrarAlumnos.Size = new System.Drawing.Size(178, 23);
            this.btnMostrarAlumnos.TabIndex = 2;
            this.btnMostrarAlumnos.Text = "Mostrar Alumnos Cargados";
            this.btnMostrarAlumnos.UseVisualStyleBackColor = true;
            this.btnMostrarAlumnos.Click += new System.EventHandler(this.btnMostrarAlumnos_Click);
            // 
            // btnMostrarProfesores
            // 
            this.btnMostrarProfesores.Location = new System.Drawing.Point(218, 176);
            this.btnMostrarProfesores.Name = "btnMostrarProfesores";
            this.btnMostrarProfesores.Size = new System.Drawing.Size(178, 23);
            this.btnMostrarProfesores.TabIndex = 3;
            this.btnMostrarProfesores.Text = "Mostrar Profesores Cargados";
            this.btnMostrarProfesores.UseVisualStyleBackColor = true;
            this.btnMostrarProfesores.Click += new System.EventHandler(this.btnMostrarProfesores_Click);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(35, 118);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarAlumno.TabIndex = 4;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Location = new System.Drawing.Point(234, 118);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarProfesor.TabIndex = 5;
            this.btnAgregarProfesor.Text = "Agregar Profesor";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // btnListarAlumnosDB
            // 
            this.btnListarAlumnosDB.Location = new System.Drawing.Point(218, 410);
            this.btnListarAlumnosDB.Name = "btnListarAlumnosDB";
            this.btnListarAlumnosDB.Size = new System.Drawing.Size(177, 23);
            this.btnListarAlumnosDB.TabIndex = 6;
            this.btnListarAlumnosDB.Text = "Listar Alumnos Base de Datos";
            this.btnListarAlumnosDB.UseVisualStyleBackColor = true;
            this.btnListarAlumnosDB.Click += new System.EventHandler(this.btnListarDB_Click);
            // 
            // btnListarProfesoresDB
            // 
            this.btnListarProfesoresDB.Location = new System.Drawing.Point(12, 410);
            this.btnListarProfesoresDB.Name = "btnListarProfesoresDB";
            this.btnListarProfesoresDB.Size = new System.Drawing.Size(177, 23);
            this.btnListarProfesoresDB.TabIndex = 7;
            this.btnListarProfesoresDB.Text = "Listar Profesores Base de Datos";
            this.btnListarProfesoresDB.UseVisualStyleBackColor = true;
            this.btnListarProfesoresDB.Click += new System.EventHandler(this.btnListarProfesoresDB_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(70, 359);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 15);
            this.lblHora.TabIndex = 8;
            // 
            // btnGuardarPersonasDB
            // 
            this.btnGuardarPersonasDB.Location = new System.Drawing.Point(122, 381);
            this.btnGuardarPersonasDB.Name = "btnGuardarPersonasDB";
            this.btnGuardarPersonasDB.Size = new System.Drawing.Size(178, 23);
            this.btnGuardarPersonasDB.TabIndex = 11;
            this.btnGuardarPersonasDB.Text = "Guardar Personas En DB";
            this.btnGuardarPersonasDB.UseVisualStyleBackColor = true;
            this.btnGuardarPersonasDB.Click += new System.EventHandler(this.btnGuardarPersonasDB_Click);
            // 
            // btnSortearPremio
            // 
            this.btnSortearPremio.Location = new System.Drawing.Point(122, 251);
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
            this.lblInformacionSorteo.Location = new System.Drawing.Point(131, 306);
            this.lblInformacionSorteo.Name = "lblInformacionSorteo";
            this.lblInformacionSorteo.Size = new System.Drawing.Size(160, 15);
            this.lblInformacionSorteo.TabIndex = 13;
            this.lblInformacionSorteo.Text = "(Para personas en el Sistema)";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(157, 67);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(98, 23);
            this.btnCargarDatos.TabIndex = 14;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(421, 445);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.lblInformacionSorteo);
            this.Controls.Add(this.btnSortearPremio);
            this.Controls.Add(this.btnGuardarPersonasDB);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnListarProfesoresDB);
            this.Controls.Add(this.btnListarAlumnosDB);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.btnAgregarAlumno);
            this.Controls.Add(this.btnMostrarProfesores);
            this.Controls.Add(this.btnMostrarAlumnos);
            this.Controls.Add(this.btnGuardarPersonas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPersonas;
        private System.Windows.Forms.Button btnMostrarAlumnos;
        private System.Windows.Forms.Button btnMostrarProfesores;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Button btnListarAlumnosDB;
        private System.Windows.Forms.Button btnListarProfesoresDB;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnGuardarPersonasDB;
        private System.Windows.Forms.Button btnSortearPremio;
        private System.Windows.Forms.Label lblInformacionSorteo;
        private System.Windows.Forms.Button btnCargarDatos;
    }
}