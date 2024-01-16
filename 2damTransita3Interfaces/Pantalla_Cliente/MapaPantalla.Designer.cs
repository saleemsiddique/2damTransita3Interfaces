
namespace Pantalla_Cliente
{
    partial class MapaPantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapaPantalla));
            this.panel_central = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_resetPointer = new System.Windows.Forms.Button();
            this.adelanteBtn = new System.Windows.Forms.Label();
            this.atrasBtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxIncidencias = new System.Windows.Forms.ListBox();
            this.panel_central.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_central
            // 
            this.panel_central.AutoScroll = true;
            this.panel_central.AutoSize = true;
            this.panel_central.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_central.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.panel_central.Controls.Add(this.listBoxIncidencias);
            this.panel_central.Controls.Add(this.panel1);
            this.panel_central.Controls.Add(this.adelanteBtn);
            this.panel_central.Controls.Add(this.atrasBtn);
            this.panel_central.Controls.Add(this.label2);
            this.panel_central.Location = new System.Drawing.Point(271, 0);
            this.panel_central.MinimumSize = new System.Drawing.Size(793, 0);
            this.panel_central.Name = "panel_central";
            this.panel_central.Size = new System.Drawing.Size(793, 681);
            this.panel_central.TabIndex = 30;
            this.panel_central.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_resetPointer);
            this.panel1.Location = new System.Drawing.Point(19, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 570);
            this.panel1.TabIndex = 41;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_resetPointer
            // 
            this.btn_resetPointer.Image = ((System.Drawing.Image)(resources.GetObject("btn_resetPointer.Image")));
            this.btn_resetPointer.Location = new System.Drawing.Point(485, 510);
            this.btn_resetPointer.Name = "btn_resetPointer";
            this.btn_resetPointer.Size = new System.Drawing.Size(32, 34);
            this.btn_resetPointer.TabIndex = 42;
            this.btn_resetPointer.UseVisualStyleBackColor = true;
            this.btn_resetPointer.Click += new System.EventHandler(this.btn_resetPointer_Click);
            // 
            // adelanteBtn
            // 
            this.adelanteBtn.BackColor = System.Drawing.Color.Transparent;
            this.adelanteBtn.Location = new System.Drawing.Point(438, 598);
            this.adelanteBtn.Name = "adelanteBtn";
            this.adelanteBtn.Size = new System.Drawing.Size(50, 50);
            this.adelanteBtn.TabIndex = 40;
            // 
            // atrasBtn
            // 
            this.atrasBtn.BackColor = System.Drawing.Color.Transparent;
            this.atrasBtn.Location = new System.Drawing.Point(45, 598);
            this.atrasBtn.Name = "atrasBtn";
            this.atrasBtn.Size = new System.Drawing.Size(50, 50);
            this.atrasBtn.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(325, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mapa Transita";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxIncidencias
            // 
            this.listBoxIncidencias.FormattingEnabled = true;
            this.listBoxIncidencias.Location = new System.Drawing.Point(558, 93);
            this.listBoxIncidencias.Name = "listBoxIncidencias";
            this.listBoxIncidencias.Size = new System.Drawing.Size(223, 563);
            this.listBoxIncidencias.TabIndex = 42;
            // 
            // MapaPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panel_central);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(960, 450);
            this.Name = "MapaPantalla";
            this.Text = "MapaPantalla";
            this.panel_central.ResumeLayout(false);
            this.panel_central.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_central;
        private System.Windows.Forms.Label adelanteBtn;
        private System.Windows.Forms.Label atrasBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_resetPointer;
        private System.Windows.Forms.ListBox listBoxIncidencias;
    }
}