
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
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.contrasenya = new System.Windows.Forms.TextBox();
            this.checkBoxMostrarContrasenya = new System.Windows.Forms.CheckBox();
            this.buttonEntrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.White;
            this.imgUser.Image = global::Pantalla_Cliente.Properties.Resources.Jugador;
            this.imgUser.Location = new System.Drawing.Point(151, 21);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(147, 160);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUser.TabIndex = 0;
            this.imgUser.TabStop = false;
            this.imgUser.Click += new System.EventHandler(this.imgUser_Click);
            // 
            // Correo
            // 
            this.Correo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Correo.Location = new System.Drawing.Point(101, 218);
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
            this.contrasenya.Location = new System.Drawing.Point(101, 274);
            this.contrasenya.Name = "contrasenya";
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
            this.checkBoxMostrarContrasenya.Location = new System.Drawing.Point(344, 279);
            this.checkBoxMostrarContrasenya.Name = "checkBoxMostrarContrasenya";
            this.checkBoxMostrarContrasenya.Size = new System.Drawing.Size(61, 17);
            this.checkBoxMostrarContrasenya.TabIndex = 3;
            this.checkBoxMostrarContrasenya.Text = "Mostrar";
            this.checkBoxMostrarContrasenya.UseVisualStyleBackColor = true;
            this.checkBoxMostrarContrasenya.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(166, 329);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(105, 42);
            this.buttonEntrar.TabIndex = 4;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(434, 432);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.checkBoxMostrarContrasenya);
            this.Controls.Add(this.contrasenya);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.imgUser);
            this.MaximumSize = new System.Drawing.Size(450, 560);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox contrasenya;
        private System.Windows.Forms.CheckBox checkBoxMostrarContrasenya;
        private System.Windows.Forms.Button buttonEntrar;
    }
}