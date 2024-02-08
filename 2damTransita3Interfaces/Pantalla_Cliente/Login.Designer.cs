
namespace Pantalla_Cliente
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Correo = new System.Windows.Forms.TextBox();
            this.contrasenya = new System.Windows.Forms.TextBox();
            this.checkBoxMostrarContrasenya = new System.Windows.Forms.CheckBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.imgTransita = new System.Windows.Forms.Label();
            this.btn_ajustes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Correo.Location = new System.Drawing.Point(98, 236);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(234, 22);
            this.Correo.TabIndex = 1;
            this.Correo.Text = "Ingrese el correo";
            this.Correo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Correo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Correo.Enter += new System.EventHandler(this.user_enter);
            this.Correo.Leave += new System.EventHandler(this.user_leave);
            // 
            // contrasenya
            // 
            this.contrasenya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.contrasenya.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasenya.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.contrasenya.Location = new System.Drawing.Point(98, 292);
            this.contrasenya.Name = "contrasenya";
            this.contrasenya.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contrasenya.Size = new System.Drawing.Size(234, 22);
            this.contrasenya.TabIndex = 2;
            this.contrasenya.Text = "Ingrese la contraseña";
            this.contrasenya.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contrasenya.TextChanged += new System.EventHandler(this.contrasenya_TextChanged);
            this.contrasenya.Enter += new System.EventHandler(this.contrasenya_enter);
            this.contrasenya.Leave += new System.EventHandler(this.contrasenya_leave);
            // 
            // checkBoxMostrarContrasenya
            // 
            this.checkBoxMostrarContrasenya.AutoSize = true;
            this.checkBoxMostrarContrasenya.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxMostrarContrasenya.Location = new System.Drawing.Point(341, 297);
            this.checkBoxMostrarContrasenya.Name = "checkBoxMostrarContrasenya";
            this.checkBoxMostrarContrasenya.Size = new System.Drawing.Size(61, 17);
            this.checkBoxMostrarContrasenya.TabIndex = 3;
            this.checkBoxMostrarContrasenya.Text = "Mostrar";
            this.checkBoxMostrarContrasenya.UseVisualStyleBackColor = true;
            this.checkBoxMostrarContrasenya.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(163, 347);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(105, 42);
            this.buttonEntrar.TabIndex = 4;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // imgTransita
            // 
            this.imgTransita.Image = ((System.Drawing.Image)(resources.GetObject("imgTransita.Image")));
            this.imgTransita.Location = new System.Drawing.Point(109, 37);
            this.imgTransita.Name = "imgTransita";
            this.imgTransita.Size = new System.Drawing.Size(223, 184);
            this.imgTransita.TabIndex = 6;
            // 
            // btn_ajustes
            // 
            this.btn_ajustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.btn_ajustes.CausesValidation = false;
            this.btn_ajustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajustes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.btn_ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajustes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ajustes.Image = global::Pantalla_Cliente.Properties.Resources.settingIcon;
            this.btn_ajustes.Location = new System.Drawing.Point(372, 12);
            this.btn_ajustes.Name = "btn_ajustes";
            this.btn_ajustes.Size = new System.Drawing.Size(50, 47);
            this.btn_ajustes.TabIndex = 7;
            this.btn_ajustes.UseVisualStyleBackColor = false;
            this.btn_ajustes.Click += new System.EventHandler(this.btn_ajustes_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(432, 432);
            this.Controls.Add(this.btn_ajustes);
            this.Controls.Add(this.imgTransita);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.checkBoxMostrarContrasenya);
            this.Controls.Add(this.contrasenya);
            this.Controls.Add(this.Correo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 558);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox contrasenya;
        private System.Windows.Forms.CheckBox checkBoxMostrarContrasenya;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label imgTransita;
        private System.Windows.Forms.Button btn_ajustes;
    }
}