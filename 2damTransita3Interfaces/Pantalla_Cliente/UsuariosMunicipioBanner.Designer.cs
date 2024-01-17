
namespace Pantalla_Cliente
{
    partial class UsuariosMunicipioBanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosMunicipioBanner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.idCliente = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.Label();
            this.moreOption = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idCliente);
            this.panel1.Controls.Add(this.nombreCliente);
            this.panel1.Controls.Add(this.moreOption);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 44);
            this.panel1.TabIndex = 24;
            // 
            // idCliente
            // 
            this.idCliente.AutoSize = true;
            this.idCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idCliente.Location = new System.Drawing.Point(75, 7);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(18, 13);
            this.idCliente.TabIndex = 27;
            this.idCliente.Text = "ID";
            // 
            // nombreCliente
            // 
            this.nombreCliente.AutoSize = true;
            this.nombreCliente.ForeColor = System.Drawing.Color.White;
            this.nombreCliente.Location = new System.Drawing.Point(75, 25);
            this.nombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(67, 13);
            this.nombreCliente.TabIndex = 26;
            this.nombreCliente.Text = "Nom_Cliente";
            // 
            // moreOption
            // 
            this.moreOption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moreOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.moreOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.moreOption.Image = ((System.Drawing.Image)(resources.GetObject("moreOption.Image")));
            this.moreOption.Location = new System.Drawing.Point(351, -6);
            this.moreOption.Name = "moreOption";
            this.moreOption.Size = new System.Drawing.Size(30, 57);
            this.moreOption.TabIndex = 25;
            this.moreOption.UseVisualStyleBackColor = false;
            this.moreOption.Click += new System.EventHandler(this.moreOption_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox2.InitialImage = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox2.Location = new System.Drawing.Point(16, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // UsuariosMunicipioBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panel1);
            this.Name = "UsuariosMunicipioBanner";
            this.Size = new System.Drawing.Size(400, 45);
            this.Load += new System.EventHandler(this.UsuariosMunicipioBanner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label idCliente;
        private System.Windows.Forms.Label nombreCliente;
        private System.Windows.Forms.Button moreOption;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
