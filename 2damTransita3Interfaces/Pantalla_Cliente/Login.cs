using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contrasenya_TextChanged(object sender, EventArgs e)
        {

        }
        private void user_enter(object sender, EventArgs e) {

            if (Correo.Text == "Ingrese el correo") {

                Correo.Text = "";
                
            }
        
        }


        public async void getUser()
        {
            Console.WriteLine("El método ha sido activado");
            string url = Program.rutaBase + "api/auth/signin/cliente";
           // UserLoged userLoged = new UserLoged(Correo.Text,contrasenya.Text);
            string nombreUsuario = Correo.Text;
            string contrasenyaCont = contrasenya.Text;

            string jsonString = $"{{\"nombreUsuario\":\"{nombreUsuario}\",\"contrasenya\":\"{contrasenyaCont}\"}}";

         
            string response = await ApiClient.GetRequestAsync("GET", url,null, jsonString);
         
            Console.WriteLine(response);

            // Verifica si la respuesta contiene un error de autenticación
            if (response.Contains("Unauthorized") && response.Contains("Bad credentials"))
            {
                // Muestra un mensaje de error al usuario
                MessageBox.Show("Credenciales incorrectas. No se puede autenticar.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // La respuesta es exitosa y el usuario está autorizado, abre el formulario Transita
                Transita transita = new Transita();
                transita.Show();
                this.Hide();
            }
        }



        private void obtenerToken(string response)
        {
          
        }

        private void user_leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Correo.Text))
            {
                Correo.Text = "Ingrese el correo";
            }

        }
        private void contrasenya_enter(object sender, EventArgs e)
        {

            if (contrasenya.Text == "Ingrese la contraseña")
            {

                contrasenya.Text = "";
                contrasenya.UseSystemPasswordChar = true;

            }

        }
        private void contrasenya_leave(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(contrasenya.Text))
            {
                contrasenya.Text = "Ingrese la contraseña";
                contrasenya.UseSystemPasswordChar = false;
            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarContrasenya.Checked == true)
            {

                contrasenya.UseSystemPasswordChar = false;

            }
            else {

                contrasenya.UseSystemPasswordChar = true;

            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            getUser();

        }

        private void imgUser_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            GraphicsPath roundPath = new GraphicsPath();
            roundPath.AddEllipse(0, 0, imgUser.Width, imgUser.Height);

            // Crea una región con la forma redonda y aplícala al PictureBox
            Region region = new Region(roundPath);
            imgUser.Region = region;
        }
    }
}
