
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
            this.moreOption = new System.Windows.Forms.Button();
            this.favCliente = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.idCliente = new System.Windows.Forms.Label();
            this.nombreCliente = new System.Windows.Forms.Label();
            this.btnViewUsuarioMuni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.favCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // moreOption
            // 
            this.moreOption.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.moreOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.moreOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moreOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.moreOption.Image = ((System.Drawing.Image)(resources.GetObject("moreOption.Image")));
            this.moreOption.Location = new System.Drawing.Point(401, 5);
            this.moreOption.Name = "moreOption";
            this.moreOption.Size = new System.Drawing.Size(30, 57);
            this.moreOption.TabIndex = 21;
            this.moreOption.UseVisualStyleBackColor = false;
            this.moreOption.Click += new System.EventHandler(this.moreOption_Click);
            // 
            // favCliente
            // 
            this.favCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.favCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.favCliente.Image = global::Pantalla_Cliente.Properties.Resources.estrellaNegra_fotor_bg_remover_2023102118503;
            this.favCliente.InitialImage = global::Pantalla_Cliente.Properties.Resources.estrellaAmarilla_fotor_bg_remover_20231021185036;
            this.favCliente.Location = new System.Drawing.Point(278, 22);
            this.favCliente.Name = "favCliente";
            this.favCliente.Size = new System.Drawing.Size(25, 25);
            this.favCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.favCliente.TabIndex = 20;
            this.favCliente.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox2.InitialImage = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.pictureBox2.Location = new System.Drawing.Point(20, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // idCliente
            // 
            this.idCliente.AutoSize = true;
            this.idCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idCliente.Location = new System.Drawing.Point(79, 22);
            this.idCliente.Name = "idCliente";
            this.idCliente.Size = new System.Drawing.Size(18, 13);
            this.idCliente.TabIndex = 23;
            this.idCliente.Text = "ID";
            // 
            // nombreCliente
            // 
            this.nombreCliente.AutoSize = true;
            this.nombreCliente.ForeColor = System.Drawing.Color.White;
            this.nombreCliente.Location = new System.Drawing.Point(79, 40);
            this.nombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(67, 13);
            this.nombreCliente.TabIndex = 22;
            this.nombreCliente.Text = "Nom_Cliente";
            this.nombreCliente.Click += new System.EventHandler(this.nombreCliente_Click);
            // 
            // btnViewUsuarioMuni
            // 
            this.btnViewUsuarioMuni.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnViewUsuarioMuni.Location = new System.Drawing.Point(320, 22);
            this.btnViewUsuarioMuni.Name = "btnViewUsuarioMuni";
            this.btnViewUsuarioMuni.Size = new System.Drawing.Size(75, 23);
            this.btnViewUsuarioMuni.TabIndex = 24;
            this.btnViewUsuarioMuni.Text = "View";
            this.btnViewUsuarioMuni.UseVisualStyleBackColor = true;
            this.btnViewUsuarioMuni.Click += new System.EventHandler(this.btnViewCliente_Click);
            // 
            // UsuariosMunicipioBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnViewUsuarioMuni);
            this.Controls.Add(this.idCliente);
            this.Controls.Add(this.nombreCliente);
            this.Controls.Add(this.moreOption);
            this.Controls.Add(this.favCliente);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UsuariosMunicipioBanner";
            this.Size = new System.Drawing.Size(450, 67);
            this.Load += new System.EventHandler(this.UsuariosMunicipioBanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.favCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moreOption;
        private System.Windows.Forms.PictureBox favCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label idCliente;
        private System.Windows.Forms.Label nombreCliente;
        private System.Windows.Forms.Button btnViewUsuarioMuni;
    }
}
