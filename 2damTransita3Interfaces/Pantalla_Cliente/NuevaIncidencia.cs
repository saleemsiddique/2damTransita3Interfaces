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
using System.Web.Helpers;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class NuevaIncidencia : Form
    {
        Dictionary<int, string> listaIdClientes = new Dictionary<int, string>();
        List<int> listaIdPuntos = new List<int>();
        Incidencia incidencia;
        Cliente cliente;
        Punto punto;

        public NuevaIncidencia(string idModificar)
        {
            InitializeComponent();
            incidenciaEditar.Text = "Incidencia: " + idModificar;
            InicializarAsync(idModificar);
            getCliente(1 + "");
        }

        private async void InicializarAsync(string idModificar)
        {
            await Task.WhenAll(getClientes(), getPuntos(), getIncidencia(idModificar), getCliente(cliente_input.Text.Substring(1, 1)));

            Console.WriteLine(incidencia.cliente.id + incidencia.cliente.nombreUsuario);

            if (incidencia != null)
            {
                descripcion_input.Text = incidencia.descripcion;
                duracion_input.Text = incidencia.duracion;
                int selecEstado = estado_input.FindStringExact(incidencia.estado.ToString());
                estado_input.SelectedIndex = selecEstado;
                fecha_input.Value = incidencia.fechaHora;
                int selecCliente = cliente_input.FindStringExact("[" + incidencia.cliente.id + ", " + incidencia.cliente.nombreUsuario + "]");
                cliente_input.SelectedIndex = selecCliente;
                int selecPunto = punto_input.FindStringExact(incidencia.punto.id.ToString());
                punto_input.SelectedIndex = selecPunto;
            }
        }

        public async Task getClientes()
        {
            Console.WriteLine("metodo ha sido activado");
            String url = "http://localhost:8083/cliente";
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJwcnVlYmExQGdtYWlsLmNvbSIsImlhdCI6MTY5ODU4ODQ2OCwiZXhwIjoxNjk4Njc0ODY4fQ.c_vlQ6q-tmdqfjDVeimg46dMJOE8Ch1Lr3z4VZDChGFkk6EGeu7jTGw4iOGWFiEfQnTiUiNps_03CXtYXxDJaQ"; // Reemplaza con el token adecuado, crea uno nuevo
            string response = await ApiClient.GetRequestAsync("GET", url, token);

            Console.WriteLine(response);
            List<Cliente> listaClientes = JsonSerializer.Deserialize<List<Cliente>>(response);

            foreach (Cliente cliente in listaClientes)
            {
                listaIdClientes.Add(cliente.id, cliente.nombreUsuario);
            }
            foreach (var item in listaIdClientes)
            {
                cliente_input.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
            }
        }

        public async Task modifyClientes(int id)
        {
            Incidencia incidencia = new Incidencia(id, descripcion_input.Text, estado_input.Text, duracion_input.Text, fecha_input.Value.ToString("yyyy-MM-dd"), cliente_input.Text.Substring(1, 1), punto_input.Text);
            Console.WriteLine("metodo ha sido activado");
            String url = "http://localhost:8083/incidencia/modificar/" + id;
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJwcnVlYmEwQGVtYWlsLmNvbSIsImlhdCI6MTY5ODY1MTg0NCwiZXhwIjoxNjk4NzM4MjQ0fQ.XqeVOLJsM00dH5-6IGIvC5OpEVCoWMhR7CjhDQjS0RS8SbSj7FKZw4d9i2bXxKZttUcS68uNEqN84NIc2_8FIA"; // Reemplaza con el token adecuado, crea uno nuevo
            string content = "";
            string response = await ApiClient.GetRequestAsync("PUT", url, token, content);

            incidencia = JsonSerializer.Deserialize<Incidencia>(response);
            Console.WriteLine(incidencia);

        }

        public async Task getIncidencia(String id)
        {
            Console.WriteLine("metodo ha sido activado");
            String url = "http://localhost:8083/incidencia/id/" + id;
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJwcnVlYmExQGdtYWlsLmNvbSIsImlhdCI6MTY5ODU4ODQ2OCwiZXhwIjoxNjk4Njc0ODY4fQ.c_vlQ6q-tmdqfjDVeimg46dMJOE8Ch1Lr3z4VZDChGFkk6EGeu7jTGw4iOGWFiEfQnTiUiNps_03CXtYXxDJaQ"; // Reemplaza con el token adecuado, crea uno nuevo
            string response = await ApiClient.GetRequestAsync("GET", url, token);

            incidencia = JsonSerializer.Deserialize<Incidencia>(response);
            List<EstadoIncidencia> listaEstadosIncidencias = new List<EstadoIncidencia> { EstadoIncidencia.Abierta, EstadoIncidencia.Revision, EstadoIncidencia.Cerrada };
            foreach (EstadoIncidencia estado in listaEstadosIncidencias)
            {
                estado_input.Items.Add(estado);
            }
            Console.WriteLine(incidencia);
        }

        public async Task getCliente(String id)
        {
            Console.WriteLine("metodo ha sido activado");
            String url = "http://localhost:8083/cliente/id/" + id;
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJwcnVlYmEwQGVtYWlsLmNvbSIsImlhdCI6MTY5ODY1MTg0NCwiZXhwIjoxNjk4NzM4MjQ0fQ.XqeVOLJsM00dH5-6IGIvC5OpEVCoWMhR7CjhDQjS0RS8SbSj7FKZw4d9i2bXxKZttUcS68uNEqN84NIc2_8FIA"; // Reemplaza con el token adecuado, crea uno nuevo
            string response = await ApiClient.GetRequestAsync("GET", url, token);

            cliente = JsonSerializer.Deserialize<Cliente>(response);
            Console.WriteLine("GET CLIENTE: " + cliente);
        }

        public async Task getPunto(String id)
        {
            Console.WriteLine("metodo ha sido activado");
            String url = "http://localhost:8083/puntos/id/" + id;
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJwcnVlYmEwQGVtYWlsLmNvbSIsImlhdCI6MTY5ODY1MTg0NCwiZXhwIjoxNjk4NzM4MjQ0fQ.XqeVOLJsM00dH5-6IGIvC5OpEVCoWMhR7CjhDQjS0RS8SbSj7FKZw4d9i2bXxKZttUcS68uNEqN84NIc2_8FIA"; // Reemplaza con el token adecuado, crea uno nuevo
            string response = await ApiClient.GetRequestAsync("GET", url, token);

            punto = JsonSerializer.Deserialize<Punto>(response);
            Console.WriteLine("GET PUNTO: " + punto);
        }

        public async Task getPuntos()
        {
            Console.WriteLine("metodo ha sido activado");
            String url = "http://localhost:8083/puntos";
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJwcnVlYmExQGdtYWlsLmNvbSIsImlhdCI6MTY5ODU4ODQ2OCwiZXhwIjoxNjk4Njc0ODY4fQ.c_vlQ6q-tmdqfjDVeimg46dMJOE8Ch1Lr3z4VZDChGFkk6EGeu7jTGw4iOGWFiEfQnTiUiNps_03CXtYXxDJaQ"; // Reemplaza con el token adecuado, crea uno nuevo
            string response = await ApiClient.GetRequestAsync("GET", url, token);

            Console.WriteLine(response);
            List<Punto> listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);
            foreach (Punto punto in listaPuntos)
            {
                Console.WriteLine(punto);
            }

            foreach (Punto punto in listaPuntos)
            {
                listaIdPuntos.Add(punto.id);
            }
            punto_input.Items.AddRange(listaIdPuntos.Select(p => p.ToString()).ToArray());
        }


        //// Cierra el formulario actual (NuevoCliente)
        private void btn_reportarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelClienteIncidencia_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormNuevoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
