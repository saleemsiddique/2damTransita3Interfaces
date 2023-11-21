
namespace Pantalla_Cliente
{
    partial class OpcionesFiltroIncidencias
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.enviado_btn = new System.Windows.Forms.RadioButton();
            this.aceptado_btn = new System.Windows.Forms.RadioButton();
            this.enProceso_btn = new System.Windows.Forms.RadioButton();
            this.finalizado = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.finalizado, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.enviado_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.aceptado_btn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.enProceso_btn, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 71);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // enviado_btn
            // 
            this.enviado_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enviado_btn.AutoSize = true;
            this.enviado_btn.ForeColor = System.Drawing.Color.White;
            this.enviado_btn.Location = new System.Drawing.Point(27, 27);
            this.enviado_btn.Name = "enviado_btn";
            this.enviado_btn.Size = new System.Drawing.Size(73, 17);
            this.enviado_btn.TabIndex = 1;
            this.enviado_btn.TabStop = true;
            this.enviado_btn.Text = "ENVIADO";
            this.enviado_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.enviado_btn.UseVisualStyleBackColor = true;
            // 
            // aceptado_btn
            // 
            this.aceptado_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aceptado_btn.AutoSize = true;
            this.aceptado_btn.ForeColor = System.Drawing.Color.White;
            this.aceptado_btn.Location = new System.Drawing.Point(149, 27);
            this.aceptado_btn.Name = "aceptado_btn";
            this.aceptado_btn.Size = new System.Drawing.Size(83, 17);
            this.aceptado_btn.TabIndex = 2;
            this.aceptado_btn.TabStop = true;
            this.aceptado_btn.Text = "ACEPTADO";
            this.aceptado_btn.UseVisualStyleBackColor = true;
            // 
            // enProceso_btn
            // 
            this.enProceso_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enProceso_btn.AutoSize = true;
            this.enProceso_btn.ForeColor = System.Drawing.Color.White;
            this.enProceso_btn.Location = new System.Drawing.Point(271, 27);
            this.enProceso_btn.Name = "enProceso_btn";
            this.enProceso_btn.Size = new System.Drawing.Size(92, 17);
            this.enProceso_btn.TabIndex = 3;
            this.enProceso_btn.TabStop = true;
            this.enProceso_btn.Text = "ENPROCESO";
            this.enProceso_btn.UseVisualStyleBackColor = true;
            // 
            // finalizado
            // 
            this.finalizado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.finalizado.AutoSize = true;
            this.finalizado.ForeColor = System.Drawing.Color.White;
            this.finalizado.Location = new System.Drawing.Point(400, 27);
            this.finalizado.Name = "finalizado";
            this.finalizado.Size = new System.Drawing.Size(88, 17);
            this.finalizado.TabIndex = 4;
            this.finalizado.TabStop = true;
            this.finalizado.Text = "FINALIZADO";
            this.finalizado.UseVisualStyleBackColor = true;
            // 
            // OpcionesFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OpcionesFiltro";
            this.Size = new System.Drawing.Size(508, 71);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton enviado_btn;
        private System.Windows.Forms.RadioButton aceptado_btn;
        private System.Windows.Forms.RadioButton enProceso_btn;
        private System.Windows.Forms.RadioButton finalizado;
    }
}
