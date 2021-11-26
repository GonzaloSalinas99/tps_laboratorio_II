
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
            this.btnGuardarAlumnosDB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarPersonas
            // 
            this.btnGuardarPersonas.Location = new System.Drawing.Point(145, 119);
            this.btnGuardarPersonas.Name = "btnGuardarPersonas";
            this.btnGuardarPersonas.Size = new System.Drawing.Size(136, 23);
            this.btnGuardarPersonas.TabIndex = 0;
            this.btnGuardarPersonas.Text = "Guardar En Archivos";
            this.btnGuardarPersonas.UseVisualStyleBackColor = true;
            this.btnGuardarPersonas.Click += new System.EventHandler(this.btnGuardarPersonas_Click);
            // 
            // btnMostrarAlumnos
            // 
            this.btnMostrarAlumnos.Location = new System.Drawing.Point(23, 160);
            this.btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            this.btnMostrarAlumnos.Size = new System.Drawing.Size(178, 23);
            this.btnMostrarAlumnos.TabIndex = 2;
            this.btnMostrarAlumnos.Text = "Mostrar Alumnos Cargados";
            this.btnMostrarAlumnos.UseVisualStyleBackColor = true;
            this.btnMostrarAlumnos.Click += new System.EventHandler(this.btnMostrarAlumnos_Click);
            // 
            // btnMostrarProfesores
            // 
            this.btnMostrarProfesores.Location = new System.Drawing.Point(217, 160);
            this.btnMostrarProfesores.Name = "btnMostrarProfesores";
            this.btnMostrarProfesores.Size = new System.Drawing.Size(178, 23);
            this.btnMostrarProfesores.TabIndex = 3;
            this.btnMostrarProfesores.Text = "Mostrar Profesores Cargados";
            this.btnMostrarProfesores.UseVisualStyleBackColor = true;
            this.btnMostrarProfesores.Click += new System.EventHandler(this.btnMostrarProfesores_Click);
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Location = new System.Drawing.Point(40, 76);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarAlumno.TabIndex = 4;
            this.btnAgregarAlumno.Text = "Agregar Alumno";
            this.btnAgregarAlumno.UseVisualStyleBackColor = true;
            this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Location = new System.Drawing.Point(232, 76);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(136, 23);
            this.btnAgregarProfesor.TabIndex = 5;
            this.btnAgregarProfesor.Text = "Agregar Profesor";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // btnListarAlumnosDB
            // 
            this.btnListarAlumnosDB.Location = new System.Drawing.Point(218, 325);
            this.btnListarAlumnosDB.Name = "btnListarAlumnosDB";
            this.btnListarAlumnosDB.Size = new System.Drawing.Size(177, 23);
            this.btnListarAlumnosDB.TabIndex = 6;
            this.btnListarAlumnosDB.Text = "Listar Alumnos Base de Datos";
            this.btnListarAlumnosDB.UseVisualStyleBackColor = true;
            this.btnListarAlumnosDB.Click += new System.EventHandler(this.btnListarDB_Click);
            // 
            // btnListarProfesoresDB
            // 
            this.btnListarProfesoresDB.Location = new System.Drawing.Point(12, 325);
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
            this.lblHora.Location = new System.Drawing.Point(145, 40);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(38, 15);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "label1";
            // 
            // btnGuardarAlumnosDB
            // 
            this.btnGuardarAlumnosDB.Location = new System.Drawing.Point(12, 275);
            this.btnGuardarAlumnosDB.Name = "btnGuardarAlumnosDB";
            this.btnGuardarAlumnosDB.Size = new System.Drawing.Size(178, 23);
            this.btnGuardarAlumnosDB.TabIndex = 9;
            this.btnGuardarAlumnosDB.Text = "Guardar Alumnos En DB";
            this.btnGuardarAlumnosDB.UseVisualStyleBackColor = true;
            this.btnGuardarAlumnosDB.Click += new System.EventHandler(this.btnGuardarAlumnosDB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar Profesores En DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(421, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardarAlumnosDB);
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
        private System.Windows.Forms.Button btnGuardarAlumnosDB;
        private System.Windows.Forms.Button button1;
    }
}