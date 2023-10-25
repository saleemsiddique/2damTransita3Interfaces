namespace Pantalla_Cliente
{
    partial class datosIncidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datosIncidencia));
            this.picture_incidencia = new System.Windows.Forms.PictureBox();
            this.labelClienteIncidencia = new System.Windows.Forms.Label();
            this.label_datosInciencia = new System.Windows.Forms.Label();
            this.btn_AceptarIncidencia = new System.Windows.Forms.Button();
            this.btn_reportarIncidencia = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_lugar = new System.Windows.Forms.Label();
            this.label_latitud = new System.Windows.Forms.Label();
            this.label_longitud = new System.Windows.Forms.Label();
            this.label_razon = new System.Windows.Forms.Label();
            this.label_razonDesc = new System.Windows.Forms.Label();
            this.label_IDData = new System.Windows.Forms.Label();
            this.label_lugarData = new System.Windows.Forms.Label();
            this.label_latitudData = new System.Windows.Forms.Label();
            this.label_longitudData = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_incidencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_incidencia
            // 
            this.picture_incidencia.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picture_incidencia.Image = ((System.Drawing.Image)(resources.GetObject("picture_incidencia.Image")));
            this.picture_incidencia.Location = new System.Drawing.Point(138, 12);
            this.picture_incidencia.Name = "picture_incidencia";
            this.picture_incidencia.Size = new System.Drawing.Size(283, 184);
            this.picture_incidencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_incidencia.TabIndex = 0;
            this.picture_incidencia.TabStop = false;
            this.picture_incidencia.Click += new System.EventHandler(this.picture_incidencia_Click);
            // 
            // labelClienteIncidencia
            // 
            this.labelClienteIncidencia.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelClienteIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteIncidencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelClienteIncidencia.Location = new System.Drawing.Point(171, 228);
            this.labelClienteIncidencia.Name = "labelClienteIncidencia";
            this.labelClienteIncidencia.Size = new System.Drawing.Size(219, 54);
            this.labelClienteIncidencia.TabIndex = 1;
            this.labelClienteIncidencia.Text = "Cliente X";
            this.labelClienteIncidencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_datosInciencia
            // 
            this.label_datosInciencia.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_datosInciencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_datosInciencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_datosInciencia.Location = new System.Drawing.Point(73, 293);
            this.label_datosInciencia.Name = "label_datosInciencia";
            this.label_datosInciencia.Size = new System.Drawing.Size(400, 400);
            this.label_datosInciencia.TabIndex = 3;
            this.label_datosInciencia.Click += new System.EventHandler(this.label_datosInciencia_Click);
            // 
            // btn_AceptarIncidencia
            // 
            this.btn_AceptarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AceptarIncidencia.Location = new System.Drawing.Point(365, 708);
            this.btn_AceptarIncidencia.Name = "btn_AceptarIncidencia";
            this.btn_AceptarIncidencia.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarIncidencia.TabIndex = 4;
            this.btn_AceptarIncidencia.Text = "Aceptar";
            this.btn_AceptarIncidencia.UseVisualStyleBackColor = true;
            this.btn_AceptarIncidencia.Click += new System.EventHandler(this.btn_AceptarIncidencia_Click);
            // 
            // btn_reportarIncidencia
            // 
            this.btn_reportarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportarIncidencia.Location = new System.Drawing.Point(457, 708);
            this.btn_reportarIncidencia.Name = "btn_reportarIncidencia";
            this.btn_reportarIncidencia.Size = new System.Drawing.Size(75, 23);
            this.btn_reportarIncidencia.TabIndex = 5;
            this.btn_reportarIncidencia.Text = "Reportar";
            this.btn_reportarIncidencia.UseVisualStyleBackColor = true;
            this.btn_reportarIncidencia.Click += new System.EventHandler(this.btn_reportarIncidencia_Click);
            // 
            // label_ID
            // 
            this.label_ID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_ID.Location = new System.Drawing.Point(107, 340);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(100, 23);
            this.label_ID.TabIndex = 7;
            this.label_ID.Text = "ID:";
            // 
            // label_lugar
            // 
            this.label_lugar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_lugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lugar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_lugar.Location = new System.Drawing.Point(107, 388);
            this.label_lugar.Name = "label_lugar";
            this.label_lugar.Size = new System.Drawing.Size(100, 29);
            this.label_lugar.TabIndex = 8;
            this.label_lugar.Text = "Lugar:";
            // 
            // label_latitud
            // 
            this.label_latitud.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_latitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_latitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_latitud.Location = new System.Drawing.Point(107, 437);
            this.label_latitud.Name = "label_latitud";
            this.label_latitud.Size = new System.Drawing.Size(100, 23);
            this.label_latitud.TabIndex = 9;
            this.label_latitud.Text = "Latitud:";
            // 
            // label_longitud
            // 
            this.label_longitud.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_longitud.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_longitud.Location = new System.Drawing.Point(107, 481);
            this.label_longitud.Name = "label_longitud";
            this.label_longitud.Size = new System.Drawing.Size(115, 28);
            this.label_longitud.TabIndex = 10;
            this.label_longitud.Text = "Longitud:";
            // 
            // label_razon
            // 
            this.label_razon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_razon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_razon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_razon.Location = new System.Drawing.Point(107, 526);
            this.label_razon.Name = "label_razon";
            this.label_razon.Size = new System.Drawing.Size(115, 28);
            this.label_razon.TabIndex = 11;
            this.label_razon.Text = "Razón:";
            // 
            // label_razonDesc
            // 
            this.label_razonDesc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_razonDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_razonDesc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_razonDesc.Location = new System.Drawing.Point(107, 573);
            this.label_razonDesc.Name = "label_razonDesc";
            this.label_razonDesc.Size = new System.Drawing.Size(333, 105);
            this.label_razonDesc.TabIndex = 12;
            this.label_razonDesc.Text = "Obras en plena calle";
            // 
            // label_IDData
            // 
            this.label_IDData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_IDData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IDData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_IDData.Location = new System.Drawing.Point(143, 340);
            this.label_IDData.Name = "label_IDData";
            this.label_IDData.Size = new System.Drawing.Size(100, 23);
            this.label_IDData.TabIndex = 13;
            this.label_IDData.Text = "1";
            this.label_IDData.Click += new System.EventHandler(this.label_IDData_Click);
            // 
            // label_lugarData
            // 
            this.label_lugarData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_lugarData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lugarData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_lugarData.Location = new System.Drawing.Point(181, 388);
            this.label_lugarData.Name = "label_lugarData";
            this.label_lugarData.Size = new System.Drawing.Size(100, 23);
            this.label_lugarData.TabIndex = 14;
            this.label_lugarData.Text = "Calle X";
            this.label_lugarData.Click += new System.EventHandler(this.label_lugarData_Click);
            // 
            // label_latitudData
            // 
            this.label_latitudData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_latitudData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_latitudData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_latitudData.Location = new System.Drawing.Point(193, 437);
            this.label_latitudData.Name = "label_latitudData";
            this.label_latitudData.Size = new System.Drawing.Size(100, 23);
            this.label_latitudData.TabIndex = 15;
            this.label_latitudData.Text = "30.77237113";
            // 
            // label_longitudData
            // 
            this.label_longitudData.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_longitudData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_longitudData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_longitudData.Location = new System.Drawing.Point(213, 481);
            this.label_longitudData.Name = "label_longitudData";
            this.label_longitudData.Size = new System.Drawing.Size(100, 23);
            this.label_longitudData.TabIndex = 16;
            this.label_longitudData.Text = "-0.231213141412";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // datosIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(544, 753);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_longitudData);
            this.Controls.Add(this.label_latitudData);
            this.Controls.Add(this.label_lugarData);
            this.Controls.Add(this.label_IDData);
            this.Controls.Add(this.label_razonDesc);
            this.Controls.Add(this.label_razon);
            this.Controls.Add(this.label_longitud);
            this.Controls.Add(this.label_latitud);
            this.Controls.Add(this.label_lugar);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.btn_reportarIncidencia);
            this.Controls.Add(this.btn_AceptarIncidencia);
            this.Controls.Add(this.labelClienteIncidencia);
            this.Controls.Add(this.picture_incidencia);
            this.Controls.Add(this.label_datosInciencia);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "datosIncidencia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Incidencia";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.Load += new System.EventHandler(this.datosIncidencia_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picture_incidencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_incidencia;
        private System.Windows.Forms.Label labelClienteIncidencia;
        private System.Windows.Forms.Label label_datosInciencia;
        private System.Windows.Forms.Button btn_AceptarIncidencia;
        private System.Windows.Forms.Button btn_reportarIncidencia;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_lugar;
        private System.Windows.Forms.Label label_latitud;
        private System.Windows.Forms.Label label_longitud;
        private System.Windows.Forms.Label label_razon;
        private System.Windows.Forms.Label label_razonDesc;
        private System.Windows.Forms.Label label_IDData;
        private System.Windows.Forms.Label label_lugarData;
        private System.Windows.Forms.Label label_latitudData;
        private System.Windows.Forms.Label label_longitudData;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}