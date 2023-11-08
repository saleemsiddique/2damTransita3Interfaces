using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class CrearUsuarioMunicipio : Form
    {
        public CrearUsuarioMunicipio()
        {
            InitializeComponent();
            pass2_input.UseSystemPasswordChar = true;
            password1_input.UseSystemPasswordChar = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private bool verifyDatos()
        {
            if (!pass2_input.Text.Equals(password1_input.Text))
            {
                MessageBox.Show("La contraseña debe ser igual en los dos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(nombreUsuario_input.Text == "" || nombre_input.Text == "" || apellido_input.Text == ""))
            {
                return true;
            }
            MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public async Task crearUsuario()
        {

            string userNombreUsuario = nombreUsuario_input.Text;
            string userNombre = nombre_input.Text;
            string userApellido = apellido_input.Text;
            string userPassWord = password1_input.Text;
            EstadoCuenta estadoCuenta = EstadoCuenta.ACTIVADO;
            Rol rolObjt = Rol.ROLE_MODERADOR;

            if (rol_input.Equals("ROLE_ADMIN"))
            {
                rolObjt = Rol.ROLE_ADMIN;
            }
            else if (rol_input.Equals("ROLE_MODERADOR"))
            {
                rolObjt = Rol.ROLE_MODERADOR;
            }

            string content = $"{{\"nombre\": \"{userNombre}\", \"apellidos\": \"{userApellido}\", \"nombreUsuario\": \"{userNombreUsuario}\", \"contrasenya\": \"{userPassWord}\", \"rol\": [\"{rolObjt}\"]}}";

            //Cliente newUser = new Cliente(userNombre,userApellido,userNombreUsuario,userPassWord,estadoCuenta,rolObjt);
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "api/auth/signup/cliente";
            //string content = JsonSerializer.Serialize(newUser);
            string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);

            Console.WriteLine(response);

        }
        private void btn_AceptarUsuarioMuni_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de los datos de la Zona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos())
                {
                    _ = crearUsuario();

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is Transita)
                        {
                            Transita transita = (Transita)form;
                            transita.MostrarPanelDeUsuariosMunicipio();
                        }
                    }
                    this.Close();
                }
            }
        }

        private void btn_cancelarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void incidenciaEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
