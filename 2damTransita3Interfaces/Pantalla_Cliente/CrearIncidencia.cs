using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
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
        string imagen = null;
        public int idPuntoDeMapa { get; set; }
        private int puntoMarcado;
        private bool isNuevo = false;
        private double latitud, longitud;

        public CrearIncidencia(int index, double lat, double lng)
        {
            InitializeComponent();
            isNuevo = true;
            latitud = lat;
            longitud = lng;
            puntoMarcado = index;
            InicializarAsync();
            MessageBox.Show("" + index);
            this.StartPosition = FormStartPosition.CenterScreen;
            duracion_input.Text = "Sin determinar";
        }

        public CrearIncidencia(int index) {
            InitializeComponent();
            puntoMarcado = index;
            InicializarAsync();
            MessageBox.Show("" + index);
            this.StartPosition = FormStartPosition.CenterScreen;
            duracion_input.Text = "Sin determinar";
        }

        public CrearIncidencia()
        {
            InitializeComponent();
            comboBoxAccesibilidad.Visible = false;
            accessTxt.Visible = false;
            InicializarAsync();
            this.StartPosition = FormStartPosition.CenterScreen;
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

            if (puntoMarcado != null) { 
                punto_input.SelectedItem = puntoMarcado.ToString();
            }

            if (isNuevo)
            {
                punto_input.SelectedItem = puntoMarcado;
            }
            else {
                accessTxt.Visible = false;
                comboBoxAccesibilidad.Visible = false;
            }
            
        }

        public async Task getClientes()
        {
            String url = Program.rutaBase + "cliente";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

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
            }
            else
            {
                clienteId = -2;
            }
            int puntoId = int.Parse(punto_input.Text);
            string fechaFormateada = fecha_input.Value.ToString("yyyy-MM-dd");
            DateTime fechaDateTime = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            if (idPuntoDeMapa > 0)
            {
                Incidencia newIncidencia = new Incidencia(descripcion_input.Text, estado, duracion_input.Text, fechaDateTime, getCliente(clienteId), getPunto(idPuntoDeMapa), imagen);
                String url = Program.rutaBase + "incidencia";
                string content = JsonSerializer.Serialize(newIncidencia);
                string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);
            }
            else {
                Incidencia newIncidencia = new Incidencia(descripcion_input.Text, estado, duracion_input.Text, fechaDateTime, getCliente(clienteId), getPunto(puntoId), imagen);
                String url = Program.rutaBase + "incidencia";
                string content = JsonSerializer.Serialize(newIncidencia);
                string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);
            }
        }
        private void CrearIncidencia_Load(object sender, EventArgs e)
        {
            if (idPuntoDeMapa > -1) {
                punto_input.Text = idPuntoDeMapa.ToString();
                
            }
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
        public void anyadirPunto()
        {
            if (idPuntoDeMapa > 0)
            {
                punto_input.Text = idPuntoDeMapa.ToString();
            }
        }
        public async Task getPuntos()
        {
            if (listaIdPuntos != null) {
                listaIdPuntos.Clear();
            }
            String url = Program.rutaBase + "puntos";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);

            foreach (Punto punto in listaPuntos)
            {
                listaIdPuntos.Add(punto.id);
            }
            punto_input.Items.AddRange(listaIdPuntos.Select(p => p.ToString()).ToArray());

            if (puntoMarcado > listaPuntos.Last().id)
            {
                punto_input.Items.Add(puntoMarcado);
            }
        }

        private void btn_cancelarIncidencia_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool verifyDatos()
        {
            if (descripcion_input.Text != "" && estado_input.Text != "" && duracion_input.Text != "" && cliente_input.Text != "" && punto_input.Text != "" && imagen != null)
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
                        if (isNuevo) {
                            await crearPunto();
                        }
                    await getPuntos();
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

        private void subir_img_btn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = Program.fileFilter;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                string base64ImageString = ImageToBase64(image);
                imagen = base64ImageString;
                string[] rutaImagen = openFileDialog1.FileName.Split('\\');
                nombreArchivoLabel.Text = rutaImagen[rutaImagen.Length-1];
            }
        }

        private string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);

                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            }
        }

        private void descripcion_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (descripcion_input.Text.Length > 100)
            {
                e.Handled = true;
            }
        }

        private async Task crearPunto() {
            string latString = latitud.ToString();
            string lngString = longitud.ToString();
            string content = $"{{\"descripcion\": \"\", " +
                                         $"\"tipoPunto\": \"LUGAR\", " +
                                         $"\"foto\": \"\", " +
                                         $"\"latitud\": {latString.Replace(",", ".")}, " +
                                         $"\"longitud\": {lngString.Replace(",", ".")}, " +
                                         $"\"accesibilidadPunto\": \"{comboBoxAccesibilidad.SelectedItem}\", " +
                                         $"\"visibilidadPunto\": \"GLOBAL\"}}";
            String url = Program.rutaBase + "puntos";
            string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);

        }

    }
}