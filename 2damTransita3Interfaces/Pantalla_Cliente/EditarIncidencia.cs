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
        string imagen = null;

        public EditarIncidencia(string idModificar)
        {
            InitializeComponent();
            incidenciaEditar.Text = "Incidencia: " + idModificar;
            InicializarAsync(idModificar);
        }

        private async void InicializarAsync(string idModificar)
        {
            await Task.WhenAll(getClientes(), getPuntos(), getIncidencia(idModificar));


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

        public async Task modifyIncidencia(int id)
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
            else if (estado_input.Text == "FINALIZADO") {
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
            Incidencia newIncidencia = new Incidencia(descripcion_input.Text, estado, duracion_input.Text, fechaDateTime, getCliente(clienteId), getPunto(puntoId), imagen);
            String url = Program.rutaBase + "incidencia/modificar/" + id;
            string content = JsonSerializer.Serialize(newIncidencia);
            Console.WriteLine("\n\n\n content" + content );
            string response = await ApiClient.GetRequestAsync("PUT", url, Program.token, content);

            Console.WriteLine("\n\n\n\n response" + response);
        }

        public async Task getIncidencia(String id)
        {
            String url = Program.rutaBase + "incidencia/id/" + id;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            incidencia = JsonSerializer.Deserialize<Incidencia>(response);
            List<EstadoIncidencia> listaEstadosIncidencias = new List<EstadoIncidencia> {
                EstadoIncidencia.ENVIADO, EstadoIncidencia.ACEPTADO,
                EstadoIncidencia.ENPROCESO, EstadoIncidencia.FINALIZADO
            };
            foreach (EstadoIncidencia estado in listaEstadosIncidencias)
            {
                estado_input.Items.Add(estado);
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

        public async Task getPuntos()
        {
            String url = Program.rutaBase + "puntos";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);
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
                nombreArchivoLabel.Text = rutaImagen[rutaImagen.Length - 1];
            }
        }

        private string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convertir la imagen a bytes
                image.Save(ms, image.RawFormat);

                // Convertir los bytes a cadena Base64
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);

                return base64String;
            }
        }



    }
}