namespace pryRomanisioSP1TP1
{
    partial class frmConsultaLibro
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
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.dgvConsultaLibros = new System.Windows.Forms.DataGridView();
            this.codLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codDistribuidor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(508, 115);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(587, 115);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dgvConsultaLibros
            // 
            this.dgvConsultaLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLibro,
            this.nombLibro,
            this.codEditorial,
            this.codAutor,
            this.codDistribuidor});
            this.dgvConsultaLibros.Location = new System.Drawing.Point(12, 12);
            this.dgvConsultaLibros.Name = "dgvConsultaLibros";
            this.dgvConsultaLibros.Size = new System.Drawing.Size(749, 82);
            this.dgvConsultaLibros.TabIndex = 3;
            // 
            // codLibro
            // 
            this.codLibro.HeaderText = "Codigo";
            this.codLibro.Name = "codLibro";
            // 
            // nombLibro
            // 
            this.nombLibro.HeaderText = "Nombre";
            this.nombLibro.MinimumWidth = 50;
            this.nombLibro.Name = "nombLibro";
            this.nombLibro.Width = 200;
            // 
            // codEditorial
            // 
            this.codEditorial.HeaderText = "Codigo Editorial";
            this.codEditorial.Name = "codEditorial";
            // 
            // codAutor
            // 
            this.codAutor.HeaderText = "Codigo Autor";
            this.codAutor.Name = "codAutor";
            // 
            // codDistribuidor
            // 
            this.codDistribuidor.HeaderText = "Codigo Distribuidor";
            this.codDistribuidor.Name = "codDistribuidor";
            this.codDistribuidor.Width = 200;
            // 
            // frmConsultaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 164);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.dgvConsultaLibros);
            this.Name = "frmConsultaLibro";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.frmConsultaLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLibros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.DataGridView dgvConsultaLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDistribuidor;
    }
}