using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class PuntosPantalla : Form
    {
        private PuntoService puntoService = new PuntoService();
        public PuntosPantalla()
        {
            InitializeComponent();
            InitializeComponent();
            obtenerPuntos();
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

            btn_filtrar.FlatStyle = FlatStyle.Flat;
            btn_filtrar.FlatAppearance.BorderSize = 0;
        }

        private async void obtenerPuntos()
        {

            List<Punto> listaPuntos = await puntoService.GetPuntosAsync();
            CrearPanelesPuntos(listaPuntos);
           
        }
        private void CrearPanelesPuntos(List<Punto> listaPuntos)
        {

            foreach (Punto punto in listaPuntos)
            { Console.WriteLine(punto.ToString()); }

            int topPosition = 0; 

            foreach (Punto punto in listaPuntos)
            {
                PuntoBanner puntoBanner = new PuntoBanner();

                puntoBanner.getId().Text = punto.id.ToString();
                puntoBanner.getNombre().Text = $"{punto.accesibilidadPunto}";

                puntoBanner.getViewBtn().Click += (sender, e) =>
                {
                    //idPunto.Text = $"ID: {punto.id}";
                    //nombre.Text = incidencia.descripcion;
                    id_mostrar.Text = punto.id.ToString();
                    puntoDescripcion_mostrar.Text = punto.descripcion;
                    latitud_mostrar.Text = punto.latitud.ToString();
                    longitud_mostrar.Text = punto.longitud.ToString();
                    accesibilidad_mostrar.Text = punto.accesibilidadPunto.ToString();
                    tipopunto_mostrar.Text = punto.tipoPunto.ToString();
                    visibilidadpunto_mostar.Text = punto.visibilidadPunto.ToString();
                };


                // Configura la ubicación y otros detalles según sea necesario
                puntoBanner.Location = new Point(0, topPosition); // Personaliza la ubicación
                topPosition += puntoBanner.Height + 30; // Ajusta el espaciado vertical según sea necesario
                //incidenciaBanner.Anchor = AnchorStyles.Left | AnchorStyles.Right; // Anclaje para que se ajuste al tamaño del formulario
                puntoBanner.Show();
                // Agrega el control al formulario principal
                panelPuntos.Controls.Add(puntoBanner);
            }
        }
        public Panel ObtenerPanelCentralPunto()
        {
            return panel_central;
        }

        public Panel ObtenerPanelDerechaPunto()
        {
            return panel_derecha;
        }

        private void panel_central_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
