using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Pantalla_Cliente
{
    
    
    public partial class MapaPantalla : Form
    {
        private IncidenciaService incidenciaService = new IncidenciaService();
        private List<Punto> listaPuntos;
        private List<Incidencia> listaIncidencias;
        private PuntoService puntoService = new PuntoService();
        GMapControl gmapControl;
        private GMapOverlay apiMarkersOverlay;
        double minLat = 36.0; 
        double maxLat = 43.8; 
        double minLng = -10.0; 
        double maxLng = 4.0; 

       
        double defaultLat = 38.5034;
        double defaultLng = -0.2271;
        GMarkerGoogle marker;
        public MapaPantalla()
        {
            InitializeComponent();
            

            gmapControl = new GMapControl();
            gmapControl.Dock = DockStyle.Fill;
            apiMarkersOverlay = new GMapOverlay("apiMarkers");
            gmapControl.Overlays.Add(apiMarkersOverlay);
          
            gmapControl.MapProvider = GMapProviders.GoogleMap;
            
            
            gmapControl.Position = new PointLatLng(defaultLat, defaultLng);
            gmapControl.MinZoom = 7;
            gmapControl.MaxZoom = 25;
            gmapControl.Zoom = 15;

          
            panel1.Controls.Add(gmapControl);

            
           gmapControl.MouseClick += GmapControl_OnMapClick;

            this.BackColor = Color.Red;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

            _ = ObtenerPuntosConIncidenciaAsync();
            gmapControl.OnMarkerClick += GmapControl_OnMarkerClick;

        }

        private void GmapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (item.Tag is Punto punto)
            {
                // El mouse ha hecho clic en el marcador o ha pasado sobre él
                MessageBox.Show($"Información del Punto:\nLatitud: {punto.latitud}\nLongitud: {punto.longitud}\nOtra Información: {punto.id}");
            }
        }
        private void GmapControl_OnMapClick(object sender, MouseEventArgs e)
        {
            // Verifica si se hizo clic con el botón izquierdo del ratón
            if (e.Button == MouseButtons.Left)
            {
                // Obtén las coordenadas del clic en el mapa
                PointLatLng point = gmapControl.FromLocalToLatLng(e.X, e.Y);

                // Muestra las coordenadas en los Label
                latitudData.Text = $"{point.Lat}";
                longitudData.Text = $"{point.Lng}";

                // Mueve el marcador actual si ya existe
                if (marker != null)
                {
                    marker.Position = point;
                }
                else
                {
                    // Añade un nuevo marcador en el lugar del clic si no existe
                    marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);
                    GMapOverlay markersOverlay = new GMapOverlay("markers");
                    markersOverlay.Markers.Add(marker);
                    gmapControl.Overlays.Add(markersOverlay);
                    
                }
            }
        }
        public void ColocarMarcadoresEnMapa()
        {
          
            // Crea una única capa de superposición para todos los marcadores
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            // Itera sobre la lista de puntos y coloca un marcador en el mapa por cada punto
            foreach (var punto in listaPuntos)
            {
                gmapControl.Overlays.Add(markersOverlay);
                var marker = new GMarkerGoogle(new PointLatLng(punto.latitud, punto.longitud), GMarkerGoogleType.red);
                marker.Tag = punto;
                markersOverlay.Markers.Add(marker);
               

            }

          
        }
        public void QuitarMarcadores()
        {
            // Elimina todos los marcadores de la capa de la API
            apiMarkersOverlay.Markers.Clear();
        }

        public async Task ObtenerPuntosConIncidenciaAsync()
        {
            listaPuntos = await puntoService.GetPuntosConIncidenciasAsync();
            ColocarMarcadoresEnMapa(); 
        }
        /*public async Task obtenerIncidencias(4)
        {
           
            listaIncidencias = await incidenciaService.GetIncidenciasAsync();
            

        }*/

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Maneja la actualización aquí
            gmapControl.Refresh();
        }

  
        private void Marker_MarkerClick(GMapMarker item, MouseEventArgs e)
        {
            var punto = (Punto)item.Tag;
            MostrarInformacionDelPunto(punto);
        }

        private void MostrarInformacionDelPunto(Punto punto)
        {
            
            MessageBox.Show($"Información del punto - Latitud: {punto.latitud}, Longitud: {punto.longitud}");
        }
        public Panel ObtenerPanelCentralMapa()
        {
            return panel_central;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void incidencia_img_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_resetPointer_Click(object sender, EventArgs e)
        {
            gmapControl.Position = new PointLatLng(defaultLat, defaultLng);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    

   
    }
}
