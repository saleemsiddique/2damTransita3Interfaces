﻿namespace Pantalla_Cliente
{
    partial class CrearIncidencia
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
            this.estado_input = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.punto_input = new System.Windows.Forms.ComboBox();
            this.cliente_input = new System.Windows.Forms.ComboBox();
            this.fecha_input = new System.Windows.Forms.DateTimePicker();
            this.duracion_input = new System.Windows.Forms.TextBox();
            this.btn_cancelarIncidencia = new System.Windows.Forms.Button();
            this.btn_AceptarIncidencia = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcion_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_datosInciencia = new System.Windows.Forms.Label();
            this.incidenciaEditar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // estado_input
            // 
            this.estado_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado_input.FormattingEnabled = true;
            this.estado_input.Location = new System.Drawing.Point(136, 243);
            this.estado_input.Name = "estado_input";
            this.estado_input.Size = new System.Drawing.Size(158, 21);
            this.estado_input.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(190, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(260, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Punto asociado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Cliente asociado:";
            // 
            // punto_input
            // 
            this.punto_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.punto_input.FormattingEnabled = true;
            this.punto_input.Location = new System.Drawing.Point(240, 407);
            this.punto_input.Name = "punto_input";
            this.punto_input.Size = new System.Drawing.Size(121, 21);
            this.punto_input.TabIndex = 36;
            // 
            // cliente_input
            // 
            this.cliente_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cliente_input.FormattingEnabled = true;
            this.cliente_input.Location = new System.Drawing.Point(63, 407);
            this.cliente_input.Name = "cliente_input";
            this.cliente_input.Size = new System.Drawing.Size(121, 21);
            this.cliente_input.TabIndex = 35;
            // 
            // fecha_input
            // 
            this.fecha_input.Location = new System.Drawing.Point(110, 342);
            this.fecha_input.Name = "fecha_input";
            this.fecha_input.Size = new System.Drawing.Size(204, 20);
            this.fecha_input.TabIndex = 34;
            // 
            // duracion_input
            // 
            this.duracion_input.Location = new System.Drawing.Point(136, 292);
            this.duracion_input.Margin = new System.Windows.Forms.Padding(2);
            this.duracion_input.Name = "duracion_input";
            this.duracion_input.Size = new System.Drawing.Size(158, 20);
            this.duracion_input.TabIndex = 33;
            // 
            // btn_cancelarIncidencia
            // 
            this.btn_cancelarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarIncidencia.Location = new System.Drawing.Point(332, 505);
            this.btn_cancelarIncidencia.Name = "btn_cancelarIncidencia";
            this.btn_cancelarIncidencia.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelarIncidencia.TabIndex = 32;
            this.btn_cancelarIncidencia.Text = "Cancelar";
            this.btn_cancelarIncidencia.UseVisualStyleBackColor = true;
            this.btn_cancelarIncidencia.Click += new System.EventHandler(this.btn_cancelarIncidencia_Click);
            // 
            // btn_AceptarIncidencia
            // 
            this.btn_AceptarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AceptarIncidencia.Location = new System.Drawing.Point(230, 505);
            this.btn_AceptarIncidencia.Name = "btn_AceptarIncidencia";
            this.btn_AceptarIncidencia.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarIncidencia.TabIndex = 31;
            this.btn_AceptarIncidencia.Text = "Aceptar";
            this.btn_AceptarIncidencia.UseVisualStyleBackColor = true;
            this.btn_AceptarIncidencia.Click += new System.EventHandler(this.btn_AceptarIncidencia_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(190, 326);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Fecha: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(163, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Duracion estimada:";
            // 
            // descripcion_input
            // 
            this.descripcion_input.Location = new System.Drawing.Point(136, 173);
            this.descripcion_input.Margin = new System.Windows.Forms.Padding(2);
            this.descripcion_input.Multiline = true;
            this.descripcion_input.Name = "descripcion_input";
            this.descripcion_input.Size = new System.Drawing.Size(158, 40);
            this.descripcion_input.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Descripción:";
            // 
            // label_datosInciencia
            // 
            this.label_datosInciencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label_datosInciencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_datosInciencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_datosInciencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_datosInciencia.Location = new System.Drawing.Point(46, 119);
            this.label_datosInciencia.Name = "label_datosInciencia";
            this.label_datosInciencia.Size = new System.Drawing.Size(334, 370);
            this.label_datosInciencia.TabIndex = 26;
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
            this.incidenciaEditar.TabIndex = 25;
            this.incidenciaEditar.Text = "Crear Incidencia Nueva";
            this.incidenciaEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CrearIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(453, 572);
            this.Controls.Add(this.estado_input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.punto_input);
            this.Controls.Add(this.cliente_input);
            this.Controls.Add(this.fecha_input);
            this.Controls.Add(this.duracion_input);
            this.Controls.Add(this.btn_cancelarIncidencia);
            this.Controls.Add(this.btn_AceptarIncidencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descripcion_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_datosInciencia);
            this.Controls.Add(this.incidenciaEditar);
            this.MaximumSize = new System.Drawing.Size(469, 611);
            this.MinimumSize = new System.Drawing.Size(469, 611);
            this.Name = "CrearIncidencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Incidencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox estado_input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox punto_input;
        private System.Windows.Forms.ComboBox cliente_input;
        private System.Windows.Forms.DateTimePicker fecha_input;
        private System.Windows.Forms.TextBox duracion_input;
        private System.Windows.Forms.Button btn_cancelarIncidencia;
        private System.Windows.Forms.Button btn_AceptarIncidencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descripcion_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_datosInciencia;
        private System.Windows.Forms.Label incidenciaEditar;
    }
}