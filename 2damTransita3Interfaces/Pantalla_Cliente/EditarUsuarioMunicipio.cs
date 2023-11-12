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
    public partial class EditarUsuarioMunicipio : Form
    {
        Cliente user;
        int idMod;
        public EditarUsuarioMunicipio(string idModificar)
        {
            InitializeComponent();
            idMod = int.TryParse(idModificar, out int parsedId) ? parsedId : 0;
            getCliente(idModificar);
        }
        public async Task getCliente(string idModificar)
        {
            Console.WriteLine("El método ha sido activado");

                // La conversión fue exitosa, y el valor se almacena en idMod como un entero.
                Console.WriteLine("El valor convertido a entero es: " + idMod);

                String url = Program.rutaBase + "cliente/id/" + idMod.ToString();
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

                Console.WriteLine(response);

                user = JsonSerializer.Deserialize<Cliente>(response);
                nombre_input.Text = user.nombreUsuario;
                nom_input.Text = user.nombre;
                apellido_input.Text = user.apellidos;
                int selecEstado = rol_input.FindStringExact(user.rols.ToString());
                rol_input.SelectedIndex = selecEstado;
        }


        private void btn_reportarUsuarioMuni_Click(object sender, EventArgs e)
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
                Console.WriteLine(rolObjt);
            string content = $"{{\"nombre\": \"{nom_input.Text}\", \"apellidos\": \"{apellido_input.Text}\", \"nombreUsuario\": \"{nombre_input.Text}\", \"contrasenya\": \"{pass1.Text}\", \"rol\": [\"{rolObjt}\"]}}";

            Console.WriteLine("metodo ha sido activado");
                String url = Program.rutaBase + "api/auth/cliente/modificar/" + idMod;
                //string content = JsonSerializer.Serialize(user);
                string response = await ApiClient.GetRequestAsync("PUT", url, Program.token, content);

                Console.WriteLine(response);
            }
        }

        private bool verifyDatos()
        {
            if (nom_input.Text != "" && nombre_input.Text != "" && apellido_input.Text != "")
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
    }
}
