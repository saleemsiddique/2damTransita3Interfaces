namespace Pantalla_Cliente
{
    partial class CrearZona
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
            this.btn_cancelarIncidencia = new System.Windows.Forms.Button();
            this.btn_AceptarIncidencia = new System.Windows.Forms.Button();
            this.nombre_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_datosInciencia = new System.Windows.Forms.Label();
            this.incidenciaEditar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelarIncidencia
            // 
            this.btn_cancelarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarIncidencia.Location = new System.Drawing.Point(71, 253);
            this.btn_cancelarIncidencia.Name = "btn_cancelarIncidencia";
            this.btn_cancelarIncidencia.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarIncidencia.TabIndex = 38;
            this.btn_cancelarIncidencia.Text = "Cancelar";
            this.btn_cancelarIncidencia.UseVisualStyleBackColor = true;
            this.btn_cancelarIncidencia.Click += new System.EventHandler(this.btn_cancelarIncidencia_Click);
            // 
            // btn_AceptarIncidencia
            // 
            this.btn_AceptarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AceptarIncidencia.Location = new System.Drawing.Point(211, 253);
            this.btn_AceptarIncidencia.Name = "btn_AceptarIncidencia";
            this.btn_AceptarIncidencia.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarIncidencia.TabIndex = 37;
            this.btn_AceptarIncidencia.Text = "Aceptar";
            this.btn_AceptarIncidencia.UseVisualStyleBackColor = true;
            this.btn_AceptarIncidencia.Click += new System.EventHandler(this.btn_AceptarIncidencia_Click);
            // 
            // nombre_input
            // 
            this.nombre_input.Location = new System.Drawing.Point(103, 124);
            this.nombre_input.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_input.Multiline = true;
            this.nombre_input.Name = "nombre_input";
            this.nombre_input.Size = new System.Drawing.Size(158, 28);
            this.nombre_input.TabIndex = 36;
            this.nombre_input.TextChanged += new System.EventHandler(this.descripcion_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(146, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre Zona";
            // 
            // label_datosInciencia
            // 
            this.label_datosInciencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label_datosInciencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_datosInciencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_datosInciencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_datosInciencia.Location = new System.Drawing.Point(12, 71);
            this.label_datosInciencia.Name = "label_datosInciencia";
            this.label_datosInciencia.Size = new System.Drawing.Size(334, 132);
            this.label_datosInciencia.TabIndex = 34;
            // 
            // incidenciaEditar
            // 
            this.incidenciaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.incidenciaEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incidenciaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidenciaEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.incidenciaEditar.Location = new System.Drawing.Point(88, 9);
            this.incidenciaEditar.Name = "incidenciaEditar";
            this.incidenciaEditar.Size = new System.Drawing.Size(198, 55);
            this.incidenciaEditar.TabIndex = 33;
            this.incidenciaEditar.Text = "Crear Zona Nueva";
            this.incidenciaEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CrearZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(361, 313);
            this.Controls.Add(this.btn_cancelarIncidencia);
            this.Controls.Add(this.btn_AceptarIncidencia);
            this.Controls.Add(this.nombre_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_datosInciencia);
            this.Controls.Add(this.incidenciaEditar);
            this.MaximumSize = new System.Drawing.Size(377, 352);
            this.MinimumSize = new System.Drawing.Size(377, 352);
            this.Name = "CrearZona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearZona";
            this.Load += new System.EventHandler(this.CrearZona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelarIncidencia;
        private System.Windows.Forms.Button btn_AceptarIncidencia;
        private System.Windows.Forms.TextBox nombre_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_datosInciencia;
        private System.Windows.Forms.Label incidenciaEditar;
    }
}