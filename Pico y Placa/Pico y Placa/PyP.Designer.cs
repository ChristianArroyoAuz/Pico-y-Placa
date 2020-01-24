namespace Pico_y_Placa
{
    partial class PyP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PyP));
            this.etiquetaTitulo = new System.Windows.Forms.Label();
            this.etiquetaPlaca = new System.Windows.Forms.Label();
            this.etiquetaFecha = new System.Windows.Forms.Label();
            this.etiquetaHora = new System.Windows.Forms.Label();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtHora = new System.Windows.Forms.MaskedTextBox();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // etiquetaTitulo
            // 
            this.etiquetaTitulo.AutoSize = true;
            this.etiquetaTitulo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaTitulo.Location = new System.Drawing.Point(14, 9);
            this.etiquetaTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.etiquetaTitulo.Name = "etiquetaTitulo";
            this.etiquetaTitulo.Size = new System.Drawing.Size(384, 27);
            this.etiquetaTitulo.TabIndex = 0;
            this.etiquetaTitulo.Text = "Predictor de Pico y Placa Ecuador.";
            // 
            // etiquetaPlaca
            // 
            this.etiquetaPlaca.AutoSize = true;
            this.etiquetaPlaca.Location = new System.Drawing.Point(14, 63);
            this.etiquetaPlaca.Name = "etiquetaPlaca";
            this.etiquetaPlaca.Size = new System.Drawing.Size(190, 27);
            this.etiquetaPlaca.TabIndex = 1;
            this.etiquetaPlaca.Text = "Ingrese la placa:";
            // 
            // etiquetaFecha
            // 
            this.etiquetaFecha.AutoSize = true;
            this.etiquetaFecha.Location = new System.Drawing.Point(14, 117);
            this.etiquetaFecha.Name = "etiquetaFecha";
            this.etiquetaFecha.Size = new System.Drawing.Size(191, 27);
            this.etiquetaFecha.TabIndex = 2;
            this.etiquetaFecha.Text = "Ingrese la fecha:";
            // 
            // etiquetaHora
            // 
            this.etiquetaHora.AutoSize = true;
            this.etiquetaHora.Location = new System.Drawing.Point(14, 171);
            this.etiquetaHora.Name = "etiquetaHora";
            this.etiquetaHora.Size = new System.Drawing.Size(180, 27);
            this.etiquetaHora.TabIndex = 3;
            this.etiquetaHora.Text = "Ingrese la hora:";
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(210, 237);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(188, 34);
            this.botonBuscar.TabIndex = 8;
            this.botonBuscar.Text = "BUSCAR";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 216);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(211, 110);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(187, 34);
            this.txtFecha.TabIndex = 6;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            this.txtFecha.Leave += new System.EventHandler(this.TxtFecha_Leave);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(211, 164);
            this.txtHora.Mask = "00:00";
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(187, 34);
            this.txtHora.TabIndex = 7;
            this.txtHora.ValidatingType = typeof(System.DateTime);
            this.txtHora.Leave += new System.EventHandler(this.TxtHora_Leave);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(211, 56);
            this.txtPlaca.Mask = "LLL-0000";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(187, 34);
            this.txtPlaca.TabIndex = 5;
            this.txtPlaca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPlaca_KeyPress);
            this.txtPlaca.Leave += new System.EventHandler(this.TxtPlaca_Leave);
            // 
            // PyP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 284);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.etiquetaHora);
            this.Controls.Add(this.etiquetaFecha);
            this.Controls.Add(this.etiquetaPlaca);
            this.Controls.Add(this.etiquetaTitulo);
            this.Font = new System.Drawing.Font("Arial", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "PyP";
            this.Text = "Predictor Pico y Placa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label etiquetaTitulo;
        private System.Windows.Forms.Label etiquetaPlaca;
        private System.Windows.Forms.Label etiquetaFecha;
        private System.Windows.Forms.Label etiquetaHora;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.MaskedTextBox txtHora;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
    }
}

