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
    public partial class CrearPunto : Form
    {
        public double LatitudPuntoMapa { get; set; }
        public double LongitudPuntoMapa { get; set; }
        public CrearPunto()
        {
            InitializeComponent();
            InicializarAsync();
            this.StartPosition = FormStartPosition.CenterScreen;
         
        }
        private async void InicializarAsync()
        {
           
        }
        private void label_datosInciencia_Click(object sender, EventArgs e)
        {

        }

        private void incidenciaEditar_Click(object sender, EventArgs e)
        {

        }

       

        private void btn_cancelarPunto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async Task crearPunto()
        {
            
            EVisibilidad eVisibilidad = EVisibilidad.GLOBAL;
            TipoPunto tipoPunto = new TipoPunto();
            AccesibilidadTipo accesibilidadTipo = new AccesibilidadTipo();
            if (comboBoxTipoPunto.Text.Equals("ACCESO"))
            {
                tipoPunto = TipoPunto.ACCESO;
            }
            else if (comboBoxTipoPunto.Text.Equals("LUGAR"))
            {
                tipoPunto = TipoPunto.LUGAR;
            }

            if (comboBoxAccesibilidad.Text.Equals("ACCESIBLE"))
            {
                accesibilidadTipo = AccesibilidadTipo.ACCESIBLE;
            }
            else if (comboBoxAccesibilidad.Text.Equals("NO_ACCESIBLE"))
            {
                accesibilidadTipo = AccesibilidadTipo.ACCESIBLE;
            }
            else if (comboBoxAccesibilidad.Text.Equals("PARCIALMENTE_ACCESIBLE")) {
                accesibilidadTipo = AccesibilidadTipo.PARCIALMENTE_ACCESIBLE;
            }
            string content = $"{{\"descripcion\": \"{puntoDescripcion_input.Text}\", " +
                                         $"\"tipoPunto\": \"{tipoPunto}\", " +
                                         $"\"foto\": \"{"foto.jpg"}\", " +
                                         $"\"latitud\": {latitudPunto_input.Text.Replace(",", ".")}, " +
                                         $"\"longitud\": {longitudPunto_input.Text.Replace(",", ".")}, " +
                                         $"\"accesibilidadPunto\": \"{accesibilidadTipo}\", " +
                                         $"\"visibilidadPunto\": \"{eVisibilidad}\"}}";
          
            Console.WriteLine("Método ha sido activado");
                String url = Program.rutaBase + "puntos";
                string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);


        }

      
            private bool verifyDatos()
            {
                if (puntoDescripcion_input.Text != "" && latitudPunto_input.Text != "" && longitudPunto_input.Text != "" && comboBoxAccesibilidad.Text != "" && comboBoxTipoPunto.Text != "" && comboBoxVisibilidadPunto.Text != "")
                {
                    return true;
                }
                MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        

        private void CrearPunto_Load(object sender, EventArgs e)
        {
            if (LatitudPuntoMapa > -1 && LatitudPuntoMapa > -1)
            {
              
                latitudPunto_input.Text = LatitudPuntoMapa.ToString();
                longitudPunto_input.Text = LongitudPuntoMapa.ToString();
            }
        }

        private async void btn_AceptarPunto_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres dar de alta este punto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos())
                {
                    await crearPunto();

                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is Transita)
                        {
                            Transita transita = (Transita)form;
                            if (latitudPunto_input.Text.Length > 0)
                            {
                                transita.MostrarPanelDeMapa();
                            }
                            else {
                                transita.MostrarPanelDePunto();
                            }
                            
                            
                        }
                    }
                    this.Close();
                }
            }
        }

        private void limitarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

        
            TextBox textBox = sender as TextBox;
            if (textBox != null && e.KeyChar == '.' && textBox.Text.Contains(".") && e.KeyChar == '-' && textBox.Text.Contains('-'))
            {
                e.Handled = true;
            }
        }

        private void puntoDescripcion_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (puntoDescripcion_input.Text.Length > 200) { 
                e.Handled = true;
            }
        }
    }
}

