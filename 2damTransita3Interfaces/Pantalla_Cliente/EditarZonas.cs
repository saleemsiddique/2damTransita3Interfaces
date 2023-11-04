using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class EditarZonas : Form
    {
        private int idZona;
        Zona zona;
        public EditarZonas(string idModificar)
        {
            InitializeComponent();
            idZona = int.Parse(idModificar);
            InicializarAsync(idModificar);
        }

        private async void InicializarAsync(string idModificar)
        {
            await Task.WhenAll(getZona(idModificar));
        }

        public async Task modifyZona(int id)
        {
            string nombreZona = zona_input.Text;

            Zona newZona = new Zona(nombreZona);
            Console.WriteLine("Método ha sido activado");
            String url = Program.configurations.rutaBase + "zona/modificar/" + id;
            string content = JsonSerializer.Serialize(newZona);
            string response = await ApiClient.GetRequestAsync("PUT", url, Program.configurations.token, content);

            Console.WriteLine(newZona);
            Console.WriteLine(response);
        }

        public async Task getZona(String id)
        {
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "zona/id/" + id;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            zona = JsonSerializer.Deserialize<Zona>(response);
            zona_input.Text = zona.nombre;
        }

        private bool verifyDatos()
        {
            if (zona_input.Text != "")
            {
                return true;
            }
            MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

     

        private void btn_AceptarIncidencia_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar la zona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos())
                {
                    _ = modifyZona(idZona);

                    Form formularioPadre = this.Owner;

                    if (formularioPadre != null)
                    {
                        if (formularioPadre is Transita)
                        {
                            Transita formularioTransita = (Transita)formularioPadre;
                            formularioTransita.MostrarPanelDeZona();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void btn_reportarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
