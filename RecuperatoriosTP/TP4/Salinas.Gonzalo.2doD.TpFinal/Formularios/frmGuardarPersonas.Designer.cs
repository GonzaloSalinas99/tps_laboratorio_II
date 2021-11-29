
namespace Formularios
{
    partial class frmGuardarPersonas
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
            this.btnGuardarProfesores = new System.Windows.Forms.Button();
            this.btnGuardarAlumnos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuardarPersonas
            // 
            this.btnGuardarPersonas.Location = new System.Drawing.Point(58, 123);
            this.btnGuardarPersonas.Name = "btnGuardarPersonas";
            this.btnGuardarPersonas.Size = new System.Drawing.Size(136, 23);
            this.btnGuardarPersonas.TabIndex = 5;
            this.btnGuardarPersonas.Text = "GuardarPersonas";
            this.btnGuardarPersonas.UseVisualStyleBackColor = true;
            this.btnGuardarPersonas.Click += new System.EventHandler(this.btnGuardarPersonas_Click);
            // 
            // btnGuardarProfesores
            // 
            this.btnGuardarProfesores.Location = new System.Drawing.Point(58, 82);
            this.btnGuardarProfesores.Name = "btnGuardarProfesores";
            this.btnGuardarProfesores.Size = new System.Drawing.Size(136, 23);
            this.btnGuardarProfesores.TabIndex = 4;
            this.btnGuardarProfesores.Text = "Guardar Profesores";
            this.btnGuardarProfesores.UseVisualStyleBackColor = true;
            this.btnGuardarProfesores.Click += new System.EventHandler(this.btnGuardarProfesores_Click);
            // 
            // btnGuardarAlumnos
            // 
            this.btnGuardarAlumnos.Location = new System.Drawing.Point(58, 39);
            this.btnGuardarAlumnos.Name = "btnGuardarAlumnos";
            this.btnGuardarAlumnos.Size = new System.Drawing.Size(136, 23);
            this.btnGuardarAlumnos.TabIndex = 3;
            this.btnGuardarAlumnos.Text = "Guardar Alumnos";
            this.btnGuardarAlumnos.UseVisualStyleBackColor = true;
            this.btnGuardarAlumnos.Click += new System.EventHandler(this.btnGuardarAlumnos_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 167);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmGuardarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(250, 202);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarPersonas);
            this.Controls.Add(this.btnGuardarProfesores);
            this.Controls.Add(this.btnGuardarAlumnos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGuardarPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar Personas";
            this.Load += new System.EventHandler(this.frmGuardarPersonas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarPersonas;
        private System.Windows.Forms.Button btnGuardarProfesores;
        private System.Windows.Forms.Button btnGuardarAlumnos;
        private System.Windows.Forms.Button btnVolver;
    }
}