namespace Pantalla_Cliente
{
    partial class PuntoBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntoBanner));
            this.panel2 = new System.Windows.Forms.Panel();
            this.idPunto = new System.Windows.Forms.Label();
            this.nombrePunto = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnViewPunto = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.idPunto);
            this.panel2.Controls.Add(this.nombrePunto);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.btnViewPunto);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 67);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // idPunto
            // 
            this.idPunto.AutoSize = true;
            this.idPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idPunto.Location = new System.Drawing.Point(79, 10);
            this.idPunto.Name = "idPunto";
            this.idPunto.Size = new System.Drawing.Size(18, 13);
            this.idPunto.TabIndex = 21;
            this.idPunto.Text = "ID";
            this.idPunto.Click += new System.EventHandler(this.idPunto_Click);
            // 
            // nombrePunto
            // 
            this.nombrePunto.AutoSize = true;
            this.nombrePunto.ForeColor = System.Drawing.Color.White;
            this.nombrePunto.Location = new System.Drawing.Point(79, 28);
            this.nombrePunto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombrePunto.Name = "nombrePunto";
            this.nombrePunto.Size = new System.Drawing.Size(63, 13);
            this.nombrePunto.TabIndex = 20;
            this.nombrePunto.Text = "Nom_Punto";
            this.nombrePunto.Click += new System.EventHandler(this.nombrePunto_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(415, 10);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 49);
            this.button8.TabIndex = 13;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
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
            // btnViewPunto
            // 
            this.btnViewPunto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewPunto.Location = new System.Drawing.Point(334, 23);
            this.btnViewPunto.Name = "btnViewPunto";
            this.btnViewPunto.Size = new System.Drawing.Size(75, 23);
            this.btnViewPunto.TabIndex = 3;
            this.btnViewPunto.Text = "View";
            this.btnViewPunto.UseVisualStyleBackColor = true;
            this.btnViewPunto.Click += new System.EventHandler(this.btnViewPunto_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(315, 28);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // PuntoBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "PuntoBanner";
            this.Size = new System.Drawing.Size(450, 67);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label idPunto;
        private System.Windows.Forms.Label nombrePunto;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnViewPunto;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
