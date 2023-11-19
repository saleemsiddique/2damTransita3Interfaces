namespace Pantalla_Cliente
{
    partial class ModificarContrasenyaUsuarioMunicipio
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
            this.incidenciaEditar = new System.Windows.Forms.Label();
            this.contrasenyaBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmarBox = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.nombreUsuarioLabel = new System.Windows.Forms.Label();
            this.noContrasenya = new System.Windows.Forms.Label();
            this.noConfirmacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incidenciaEditar
            // 
            this.incidenciaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.incidenciaEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incidenciaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidenciaEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.incidenciaEditar.Location = new System.Drawing.Point(45, 18);
            this.incidenciaEditar.Name = "incidenciaEditar";
            this.incidenciaEditar.Size = new System.Drawing.Size(257, 74);
            this.incidenciaEditar.TabIndex = 22;
            this.incidenciaEditar.Text = "Modificar contraseña";
            this.incidenciaEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contrasenyaBox
            // 
            this.contrasenyaBox.Location = new System.Drawing.Point(68, 181);
            this.contrasenyaBox.Name = "contrasenyaBox";
            this.contrasenyaBox.Size = new System.Drawing.Size(216, 20);
            this.contrasenyaBox.TabIndex = 23;
            this.contrasenyaBox.TextChanged += new System.EventHandler(this.contrasenyaBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(68, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Contraseña: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Confirmar contraseña: ";
            // 
            // confirmarBox
            // 
            this.confirmarBox.Location = new System.Drawing.Point(68, 253);
            this.confirmarBox.Name = "confirmarBox";
            this.confirmarBox.Size = new System.Drawing.Size(216, 20);
            this.confirmarBox.TabIndex = 59;
            this.confirmarBox.TextChanged += new System.EventHandler(this.confirmarBox_TextChanged);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Location = new System.Drawing.Point(65, 324);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 62;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.Location = new System.Drawing.Point(209, 324);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 61;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.BackColor = System.Drawing.Color.Transparent;
            this.idLabel.ForeColor = System.Drawing.Color.White;
            this.idLabel.Location = new System.Drawing.Point(73, 104);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(24, 13);
            this.idLabel.TabIndex = 63;
            this.idLabel.Text = "ID: ";
            // 
            // nombreUsuarioLabel
            // 
            this.nombreUsuarioLabel.AutoSize = true;
            this.nombreUsuarioLabel.BackColor = System.Drawing.Color.Transparent;
            this.nombreUsuarioLabel.ForeColor = System.Drawing.Color.White;
            this.nombreUsuarioLabel.Location = new System.Drawing.Point(73, 126);
            this.nombreUsuarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            this.nombreUsuarioLabel.Size = new System.Drawing.Size(112, 13);
            this.nombreUsuarioLabel.TabIndex = 64;
            this.nombreUsuarioLabel.Text = "NOMBRE USUARIO: ";
            // 
            // noContrasenya
            // 
            this.noContrasenya.AutoEllipsis = true;
            this.noContrasenya.BackColor = System.Drawing.Color.Red;
            this.noContrasenya.ForeColor = System.Drawing.Color.White;
            this.noContrasenya.Location = new System.Drawing.Point(68, 200);
            this.noContrasenya.Name = "noContrasenya";
            this.noContrasenya.Size = new System.Drawing.Size(216, 15);
            this.noContrasenya.TabIndex = 65;
            this.noContrasenya.Visible = false;
            // 
            // noConfirmacion
            // 
            this.noConfirmacion.BackColor = System.Drawing.Color.Red;
            this.noConfirmacion.ForeColor = System.Drawing.Color.White;
            this.noConfirmacion.Location = new System.Drawing.Point(68, 272);
            this.noConfirmacion.Name = "noConfirmacion";
            this.noConfirmacion.Size = new System.Drawing.Size(216, 15);
            this.noConfirmacion.TabIndex = 66;
            this.noConfirmacion.Visible = false;
            // 
            // ModificarContrasenyaUsuarioMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(347, 387);
            this.Controls.Add(this.noConfirmacion);
            this.Controls.Add(this.noContrasenya);
            this.Controls.Add(this.nombreUsuarioLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmarBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contrasenyaBox);
            this.Controls.Add(this.incidenciaEditar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModificarContrasenyaUsuarioMunicipio";
            this.Text = "ModificarContrasenyaUsuarioMunicipio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incidenciaEditar;
        private System.Windows.Forms.TextBox contrasenyaBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmarBox;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nombreUsuarioLabel;
        private System.Windows.Forms.Label noContrasenya;
        private System.Windows.Forms.Label noConfirmacion;
    }
}