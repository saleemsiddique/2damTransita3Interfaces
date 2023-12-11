
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
            this.idIncidencia = new System.Windows.Forms.Label();
            this.nombreIncidencia = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.incidencia_img = new System.Windows.Forms.PictureBox();
            this.btnViewIncidencia = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidencia_img)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.idIncidencia);
            this.panel2.Controls.Add(this.nombreIncidencia);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.incidencia_img);
            this.panel2.Controls.Add(this.btnViewIncidencia);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 67);
            this.panel2.TabIndex = 17;
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
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // incidencia_img
            // 
            this.incidencia_img.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.incidencia_img.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.incidencia_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incidencia_img.Image = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.incidencia_img.InitialImage = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.incidencia_img.Location = new System.Drawing.Point(24, 15);
            this.incidencia_img.Name = "incidencia_img";
            this.incidencia_img.Size = new System.Drawing.Size(40, 40);
            this.incidencia_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.incidencia_img.TabIndex = 11;
            this.incidencia_img.TabStop = false;
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
            this.btnViewIncidencia.Click += new System.EventHandler(this.btnViewIncidencia_Click);
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
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.incidencia_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox incidencia_img;
        private System.Windows.Forms.Button btnViewIncidencia;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label idIncidencia;
        private System.Windows.Forms.Label nombreIncidencia;
    }
}
