using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class EditarUsuarioMunicipio : Form
    {
        Cliente user;
        int idMod;
        
        public EditarUsuarioMunicipio(string idModificar)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            idMod = int.TryParse(idModificar, out int parsedId) ? parsedId : 0;
            getCliente(idModificar);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public async Task getCliente(string idModificar)
        {

                // La conversión fue exitosa, y el valor se almacena en idMod como un entero.

                String url = Program.rutaBase + "cliente/id/" + idMod.ToString();
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

                user = JsonSerializer.Deserialize<Cliente>(response);
                nombreUsuario_input.Text = user.nombreUsuario;
                nom_input.Text = user.nombre;
                apellido_input.Text = user.apellidos;
                int selecEstado = rol_input.FindStringExact(user.rols[0].ToString());
                rol_input.SelectedIndex = selecEstado;
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task modifyUser(int idMod)
        {
            foreach (var rol in user.rols)
            {
                string rolObjt = rol.nombre;
                if (rol_input.Text.Equals("ROLE_ADMIN"))
                {
                    rolObjt = "ROLE_ADMIN";
                } else if (rol_input.Text.Equals("ROLE_MODERADOR")) {
                    rolObjt = "ROLE_MODERADOR";
                }
            string content = $"{{\"nombre\": \"{nom_input.Text}\", \"apellidos\": \"{apellido_input.Text}\"," +
                    $" \"nombreUsuario\": \"{nombreUsuario_input.Text}\", \"rol\": [\"{rolObjt}\"]}}";

                String url = Program.rutaBase + "api/auth/cliente/modificar/" + idMod;
                //string content = JsonSerializer.Serialize(user);
                string response = await ApiClient.GetRequestAsync("PUT", url, Program.token, content);

            }
        }

        private bool verifyDatos()
        {
            if (nom_input.Text != "" && nombreUsuario_input.Text != "" && apellido_input.Text != "")
            {
                return true;
            }
            MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        private void btn_AceptarUsuarioMuni_ClickAsync(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos())
                {
                    Task task = modifyUser(idMod);

                    task.ContinueWith(t =>
                    {
                        // This part will be executed when modifyUser completes, but won't block the UI
                        Form formularioPadre = this.Owner;

                        if (formularioPadre != null)
                        {
                            if (formularioPadre is Transita)
                            {
                                Transita formularioTransita = (Transita)formularioPadre;
                                formularioTransita.MostrarPanelDeUsuariosMunicipio();
                                this.Close();
                            }
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void punto_input_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                else {
                    confirmarNombreUsuario.Text = "El formato no es válido, Ej: prueba@email.com";
                    confirmarNombreUsuario.Visible = true;
                }
            }
            else {
                confirmarNombreUsuario.Text = "El campo no puede estar vacio";
                confirmarNombreUsuario.Visible = true;
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

        private void comprobarCampo(string campo, Label label) {
            if (campo != "")
            {
                label.Visible = false;
            }
            else {
                label.Visible = true;
            }
        }

        private void nom_input_TextChanged(object sender, EventArgs e)
        {
            comprobarCampo(nom_input.Text, confirmarNombre);
        }

        private void apellido_input_TextChanged(object sender, EventArgs e)
        {
            comprobarCampo(apellido_input.Text, confirmarApellido);
        }
    }
}
