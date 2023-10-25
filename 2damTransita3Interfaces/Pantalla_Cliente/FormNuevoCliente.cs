using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class FormNuevoCliente : Form
    {
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        //// Cierra el formulario actual (NuevoCliente)
        private void btn_reportarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public async Task PostClientesAsync()
        {
            Console.WriteLine("El método ha sido activado");
            string apiUrl = "http://localhost:8083/cliente";
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJlbWFpbDNAZ21haWwuY29tIiwiaWF0IjoxNjk4MjMyMTU1LCJleHAiOjE2OTgzMTg1NTV9.7gEmnE8oGApLcK706FWiF22f_t3aZDp_n46t9wZpmgzrxX7qLr2LXSXVpatkb_VBTuwN8jce6o2I4Adt39fe6w"; // Reemplaza con tu token adecuado

            // Verifica que los datos de entrada sean válidos
            string nombre = textBox1.Text;
            string apellido = textBox2.Text;
            string correo = textBox3.Text;
            string contrasenya = textBox4.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contrasenya))
            {
                Console.WriteLine("Los datos del cliente son inválidos.");
                return;
            }

            Cliente c1 = new Cliente(2,nombre, apellido, correo, contrasenya, EstadoCuenta.ACTIVADO);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);


                string clienteJson = JsonConvert.SerializeObject(c1);
                Console.WriteLine(clienteJson);

                var content = new StringContent(clienteJson, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(responseContent);
                      
                    }
                    else
                    {
                        Console.WriteLine("La solicitud POST falló con el código: " + response.StatusCode);
                    }
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine("Error en la solicitud POST: " + ex.Message);
                }
            }
        }

        private void btn_crearCliente_Click(object sender, EventArgs e)
        {
            _ = PostClientesAsync();
        }


        /*public async Task PostClientesAsync()
        {
            Console.WriteLine("El método ha sido activado");
            string url = "http://localhost:8083/cliente";
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJlbWFpbDNAZ21haWwuY29tIiwiaWF0IjoxNjk4MjI5NzA1LCJleHAiOjE2OTgzMTYxMDV9.-O2LT-uFSa4-GiluSTGk3iEx_9_X4_-H0_YAvVzXZTNC9-ow4l7a_AYoHFDTKK3nprVRZzfIzP7WjxYDsloavA"; // Reemplaza con tu token adecuado

            using (HttpClient client = new HttpClient())
            {
                // Agrega el token de autenticación en los encabezados de la solicitud
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                // Crea el contenido que deseas enviar en la solicitud POST
                var content = new StringContent("aquí_puedes_pasar_los_datos_del_cliente", Encoding.UTF8, "application/json");

                // Realiza la solicitud POST
                HttpResponseMessage response = await client.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);

                    // Llama a la función para procesar la respuesta
                    CrearClienteEnBoton(responseContent);
                }
                else
                {
                    Console.WriteLine("La solicitud POST falló con el código: " + response.StatusCode);
                }
            }
        }*/
        /*private void CrearClienteEnBoton(String responsePost)
        {
            String nombre = textBox1.Text;
            String apellido = textBox2.Text;
            String correo = textBox3.Text;
            String contrasenya = textBox4.Text;
            Cliente c1 = new Cliente(nombre, apellido, correo, contrasenya, EstadoCuenta.ACTIVADO);

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = "http://localhost:8083/cliente";


                string clienteJson = JsonConvert.SerializeObject(c1);


                HttpContent content = new StringContent(clienteJson, Encoding.UTF8, "application/json");

                // Realiza la solicitud POST
                HttpResponseMessage response = client.PostAsync(apiUrl, content).Result;

                if (response.IsSuccessStatusCode)
                {
                    // Procesa la respuesta si es necesario
                    string respuestaApi = response.Content.ReadAsStringAsync().Result;
                    Console.WriteLine("Solicitud POST exitosa. Respuesta de la API: " + respuestaApi);
                }
                else
                {
                    Console.WriteLine("La solicitud POST falló con el código: " + response.StatusCode);
                }

            }
        }
    }*/
    }
}
