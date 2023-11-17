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
    public partial class ModificarContrasenyaUsuarioMunicipio : Form
    {
        Cliente usuario;
        int idMod;
        public ModificarContrasenyaUsuarioMunicipio(String idModificar)
        {
            InitializeComponent();
            idMod = int.TryParse(idModificar, out int parsedId) ? parsedId : 0;
            getCliente(idModificar);
        }

        public async Task getCliente(string idModificar)
        {
            String url = Program.rutaBase + "cliente/id/" + idMod.ToString();
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            Console.WriteLine(response);

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
                Console.WriteLine("no esta vacia");
                if (confirmarBox.Text.Equals(contrasenyaBox.Text)) {
                    Console.WriteLine("son iguales");
                    return true;
                }
                MessageBox.Show("Las contraseñas introducidad no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private async Task modificarContrasenya(int idMod) {
            Console.WriteLine("modificar contraseña");
            string content = $"{{\"contrasenya\": \"{contrasenyaBox.Text}\"}}";

            String url = Program.rutaBase + "api/auth/cliente/modificarContrasenya/" + idMod;
            string response = await ApiClient.GetRequestAsync("PUT", url, Program.token, content);
            Console.WriteLine(response);
        }

        private void contrasenyaBox_TextChanged(object sender, EventArgs e)
        {
            if (contrasenyaBox.Text.Equals(""))
            {
                noContrasenya.Visible = true;
            }
            else {
                noContrasenya.Visible = false;
            }
        }

        private void confirmarBox_TextChanged(object sender, EventArgs e)
        {
            if (confirmarBox.Text.Equals(""))
            {
                noConfirmacion.Visible = true;
            }
            else
            {
                noConfirmacion.Visible = false;
            }
        }

    }
}
