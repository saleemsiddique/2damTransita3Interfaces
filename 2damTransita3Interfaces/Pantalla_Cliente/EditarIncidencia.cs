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
    public partial class EditarIncidencia : Form
    {
        Dictionary<int, string> listaIdClientes = new Dictionary<int, string>();
        List<int> listaIdPuntos = new List<int>();
        List<Cliente> listaClientes;
        List<Punto> listaPuntos;
        Incidencia incidencia;

        public EditarIncidencia(string idModificar)
        {
            InitializeComponent();
            incidenciaEditar.Text = "Incidencia: " + idModificar;
            InicializarAsync(idModificar);
        }

        private async void InicializarAsync(string idModificar)
        {
            await Task.WhenAll(getClientes(), getPuntos(), getIncidencia(idModificar));

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

        public async Task modifyIncidencia(int id)
        {
            EstadoIncidencia estado;
            if (estado_input.Text == "ABIERTA")
            {
                estado = EstadoIncidencia.Abierta;
            }
            else if (estado_input.Text == "CERRADA")
            {
                estado = EstadoIncidencia.Cerrada;
            }
            else
            {
                estado = EstadoIncidencia.Revision;
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
            String url = Program.rutaBase + "incidencia/modificar/" + id;
            string content = JsonSerializer.Serialize(newIncidencia);
            string response = await ApiClient.GetRequestAsync("PUT", url, Program.token, content);

            Console.WriteLine(incidencia);
            Console.WriteLine(response);
        }

        public async Task getIncidencia(String id)
        {
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "incidencia/id/" + id;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            incidencia = JsonSerializer.Deserialize<Incidencia>(response);
            List<EstadoIncidencia> listaEstadosIncidencias = new List<EstadoIncidencia> { EstadoIncidencia.Abierta, EstadoIncidencia.Cerrada,
                                                                                          EstadoIncidencia.Revision};
            foreach (EstadoIncidencia estado in listaEstadosIncidencias)
            {
                estado_input.Items.Add(estado);
            }
            Console.WriteLine(incidencia);
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

        private bool verifyDatos()
        {
            if (descripcion_input.Text != "" && estado_input.Text != "" && duracion_input.Text != "" && cliente_input.Text != "" && punto_input.Text != "")
            {
                return true;
            }
            MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btn_AceptarIncidencia_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar la incidencia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos())
                {
                    modifyIncidencia(incidencia.id);

                    Form formularioPadre = this.Owner;

                    if (formularioPadre != null)
                    {

                        if (formularioPadre is Transita)
                        {
                            Transita formularioTransita = (Transita)formularioPadre;
                            formularioTransita.MostrarPanelDeIncidencia();
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}