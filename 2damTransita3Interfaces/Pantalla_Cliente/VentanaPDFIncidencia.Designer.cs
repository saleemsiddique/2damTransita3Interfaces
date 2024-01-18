namespace Pantalla_Cliente
{
    partial class VentanaPDFIncidencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPDFIncidencia));
            this.btnGenerarListaInci = new System.Windows.Forms.Button();
            this.btnFiltrarInci = new System.Windows.Forms.Button();
            this.txtFiltroIncid = new System.Windows.Forms.TextBox();
            this.axAcroPDFIncidencia = new AxAcroPDFLib.AxAcroPDF();
            this.cmbFiltroInciden = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFIncidencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerarListaInci
            // 
            this.btnGenerarListaInci.Location = new System.Drawing.Point(82, 27);
            this.btnGenerarListaInci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerarListaInci.Name = "btnGenerarListaInci";
            this.btnGenerarListaInci.Size = new System.Drawing.Size(244, 19);
            this.btnGenerarListaInci.TabIndex = 0;
            this.btnGenerarListaInci.Text = "Generar lista  Incidencias";
            this.btnGenerarListaInci.UseVisualStyleBackColor = true;
            this.btnGenerarListaInci.Click += new System.EventHandler(this.btnGenerarListaInci_Click);
            // 
            // btnFiltrarInci
            // 
            this.btnFiltrarInci.Location = new System.Drawing.Point(746, 27);
            this.btnFiltrarInci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrarInci.Name = "btnFiltrarInci";
            this.btnFiltrarInci.Size = new System.Drawing.Size(110, 19);
            this.btnFiltrarInci.TabIndex = 1;
            this.btnFiltrarInci.Text = "Filtrar Incidencia";
            this.btnFiltrarInci.UseVisualStyleBackColor = true;
            this.btnFiltrarInci.Click += new System.EventHandler(this.btnFiltrarInci_Click);
            // 
            // txtFiltroIncid
            // 
            this.txtFiltroIncid.Location = new System.Drawing.Point(529, 27);
            this.txtFiltroIncid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltroIncid.Name = "txtFiltroIncid";
            this.txtFiltroIncid.Size = new System.Drawing.Size(213, 20);
            this.txtFiltroIncid.TabIndex = 2;
            // 
            // axAcroPDFIncidencia
            // 
            this.axAcroPDFIncidencia.Enabled = true;
            this.axAcroPDFIncidencia.Location = new System.Drawing.Point(82, 53);
            this.axAcroPDFIncidencia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axAcroPDFIncidencia.Name = "axAcroPDFIncidencia";
            this.axAcroPDFIncidencia.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDFIncidencia.OcxState")));
            this.axAcroPDFIncidencia.Size = new System.Drawing.Size(774, 527);
            this.axAcroPDFIncidencia.TabIndex = 49;
            // 
            // cmbFiltroInciden
            // 
            this.cmbFiltroInciden.FormattingEnabled = true;
            this.cmbFiltroInciden.Location = new System.Drawing.Point(433, 27);
            this.cmbFiltroInciden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltroInciden.Name = "cmbFiltroInciden";
            this.cmbFiltroInciden.Size = new System.Drawing.Size(92, 21);
            this.cmbFiltroInciden.TabIndex = 4;
            this.cmbFiltroInciden.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroInciden_SelectedIndexChanged);
            // 
            // VentanaPDFIncidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(939, 592);
            this.Controls.Add(this.cmbFiltroInciden);
            this.Controls.Add(this.axAcroPDFIncidencia);
            this.Controls.Add(this.txtFiltroIncid);
            this.Controls.Add(this.btnFiltrarInci);
            this.Controls.Add(this.btnGenerarListaInci);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VentanaPDFIncidencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VentanaPDFIncidencia";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDFIncidencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarListaInci;
        private System.Windows.Forms.Button btnFiltrarInci;
        private System.Windows.Forms.TextBox txtFiltroIncid;
        private AxAcroPDFLib.AxAcroPDF axAcroPDFIncidencia;
        private System.Windows.Forms.ComboBox cmbFiltroInciden;
    }
}