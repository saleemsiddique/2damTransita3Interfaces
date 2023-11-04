using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            Correo.KeyDown += contrasenya_KeyDown;
            contrasenya.KeyDown += contrasenya_KeyDown;
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
            string nombreUsuario = Correo.Text;
            string contrasenyaCont = contrasenya.Text;
            string jsonString = $"{{\"nombreUsuario\":\"{nombreUsuario}\",\"contrasenya\":\"{contrasenyaCont}\"}}";

            try
            {
                string response = await ApiClient.GetRequestAsync("POST", url, null, jsonString);
                Console.WriteLine(response);
                Program.userLogged = JsonConvert.DeserializeObject<UserLoged>(response);
                Program.token = Program.userLogged.token;
                Console.WriteLine(Program.userLogged);
                if (response.Contains("Unauthorized") && response.Contains("Bad credentials"))
                {
                    MessageBox.Show("Credenciales incorrectas. No se puede autenticar.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Transita transita = new Transita();
                    transita.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                this.Hide();
                MessageBox.Show("Credenciales incorrectas. No se puede autenticar.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login login = new Login();
                login.Show();
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

        }

        private void contrasenya_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getUser();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
