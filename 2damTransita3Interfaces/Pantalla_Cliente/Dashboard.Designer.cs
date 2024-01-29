namespace Pantalla_Cliente
{
    partial class Transita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transita));
            this.panel1_central = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.panelDegradado2 = new System.Windows.Forms.Panel();
            this.panelDegradado1 = new System.Windows.Forms.Panel();
            this.pictureBoxImagenHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1_derecha = new System.Windows.Forms.Panel();
            this.panel1_central.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1_central
            // 
            this.panel1_central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel1_central.Controls.Add(this.panelHome);
            this.panel1_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_central.Location = new System.Drawing.Point(276, 0);
            this.panel1_central.Name = "panel1_central";
            this.panel1_central.Size = new System.Drawing.Size(545, 673);
            this.panel1_central.TabIndex = 35;
            // 
            // panelHome
            // 
            this.panelHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelHome.Controls.Add(this.panelDegradado2);
            this.panelHome.Controls.Add(this.panelDegradado1);
            this.panelHome.Controls.Add(this.pictureBoxImagenHome);
            this.panelHome.Location = new System.Drawing.Point(2, 4);
            this.panelHome.Margin = new System.Windows.Forms.Padding(2);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(552, 674);
            this.panelHome.TabIndex = 0;
            // 
            // panelDegradado2
            // 
            this.panelDegradado2.Location = new System.Drawing.Point(-2, 384);
            this.panelDegradado2.Name = "panelDegradado2";
            this.panelDegradado2.Size = new System.Drawing.Size(551, 250);
            this.panelDegradado2.TabIndex = 20;
            this.panelDegradado2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1Degradado_Paint);
            // 
            // panelDegradado1
            // 
            this.panelDegradado1.Location = new System.Drawing.Point(-2, 3);
            this.panelDegradado1.Name = "panelDegradado1";
            this.panelDegradado1.Size = new System.Drawing.Size(551, 250);
            this.panelDegradado1.TabIndex = 19;
            this.panelDegradado1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1Degradado_Paint);
            // 
            // pictureBoxImagenHome
            // 
            this.pictureBoxImagenHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxImagenHome.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxImagenHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImagenHome.Image")));
            this.pictureBoxImagenHome.Location = new System.Drawing.Point(-30, 246);
            this.pictureBoxImagenHome.Name = "pictureBoxImagenHome";
            this.pictureBoxImagenHome.Size = new System.Drawing.Size(580, 135);
            this.pictureBoxImagenHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImagenHome.TabIndex = 17;
            this.pictureBoxImagenHome.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_usuariosMunicipio);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_incidencias);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_mapa);
            this.panel1.Controls.Add(this.btn_puntos);
            this.panel1.Controls.Add(this.btn_cliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 673);
            this.panel1.TabIndex = 34;
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
            this.btn_usuariosMunicipio.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 407);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 144);
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
            this.btn_incidencias.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Controls.Add(this.btn_logout);
            this.panel7.Controls.Add(this.userName);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 588);
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
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
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
            this.btn_mapa.Click += new System.EventHandler(this.ToggleButton_Click);
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
            this.btn_puntos.Click += new System.EventHandler(this.ToggleButton_Click);
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
            this.btn_cliente.Click += new System.EventHandler(this.ToggleButton_Click);
            // 
            // panel1_derecha
            // 
            this.panel1_derecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel1_derecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1_derecha.Location = new System.Drawing.Point(821, 0);
            this.panel1_derecha.Name = "panel1_derecha";
            this.panel1_derecha.Size = new System.Drawing.Size(241, 673);
            this.panel1_derecha.TabIndex = 33;
            // 
            // Transita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1_central);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1_derecha);
            this.MaximumSize = new System.Drawing.Size(1080, 718);
            this.MinimumSize = new System.Drawing.Size(960, 449);
            this.Name = "Transita";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1_central.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_central;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_incidencias;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_mapa;
        private System.Windows.Forms.Button btn_puntos;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.PictureBox pictureBoxImagenHome;
        private System.Windows.Forms.Panel panelDegradado2;
        private System.Windows.Forms.Panel panelDegradado1;
        private System.Windows.Forms.Button btn_usuariosMunicipio;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel1_derecha;
    }
}