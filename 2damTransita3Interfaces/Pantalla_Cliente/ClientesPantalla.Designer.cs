
namespace Pantalla_Cliente
{
    partial class Cliente_Pantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente_Pantalla));
            this.label15 = new System.Windows.Forms.Label();
            this.btnGenerarpdf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_incidencias = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_mapa = new System.Windows.Forms.Button();
            this.btn_puntos = new System.Windows.Forms.Button();
            this.btn_zonas = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.panel_central = new System.Windows.Forms.Panel();
            this.label_tipoclientes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.estadoDesactivado = new System.Windows.Forms.CheckBox();
            this.estadoActivo = new System.Windows.Forms.CheckBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.paginaDropDown = new System.Windows.Forms.ComboBox();
            this.paginas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.clientesLabel = new System.Windows.Forms.Label();
            this.fondoGrisMid = new System.Windows.Forms.Label();
            this.adelanteBtn = new System.Windows.Forms.Label();
            this.atrasBtn = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.filtroClientes_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imgTransita = new System.Windows.Forms.Label();
            this.btn_verFavoritos = new System.Windows.Forms.Button();
            this.correo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_mostrar = new System.Windows.Forms.TextBox();
            this.nombre_mostrar = new System.Windows.Forms.TextBox();
            this.apellidos_mostrar = new System.Windows.Forms.TextBox();
            this.email_mostrar = new System.Windows.Forms.TextBox();
            this.clienteImg = new System.Windows.Forms.PictureBox();
            this.panel_derecha = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_central.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelClientes.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteImg)).BeginInit();
            this.panel_derecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(1275, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(276, 1);
            this.label15.TabIndex = 24;
            // 
            // btnGenerarpdf
            // 
            this.btnGenerarpdf.Location = new System.Drawing.Point(343, 150);
            this.btnGenerarpdf.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerarpdf.Name = "btnGenerarpdf";
            this.btnGenerarpdf.Size = new System.Drawing.Size(126, 19);
            this.btnGenerarpdf.TabIndex = 42;
            this.btnGenerarpdf.Text = "Generar pdf cliente";
            this.btnGenerarpdf.UseVisualStyleBackColor = true;
            this.btnGenerarpdf.Click += new System.EventHandler(this.btnGenerarpdf_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.btn_incidencias);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.imgTransita);
            this.panel1.Controls.Add(this.btn_mapa);
            this.panel1.Controls.Add(this.btn_puntos);
            this.panel1.Controls.Add(this.btn_zonas);
            this.panel1.Controls.Add(this.btn_cliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 673);
            this.panel1.TabIndex = 30;
            // 
            // btn_incidencias
            // 
            this.btn_incidencias.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incidencias.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incidencias.FlatAppearance.BorderSize = 0;
            this.btn_incidencias.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incidencias.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incidencias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_incidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_incidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_incidencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_incidencias.Location = new System.Drawing.Point(33, 116);
            this.btn_incidencias.Name = "btn_incidencias";
            this.btn_incidencias.Size = new System.Drawing.Size(245, 53);
            this.btn_incidencias.TabIndex = 15;
            this.btn_incidencias.Text = "Incidencias";
            this.btn_incidencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_incidencias.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Controls.Add(this.button6);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 588);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(276, 85);
            this.panel7.TabIndex = 14;
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
            this.btn_mapa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mapa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mapa.FlatAppearance.BorderSize = 0;
            this.btn_mapa.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mapa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mapa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mapa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_mapa.Location = new System.Drawing.Point(32, 280);
            this.btn_mapa.Name = "btn_mapa";
            this.btn_mapa.Size = new System.Drawing.Size(246, 53);
            this.btn_mapa.TabIndex = 4;
            this.btn_mapa.Text = "Mapas";
            this.btn_mapa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mapa.UseVisualStyleBackColor = false;
            // 
            // btn_puntos
            // 
            this.btn_puntos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_puntos.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_puntos.FlatAppearance.BorderSize = 0;
            this.btn_puntos.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_puntos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_puntos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_puntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_puntos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_puntos.Location = new System.Drawing.Point(33, 227);
            this.btn_puntos.Name = "btn_puntos";
            this.btn_puntos.Size = new System.Drawing.Size(245, 53);
            this.btn_puntos.TabIndex = 3;
            this.btn_puntos.Text = "Puntos";
            this.btn_puntos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_puntos.UseVisualStyleBackColor = false;
            // 
            // btn_zonas
            // 
            this.btn_zonas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_zonas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_zonas.FlatAppearance.BorderSize = 0;
            this.btn_zonas.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_zonas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_zonas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_zonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_zonas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_zonas.Location = new System.Drawing.Point(33, 175);
            this.btn_zonas.Name = "btn_zonas";
            this.btn_zonas.Size = new System.Drawing.Size(245, 53);
            this.btn_zonas.TabIndex = 2;
            this.btn_zonas.Text = "Zonas";
            this.btn_zonas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_zonas.UseVisualStyleBackColor = false;
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cliente.Enabled = false;
            this.btn_cliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cliente.Location = new System.Drawing.Point(33, 57);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(245, 53);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.UseVisualStyleBackColor = false;
            // 
            // panel_central
            // 
            this.panel_central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel_central.Controls.Add(this.adelanteBtn);
            this.panel_central.Controls.Add(this.atrasBtn);
            this.panel_central.Controls.Add(this.label_tipoclientes);
            this.panel_central.Controls.Add(this.groupBox1);
            this.panel_central.Controls.Add(this.panelClientes);
            this.panel_central.Controls.Add(this.buscarTextBox);
            this.panel_central.Controls.Add(this.filtroClientes_btn);
            this.panel_central.Controls.Add(this.clientesLabel);
            this.panel_central.Controls.Add(this.btnGenerarpdf);
            this.panel_central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_central.Location = new System.Drawing.Point(276, 0);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(557, 673);
            this.panel_central.TabIndex = 32;
            // 
            // label_tipoclientes
            // 
            this.label_tipoclientes.AutoSize = true;
            this.label_tipoclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tipoclientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_tipoclientes.Location = new System.Drawing.Point(29, 128);
            this.label_tipoclientes.Name = "label_tipoclientes";
            this.label_tipoclientes.Size = new System.Drawing.Size(208, 25);
            this.label_tipoclientes.TabIndex = 35;
            this.label_tipoclientes.Text = "Todos los Clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.estadoDesactivado);
            this.groupBox1.Controls.Add(this.estadoActivo);
            this.groupBox1.Controls.Add(this.buttonAceptar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(302, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 128);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            this.groupBox1.Visible = false;
            // 
            // estadoDesactivado
            // 
            this.estadoDesactivado.AutoSize = true;
            this.estadoDesactivado.Location = new System.Drawing.Point(25, 56);
            this.estadoDesactivado.Name = "estadoDesactivado";
            this.estadoDesactivado.Size = new System.Drawing.Size(86, 17);
            this.estadoDesactivado.TabIndex = 8;
            this.estadoDesactivado.Text = "Desactivado";
            this.estadoDesactivado.UseVisualStyleBackColor = true;
            this.estadoDesactivado.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // estadoActivo
            // 
            this.estadoActivo.AutoSize = true;
            this.estadoActivo.Location = new System.Drawing.Point(25, 24);
            this.estadoActivo.Name = "estadoActivo";
            this.estadoActivo.Size = new System.Drawing.Size(68, 17);
            this.estadoActivo.TabIndex = 7;
            this.estadoActivo.Text = "Activado";
            this.estadoActivo.UseVisualStyleBackColor = true;
            this.estadoActivo.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAceptar.Location = new System.Drawing.Point(29, 87);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 4;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // panelClientes
            // 
            this.panelClientes.AutoScroll = true;
            this.panelClientes.Controls.Add(this.paginaDropDown);
            this.panelClientes.Controls.Add(this.paginas);
            this.panelClientes.Controls.Add(this.panel2);
            this.panelClientes.Location = new System.Drawing.Point(36, 182);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(495, 413);
            this.panelClientes.TabIndex = 33;
            // 
            // paginaDropDown
            // 
            this.paginaDropDown.FormattingEnabled = true;
            this.paginaDropDown.Location = new System.Drawing.Point(168, 384);
            this.paginaDropDown.Name = "paginaDropDown";
            this.paginaDropDown.Size = new System.Drawing.Size(49, 21);
            this.paginaDropDown.TabIndex = 41;
            this.paginaDropDown.SelectedIndexChanged += new System.EventHandler(this.paginaDropDown_SelectedIndexChanged);
            // 
            // paginas
            // 
            this.paginas.ForeColor = System.Drawing.Color.White;
            this.paginas.Location = new System.Drawing.Point(219, 386);
            this.paginas.Name = "paginas";
            this.paginas.Size = new System.Drawing.Size(100, 20);
            this.paginas.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(2, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 67);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button7.Location = new System.Drawing.Point(320, 23);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 3;
            this.button7.Text = "View";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom_Cliente";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.ForeColor = System.Drawing.Color.Transparent;
            this.radioButton1.Location = new System.Drawing.Point(364, 28);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.buscarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.buscarTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.buscarTextBox.Location = new System.Drawing.Point(340, 76);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.buscarTextBox.Size = new System.Drawing.Size(178, 20);
            this.buscarTextBox.TabIndex = 28;
            this.buscarTextBox.Text = "Buscar";
            this.buscarTextBox.Enter += new System.EventHandler(this.buscarTextBox_Click);
            this.buscarTextBox.Leave += new System.EventHandler(this.buscarTextBox_Leave_1);
            this.buscarTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.buscarTextBox_PreviewKeyDown);
            // 
            // clientesLabel
            // 
            this.clientesLabel.AutoSize = true;
            this.clientesLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.clientesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientesLabel.Location = new System.Drawing.Point(188, 18);
            this.clientesLabel.Name = "clientesLabel";
            this.clientesLabel.Size = new System.Drawing.Size(191, 25);
            this.clientesLabel.TabIndex = 19;
            this.clientesLabel.Text = "Clientes Transita";
            // 
            // fondoGrisMid
            // 
            this.fondoGrisMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fondoGrisMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondoGrisMid.Location = new System.Drawing.Point(0, 0);
            this.fondoGrisMid.Name = "fondoGrisMid";
            this.fondoGrisMid.Size = new System.Drawing.Size(1064, 673);
            this.fondoGrisMid.TabIndex = 9;
            // 
            // adelanteBtn
            // 
            this.adelanteBtn.BackColor = System.Drawing.Color.Transparent;
            this.adelanteBtn.Image = global::Transita3.Properties.Resources.delante;
            this.adelanteBtn.Location = new System.Drawing.Point(438, 598);
            this.adelanteBtn.Name = "adelanteBtn";
            this.adelanteBtn.Size = new System.Drawing.Size(50, 50);
            this.adelanteBtn.TabIndex = 40;
            this.adelanteBtn.Click += new System.EventHandler(this.adelanteBtn_Click);
            // 
            // atrasBtn
            // 
            this.atrasBtn.BackColor = System.Drawing.Color.Transparent;
            this.atrasBtn.Image = global::Transita3.Properties.Resources.atras;
            this.atrasBtn.Location = new System.Drawing.Point(45, 598);
            this.atrasBtn.Name = "atrasBtn";
            this.atrasBtn.Size = new System.Drawing.Size(50, 50);
            this.atrasBtn.TabIndex = 39;
            this.atrasBtn.Click += new System.EventHandler(this.atrasBtn_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(401, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 57);
            this.button8.TabIndex = 18;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(278, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(20, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // filtroClientes_btn
            // 
            this.filtroClientes_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtroClientes_btn.AutoSize = true;
            this.filtroClientes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filtroClientes_btn.Image = ((System.Drawing.Image)(resources.GetObject("filtroClientes_btn.Image")));
            this.filtroClientes_btn.Location = new System.Drawing.Point(271, 74);
            this.filtroClientes_btn.Name = "filtroClientes_btn";
            this.filtroClientes_btn.Size = new System.Drawing.Size(36, 36);
            this.filtroClientes_btn.TabIndex = 22;
            this.filtroClientes_btn.UseVisualStyleBackColor = false;
            this.filtroClientes_btn.Click += new System.EventHandler(this.filtroClientes_btn_Click);
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
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(213, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // imgTransita
            // 
            this.imgTransita.Image = ((System.Drawing.Image)(resources.GetObject("imgTransita.Image")));
            this.imgTransita.Location = new System.Drawing.Point(30, 358);
            this.imgTransita.Name = "imgTransita";
            this.imgTransita.Size = new System.Drawing.Size(223, 184);
            this.imgTransita.TabIndex = 5;
            // 
            // btn_verFavoritos
            // 
            this.btn_verFavoritos.Image = global::Transita3.Properties.Resources.estrellaFav;
            this.btn_verFavoritos.Location = new System.Drawing.Point(91, 588);
            this.btn_verFavoritos.Name = "btn_verFavoritos";
            this.btn_verFavoritos.Size = new System.Drawing.Size(39, 36);
            this.btn_verFavoritos.TabIndex = 27;
            this.btn_verFavoritos.UseVisualStyleBackColor = true;
            this.btn_verFavoritos.Click += new System.EventHandler(this.button1_Click);
            // 
            // correo
            // 
            this.correo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.correo.AutoSize = true;
            this.correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.correo.ForeColor = System.Drawing.Color.DarkGray;
            this.correo.Location = new System.Drawing.Point(67, 267);
            this.correo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(50, 13);
            this.correo.TabIndex = 25;
            this.correo.Text = "@Cliente";
            // 
            // nombre
            // 
            this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nombre.AutoSize = true;
            this.nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.White;
            this.nombre.Location = new System.Drawing.Point(66, 234);
            this.nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 23;
            this.nombre.Text = "Nom_Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.email_mostrar);
            this.groupBox2.Controls.Add(this.apellidos_mostrar);
            this.groupBox2.Controls.Add(this.nombre_mostrar);
            this.groupBox2.Controls.Add(this.id_mostrar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(29, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 206);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Primer nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // id_mostrar
            // 
            this.id_mostrar.Enabled = false;
            this.id_mostrar.Location = new System.Drawing.Point(9, 19);
            this.id_mostrar.Name = "id_mostrar";
            this.id_mostrar.Size = new System.Drawing.Size(100, 20);
            this.id_mostrar.TabIndex = 3;
            // 
            // nombre_mostrar
            // 
            this.nombre_mostrar.Enabled = false;
            this.nombre_mostrar.Location = new System.Drawing.Point(9, 68);
            this.nombre_mostrar.Name = "nombre_mostrar";
            this.nombre_mostrar.Size = new System.Drawing.Size(100, 20);
            this.nombre_mostrar.TabIndex = 4;
            // 
            // apellidos_mostrar
            // 
            this.apellidos_mostrar.Enabled = false;
            this.apellidos_mostrar.Location = new System.Drawing.Point(9, 124);
            this.apellidos_mostrar.Name = "apellidos_mostrar";
            this.apellidos_mostrar.Size = new System.Drawing.Size(100, 20);
            this.apellidos_mostrar.TabIndex = 5;
            // 
            // email_mostrar
            // 
            this.email_mostrar.Enabled = false;
            this.email_mostrar.Location = new System.Drawing.Point(9, 180);
            this.email_mostrar.Name = "email_mostrar";
            this.email_mostrar.Size = new System.Drawing.Size(100, 20);
            this.email_mostrar.TabIndex = 6;
            // 
            // clienteImg
            // 
            this.clienteImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clienteImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.clienteImg.Location = new System.Drawing.Point(51, 104);
            this.clienteImg.Name = "clienteImg";
            this.clienteImg.Size = new System.Drawing.Size(130, 112);
            this.clienteImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clienteImg.TabIndex = 24;
            this.clienteImg.TabStop = false;
            // 
            // panel_derecha
            // 
            this.panel_derecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel_derecha.Controls.Add(this.btn_verFavoritos);
            this.panel_derecha.Controls.Add(this.clienteImg);
            this.panel_derecha.Controls.Add(this.groupBox2);
            this.panel_derecha.Controls.Add(this.nombre);
            this.panel_derecha.Controls.Add(this.correo);
            this.panel_derecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_derecha.Location = new System.Drawing.Point(833, 0);
            this.panel_derecha.Name = "panel_derecha";
            this.panel_derecha.Size = new System.Drawing.Size(231, 673);
            this.panel_derecha.TabIndex = 28;
            // 
            // Cliente_Pantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1064, 673);
            this.Controls.Add(this.panel_central);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_derecha);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.fondoGrisMid);
            this.MaximumSize = new System.Drawing.Size(1280, 718);
            this.MinimumSize = new System.Drawing.Size(960, 449);
            this.Name = "Cliente_Pantalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transita";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelClientes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteImg)).EndInit();
            this.panel_derecha.ResumeLayout(false);
            this.panel_derecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label imgTransita;
        private System.Windows.Forms.Button btn_mapa;
        private System.Windows.Forms.Button btn_puntos;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.Label fondoGrisMid;
        private System.Windows.Forms.Button btn_incidencias;
        private System.Windows.Forms.Button btn_zonas;
        private System.Windows.Forms.Button filtroClientes_btn;
        private System.Windows.Forms.Label clientesLabel;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panelClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label label_tipoclientes;
        private System.Windows.Forms.CheckBox estadoDesactivado;
        private System.Windows.Forms.CheckBox estadoActivo;
        private System.Windows.Forms.Label adelanteBtn;
        private System.Windows.Forms.Label atrasBtn;
        private System.Windows.Forms.Label paginas;
        private System.Windows.Forms.ComboBox paginaDropDown;
        private System.Windows.Forms.Button btnGenerarpdf;
        private System.Windows.Forms.Button btn_verFavoritos;
        private System.Windows.Forms.Label correo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox email_mostrar;
        private System.Windows.Forms.TextBox apellidos_mostrar;
        private System.Windows.Forms.TextBox nombre_mostrar;
        private System.Windows.Forms.TextBox id_mostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox clienteImg;
        private System.Windows.Forms.Panel panel_derecha;
    }
}

