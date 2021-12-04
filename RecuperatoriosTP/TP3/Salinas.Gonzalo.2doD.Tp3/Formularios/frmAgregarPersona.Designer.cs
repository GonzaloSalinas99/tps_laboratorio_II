
namespace Formularios
{
    partial class frmAgregarPersona
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
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblPaisNacido = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblTerminoSecundario = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.cmbEstudioSecundario = new System.Windows.Forms.ComboBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.lblSoloLetras = new System.Windows.Forms.Label();
            this.lblSoloLetras2 = new System.Windows.Forms.Label();
            this.lblSoloNumeros1 = new System.Windows.Forms.Label();
            this.lblSoloNumeros2 = new System.Windows.Forms.Label();
            this.lblSoloNumeros3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.Location = new System.Drawing.Point(16, 349);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(51, 15);
            this.lblGenero.TabIndex = 26;
            this.lblGenero.Text = "Género";
            // 
            // lblPaisNacido
            // 
            this.lblPaisNacido.AutoSize = true;
            this.lblPaisNacido.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaisNacido.Location = new System.Drawing.Point(16, 405);
            this.lblPaisNacido.Name = "lblPaisNacido";
            this.lblPaisNacido.Size = new System.Drawing.Size(113, 15);
            this.lblPaisNacido.TabIndex = 24;
            this.lblPaisNacido.Text = "Pais Donde Nacio";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(20, 286);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(121, 23);
            this.txtDocumento.TabIndex = 23;
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDocumento.Location = new System.Drawing.Point(20, 268);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(77, 15);
            this.lblDocumento.TabIndex = 22;
            this.lblDocumento.Text = "Documento";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(20, 205);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(121, 23);
            this.txtEdad.TabIndex = 21;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.Location = new System.Drawing.Point(20, 187);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(37, 15);
            this.lblEdad.TabIndex = 20;
            this.lblEdad.Text = "Edad";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(24, 119);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(117, 23);
            this.txtApellido.TabIndex = 19;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.Location = new System.Drawing.Point(24, 101);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 15);
            this.lblApellido.TabIndex = 18;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(24, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 23);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(24, 17);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(182, 650);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "Agregar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolver.Location = new System.Drawing.Point(24, 650);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(20, 541);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(121, 23);
            this.txtSalario.TabIndex = 32;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalario.Location = new System.Drawing.Point(20, 523);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(49, 15);
            this.lblSalario.TabIndex = 31;
            this.lblSalario.Text = "Salario";
            // 
            // lblTerminoSecundario
            // 
            this.lblTerminoSecundario.AutoSize = true;
            this.lblTerminoSecundario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTerminoSecundario.Location = new System.Drawing.Point(20, 459);
            this.lblTerminoSecundario.Name = "lblTerminoSecundario";
            this.lblTerminoSecundario.Size = new System.Drawing.Size(124, 15);
            this.lblTerminoSecundario.TabIndex = 29;
            this.lblTerminoSecundario.Text = "Estudio Secundario";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(20, 367);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(121, 23);
            this.cmbGenero.TabIndex = 33;
            // 
            // cmbEstudioSecundario
            // 
            this.cmbEstudioSecundario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstudioSecundario.FormattingEnabled = true;
            this.cmbEstudioSecundario.Location = new System.Drawing.Point(20, 477);
            this.cmbEstudioSecundario.Name = "cmbEstudioSecundario";
            this.cmbEstudioSecundario.Size = new System.Drawing.Size(121, 23);
            this.cmbEstudioSecundario.TabIndex = 34;
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(20, 423);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 23);
            this.cmbPais.TabIndex = 35;
            // 
            // lblSoloLetras
            // 
            this.lblSoloLetras.AutoSize = true;
            this.lblSoloLetras.Location = new System.Drawing.Point(20, 61);
            this.lblSoloLetras.Name = "lblSoloLetras";
            this.lblSoloLetras.Size = new System.Drawing.Size(142, 15);
            this.lblSoloLetras.TabIndex = 36;
            this.lblSoloLetras.Text = "Solo puede ingresar letras";
            // 
            // lblSoloLetras2
            // 
            this.lblSoloLetras2.AutoSize = true;
            this.lblSoloLetras2.Location = new System.Drawing.Point(20, 145);
            this.lblSoloLetras2.Name = "lblSoloLetras2";
            this.lblSoloLetras2.Size = new System.Drawing.Size(142, 15);
            this.lblSoloLetras2.TabIndex = 37;
            this.lblSoloLetras2.Text = "Solo puede ingresar letras";
            // 
            // lblSoloNumeros1
            // 
            this.lblSoloNumeros1.AutoSize = true;
            this.lblSoloNumeros1.Location = new System.Drawing.Point(20, 231);
            this.lblSoloNumeros1.Name = "lblSoloNumeros1";
            this.lblSoloNumeros1.Size = new System.Drawing.Size(161, 15);
            this.lblSoloNumeros1.TabIndex = 38;
            this.lblSoloNumeros1.Text = "Solo puede ingresar numeros";
            // 
            // lblSoloNumeros2
            // 
            this.lblSoloNumeros2.AutoSize = true;
            this.lblSoloNumeros2.Location = new System.Drawing.Point(20, 312);
            this.lblSoloNumeros2.Name = "lblSoloNumeros2";
            this.lblSoloNumeros2.Size = new System.Drawing.Size(161, 15);
            this.lblSoloNumeros2.TabIndex = 39;
            this.lblSoloNumeros2.Text = "Solo puede ingresar numeros";
            // 
            // lblSoloNumeros3
            // 
            this.lblSoloNumeros3.AutoSize = true;
            this.lblSoloNumeros3.Location = new System.Drawing.Point(20, 567);
            this.lblSoloNumeros3.Name = "lblSoloNumeros3";
            this.lblSoloNumeros3.Size = new System.Drawing.Size(161, 15);
            this.lblSoloNumeros3.TabIndex = 40;
            this.lblSoloNumeros3.Text = "Solo puede ingresar numeros";
            // 
            // frmAgregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(269, 685);
            this.Controls.Add(this.lblSoloNumeros3);
            this.Controls.Add(this.lblSoloNumeros2);
            this.Controls.Add(this.lblSoloNumeros1);
            this.Controls.Add(this.lblSoloLetras2);
            this.Controls.Add(this.lblSoloLetras);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.cmbEstudioSecundario);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblTerminoSecundario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblPaisNacido);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCrear);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarProfesor";
            this.Load += new System.EventHandler(this.AgregarProfesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPaisNacido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblTerminoSecundario;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.ComboBox cmbEstudioSecundario;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Label lblSoloLetras;
        private System.Windows.Forms.Label lblSoloLetras2;
        private System.Windows.Forms.Label lblSoloNumeros1;
        private System.Windows.Forms.Label lblSoloNumeros2;
        private System.Windows.Forms.Label lblSoloNumeros3;
    }
}