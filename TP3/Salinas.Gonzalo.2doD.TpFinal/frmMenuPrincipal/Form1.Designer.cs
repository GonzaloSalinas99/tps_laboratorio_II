
namespace frmMenuPrincipal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCargarJson = new System.Windows.Forms.Button();
            this.btnCargarXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(824, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCargarJson
            // 
            this.btnCargarJson.Location = new System.Drawing.Point(26, 33);
            this.btnCargarJson.Name = "btnCargarJson";
            this.btnCargarJson.Size = new System.Drawing.Size(132, 23);
            this.btnCargarJson.TabIndex = 1;
            this.btnCargarJson.Text = "Cargar Formato Json";
            this.btnCargarJson.UseVisualStyleBackColor = true;
            this.btnCargarJson.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnCargarXml
            // 
            this.btnCargarXml.Location = new System.Drawing.Point(26, 62);
            this.btnCargarXml.Name = "btnCargarXml";
            this.btnCargarXml.Size = new System.Drawing.Size(132, 23);
            this.btnCargarXml.TabIndex = 2;
            this.btnCargarXml.Text = "Cargar Formato Xml";
            this.btnCargarXml.UseVisualStyleBackColor = true;
            this.btnCargarXml.Click += new System.EventHandler(this.btnCargarXml_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 399);
            this.Controls.Add(this.btnCargarXml);
            this.Controls.Add(this.btnCargarJson);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCargarJson;
        private System.Windows.Forms.Button btnCargarXml;
    }
}

