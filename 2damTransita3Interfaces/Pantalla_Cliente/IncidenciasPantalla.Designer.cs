
namespace Pantalla_Cliente
{
    partial class Incidencias_Pantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incidencias_Pantalla));
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fecha_mostrar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.estado_mostrar = new System.Windows.Forms.TextBox();
            this.descripcion_mostrar = new System.Windows.Forms.TextBox();
            this.id_mostrar = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.correo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgTransita = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.botonVerDatosIncidencia = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonAddCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1030, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 1);
            this.label4.TabIndex = 10;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fecha_mostrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.estado_mostrar);
            this.groupBox1.Controls.Add(this.descripcion_mostrar);
            this.groupBox1.Controls.Add(this.id_mostrar);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 206);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // fecha_mostrar
            // 
            this.fecha_mostrar.Enabled = false;
            this.fecha_mostrar.Location = new System.Drawing.Point(9, 126);
            this.fecha_mostrar.Name = "fecha_mostrar";
            this.fecha_mostrar.Size = new System.Drawing.Size(100, 20);
            this.fecha_mostrar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de Incidencia:";
            // 
            // estado_mostrar
            // 
            this.estado_mostrar.Enabled = false;
            this.estado_mostrar.Location = new System.Drawing.Point(9, 180);
            this.estado_mostrar.Name = "estado_mostrar";
            this.estado_mostrar.Size = new System.Drawing.Size(100, 20);
            this.estado_mostrar.TabIndex = 6;
            // 
            // descripcion_mostrar
            // 
            this.descripcion_mostrar.Enabled = false;
            this.descripcion_mostrar.Location = new System.Drawing.Point(9, 68);
            this.descripcion_mostrar.Name = "descripcion_mostrar";
            this.descripcion_mostrar.Size = new System.Drawing.Size(100, 20);
            this.descripcion_mostrar.TabIndex = 5;
            // 
            // id_mostrar
            // 
            this.id_mostrar.Enabled = false;
            this.id_mostrar.Location = new System.Drawing.Point(9, 19);
            this.id_mostrar.Name = "id_mostrar";
            this.id_mostrar.Size = new System.Drawing.Size(100, 20);
            this.id_mostrar.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 164);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Estado:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(6, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Descripcion de Incidencia:";
            // 
            // correo
            // 
            this.correo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.correo.AutoSize = true;
            this.correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.correo.ForeColor = System.Drawing.Color.DarkGray;
            this.correo.Location = new System.Drawing.Point(92, 267);
            this.correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(50, 13);
            this.correo.TabIndex = 25;
            this.correo.Text = "@Cliente";
            this.correo.Click += new System.EventHandler(this.label11_Click);
            // 
            // nombre
            // 
            this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(58, 232);
            this.nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(123, 20);
            this.nombre.TabIndex = 23;
            this.nombre.Text = "Nom_Incidencia";
            this.nombre.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.pictureBox12);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.nombre);
            this.panel3.Controls.Add(this.correo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(833, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 681);
            this.panel3.TabIndex = 27;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.pictureBox12.Image = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox12.InitialImage = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox12.Location = new System.Drawing.Point(51, 104);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(130, 112);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 24;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cliente.Location = new System.Drawing.Point(20, 75);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(142, 23);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(20, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Incidencias";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(20, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(255, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Zonas";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(20, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Puntos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(20, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 36);
            this.button5.TabIndex = 4;
            this.button5.Text = "Mapas";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(73, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 42);
            this.button6.TabIndex = 9;
            this.button6.Text = "User";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(-1, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 1);
            this.label5.TabIndex = 11;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.imgTransita);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_cliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 681);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 594);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 85);
            this.panel5.TabIndex = 14;
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(213, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // imgTransita
            // 
            this.imgTransita.Image = ((System.Drawing.Image)(resources.GetObject("imgTransita.Image")));
            this.imgTransita.Location = new System.Drawing.Point(30, 308);
            this.imgTransita.Name = "imgTransita";
            this.imgTransita.Size = new System.Drawing.Size(223, 184);
            this.imgTransita.TabIndex = 5;
            this.imgTransita.Click += new System.EventHandler(this.imgTransita_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.AutoSize = true;
            this.btn_filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_filtrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_filtrar.Image")));
            this.btn_filtrar.Location = new System.Drawing.Point(947, 88);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(42, 36);
            this.btn_filtrar.TabIndex = 15;
            this.btn_filtrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(885, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Incidencias Transita";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.botonVerDatosIncidencia);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(51, 213);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 67);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(460, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 49);
            this.button8.TabIndex = 13;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox4.InitialImage = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox4.Location = new System.Drawing.Point(24, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // botonVerDatosIncidencia
            // 
            this.botonVerDatosIncidencia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.botonVerDatosIncidencia.Location = new System.Drawing.Point(379, 23);
            this.botonVerDatosIncidencia.Name = "botonVerDatosIncidencia";
            this.botonVerDatosIncidencia.Size = new System.Drawing.Size(75, 23);
            this.botonVerDatosIncidencia.TabIndex = 3;
            this.botonVerDatosIncidencia.Text = "View";
            this.botonVerDatosIncidencia.UseVisualStyleBackColor = true;
            this.botonVerDatosIncidencia.Click += new System.EventHandler(this.botonVerDatosIncidencia_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(351, 28);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Incidencia";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(336, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.buscarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buscarTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buscarTextBox.Location = new System.Drawing.Point(392, 92);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.buscarTextBox.Size = new System.Drawing.Size(178, 20);
            this.buscarTextBox.TabIndex = 29;
            this.buscarTextBox.Text = "Buscar";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.buttonAddCliente);
            this.panel4.Controls.Add(this.buscarTextBox);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(231, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 681);
            this.panel4.TabIndex = 28;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(39, 152);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Añadir Incidencia";
            // 
            // buttonAddCliente
            // 
            this.buttonAddCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.buttonAddCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddCliente.Location = new System.Drawing.Point(160, 144);
            this.buttonAddCliente.Name = "buttonAddCliente";
            this.buttonAddCliente.Size = new System.Drawing.Size(30, 30);
            this.buttonAddCliente.TabIndex = 30;
            this.buttonAddCliente.Text = "+";
            this.buttonAddCliente.UseVisualStyleBackColor = false;
            // 
            // Incidencias_Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(960, 450);
            this.Name = "Incidencias_Pantalla";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transita";
            this.Load += new System.EventHandler(this.Incidencias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_filtrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.TextBox estado_mostrar;
        private System.Windows.Forms.TextBox descripcion_mostrar;
        private System.Windows.Forms.TextBox id_mostrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label imgTransita;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox fecha_mostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button botonVerDatosIncidencia;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonAddCliente;
    }
}