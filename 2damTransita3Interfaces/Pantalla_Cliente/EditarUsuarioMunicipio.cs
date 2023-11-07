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
        public EditarUsuarioMunicipio(string idModificar)
        {
            InitializeComponent();
            getCliente(idModificar);
        }
        public async Task getCliente(string idModificar)
        {
            Console.WriteLine("El método ha sido activado");

            if (int.TryParse(idModificar, out int idMod))
            {
                // La conversión fue exitosa, y el valor se almacena en idMod como un entero.
                Console.WriteLine("El valor convertido a entero es: " + idMod);

                String url = Program.rutaBase + "cliente/id/" + idMod.ToString();
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

                Console.WriteLine(response);

                user = JsonSerializer.Deserialize<Cliente>(response);
                textbox1.Text = user.nombreUsuario;
                textBox5.Text = user.nombre;
                textBox2.Text = user.apellidos;
                int selecEstado = rol_input.FindStringExact(user.rol.ToString());
                rol_input.SelectedIndex = selecEstado;
            }
            else
            {
                // La conversión falló, el valor de idModificar no es un número entero válido.
                Console.WriteLine("El valor no se pudo convertir a entero.");
            }
        }


        private void btn_reportarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AceptarIncidencia_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void punto_input_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
