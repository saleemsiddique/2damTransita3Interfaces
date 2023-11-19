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
        List<int> listaIdZonas = new List<int>();
        List<Zona> listaZonas;
        List<Punto> listaPuntos;

        public EditarPunto(String idPunto)
        {
            InitializeComponent();
            idMod = int.TryParse(idPunto, out int parsedId) ? parsedId : 0;
            getZonas();
            getPunto();

        }

        private void EditarPunto_Load(object sender, EventArgs e)
        {

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
        public async Task getZonas()
        {
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "zonas";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            Console.WriteLine(response);
            listaZonas = JsonSerializer.Deserialize<List<Zona>>(response);
            foreach (Zona zona in listaZonas)
            {
                Console.WriteLine(zona);
            }

            foreach (Zona zona in listaZonas)
            {
                listaIdZonas.Add(zona.id);
            }
            comboBoxZona.Items.AddRange(listaIdZonas.Select(p => p.ToString()).ToArray());
        }

        private async Task modifyPunto(int idMod)
        {
                
                
            
                string content = "";

                Console.WriteLine("metodo ha sido activado");
                String url = Program.rutaBase + "punto/modificar/" + idMod;
                
                string response = await ApiClient.GetRequestAsync("PUT", url, Program.token, content);

               
            
        }


        //metodo cerrar pestaña
        private void btn_cancelarPunto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AceptarPunto_Click(object sender, EventArgs e)
        {

        }
    }
}
