
namespace Pantalla_Cliente
{
    partial class MapaPantalla
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapaPantalla));
            this.toolTipCrearPuntoButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMapCenter = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.atrasBtn = new System.Windows.Forms.Label();
            this.adelanteBtn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxIncidencias = new System.Windows.Forms.ListBox();
            this.btn_crearPunto = new System.Windows.Forms.Button();
            this.btnCrearIncidencia = new System.Windows.Forms.Button();
            this.panel_central = new System.Windows.Forms.Panel();
            this.btn_resetPointer = new System.Windows.Forms.Button();
            this.panel_derecha = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_usuariosMunicipio = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_incidencias = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_mapa = new System.Windows.Forms.Button();
            this.btn_puntos = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_central.SuspendLayout();
            this.panel_derecha.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipCrearPuntoButton
            // 
            this.toolTipCrearPuntoButton.ForeColor = System.Drawing.Color.Lavender;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(325, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mapa Transita";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // atrasBtn
            // 
            this.atrasBtn.BackColor = System.Drawing.Color.Transparent;
            this.atrasBtn.Location = new System.Drawing.Point(45, 598);
            this.atrasBtn.Name = "atrasBtn";
            this.atrasBtn.Size = new System.Drawing.Size(50, 50);
            this.atrasBtn.TabIndex = 39;
            // 
            // adelanteBtn
            // 
            this.adelanteBtn.BackColor = System.Drawing.Color.Transparent;
            this.adelanteBtn.Location = new System.Drawing.Point(438, 598);
            this.adelanteBtn.Name = "adelanteBtn";
            this.adelanteBtn.Size = new System.Drawing.Size(50, 50);
            this.adelanteBtn.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_resetPointer);
            this.panel1.Location = new System.Drawing.Point(19, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 570);
            this.panel1.TabIndex = 41;
            // 
            // listBoxIncidencias
            // 
            this.listBoxIncidencias.FormattingEnabled = true;
            this.listBoxIncidencias.Location = new System.Drawing.Point(6, 85);
            this.listBoxIncidencias.Name = "listBoxIncidencias";
            this.listBoxIncidencias.Size = new System.Drawing.Size(223, 563);
            this.listBoxIncidencias.TabIndex = 42;
            // 
            // btn_crearPunto
            // 
            this.btn_crearPunto.Enabled = false;
            this.btn_crearPunto.Location = new System.Drawing.Point(19, 59);
            this.btn_crearPunto.Name = "btn_crearPunto";
            this.btn_crearPunto.Size = new System.Drawing.Size(75, 23);
            this.btn_crearPunto.TabIndex = 43;
            this.btn_crearPunto.Text = "Crear Punto";
            this.btn_crearPunto.UseVisualStyleBackColor = true;
            this.btn_crearPunto.Click += new System.EventHandler(this.btn_crearPunto_Click);
            // 
            // btnCrearIncidencia
            // 
            this.btnCrearIncidencia.Enabled = false;
            this.btnCrearIncidencia.Location = new System.Drawing.Point(100, 59);
            this.btnCrearIncidencia.Name = "btnCrearIncidencia";
            this.btnCrearIncidencia.Size = new System.Drawing.Size(107, 23);
            this.btnCrearIncidencia.TabIndex = 44;
            this.btnCrearIncidencia.Text = "Crear Incidencia";
            this.btnCrearIncidencia.UseVisualStyleBackColor = true;
            this.btnCrearIncidencia.Click += new System.EventHandler(this.btnCrearIncidencia_Click);
            // 
            // panel_central
            // 
            this.panel_central.AutoScroll = true;
            this.panel_central.AutoSize = true;
            this.panel_central.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel_central.Controls.Add(this.btnCrearIncidencia);
            this.panel_central.Controls.Add(this.btn_crearPunto);
            this.panel_central.Controls.Add(this.panel1);
            this.panel_central.Controls.Add(this.adelanteBtn);
            this.panel_central.Controls.Add(this.atrasBtn);
            this.panel_central.Controls.Add(this.label2);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(0, 0);
            this.panel_central.MinimumSize = new System.Drawing.Size(793, 0);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(1064, 681);
            this.panel_central.TabIndex = 30;
            this.panel_central.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // btn_resetPointer
            // 
            this.btn_resetPointer.Image = ((System.Drawing.Image)(resources.GetObject("btn_resetPointer.Image")));
            this.btn_resetPointer.Location = new System.Drawing.Point(485, 510);
            this.btn_resetPointer.Name = "btn_resetPointer";
            this.btn_resetPointer.Size = new System.Drawing.Size(32, 34);
            this.btn_resetPointer.TabIndex = 42;
            this.btn_resetPointer.UseVisualStyleBackColor = true;
            this.btn_resetPointer.Click += new System.EventHandler(this.btn_resetPointer_Click);
            // 
            // panel_derecha
            // 
            this.panel_derecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel_derecha.Controls.Add(this.listBoxIncidencias);
            this.panel_derecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_derecha.Location = new System.Drawing.Point(823, 0);
            this.panel_derecha.Name = "panel_derecha";
            this.panel_derecha.Size = new System.Drawing.Size(241, 681);
            this.panel_derecha.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.btn_usuariosMunicipio);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_incidencias);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_mapa);
            this.panel2.Controls.Add(this.btn_puntos);
            this.panel2.Controls.Add(this.btn_cliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 681);
            this.panel2.TabIndex = 44;
            // 
            // btn_usuariosMunicipio
            // 
            this.btn_usuariosMunicipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btn_usuariosMunicipio.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_usuariosMunicipio.FlatAppearance.BorderSize = 0;
            this.btn_usuariosMunicipio.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_usuariosMunicipio.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_usuariosMunicipio.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_usuariosMunicipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuariosMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usuariosMunicipio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_usuariosMunicipio.Location = new System.Drawing.Point(0, 273);
            this.btn_usuariosMunicipio.Name = "btn_usuariosMunicipio";
            this.btn_usuariosMunicipio.Size = new System.Drawing.Size(278, 57);
            this.btn_usuariosMunicipio.TabIndex = 17;
            this.btn_usuariosMunicipio.Text = "      &Usuarios Municipio";
            this.btn_usuariosMunicipio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_usuariosMunicipio.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // btn_incidencias
            // 
            this.btn_incidencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btn_incidencias.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incidencias.FlatAppearance.BorderSize = 0;
            this.btn_incidencias.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incidencias.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incidencias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incidencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_incidencias.Location = new System.Drawing.Point(0, 108);
            this.btn_incidencias.Name = "btn_incidencias";
            this.btn_incidencias.Size = new System.Drawing.Size(278, 57);
            this.btn_incidencias.TabIndex = 15;
            this.btn_incidencias.Text = "      &Incidencias";
            this.btn_incidencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_incidencias.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Controls.Add(this.btn_logout);
            this.panel7.Controls.Add(this.userName);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 596);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(276, 85);
            this.panel7.TabIndex = 14;
            // 
            // btn_logout
            // 
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(219, 26);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(38, 37);
            this.btn_logout.TabIndex = 11;
            this.btn_logout.UseVisualStyleBackColor = true;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userName.FlatAppearance.BorderSize = 0;
            this.userName.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userName.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userName.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.Location = new System.Drawing.Point(73, 22);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(119, 42);
            this.userName.TabIndex = 9;
            this.userName.Text = "User";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userName.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(220, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Transita";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-1, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 1);
            this.label5.TabIndex = 11;
            // 
            // btn_mapa
            // 
            this.btn_mapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btn_mapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mapa.FlatAppearance.BorderSize = 0;
            this.btn_mapa.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mapa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mapa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mapa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mapa.Location = new System.Drawing.Point(0, 218);
            this.btn_mapa.Name = "btn_mapa";
            this.btn_mapa.Size = new System.Drawing.Size(278, 57);
            this.btn_mapa.TabIndex = 4;
            this.btn_mapa.Text = "      &Mapas";
            this.btn_mapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mapa.UseVisualStyleBackColor = false;
            // 
            // btn_puntos
            // 
            this.btn_puntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btn_puntos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_puntos.FlatAppearance.BorderSize = 0;
            this.btn_puntos.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_puntos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_puntos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_puntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_puntos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_puntos.Location = new System.Drawing.Point(0, 163);
            this.btn_puntos.Name = "btn_puntos";
            this.btn_puntos.Size = new System.Drawing.Size(278, 57);
            this.btn_puntos.TabIndex = 3;
            this.btn_puntos.Text = "      &Puntos";
            this.btn_puntos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_puntos.UseVisualStyleBackColor = false;
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btn_cliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cliente.Location = new System.Drawing.Point(0, 53);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(278, 57);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.Text = "      &Cliente";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.UseVisualStyleBackColor = false;
            // 
            // MapaPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_derecha);
            this.Controls.Add(this.panel_central);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(960, 450);
            this.Name = "MapaPantalla";
            this.Text = "MapaPantalla";
            this.panel1.ResumeLayout(false);
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.panel_derecha.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipCrearPuntoButton;
        private System.Windows.Forms.ToolTip toolTipMapCenter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label atrasBtn;
        private System.Windows.Forms.Label adelanteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_resetPointer;
        private System.Windows.Forms.ListBox listBoxIncidencias;
        private System.Windows.Forms.Button btn_crearPunto;
        private System.Windows.Forms.Button btnCrearIncidencia;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.Panel panel_derecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_usuariosMunicipio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_incidencias;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_mapa;
        private System.Windows.Forms.Button btn_puntos;
        private System.Windows.Forms.Button btn_cliente;
    }
}