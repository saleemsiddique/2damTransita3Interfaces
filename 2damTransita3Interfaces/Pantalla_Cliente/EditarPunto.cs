using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class EditarPunto : Form
    {
        Punto punto;
        int idMod;
        List<Punto> listaPuntos;

        public EditarPunto(String idPunto)
        {
            InitializeComponent();
            idMod = int.TryParse(idPunto, out int parsedId) ? parsedId : 0;
            //getZonas();
            getPunto();

        }

        private void EditarPunto_Load(object sender, EventArgs e)
        {

        }
        private bool verifyDatos()
        {
            if (descripcionPunto_input.Text != "" && latitudPunto_input.Text != "" && longitudPunto_input.Text != "" && comboBoxAccesibilidad.Text != "" && comboBoxTipoPunto.Text != "" && comboBoxVisibilidadPunto.Text != "")
            {
                return true;
            }
            MessageBox.Show("Verifica los datos introducidos, no pueden haber campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        public async Task getPunto()
        {
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "puntos/id/" + idMod;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            punto = JsonSerializer.Deserialize<Punto>(response);
            descripcionPunto_input.Text = punto.descripcion;
            latitudPunto_input.Text = punto.latitud.ToString();
            longitudPunto_input.Text = punto.longitud.ToString();
            comboBoxAccesibilidad.Text = punto.accesibilidadPunto.ToString();
            comboBoxTipoPunto.Text = punto.tipoPunto.ToString();
            comboBoxVisibilidadPunto.Text = punto.visibilidadPunto.ToString();




        }
        private async Task modifyPunto(int idMod)
        { 
            string content = $"{{\"descripcion\": \"{descripcionPunto_input.Text}\", \"tipoPunto\": \"{comboBoxTipoPunto.SelectedItem}\", \"foto\": \"{"foto.jpg"}\", \"latitud\": {latitudPunto_input.Text}, \"longitud\": {longitudPunto_input.Text}, \"accesibilidadPunto\": \"{comboBoxAccesibilidad.SelectedItem}\", \"visibilidadPunto\": \"{comboBoxVisibilidadPunto.SelectedItem}\"}}";

            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "punto/modificar/" + idMod;

            string response = await ApiClient.GetRequestAsync("PUT", url, Program.token, content);
        }


        
        private void btn_cancelarPunto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AceptarPunto_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas modificar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                if (verifyDatos()){
                    Task task = modifyPunto(idMod);

                    task.ContinueWith(t =>
                    {
                        // This part will be executed when modifyUser completes, but won't block the UI
                        Form formularioPadre = this.Owner;

                        if (formularioPadre != null)
                        {
                            if (formularioPadre is Transita)
                            {
                                Transita formularioTransita = (Transita)formularioPadre;
                                formularioTransita.MostrarPanelDePunto();
                                this.Close();
                            }
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());
                }
            }
        }

        private void limitarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
