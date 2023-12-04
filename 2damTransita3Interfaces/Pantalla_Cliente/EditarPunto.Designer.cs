namespace Pantalla_Cliente
{
    partial class EditarPunto
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxZona = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoPunto = new System.Windows.Forms.ComboBox();
            this.comboBoxAccesibilidad = new System.Windows.Forms.ComboBox();
            this.visibilidadPunto = new System.Windows.Forms.Label();
            this.comboBoxVisibilidadPunto = new System.Windows.Forms.ComboBox();
            this.tipoPunto = new System.Windows.Forms.Label();
            this.AccesibilidadPunto = new System.Windows.Forms.Label();
            this.longitudPunto_input = new System.Windows.Forms.TextBox();
            this.longitudPunto = new System.Windows.Forms.Label();
            this.latitudPunto_input = new System.Windows.Forms.TextBox();
            this.latitudPunto = new System.Windows.Forms.Label();
            this.descripcionPunto_input = new System.Windows.Forms.TextBox();
            this.puntoDesc = new System.Windows.Forms.Label();
            this.btn_cancelarPunto = new System.Windows.Forms.Button();
            this.btn_AceptarPunto = new System.Windows.Forms.Button();
            this.label_datosInciencia = new System.Windows.Forms.Label();
            this.puntoEditar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(282, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Zona";
            // 
            // comboBoxZona
            // 
            this.comboBoxZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZona.FormattingEnabled = true;
            this.comboBoxZona.Location = new System.Drawing.Point(285, 411);
            this.comboBoxZona.Name = "comboBoxZona";
            this.comboBoxZona.Size = new System.Drawing.Size(112, 21);
            this.comboBoxZona.TabIndex = 87;
            // 
            // comboBoxTipoPunto
            // 
            this.comboBoxTipoPunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoPunto.FormattingEnabled = true;
            this.comboBoxTipoPunto.Items.AddRange(new object[] {
            "ACCESO",
            "LUGAR"});
            this.comboBoxTipoPunto.Location = new System.Drawing.Point(165, 349);
            this.comboBoxTipoPunto.Name = "comboBoxTipoPunto";
            this.comboBoxTipoPunto.Size = new System.Drawing.Size(112, 21);
            this.comboBoxTipoPunto.TabIndex = 86;
            // 
            // comboBoxAccesibilidad
            // 
            this.comboBoxAccesibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccesibilidad.FormattingEnabled = true;
            this.comboBoxAccesibilidad.Items.AddRange(new object[] {
            "ACCESIBLE",
            "NO_ACCESIBLE",
            "PARCIALMENTE_ACCESIBLE"});
            this.comboBoxAccesibilidad.Location = new System.Drawing.Point(166, 291);
            this.comboBoxAccesibilidad.Name = "comboBoxAccesibilidad";
            this.comboBoxAccesibilidad.Size = new System.Drawing.Size(112, 21);
            this.comboBoxAccesibilidad.TabIndex = 85;
            // 
            // visibilidadPunto
            // 
            this.visibilidadPunto.AutoSize = true;
            this.visibilidadPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.visibilidadPunto.ForeColor = System.Drawing.Color.White;
            this.visibilidadPunto.Location = new System.Drawing.Point(164, 386);
            this.visibilidadPunto.Name = "visibilidadPunto";
            this.visibilidadPunto.Size = new System.Drawing.Size(84, 13);
            this.visibilidadPunto.TabIndex = 84;
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
            this.comboBoxVisibilidadPunto.Location = new System.Drawing.Point(167, 411);
            this.comboBoxVisibilidadPunto.Name = "comboBoxVisibilidadPunto";
            this.comboBoxVisibilidadPunto.Size = new System.Drawing.Size(112, 21);
            this.comboBoxVisibilidadPunto.TabIndex = 83;
            // 
            // tipoPunto
            // 
            this.tipoPunto.AutoSize = true;
            this.tipoPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.tipoPunto.ForeColor = System.Drawing.Color.White;
            this.tipoPunto.Location = new System.Drawing.Point(164, 327);
            this.tipoPunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tipoPunto.Name = "tipoPunto";
            this.tipoPunto.Size = new System.Drawing.Size(59, 13);
            this.tipoPunto.TabIndex = 82;
            this.tipoPunto.Text = "Tipo Punto";
            // 
            // AccesibilidadPunto
            // 
            this.AccesibilidadPunto.AutoSize = true;
            this.AccesibilidadPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.AccesibilidadPunto.ForeColor = System.Drawing.Color.White;
            this.AccesibilidadPunto.Location = new System.Drawing.Point(164, 268);
            this.AccesibilidadPunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AccesibilidadPunto.Name = "AccesibilidadPunto";
            this.AccesibilidadPunto.Size = new System.Drawing.Size(69, 13);
            this.AccesibilidadPunto.TabIndex = 81;
            this.AccesibilidadPunto.Text = "Accesibilidad";
            // 
            // longitudPunto_input
            // 
            this.longitudPunto_input.Location = new System.Drawing.Point(167, 232);
            this.longitudPunto_input.Margin = new System.Windows.Forms.Padding(2);
            this.longitudPunto_input.Name = "longitudPunto_input";
            this.longitudPunto_input.Size = new System.Drawing.Size(158, 20);
            this.longitudPunto_input.TabIndex = 80;
            this.longitudPunto_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitarSoloNumeros);
            // 
            // longitudPunto
            // 
            this.longitudPunto.AutoSize = true;
            this.longitudPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.longitudPunto.ForeColor = System.Drawing.Color.White;
            this.longitudPunto.Location = new System.Drawing.Point(164, 208);
            this.longitudPunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.longitudPunto.Name = "longitudPunto";
            this.longitudPunto.Size = new System.Drawing.Size(48, 13);
            this.longitudPunto.TabIndex = 79;
            this.longitudPunto.Text = "Longitud";
            // 
            // latitudPunto_input
            // 
            this.latitudPunto_input.Location = new System.Drawing.Point(167, 169);
            this.latitudPunto_input.Margin = new System.Windows.Forms.Padding(2);
            this.latitudPunto_input.Name = "latitudPunto_input";
            this.latitudPunto_input.Size = new System.Drawing.Size(158, 20);
            this.latitudPunto_input.TabIndex = 78;
            this.latitudPunto_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.limitarSoloNumeros);
            // 
            // latitudPunto
            // 
            this.latitudPunto.AutoSize = true;
            this.latitudPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.latitudPunto.ForeColor = System.Drawing.Color.White;
            this.latitudPunto.Location = new System.Drawing.Point(164, 145);
            this.latitudPunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.latitudPunto.Name = "latitudPunto";
            this.latitudPunto.Size = new System.Drawing.Size(39, 13);
            this.latitudPunto.TabIndex = 77;
            this.latitudPunto.Text = "Latitud";
            // 
            // descripcionPunto_input
            // 
            this.descripcionPunto_input.Location = new System.Drawing.Point(167, 108);
            this.descripcionPunto_input.Margin = new System.Windows.Forms.Padding(2);
            this.descripcionPunto_input.Name = "descripcionPunto_input";
            this.descripcionPunto_input.Size = new System.Drawing.Size(158, 20);
            this.descripcionPunto_input.TabIndex = 76;
            // 
            // puntoDesc
            // 
            this.puntoDesc.AutoSize = true;
            this.puntoDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.puntoDesc.ForeColor = System.Drawing.Color.White;
            this.puntoDesc.Location = new System.Drawing.Point(164, 84);
            this.puntoDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puntoDesc.Name = "puntoDesc";
            this.puntoDesc.Size = new System.Drawing.Size(94, 13);
            this.puntoDesc.TabIndex = 75;
            this.puntoDesc.Text = "Punto Descripcion";
            // 
            // btn_cancelarPunto
            // 
            this.btn_cancelarPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarPunto.Location = new System.Drawing.Point(122, 479);
            this.btn_cancelarPunto.Name = "btn_cancelarPunto";
            this.btn_cancelarPunto.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarPunto.TabIndex = 74;
            this.btn_cancelarPunto.Text = "Cancelar";
            this.btn_cancelarPunto.UseVisualStyleBackColor = true;
            this.btn_cancelarPunto.Click += new System.EventHandler(this.btn_cancelarPunto_Click);
            // 
            // btn_AceptarPunto
            // 
            this.btn_AceptarPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AceptarPunto.Location = new System.Drawing.Point(298, 479);
            this.btn_AceptarPunto.Name = "btn_AceptarPunto";
            this.btn_AceptarPunto.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarPunto.TabIndex = 73;
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
            this.label_datosInciencia.Location = new System.Drawing.Point(75, 68);
            this.label_datosInciencia.Name = "label_datosInciencia";
            this.label_datosInciencia.Size = new System.Drawing.Size(334, 403);
            this.label_datosInciencia.TabIndex = 72;
            // 
            // puntoEditar
            // 
            this.puntoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.puntoEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.puntoEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntoEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.puntoEditar.Location = new System.Drawing.Point(147, 8);
            this.puntoEditar.Name = "puntoEditar";
            this.puntoEditar.Size = new System.Drawing.Size(198, 55);
            this.puntoEditar.TabIndex = 71;
            this.puntoEditar.Text = "Editar Punto";
            this.puntoEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditarPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxZona);
            this.Controls.Add(this.comboBoxTipoPunto);
            this.Controls.Add(this.comboBoxAccesibilidad);
            this.Controls.Add(this.visibilidadPunto);
            this.Controls.Add(this.comboBoxVisibilidadPunto);
            this.Controls.Add(this.tipoPunto);
            this.Controls.Add(this.AccesibilidadPunto);
            this.Controls.Add(this.longitudPunto_input);
            this.Controls.Add(this.longitudPunto);
            this.Controls.Add(this.latitudPunto_input);
            this.Controls.Add(this.latitudPunto);
            this.Controls.Add(this.descripcionPunto_input);
            this.Controls.Add(this.puntoDesc);
            this.Controls.Add(this.btn_cancelarPunto);
            this.Controls.Add(this.btn_AceptarPunto);
            this.Controls.Add(this.label_datosInciencia);
            this.Controls.Add(this.puntoEditar);
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "EditarPunto";
            this.Text = "EditarPunto";
            this.Load += new System.EventHandler(this.EditarPunto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxZona;
        private System.Windows.Forms.ComboBox comboBoxTipoPunto;
        private System.Windows.Forms.ComboBox comboBoxAccesibilidad;
        private System.Windows.Forms.Label visibilidadPunto;
        private System.Windows.Forms.ComboBox comboBoxVisibilidadPunto;
        private System.Windows.Forms.Label tipoPunto;
        private System.Windows.Forms.Label AccesibilidadPunto;
        private System.Windows.Forms.TextBox longitudPunto_input;
        private System.Windows.Forms.Label longitudPunto;
        private System.Windows.Forms.TextBox latitudPunto_input;
        private System.Windows.Forms.Label latitudPunto;
        private System.Windows.Forms.TextBox descripcionPunto_input;
        private System.Windows.Forms.Label puntoDesc;
        private System.Windows.Forms.Button btn_cancelarPunto;
        private System.Windows.Forms.Button btn_AceptarPunto;
        private System.Windows.Forms.Label label_datosInciencia;
        private System.Windows.Forms.Label puntoEditar;
    }
}