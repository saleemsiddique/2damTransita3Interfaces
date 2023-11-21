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
    public partial class CrearIncidencia : Form
    {
        Dictionary<int, string> listaIdClientes = new Dictionary<int, string>();
        List<int> listaIdPuntos = new List<int>();
        List<Cliente> listaClientes;
        List<Punto> listaPuntos;

        public CrearIncidencia()
        {
            InitializeComponent();
            InicializarAsync();
            duracion_input.Text = "Sin determinar";
            
        }

        private async void InicializarAsync()
        {
            await Task.WhenAll(getClientes(), getPuntos());
            List<EstadoIncidencia> listaEstadosIncidencias = new List<EstadoIncidencia> { 
                EstadoIncidencia.ENVIADO, EstadoIncidencia.ACEPTADO, 
                EstadoIncidencia.ENPROCESO, EstadoIncidencia.FINALIZADO 
            };
            foreach (EstadoIncidencia estado in listaEstadosIncidencias)
            {
                estado_input.Items.Add(estado);
            }
            estado_input.SelectedIndex = 0;
        }

        public async Task getClientes()
        {
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "cliente";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            Console.WriteLine(response);
            listaClientes = JsonSerializer.Deserialize<List<Cliente>>(response);

            foreach (Cliente cliente in listaClientes)
            {
                listaIdClientes.Add(cliente.id, cliente.nombreUsuario);
            }
            foreach (var item in listaIdClientes)
            {
                cliente_input.Items.Add(new KeyValuePair<int, string>(item.Key, item.Value));
            }
        }

        public async Task crearIncidencia()
        {
            EstadoIncidencia estado;
            if (estado_input.Text == "ENVIADO")
            {
                estado = EstadoIncidencia.ENVIADO;
            }
            else if (estado_input.Text == "ENPROCESO")
            {
                estado = EstadoIncidencia.ENPROCESO;
            }
            else if (estado_input.Text == "FINALIZADO")
            {
                estado = EstadoIncidencia.FINALIZADO;
            }
            else
            {
                estado = EstadoIncidencia.ACEPTADO;
            }
            int clienteId;
            string clienteIdString = cliente_input.Text;
            clienteIdString = clienteIdString.Replace("[", "").Replace("]", "");
            string[] parts = clienteIdString.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2)
            {
                clienteId = int.Parse(parts[0].Trim());
                Console.WriteLine("Cliente ID: " + clienteId);
            }
            else
            {
                clienteId = -2;
                Console.WriteLine("Formato incorrecto en cliente_input");
            }
            int puntoId = int.Parse(punto_input.Text);
            string fechaFormateada = fecha_input.Value.ToString("yyyy-MM-dd");
            DateTime fechaDateTime = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Incidencia newIncidencia = new Incidencia(descripcion_input.Text, estado, duracion_input.Text, fechaDateTime, getCliente(clienteId), getPunto(puntoId), "");
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "incidencia";
            string content = JsonSerializer.Serialize(newIncidencia);
            string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);

            Console.WriteLine(response);

        }

        public Cliente getCliente(int id)
        {
            foreach (Cliente cliente in listaClientes)
            {
                if (cliente.id == id)
                {
                    return cliente;
                }
            }
            return null;
        }

        public Punto getPunto(int id)
        {
            foreach (Punto punto in listaPuntos)
            {
                if (punto.id == id)
                {
                    return punto;
                }
            }
            return null;
        }

        public async Task getPuntos()
        {
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "puntos";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            Console.WriteLine(response);
            listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);
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

        private void btn_cancelarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool verifyDatos()
        {
            if (descripcion_input.Text != "" && estado_input.Text != "" && duracion_input.Text != "" && cliente_input.Text != "" && punto_input.Text != "")
            {
                return true;
            }
            MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private async void btn_AceptarIncidencia_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de los datos de la incidencia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos())
                {
                    await crearIncidencia();

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is Transita)
                        {
                            Transita transita = (Transita)form;
                            transita.MostrarPanelDeIncidencia();
                        }
                    }
                    this.Close();
                }
            }
        }

        private void descripcion_input_TextChanged(object sender, EventArgs e)
        {
            comprobarCampo(descripcion_input.Text, comprobarDescripcion);
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