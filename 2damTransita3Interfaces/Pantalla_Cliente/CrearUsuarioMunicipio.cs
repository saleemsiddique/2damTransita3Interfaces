using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class CrearUsuarioMunicipio : Form
    {
        string regexContrasenya = @"^[a-zA-Z0-9]{8,40}$";
        string noMatch = "La contraseña ha de tener de 8 a 40 \n carácteres alfanuméricos";
        string noPass = "INTRODUCE CAMPO";
        public CrearUsuarioMunicipio()
        {
            InitializeComponent();
            pass2_input.UseSystemPasswordChar = true;
            password1_input.UseSystemPasswordChar = true;
            rol_input.SelectedIndex = 0;
        }
        private bool verifyDatos()
        {
            if (!pass2_input.Text.Equals(password1_input.Text))
            {
                MessageBox.Show("La contraseña debe ser igual en los dos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nombreUsuario_input.Text == "" && nombre_input.Text == "" && apellido_input.Text == "")
            {
                MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public async Task crearUsuario(string nombreUsuario, string nombre, string apellido, string password, string rol_input_value)
        {
            EstadoCuenta estadoCuenta = EstadoCuenta.ACTIVADO;
            Rol rol = new Rol();
            List<Rol> rolObjt = new List<Rol>();

            if (rol_input_value.Equals("ROLE_ADMIN"))
            {
                rol = new Rol(1, "ROLE_ADMIN");
                rolObjt.Add(rol);
            }
            else if (rol_input_value.Equals("ROLE_MODERADOR"))
            {
                rol = new Rol(2, "ROLE_MODERADOR");
                rolObjt.Add(rol);
            }

            Cliente cliente = new Cliente
            {
                nombre = nombre,
                apellidos = apellido,
                nombreUsuario = nombreUsuario,
                contrasenya = password,
                estadoCuenta = estadoCuenta,
                rols = rolObjt
            };

            string content = $"{{\"nombre\": \"{cliente.nombre}\", \"apellidos\": \"{cliente.apellidos}\", \"nombreUsuario\": \"{cliente.nombreUsuario}\", \"contrasenya\": \"{cliente.contrasenya}\", \"rol\": [\"{string.Join("\", \"", cliente.rols.Select(r => r.nombre))}\"]}}";

            String url = Program.rutaBase + "api/auth/signup/cliente";
            string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);

        }




        private void btn_AceptarUsuarioMuni_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres dar de alta este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos())
                {
                    string nombreUsuario = nombreUsuario_input.Text;
                    string nombre = nombre_input.Text;
                    string apellido = apellido_input.Text;
                    string password = password1_input.Text;
                    string rol_input_value = rol_input.Text;

                    Task.Run(() => crearUsuario(nombreUsuario, nombre, apellido, password, rol_input_value))
                        .ContinueWith(task =>
                        {
                            foreach (Form form in Application.OpenForms)
                            {
                                if (form is Transita)
                                {
                                    Transita transita = (Transita)form;
                                    transita.MostrarPanelDeUsuariosMunicipio();
                                }
                            }
                            this.Close();
                        }, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }


        private void btn_cancelarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool isValidPassword(string contrasenya)
        {
            if (Regex.IsMatch(contrasenya, regexContrasenya))
            {
                return true;
            }

            return false;
        }

        private void comprobarCampo(string campo, Label label)
        {
            if (campo != "")
            {
                label.Text = "EL CAMPO NO PUEDE ESTAR VACIO";
                label.Visible = false;
            }
            else
            {
                label.Visible = true;
            }
        }

        private void comprobarContrasenya(string contrasenya, Label label) {
            if (contrasenya.Equals(""))
            {
                label.Visible = true;
                label.Text = noPass;
                label.Height = 15;
            }
            else
            {
                label.Visible = false;
                if (!isValidPassword(contrasenya))
                {
                    label.Text = noMatch;
                    label.Visible = true;
                    label.Height = 30;
                }
            }
        }



        private bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void nombre_input_TextChanged(object sender, EventArgs e)
        {
            comprobarCampo(nombre_input.Text, confirmarNombre);
        }

        private void nombreUsuario_input_TextChanged(object sender, EventArgs e)
        {
            if (nombreUsuario_input.Text != "")
            {
                confirmarNombreUsuario.Visible = false;
                if (IsEmailValid(nombreUsuario_input.Text))
                {
                    confirmarNombreUsuario.Visible = false;
                }
                else
                {
                    confirmarNombreUsuario.Text = "El formato no es válido, Ej: prueba@email.com";
                    confirmarNombreUsuario.Height = 30;
                    confirmarNombreUsuario.Visible = true;
                }
            }
            else
            {
                confirmarNombreUsuario.Text = "El campo no puede estar vacio";
                confirmarNombreUsuario.Height = 15;
                confirmarNombreUsuario.Visible = true;
            }
        }

        private void apellido_input_TextChanged(object sender, EventArgs e)
        {
            comprobarCampo(apellido_input.Text, confirmarApellido);
        }

        private void password1_input_TextChanged(object sender, EventArgs e)
        {
            comprobarContrasenya(password1_input.Text, confirmarContrasenya);
        }

        private void pass2_input_TextChanged(object sender, EventArgs e)
        {
            comprobarContrasenya(pass2_input.Text, confirmarRepetir);
        }
    }
}
