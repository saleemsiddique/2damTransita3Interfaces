
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
    public partial class CrearZona : Form
    {
        public CrearZona()
        {
            InitializeComponent();
        }

        private void btn_cancelarZona_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool verifyDatos()
        {
            if (nombre_input.Text != "")
            {
                return true;
            }
            MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public async Task crearZona()
        {

            string zonaNombre = nombre_input.Text;

            Zona newZona = new Zona(zonaNombre);
            Console.WriteLine("metodo ha sido activado");
            String url = Program.configurations.rutaBase + "zona";
            string content = JsonSerializer.Serialize(newZona);
            string response = await ApiClient.GetRequestAsync("POST", url, Program.configurations.token, content);

            Console.WriteLine(response);

        }
        private void btn_AceptarZona_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de los datos de la Zona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos())
                {
                    _ = crearZona();

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is Transita)
                        {
                            Transita transita = (Transita)form;
                            transita.MostrarPanelDeZona();
                        }
                    }
                    this.Close();
                }
            }
        }

        private void descripcion_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_AceptarIncidencia_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de los datos de la Zona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos())
                {
                    _ = crearZona();

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is Transita)
                        {
                            Transita transita = (Transita)form;
                            transita.MostrarPanelDeZona();
                        }
                    }
                    this.Close();
                }
            }
        }

        private void btn_cancelarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}