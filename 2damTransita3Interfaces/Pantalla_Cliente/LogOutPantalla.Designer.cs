
namespace transitaControllers
{
    partial class LogOutPantalla
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_si = new System.Windows.Forms.Button();
            this.logOutTImer1 = new transitaControllers.LogOutTImer();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(66, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cerrando sesion Automaticamente en";
            // 
            // btn_si
            // 
            this.btn_si.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_si.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_si.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_si.ForeColor = System.Drawing.Color.White;
            this.btn_si.Location = new System.Drawing.Point(137, 227);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(122, 38);
            this.btn_si.TabIndex = 0;
            this.btn_si.Text = "Cerrar Sesion Ahora";
            this.btn_si.UseVisualStyleBackColor = false;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // logOutTImer1
            // 
            this.logOutTImer1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOutTImer1.Location = new System.Drawing.Point(152, 138);
            this.logOutTImer1.Name = "logOutTImer1";
            this.logOutTImer1.Size = new System.Drawing.Size(250, 83);
            this.logOutTImer1.TabIndex = 4;
            this.logOutTImer1.Load += new System.EventHandler(this.logOutTImer1_Load);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(295, 227);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(122, 38);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // LogOutPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(534, 291);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.logOutTImer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_si);
            this.MaximumSize = new System.Drawing.Size(550, 330);
            this.MinimumSize = new System.Drawing.Size(550, 330);
            this.Name = "LogOutPantalla";
            this.Text = "LogOutPantalla";
            this.Load += new System.EventHandler(this.LogOutPantalla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_si;
        private LogOutTImer logOutTImer1;
        private System.Windows.Forms.Button btn_cancelar;
    }
}