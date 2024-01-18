﻿namespace Pantalla_Cliente
{
    partial class VentanaPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPDF));
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnGenerarLista = new System.Windows.Forms.Button();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(470, 128);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(307, 22);
            this.txtFiltro.TabIndex = 46;
            // 
            // btnGenerarLista
            // 
            this.btnGenerarLista.Location = new System.Drawing.Point(433, 34);
            this.btnGenerarLista.Name = "btnGenerarLista";
            this.btnGenerarLista.Size = new System.Drawing.Size(326, 23);
            this.btnGenerarLista.TabIndex = 48;
            this.btnGenerarLista.Text = "Generar lista de todos los cliente";
            this.btnGenerarLista.UseVisualStyleBackColor = true;
            this.btnGenerarLista.Click += new System.EventHandler(this.btnGenerarLista_Click_1);
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(263, 168);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(774, 527);
            this.axAcroPDF.TabIndex = 49;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(1111, 34);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(117, 23);
            this.btnImprimir.TabIndex = 50;
            this.btnImprimir.Text = "imprimir PDF";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(297, 126);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(146, 23);
            this.btnFiltrar.TabIndex = 47;
            this.btnFiltrar.Text = "Filtrar por cliente";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(153, 125);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 24);
            this.cmbFiltro.TabIndex = 51;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged_1);
            // 
            // VentanaPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1265, 856);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.axAcroPDF);
            this.Controls.Add(this.btnGenerarLista);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Name = "VentanaPDF";
            this.Text = "VentanaPDF";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnGenerarLista;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}