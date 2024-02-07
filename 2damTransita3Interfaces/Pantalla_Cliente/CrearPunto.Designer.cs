namespace Pantalla_Cliente
{
    partial class CrearPunto
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
            this.btn_cancelarPunto = new System.Windows.Forms.Button();
            this.btn_AceptarPunto = new System.Windows.Forms.Button();
            this.label_datosInciencia = new System.Windows.Forms.Label();
            this.incidenciaEditar = new System.Windows.Forms.Label();
            this.visibilidadPunto = new System.Windows.Forms.Label();
            this.comboBoxVisibilidadPunto = new System.Windows.Forms.ComboBox();
            this.tipoPunto = new System.Windows.Forms.Label();
            this.AccesibilidadPunto = new System.Windows.Forms.Label();
            this.longitudPunto = new System.Windows.Forms.Label();
            this.latitudPunto = new System.Windows.Forms.Label();
            this.puntoDescripcion_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAccesibilidad = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoPunto = new System.Windows.Forms.ComboBox();
            this.latitudPunto_input = new System.Windows.Forms.TextBox();
            this.longitudPunto_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_cancelarPunto
            // 
            this.btn_cancelarPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarPunto.Location = new System.Drawing.Point(120, 476);
            this.btn_cancelarPunto.Name = "btn_cancelarPunto";
            this.btn_cancelarPunto.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarPunto.TabIndex = 6;
            this.btn_cancelarPunto.Text = "Cancelar";
            this.btn_cancelarPunto.UseVisualStyleBackColor = true;
            this.btn_cancelarPunto.Click += new System.EventHandler(this.btn_cancelarPunto_Click);
            // 
            // btn_AceptarPunto
            // 
            this.btn_AceptarPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AceptarPunto.Location = new System.Drawing.Point(296, 476);
            this.btn_AceptarPunto.Name = "btn_AceptarPunto";
            this.btn_AceptarPunto.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarPunto.TabIndex = 7;
            this.btn_AceptarPunto.Text = "Aceptar";
            this.btn_AceptarPunto.UseVisualStyleBackColor = true;
            this.btn_AceptarPunto.Click += new System.EventHandler(this.btn_AceptarPunto_Click);
            // 
            // label_datosInciencia
            // 
            this.label_datosInciencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label_datosInciencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_datosInciencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_datosInciencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_datosInciencia.Location = new System.Drawing.Point(73, 65);
            this.label_datosInciencia.Name = "label_datosInciencia";
            this.label_datosInciencia.Size = new System.Drawing.Size(334, 403);
            this.label_datosInciencia.TabIndex = 46;
            // 
            // incidenciaEditar
            // 
            this.incidenciaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.incidenciaEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incidenciaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidenciaEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.incidenciaEditar.Location = new System.Drawing.Point(145, 5);
            this.incidenciaEditar.Name = "incidenciaEditar";
            this.incidenciaEditar.Size = new System.Drawing.Size(198, 55);
            this.incidenciaEditar.TabIndex = 45;
            this.incidenciaEditar.Text = "Crear Punto";
            this.incidenciaEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visibilidadPunto
            // 
            this.visibilidadPunto.AutoSize = true;
            this.visibilidadPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.visibilidadPunto.ForeColor = System.Drawing.Color.White;
            this.visibilidadPunto.Location = new System.Drawing.Point(162, 383);
            this.visibilidadPunto.Name = "visibilidadPunto";
            this.visibilidadPunto.Size = new System.Drawing.Size(84, 13);
            this.visibilidadPunto.TabIndex = 66;
            this.visibilidadPunto.Text = "Visibilidad Punto";
            // 
            // comboBoxVisibilidadPunto
            // 
            this.comboBoxVisibilidadPunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisibilidadPunto.FormattingEnabled = true;
            this.comboBoxVisibilidadPunto.Items.AddRange(new object[] {
            "GLOBAL",
            "FAVORITO",
            "INCIDENCIA",
            "OCULTO"});
            this.comboBoxVisibilidadPunto.Location = new System.Drawing.Point(165, 408);
            this.comboBoxVisibilidadPunto.Name = "comboBoxVisibilidadPunto";
            this.comboBoxVisibilidadPunto.Size = new System.Drawing.Size(158, 21);
            this.comboBoxVisibilidadPunto.TabIndex = 5;
            // 
            // tipoPunto
            // 
            this.tipoPunto.AutoSize = true;
            this.tipoPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.tipoPunto.ForeColor = System.Drawing.Color.White;
            this.tipoPunto.Location = new System.Drawing.Point(162, 324);
            this.tipoPunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipoPunto.Name = "tipoPunto";
            this.tipoPunto.Size = new System.Drawing.Size(59, 13);
            this.tipoPunto.TabIndex = 63;
            this.tipoPunto.Text = "Tipo Punto";
            // 
            // AccesibilidadPunto
            // 
            this.AccesibilidadPunto.AutoSize = true;
            this.AccesibilidadPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.AccesibilidadPunto.ForeColor = System.Drawing.Color.White;
            this.AccesibilidadPunto.Location = new System.Drawing.Point(162, 265);
            this.AccesibilidadPunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccesibilidadPunto.Name = "AccesibilidadPunto";
            this.AccesibilidadPunto.Size = new System.Drawing.Size(69, 13);
            this.AccesibilidadPunto.TabIndex = 61;
            this.AccesibilidadPunto.Text = "Accesibilidad";
            // 
            // longitudPunto
            // 
            this.longitudPunto.AutoSize = true;
            this.longitudPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.longitudPunto.ForeColor = System.Drawing.Color.White;
            this.longitudPunto.Location = new System.Drawing.Point(162, 205);
            this.longitudPunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.longitudPunto.Name = "longitudPunto";
            this.longitudPunto.Size = new System.Drawing.Size(48, 13);
            this.longitudPunto.TabIndex = 59;
            this.longitudPunto.Text = "Longitud";
            // 
            // latitudPunto
            // 
            this.latitudPunto.AutoSize = true;
            this.latitudPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.latitudPunto.ForeColor = System.Drawing.Color.White;
            this.latitudPunto.Location = new System.Drawing.Point(162, 142);
            this.latitudPunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.latitudPunto.Name = "latitudPunto";
            this.latitudPunto.Size = new System.Drawing.Size(39, 13);
            this.latitudPunto.TabIndex = 57;
            this.latitudPunto.Text = "Latitud";
            // 
            // puntoDescripcion_input
            // 
            this.puntoDescripcion_input.Location = new System.Drawing.Point(165, 105);
            this.puntoDescripcion_input.Margin = new System.Windows.Forms.Padding(2);
            this.puntoDescripcion_input.Name = "puntoDescripcion_input";
            this.puntoDescripcion_input.Size = new System.Drawing.Size(158, 20);
            this.puntoDescripcion_input.TabIndex = 0;
            this.puntoDescripcion_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.puntoDescripcion_input_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Punto Descripcion";
            // 
            // comboBoxAccesibilidad
            // 
            this.comboBoxAccesibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccesibilidad.FormattingEnabled = true;
            this.comboBoxAccesibilidad.Items.AddRange(new object[] {
            "ACCESIBLE",
            "NO_ACCESIBLE",
            "PARCIALMENTE_ACCESIBLE"});
            this.comboBoxAccesibilidad.Location = new System.Drawing.Point(164, 288);
            this.comboBoxAccesibilidad.Name = "comboBoxAccesibilidad";
            this.comboBoxAccesibilidad.Size = new System.Drawing.Size(159, 21);
            this.comboBoxAccesibilidad.TabIndex = 3;
            // 
            // comboBoxTipoPunto
            // 
            this.comboBoxTipoPunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoPunto.FormattingEnabled = true;
            this.comboBoxTipoPunto.Items.AddRange(new object[] {
            "ACCESO",
            "LUGAR",
            "PARKING"});
            this.comboBoxTipoPunto.Location = new System.Drawing.Point(163, 346);
            this.comboBoxTipoPunto.Name = "comboBoxTipoPunto";
            this.comboBoxTipoPunto.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTipoPunto.TabIndex = 4;
            // 
            // latitudPunto_input
            // 
            this.latitudPunto_input.Location = new System.Drawing.Point(165, 171);
            this.latitudPunto_input.Name = "latitudPunto_input";
            this.latitudPunto_input.Size = new System.Drawing.Size(158, 20);
            this.latitudPunto_input.TabIndex = 67;
            this.latitudPunto_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitarSoloNumeros);
            // 
            // longitudPunto_input
            // 
            this.longitudPunto_input.Location = new System.Drawing.Point(165, 231);
            this.longitudPunto_input.Name = "longitudPunto_input";
            this.longitudPunto_input.Size = new System.Drawing.Size(158, 20);
            this.longitudPunto_input.TabIndex = 68;
            this.longitudPunto_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitarSoloNumeros);
            // 
            // CrearPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.longitudPunto_input);
            this.Controls.Add(this.latitudPunto_input);
            this.Controls.Add(this.comboBoxTipoPunto);
            this.Controls.Add(this.comboBoxAccesibilidad);
            this.Controls.Add(this.visibilidadPunto);
            this.Controls.Add(this.comboBoxVisibilidadPunto);
            this.Controls.Add(this.tipoPunto);
            this.Controls.Add(this.AccesibilidadPunto);
            this.Controls.Add(this.longitudPunto);
            this.Controls.Add(this.latitudPunto);
            this.Controls.Add(this.puntoDescripcion_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelarPunto);
            this.Controls.Add(this.btn_AceptarPunto);
            this.Controls.Add(this.label_datosInciencia);
            this.Controls.Add(this.incidenciaEditar);
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "CrearPunto";
            this.Text = "CrearPunto";
            this.Load += new System.EventHandler(this.CrearPunto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelarPunto;
        private System.Windows.Forms.Button btn_AceptarPunto;
        private System.Windows.Forms.Label label_datosInciencia;
        private System.Windows.Forms.Label incidenciaEditar;
        private System.Windows.Forms.Label visibilidadPunto;
        private System.Windows.Forms.ComboBox comboBoxVisibilidadPunto;
        private System.Windows.Forms.Label tipoPunto;
        private System.Windows.Forms.Label AccesibilidadPunto;
        private System.Windows.Forms.Label longitudPunto;
        private System.Windows.Forms.Label latitudPunto;
        private System.Windows.Forms.TextBox puntoDescripcion_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAccesibilidad;
        private System.Windows.Forms.ComboBox comboBoxTipoPunto;
        private System.Windows.Forms.TextBox latitudPunto_input;
        private System.Windows.Forms.TextBox longitudPunto_input;
    }
}