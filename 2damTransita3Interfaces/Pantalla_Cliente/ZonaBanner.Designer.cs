
namespace Pantalla_Cliente
{
    partial class ZonaBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZonaBanner));
            this.idZona = new System.Windows.Forms.Label();
            this.nombreZona = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnViewZona = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // idZona
            // 
            this.idZona.AutoSize = true;
            this.idZona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idZona.Location = new System.Drawing.Point(70, 9);
            this.idZona.Name = "idZona";
            this.idZona.Size = new System.Drawing.Size(18, 13);
            this.idZona.TabIndex = 27;
            this.idZona.Text = "ID";
            // 
            // nombreZona
            // 
            this.nombreZona.AutoSize = true;
            this.nombreZona.ForeColor = System.Drawing.Color.White;
            this.nombreZona.Location = new System.Drawing.Point(70, 27);
            this.nombreZona.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreZona.Name = "nombreZona";
            this.nombreZona.Size = new System.Drawing.Size(60, 13);
            this.nombreZona.TabIndex = 26;
            this.nombreZona.Text = "Nom_Zona";
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(406, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 49);
            this.button8.TabIndex = 25;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox4.InitialImage = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox4.Location = new System.Drawing.Point(15, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // btnViewZona
            // 
            this.btnViewZona.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewZona.Location = new System.Drawing.Point(325, 22);
            this.btnViewZona.Name = "btnViewZona";
            this.btnViewZona.Size = new System.Drawing.Size(75, 23);
            this.btnViewZona.TabIndex = 23;
            this.btnViewZona.Text = "View";
            this.btnViewZona.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(306, 27);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ZonaBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.idZona);
            this.Controls.Add(this.nombreZona);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnViewZona);
            this.Controls.Add(this.radioButton1);
            this.Name = "ZonaBanner";
            this.Size = new System.Drawing.Size(450, 67);
            this.Load += new System.EventHandler(this.ZonaBanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idZona;
        private System.Windows.Forms.Label nombreZona;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnViewZona;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
