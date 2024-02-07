using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{

    public partial class ModificarContrasenyaUsuarioMunicipio : Form
    {
        Cliente usuario;
        int idMod;
        string regexContrasenya = @"^[a-zA-Z0-9]{8,40}$";
        string noMatch = "La contraseña ha de tener de 8 a 40 \n carácteres alfanuméricos";
        string noPass = "INTRODUCE CAMPO";

        public ModificarContrasenyaUsuarioMunicipio(String idModificar)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            idMod = int.TryParse(idModificar, out int parsedId) ? parsedId : 0;
            getCliente(idModificar);
        }

        public async Task getCliente(string idModificar)
        {
            String url = Program.rutaBase + "cliente/id/" + idMod.ToString();
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            usuario = JsonSerializer.Deserialize<Cliente>(response);
            idLabel.Text += usuario.id;
            nombreUsuarioLabel.Text += usuario.nombreUsuario;           
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verificarDatos())
                {
                    Task task = modificarContrasenya(idMod);

                    task.ContinueWith(t =>
                    {
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

        private bool verificarDatos() {
            if (contrasenyaBox.Text != "" && confirmarBox.Text != "") {
                if (confirmarBox.Text.Equals(contrasenyaBox.Text)) {
                    return true;
                }
                MessageBox.Show("Las contraseñas introducidas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private async Task modificarContrasenya(int idMod) {
            string content = $"{{\"contrasenya\": \"{contrasenyaBox.Text}\"}}";

            String url = Program.rutaBase + "api/auth/cliente/modificarContrasenya/" + idMod;
            string response = await ApiClient.GetRequestAsync("PUT", url, Program.token, content);
        }

        private void contrasenyaBox_TextChanged(object sender, EventArgs e)
        {
            string contrasenya = contrasenyaBox.Text;
            if (contrasenya.Equals(""))
            {
                noContrasenya.Visible = true;
                noContrasenya.Text = noPass;
                noContrasenya.Height = 15;
            }
            else
            {
                noContrasenya.Visible = false;
                if (!isValidPassword(contrasenya))
                {
                    noContrasenya.Text = noMatch;
                    noContrasenya.Visible = true;
                    noContrasenya.Height = 30;
                }
            }
        }

        private void confirmarBox_TextChanged(object sender, EventArgs e)
        {
            string contrasenya = confirmarBox.Text;
            if (contrasenya.Equals(""))
            {
                noConfirmacion.Visible = true;
                noConfirmacion.Text = noPass;
                noConfirmacion.Height = 15;
            }
            else
            {
                noConfirmacion.Visible = false;
                if (isValidPassword(contrasenya))
                {
                    noConfirmacion.Text = noMatch;
                    noConfirmacion.Visible = true;
                    noConfirmacion.Height = 30;
                }

            }
        }

        private bool isValidPassword(string contrasenya)
        {
            if (Regex.IsMatch(contrasenya, regexContrasenya)) {
                return true;
            }

            return false;
        }
    }
}
