﻿using System;
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
            Punto punto;
            double latitud, longitud;
            
                // La conversión fue exitosa, puedes usar latitud y longitud aquí
               
                // Create a Punto object and set its properties
                punto = new Punto
                {
                    descripcion = puntoDescripcion_input.Text,
                    tipoPunto = tipoPunto,
                    foto = "foto.jpg",
                    latitud = latitudPunto_input.Text, // Usar la variable latitud convertida a double
                    longitud = longitudPunto_input.Text, // Usar la variable longitud convertida a double
                    accesibilidadPunto = accesibilidadTipo,
                    visibilidadPunto = eVisibilidad,
                };

                string content = $"{{\"descripcion\": \"{punto.descripcion}\", " +
                                         $"\"tipoPunto\": \"{punto.tipoPunto}\", " +
                                         $"\"foto\": \"{punto.foto}\", " +
                                         $"\"latitud\": {punto.latitud}, " +
                                         $"\"longitud\": {punto.longitud}, " +
                                         $"\"accesibilidadPunto\": \"{punto.accesibilidadPunto}\", " +
                                         $"\"visibilidadPunto\": \"{punto.visibilidadPunto}\"}}";

                Console.WriteLine("Método ha sido activado");
                String url = Program.rutaBase + "puntos";
                string response = await ApiClient.GetRequestAsync("POST", url, Program.token, content);

                Console.WriteLine(response);
            
           

            
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
                // Si hay datos, establecer los textos de los labels
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
                            transita.MostrarPanelDePunto();
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

            // Asegúrate de que solo haya un punto decimal
            TextBox textBox = sender as TextBox;
            if (textBox != null && e.KeyChar == '.' && textBox.Text.Contains(".") && e.KeyChar == '-' && textBox.Text.Contains('-'))
            {
                e.Handled = true;
            }
        }


    }
}




/* json de get punto
 * {
  "descripcion": "punto 1",
  "tipoPunto": "ACCESO",
  "foto": "foto.jpg",
  "latitud": 3993.0,
  "longitud": -3.2183138E7,
  "accesibilidadPunto": "ACCESIBLE",
  "visibilidadPunto": "GLOBAL",
  "zona": {
      "nombre": "zona 1",
      "id": 1
  },
  "id": 1
}*/
