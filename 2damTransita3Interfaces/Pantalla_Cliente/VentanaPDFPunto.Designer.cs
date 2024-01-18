namespace Pantalla_Cliente
{
    partial class VentanaPDFPunto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPDFPunto));
            this.btnGenerarListaPunto = new System.Windows.Forms.Button();
            this.btnFiltrarPunto = new System.Windows.Forms.Button();
            this.axAcroPDFPunto = new AxAcroPDFLib.AxAcroPDF();
            this.txtFiltroPunto = new System.Windows.Forms.TextBox();
            this.cmbFiltroPunto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFPunto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarListaPunto
            // 
            this.btnGenerarListaPunto.Location = new System.Drawing.Point(517, 25);
            this.btnGenerarListaPunto.Name = "btnGenerarListaPunto";
            this.btnGenerarListaPunto.Size = new System.Drawing.Size(315, 23);
            this.btnGenerarListaPunto.TabIndex = 0;
            this.btnGenerarListaPunto.Text = "Generar Lista Puntos";
            this.btnGenerarListaPunto.UseVisualStyleBackColor = true;
            this.btnGenerarListaPunto.Click += new System.EventHandler(this.btnGenerarListaPunto_Click);
            // 
            // btnFiltrarPunto
            // 
            this.btnFiltrarPunto.Location = new System.Drawing.Point(318, 106);
            this.btnFiltrarPunto.Name = "btnFiltrarPunto";
            this.btnFiltrarPunto.Size = new System.Drawing.Size(198, 23);
            this.btnFiltrarPunto.TabIndex = 1;
            this.btnFiltrarPunto.Text = "Filtrar Punto";
            this.btnFiltrarPunto.UseVisualStyleBackColor = true;
            this.btnFiltrarPunto.Click += new System.EventHandler(this.btnFiltrarPunto_Click);
            // 
            // axAcroPDFPunto
            // 
            this.axAcroPDFPunto.Enabled = true;
            this.axAcroPDFPunto.Location = new System.Drawing.Point(318, 145);
            this.axAcroPDFPunto.Name = "axAcroPDFPunto";
            this.axAcroPDFPunto.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFPunto.OcxState")));
            this.axAcroPDFPunto.Size = new System.Drawing.Size(919, 663);
            this.axAcroPDFPunto.TabIndex = 2;
            // 
            // txtFiltroPunto
            // 
            this.txtFiltroPunto.Location = new System.Drawing.Point(559, 107);
            this.txtFiltroPunto.Name = "txtFiltroPunto";
            this.txtFiltroPunto.Size = new System.Drawing.Size(374, 22);
            this.txtFiltroPunto.TabIndex = 3;
            // 
            // cmbFiltroPunto
            // 
            this.cmbFiltroPunto.FormattingEnabled = true;
            this.cmbFiltroPunto.Location = new System.Drawing.Point(170, 105);
            this.cmbFiltroPunto.Name = "cmbFiltroPunto";
            this.cmbFiltroPunto.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltroPunto.TabIndex = 4;
            this.cmbFiltroPunto.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPunto_SelectedIndexChanged);
            // 
            // VentanaPDFPunto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1586, 1082);
            this.Controls.Add(this.cmbFiltroPunto);
            this.Controls.Add(this.txtFiltroPunto);
            this.Controls.Add(this.axAcroPDFPunto);
            this.Controls.Add(this.btnFiltrarPunto);
            this.Controls.Add(this.btnGenerarListaPunto);
            this.Name = "VentanaPDFPunto";
            this.Text = "VentanaPDFPunto";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFPunto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarListaPunto;
        private System.Windows.Forms.Button btnFiltrarPunto;
        private AxAcroPDFLib.AxAcroPDF axAcroPDFPunto;
        private System.Windows.Forms.TextBox txtFiltroPunto;
        private System.Windows.Forms.ComboBox cmbFiltroPunto;
    }
}