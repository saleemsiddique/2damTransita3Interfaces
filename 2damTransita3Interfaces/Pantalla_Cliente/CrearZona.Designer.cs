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
            this.btn_cancelarZona = new System.Windows.Forms.Button();
            this.btn_AceptarZona = new System.Windows.Forms.Button();
            this.nombre_input = new System.Windows.Forms.TextBox();
            this.nombre_label = new System.Windows.Forms.Label();
            this.label_datosInciencia = new System.Windows.Forms.Label();
            this.incidenciaEditar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelarZona
            // 
            this.btn_cancelarZona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarZona.Location = new System.Drawing.Point(249, 298);
            this.btn_cancelarZona.Name = "btn_cancelarZona";
            this.btn_cancelarZona.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarZona.TabIndex = 48;
            this.btn_cancelarZona.Text = "Cancelar";
            this.btn_cancelarZona.UseVisualStyleBackColor = true;
            this.btn_cancelarZona.Click += new System.EventHandler(this.btn_cancelarZona_Click);
            // 
            // btn_AceptarZona
            // 
            this.btn_AceptarZona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AceptarZona.Location = new System.Drawing.Point(105, 298);
            this.btn_AceptarZona.Name = "btn_AceptarZona";
            this.btn_AceptarZona.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarZona.TabIndex = 47;
            this.btn_AceptarZona.Text = "Aceptar";
            this.btn_AceptarZona.UseVisualStyleBackColor = true;
            this.btn_AceptarZona.Click += new System.EventHandler(this.btn_AceptarZona_Click);
            // 
            // nombre_input
            // 
            this.nombre_input.Location = new System.Drawing.Point(136, 173);
            this.nombre_input.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_input.Multiline = true;
            this.nombre_input.Name = "nombre_input";
            this.nombre_input.Size = new System.Drawing.Size(158, 40);
            this.nombre_input.TabIndex = 44;
            // 
            // nombre_label
            // 
            this.nombre_label.AutoSize = true;
            this.nombre_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.nombre_label.ForeColor = System.Drawing.Color.White;
            this.nombre_label.Location = new System.Drawing.Point(168, 146);
            this.nombre_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre_label.Name = "nombre_label";
            this.nombre_label.Size = new System.Drawing.Size(96, 13);
            this.nombre_label.TabIndex = 43;
            this.nombre_label.Text = "Nombre de la zona";
            // 
            // label_datosInciencia
            // 
            this.label_datosInciencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label_datosInciencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_datosInciencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_datosInciencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_datosInciencia.Location = new System.Drawing.Point(46, 119);
            this.label_datosInciencia.Name = "label_datosInciencia";
            this.label_datosInciencia.Size = new System.Drawing.Size(334, 139);
            this.label_datosInciencia.TabIndex = 42;
            // 
            // incidenciaEditar
            // 
            this.incidenciaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.incidenciaEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incidenciaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidenciaEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.incidenciaEditar.Location = new System.Drawing.Point(105, 45);
            this.incidenciaEditar.Name = "incidenciaEditar";
            this.incidenciaEditar.Size = new System.Drawing.Size(219, 54);
            this.incidenciaEditar.TabIndex = 41;
            this.incidenciaEditar.Text = "Crear Zona Nueva";
            this.incidenciaEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CrearZona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(411, 366);
            this.Controls.Add(this.btn_cancelarZona);
            this.Controls.Add(this.btn_AceptarZona);
            this.Controls.Add(this.nombre_input);
            this.Controls.Add(this.nombre_label);
            this.Controls.Add(this.label_datosInciencia);
            this.Controls.Add(this.incidenciaEditar);
            this.MaximumSize = new System.Drawing.Size(427, 405);
            this.MinimumSize = new System.Drawing.Size(427, 405);
            this.Name = "CrearZona";
            this.Text = "CrearZona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelarZona;
        private System.Windows.Forms.Button btn_AceptarZona;
        private System.Windows.Forms.TextBox nombre_input;
        private System.Windows.Forms.Label nombre_label;
        private System.Windows.Forms.Label label_datosInciencia;
        private System.Windows.Forms.Label incidenciaEditar;
    }
}