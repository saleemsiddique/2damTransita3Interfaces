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
                Console.WriteLine("ROLE_ADMIN selected");
                rol = new Rol(1, "ROLE_ADMIN");
                rolObjt.Add(rol);
            }
            else if (rol_input_value.Equals("ROLE_MODERADOR"))
            {
                Console.WriteLine("ROLE_MODERADOR selected");
                rol = new Rol(2, "ROLE_MODERADOR");
                rolObjt.Add(rol);
            }

            // Create a Cliente object and set its properties
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


            Console.WriteLine("Método ha sido activado");
            String url = Program.rutaBase + "api/auth/signup/cliente";
            string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);

            Console.WriteLine(response);
        }




        private void btn_AceptarUsuarioMuni_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres dar de alta este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Capture UI element values
                string nombreUsuario = nombreUsuario_input.Text;
                string nombre = nombre_input.Text;
                string apellido = apellido_input.Text;
                string password = password1_input.Text;
                string rol_input_value = rol_input.Text;

                Task.Run(() => crearUsuario(nombreUsuario, nombre, apellido, password, rol_input_value))
                    .ContinueWith(task =>
                    {
                        // This part will be executed when crearUsuario completes, but won't block the UI
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
