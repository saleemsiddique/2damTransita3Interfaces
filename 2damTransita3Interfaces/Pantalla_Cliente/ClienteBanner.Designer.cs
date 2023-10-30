namespace Pantalla_Cliente
{
    partial class ClienteBanner
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteBanner));
            this.panel2 = new System.Windows.Forms.Panel();
            this.idCliente = new System.Windows.Forms.Label();
            this.moreOption = new System.Windows.Forms.Button();
            this.favCliente = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnViewCliente = new System.Windows.Forms.Button();
            this.nombreCliente = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.idCliente);
            this.panel2.Controls.Add(this.moreOption);
            this.panel2.Controls.Add(this.favCliente);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnViewCliente);
            this.panel2.Controls.Add(this.nombreCliente);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 67);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // idCliente
            // 
            this.idCliente.AutoSize = true;
            this.idCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idCliente.Location = new System.Drawing.Point(74, 15);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(18, 13);
            this.idCliente.TabIndex = 19;
            this.idCliente.Text = "ID";
            this.idCliente.Click += new System.EventHandler(this.idCliente_Click);
            // 
            // moreOption
            // 
            this.moreOption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moreOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.moreOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.moreOption.Image = ((System.Drawing.Image)(resources.GetObject("moreOption.Image")));
            this.moreOption.Location = new System.Drawing.Point(401, 4);
            this.moreOption.Name = "moreOption";
            this.moreOption.Size = new System.Drawing.Size(30, 57);
            this.moreOption.TabIndex = 18;
            this.moreOption.UseVisualStyleBackColor = false;
            this.moreOption.Click += new System.EventHandler(this.moreOption_Click);
            // 
            // favCliente
            // 
            this.favCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.favCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.favCliente.Image = global::Pantalla_Cliente.Properties.Resources.estrellaNegra_fotor_bg_remover_2023102118503;
            this.favCliente.InitialImage = global::Pantalla_Cliente.Properties.Resources.estrellaAmarilla_fotor_bg_remover_20231021185036;
            this.favCliente.Location = new System.Drawing.Point(278, 21);
            this.favCliente.Name = "favCliente";
            this.favCliente.Size = new System.Drawing.Size(25, 25);
            this.favCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.favCliente.TabIndex = 17;
            this.favCliente.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox2.InitialImage = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox2.Location = new System.Drawing.Point(20, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnViewCliente
            // 
            this.btnViewCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewCliente.Location = new System.Drawing.Point(320, 23);
            this.btnViewCliente.Name = "btnViewCliente";
            this.btnViewCliente.Size = new System.Drawing.Size(75, 23);
            this.btnViewCliente.TabIndex = 3;
            this.btnViewCliente.Text = "View";
            this.btnViewCliente.UseVisualStyleBackColor = true;
            // 
            // nombreCliente
            // 
            this.nombreCliente.AutoSize = true;
            this.nombreCliente.ForeColor = System.Drawing.Color.White;
            this.nombreCliente.Location = new System.Drawing.Point(74, 33);
            this.nombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(67, 13);
            this.nombreCliente.TabIndex = 1;
            this.nombreCliente.Text = "Nom_Cliente";
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
            // 
            // ClienteBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ClienteBanner";
            this.Size = new System.Drawing.Size(450, 67);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.favCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button moreOption;
        private System.Windows.Forms.PictureBox favCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewCliente;
        private System.Windows.Forms.Label nombreCliente;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label idCliente;
    }
}
