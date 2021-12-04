
namespace Formularios
{
    partial class frmMostrarPersonas
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
            this.dtgInfoPersonas = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgInfoPersonas
            // 
            this.dtgInfoPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfoPersonas.Location = new System.Drawing.Point(29, 42);
            this.dtgInfoPersonas.Name = "dtgInfoPersonas";
            this.dtgInfoPersonas.RowTemplate.Height = 25;
            this.dtgInfoPersonas.Size = new System.Drawing.Size(637, 190);
            this.dtgInfoPersonas.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(29, 238);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmMostrarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(696, 293);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgInfoPersonas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMostrarPersonas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Personas";
            this.Load += new System.EventHandler(this.frmMostrarPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfoPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgInfoPersonas;
        private System.Windows.Forms.Button btnVolver;
    }
}