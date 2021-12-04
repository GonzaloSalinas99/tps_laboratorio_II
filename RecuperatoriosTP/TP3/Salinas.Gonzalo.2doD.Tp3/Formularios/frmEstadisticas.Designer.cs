
namespace Formularios
{
    partial class frmEstadisticas
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
            this.rtbEstadisticas = new System.Windows.Forms.RichTextBox();
            this.btnCalcularPersonaMAyorEdad = new System.Windows.Forms.Button();
            this.btnGeneroConMasPersonasCargadas = new System.Windows.Forms.Button();
            this.btnOrdenarListaPorSalario = new System.Windows.Forms.Button();
            this.btnCalcularCantidadDePersonasConEstudioSecundario = new System.Windows.Forms.Button();
            this.cmbOrdenLista = new System.Windows.Forms.ComboBox();
            this.cmbOpcionEstudiosSecundarios = new System.Windows.Forms.ComboBox();
            this.btnCalcularCantidadPersonasEnPais = new System.Windows.Forms.Button();
            this.btnCalcularPromedioMinimoMaximoSalarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbEstadisticas
            // 
            this.rtbEstadisticas.Location = new System.Drawing.Point(44, 25);
            this.rtbEstadisticas.Name = "rtbEstadisticas";
            this.rtbEstadisticas.Size = new System.Drawing.Size(408, 202);
            this.rtbEstadisticas.TabIndex = 0;
            this.rtbEstadisticas.Text = "";
            // 
            // btnCalcularPersonaMAyorEdad
            // 
            this.btnCalcularPersonaMAyorEdad.Location = new System.Drawing.Point(44, 264);
            this.btnCalcularPersonaMAyorEdad.Name = "btnCalcularPersonaMAyorEdad";
            this.btnCalcularPersonaMAyorEdad.Size = new System.Drawing.Size(132, 57);
            this.btnCalcularPersonaMAyorEdad.TabIndex = 1;
            this.btnCalcularPersonaMAyorEdad.Text = "Calcular Persona Con Mayor Edad";
            this.btnCalcularPersonaMAyorEdad.UseVisualStyleBackColor = true;
            this.btnCalcularPersonaMAyorEdad.Click += new System.EventHandler(this.btnCalcularPersonaMAyorEdad_Click);
            // 
            // btnGeneroConMasPersonasCargadas
            // 
            this.btnGeneroConMasPersonasCargadas.Location = new System.Drawing.Point(320, 264);
            this.btnGeneroConMasPersonasCargadas.Name = "btnGeneroConMasPersonasCargadas";
            this.btnGeneroConMasPersonasCargadas.Size = new System.Drawing.Size(132, 58);
            this.btnGeneroConMasPersonasCargadas.TabIndex = 3;
            this.btnGeneroConMasPersonasCargadas.Text = "Calcular Promedio De Generos De Personas";
            this.btnGeneroConMasPersonasCargadas.UseVisualStyleBackColor = true;
            this.btnGeneroConMasPersonasCargadas.Click += new System.EventHandler(this.btnGeneroConMasPersonasCargadas_Click);
            // 
            // btnOrdenarListaPorSalario
            // 
            this.btnOrdenarListaPorSalario.Location = new System.Drawing.Point(44, 329);
            this.btnOrdenarListaPorSalario.Name = "btnOrdenarListaPorSalario";
            this.btnOrdenarListaPorSalario.Size = new System.Drawing.Size(132, 57);
            this.btnOrdenarListaPorSalario.TabIndex = 4;
            this.btnOrdenarListaPorSalario.Text = "Ordenar Lista Por Salario";
            this.btnOrdenarListaPorSalario.UseVisualStyleBackColor = true;
            this.btnOrdenarListaPorSalario.Click += new System.EventHandler(this.btnOrdenarListaPorSalario_Click);
            // 
            // btnCalcularCantidadDePersonasConEstudioSecundario
            // 
            this.btnCalcularCantidadDePersonasConEstudioSecundario.Location = new System.Drawing.Point(182, 329);
            this.btnCalcularCantidadDePersonasConEstudioSecundario.Name = "btnCalcularCantidadDePersonasConEstudioSecundario";
            this.btnCalcularCantidadDePersonasConEstudioSecundario.Size = new System.Drawing.Size(132, 58);
            this.btnCalcularCantidadDePersonasConEstudioSecundario.TabIndex = 5;
            this.btnCalcularCantidadDePersonasConEstudioSecundario.Text = "Calcular Cantidad Personas con Estudio Secundario";
            this.btnCalcularCantidadDePersonasConEstudioSecundario.UseVisualStyleBackColor = true;
            this.btnCalcularCantidadDePersonasConEstudioSecundario.Click += new System.EventHandler(this.btnCalcularCantidadDePersonasConEstudioSecundario_Click);
            // 
            // cmbOrdenLista
            // 
            this.cmbOrdenLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenLista.FormattingEnabled = true;
            this.cmbOrdenLista.Location = new System.Drawing.Point(44, 392);
            this.cmbOrdenLista.Name = "cmbOrdenLista";
            this.cmbOrdenLista.Size = new System.Drawing.Size(132, 23);
            this.cmbOrdenLista.TabIndex = 6;
            // 
            // cmbOpcionEstudiosSecundarios
            // 
            this.cmbOpcionEstudiosSecundarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionEstudiosSecundarios.FormattingEnabled = true;
            this.cmbOpcionEstudiosSecundarios.Location = new System.Drawing.Point(182, 392);
            this.cmbOpcionEstudiosSecundarios.Name = "cmbOpcionEstudiosSecundarios";
            this.cmbOpcionEstudiosSecundarios.Size = new System.Drawing.Size(132, 23);
            this.cmbOpcionEstudiosSecundarios.TabIndex = 7;
            // 
            // btnCalcularCantidadPersonasEnPais
            // 
            this.btnCalcularCantidadPersonasEnPais.Location = new System.Drawing.Point(182, 264);
            this.btnCalcularCantidadPersonasEnPais.Name = "btnCalcularCantidadPersonasEnPais";
            this.btnCalcularCantidadPersonasEnPais.Size = new System.Drawing.Size(132, 58);
            this.btnCalcularCantidadPersonasEnPais.TabIndex = 8;
            this.btnCalcularCantidadPersonasEnPais.Text = "Calcular Cantidad De Personas Por Pais";
            this.btnCalcularCantidadPersonasEnPais.UseVisualStyleBackColor = true;
            this.btnCalcularCantidadPersonasEnPais.Click += new System.EventHandler(this.btnCalcularCantidadPersonasEnPais_Click);
            // 
            // btnCalcularPromedioMinimoMaximoSalarios
            // 
            this.btnCalcularPromedioMinimoMaximoSalarios.Location = new System.Drawing.Point(320, 328);
            this.btnCalcularPromedioMinimoMaximoSalarios.Name = "btnCalcularPromedioMinimoMaximoSalarios";
            this.btnCalcularPromedioMinimoMaximoSalarios.Size = new System.Drawing.Size(132, 58);
            this.btnCalcularPromedioMinimoMaximoSalarios.TabIndex = 9;
            this.btnCalcularPromedioMinimoMaximoSalarios.Text = "Calcaular Promedio-Minimo- Maximo De Salarios";
            this.btnCalcularPromedioMinimoMaximoSalarios.UseVisualStyleBackColor = true;
            this.btnCalcularPromedioMinimoMaximoSalarios.Click += new System.EventHandler(this.btnCalcularPromedioMinimoMaximoSalarios_Click);
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.btnCalcularPromedioMinimoMaximoSalarios);
            this.Controls.Add(this.btnCalcularCantidadPersonasEnPais);
            this.Controls.Add(this.cmbOpcionEstudiosSecundarios);
            this.Controls.Add(this.cmbOrdenLista);
            this.Controls.Add(this.btnCalcularCantidadDePersonasConEstudioSecundario);
            this.Controls.Add(this.btnOrdenarListaPorSalario);
            this.Controls.Add(this.btnGeneroConMasPersonasCargadas);
            this.Controls.Add(this.btnCalcularPersonaMAyorEdad);
            this.Controls.Add(this.rtbEstadisticas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbEstadisticas;
        private System.Windows.Forms.Button btnCalcularPersonaMAyorEdad;
        private System.Windows.Forms.Button btnGeneroConMasPersonasCargadas;
        private System.Windows.Forms.Button btnOrdenarListaPorSalario;
        private System.Windows.Forms.Button btnCalcularCantidadDePersonasConEstudioSecundario;
        private System.Windows.Forms.ComboBox cmbOrdenLista;
        private System.Windows.Forms.ComboBox cmbOpcionEstudiosSecundarios;
        private System.Windows.Forms.Button btnCalcularCantidadPersonasEnPais;
        private System.Windows.Forms.Button btnCalcularPromedioMinimoMaximoSalarios;
    }
}