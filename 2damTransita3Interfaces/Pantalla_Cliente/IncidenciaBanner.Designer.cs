
namespace Pantalla_Cliente
{
    partial class IncidenciaBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncidenciaBanner));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnViewIncidencia = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.idIncidencia = new System.Windows.Forms.Label();
            this.nombreIncidencia = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.idIncidencia);
            this.panel2.Controls.Add(this.nombreIncidencia);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.btnViewIncidencia);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 67);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(415, 10);
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
            // btnViewIncidencia
            // 
            this.btnViewIncidencia.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewIncidencia.Location = new System.Drawing.Point(334, 23);
            this.btnViewIncidencia.Name = "btnViewIncidencia";
            this.btnViewIncidencia.Size = new System.Drawing.Size(75, 23);
            this.btnViewIncidencia.TabIndex = 3;
            this.btnViewIncidencia.Text = "View";
            this.btnViewIncidencia.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(306, 28);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // idIncidencia
            // 
            this.idIncidencia.AutoSize = true;
            this.idIncidencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idIncidencia.Location = new System.Drawing.Point(79, 10);
            this.idIncidencia.Name = "idIncidencia";
            this.idIncidencia.Size = new System.Drawing.Size(18, 13);
            this.idIncidencia.TabIndex = 21;
            this.idIncidencia.Text = "ID";
            // 
            // nombreIncidencia
            // 
            this.nombreIncidencia.AutoSize = true;
            this.nombreIncidencia.ForeColor = System.Drawing.Color.White;
            this.nombreIncidencia.Location = new System.Drawing.Point(79, 28);
            this.nombreIncidencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreIncidencia.Name = "nombreIncidencia";
            this.nombreIncidencia.Size = new System.Drawing.Size(84, 13);
            this.nombreIncidencia.TabIndex = 20;
            this.nombreIncidencia.Text = "Nom_Incidencia";
            // 
            // IncidenciaBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "IncidenciaBanner";
            this.Size = new System.Drawing.Size(450, 67);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnViewIncidencia;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label idIncidencia;
        private System.Windows.Forms.Label nombreIncidencia;
    }
}
