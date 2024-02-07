
namespace Pantalla_Cliente
{
    partial class EditarUsuarioMunicipio
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_AceptarUsuarioMuni = new System.Windows.Forms.Button();
            this.incidenciaEditar = new System.Windows.Forms.Label();
            this.label_datosInciencia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rol_input = new System.Windows.Forms.ComboBox();
            this.apellido_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nom_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreUsuario_input = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmarNombre = new System.Windows.Forms.Label();
            this.confirmarApellido = new System.Windows.Forms.Label();
            this.confirmarNombreUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Location = new System.Drawing.Point(147, 431);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 26;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_AceptarUsuarioMuni
            // 
            this.btn_AceptarUsuarioMuni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AceptarUsuarioMuni.Location = new System.Drawing.Point(291, 431);
            this.btn_AceptarUsuarioMuni.Name = "btn_AceptarUsuarioMuni";
            this.btn_AceptarUsuarioMuni.Size = new System.Drawing.Size(75, 23);
            this.btn_AceptarUsuarioMuni.TabIndex = 25;
            this.btn_AceptarUsuarioMuni.Text = "Aceptar";
            this.btn_AceptarUsuarioMuni.UseVisualStyleBackColor = true;
            this.btn_AceptarUsuarioMuni.Click += new System.EventHandler(this.btn_AceptarUsuarioMuni_ClickAsync);
            // 
            // incidenciaEditar
            // 
            this.incidenciaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.incidenciaEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incidenciaEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidenciaEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.incidenciaEditar.Location = new System.Drawing.Point(138, 26);
            this.incidenciaEditar.Name = "incidenciaEditar";
            this.incidenciaEditar.Size = new System.Drawing.Size(257, 74);
            this.incidenciaEditar.TabIndex = 21;
            this.incidenciaEditar.Text = "Editar Usuario Municipio";
            this.incidenciaEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_datosInciencia
            // 
            this.label_datosInciencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label_datosInciencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_datosInciencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_datosInciencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_datosInciencia.Location = new System.Drawing.Point(93, 120);
            this.label_datosInciencia.Name = "label_datosInciencia";
            this.label_datosInciencia.Size = new System.Drawing.Size(334, 295);
            this.label_datosInciencia.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(179, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "ROL";
            // 
            // rol_input
            // 
            this.rol_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rol_input.FormattingEnabled = true;
            this.rol_input.Items.AddRange(new object[] {
            "ROLE_ADMIN",
            "ROLE_MODERADOR"});
            this.rol_input.Location = new System.Drawing.Point(182, 356);
            this.rol_input.Name = "rol_input";
            this.rol_input.Size = new System.Drawing.Size(158, 21);
            this.rol_input.TabIndex = 67;
            // 
            // apellido_input
            // 
            this.apellido_input.Location = new System.Drawing.Point(182, 286);
            this.apellido_input.Margin = new System.Windows.Forms.Padding(2);
            this.apellido_input.Name = "apellido_input";
            this.apellido_input.Size = new System.Drawing.Size(158, 20);
            this.apellido_input.TabIndex = 62;
            this.apellido_input.TextChanged += new System.EventHandler(this.apellido_input_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(179, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Apellido";
            // 
            // nom_input
            // 
            this.nom_input.Location = new System.Drawing.Point(182, 216);
            this.nom_input.Margin = new System.Windows.Forms.Padding(2);
            this.nom_input.Name = "nom_input";
            this.nom_input.Size = new System.Drawing.Size(158, 20);
            this.nom_input.TabIndex = 60;
            this.nom_input.TextChanged += new System.EventHandler(this.nom_input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre ";
            // 
            // nombreUsuario_input
            // 
            this.nombreUsuario_input.Location = new System.Drawing.Point(182, 146);
            this.nombreUsuario_input.Margin = new System.Windows.Forms.Padding(2);
            this.nombreUsuario_input.Name = "nombreUsuario_input";
            this.nombreUsuario_input.Size = new System.Drawing.Size(158, 20);
            this.nombreUsuario_input.TabIndex = 58;
            this.nombreUsuario_input.TextChanged += new System.EventHandler(this.nombreUsuario_input_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(179, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Nombre Usuario";
            // 
            // confirmarNombre
            // 
            this.confirmarNombre.AutoEllipsis = true;
            this.confirmarNombre.BackColor = System.Drawing.Color.Red;
            this.confirmarNombre.ForeColor = System.Drawing.Color.White;
            this.confirmarNombre.Location = new System.Drawing.Point(182, 234);
            this.confirmarNombre.Name = "confirmarNombre";
            this.confirmarNombre.Size = new System.Drawing.Size(158, 26);
            this.confirmarNombre.TabIndex = 70;
            this.confirmarNombre.Text = "EL CAMPO NO PUEDE ESTAR VACIO";
            this.confirmarNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmarNombre.Visible = false;
            // 
            // confirmarApellido
            // 
            this.confirmarApellido.AutoEllipsis = true;
            this.confirmarApellido.BackColor = System.Drawing.Color.Red;
            this.confirmarApellido.ForeColor = System.Drawing.Color.White;
            this.confirmarApellido.Location = new System.Drawing.Point(182, 304);
            this.confirmarApellido.Name = "confirmarApellido";
            this.confirmarApellido.Size = new System.Drawing.Size(158, 26);
            this.confirmarApellido.TabIndex = 71;
            this.confirmarApellido.Text = "EL CAMPO NO PUEDE ESTAR VACIO";
            this.confirmarApellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmarApellido.Visible = false;
            // 
            // confirmarNombreUsuario
            // 
            this.confirmarNombreUsuario.AutoEllipsis = true;
            this.confirmarNombreUsuario.BackColor = System.Drawing.Color.Red;
            this.confirmarNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.confirmarNombreUsuario.Location = new System.Drawing.Point(182, 166);
            this.confirmarNombreUsuario.Name = "confirmarNombreUsuario";
            this.confirmarNombreUsuario.Size = new System.Drawing.Size(158, 26);
            this.confirmarNombreUsuario.TabIndex = 72;
            this.confirmarNombreUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmarNombreUsuario.Visible = false;
            // 
            // EditarUsuarioMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(528, 483);
            this.Controls.Add(this.confirmarNombreUsuario);
            this.Controls.Add(this.confirmarApellido);
            this.Controls.Add(this.confirmarNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rol_input);
            this.Controls.Add(this.apellido_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nom_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombreUsuario_input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_AceptarUsuarioMuni);
            this.Controls.Add(this.label_datosInciencia);
            this.Controls.Add(this.incidenciaEditar);
            this.Name = "EditarUsuarioMunicipio";
            this.Text = "EditarUsuarioMunicipio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_AceptarUsuarioMuni;
        private System.Windows.Forms.Label incidenciaEditar;
        private System.Windows.Forms.Label label_datosInciencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rol_input;
        private System.Windows.Forms.TextBox apellido_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nom_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreUsuario_input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label confirmarNombre;
        private System.Windows.Forms.Label confirmarApellido;
        private System.Windows.Forms.Label confirmarNombreUsuario;
    }
}