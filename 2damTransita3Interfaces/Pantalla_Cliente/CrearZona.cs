
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
        List<Zona> zonasList;
        List<string> zonasStringList = new List<string>();
        public CrearZona()
        {
            InitializeComponent();
            cargarZonaList();
        }

        private async void cargarZonaList() {
            ZonaService zonaService = new ZonaService();
            zonasList = await zonaService.GetZonasAsync();
            cargarZonaStringList();
        }

        private void cargarZonaStringList() {
            foreach (Zona zona in zonasList) {
                zonasStringList.Add(zona.nombre);
                Console.WriteLine(zona.nombre);
            }
        }

        private void btn_cancelarZona_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool verifyDatos()
        {
            if (nombre_input.Text == "")
            {
                MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (zonasStringList.Contains(nombre_input.Text))
            {
                MessageBox.Show("Verifica el nombre, Nombre ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public async Task crearZona()
        {

            string zonaNombre = nombre_input.Text;

            Zona newZona = new Zona(zonaNombre);
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "zona";
            string content = JsonSerializer.Serialize(newZona);
            string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);

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

        private void CrearZona_Load(object sender, EventArgs e)
        {

        }

        private void nombre_input_TextChanged(object sender, EventArgs e)
        {
            comprobarCampo(nombre_input.Text, confirmarNombre);
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

    }
}