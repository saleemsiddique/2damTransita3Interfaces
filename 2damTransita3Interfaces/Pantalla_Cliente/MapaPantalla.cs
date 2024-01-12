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
        private List<Punto> listaPuntos;
        private PuntoService puntoService = new PuntoService();
        GMapControl gmapControl;
        private GMapOverlay apiMarkersOverlay;
        double minLat = 36.0; // Latitud mínima
        double maxLat = 43.8; // Latitud máxima
        double minLng = -10.0; // Longitud mínima
        double maxLng = 4.0; // Longitud máxima

        // Coordenadas de La Vila Joiosa
        double defaultLat = 38.5034;
        double defaultLng = -0.2271;
        GMarkerGoogle marker;
        public MapaPantalla()
        {
            InitializeComponent();
            

            // Crear la instancia de GMapControl
            gmapControl = new GMapControl();
            gmapControl.Dock = DockStyle.Fill;
            apiMarkersOverlay = new GMapOverlay("apiMarkers");
            gmapControl.Overlays.Add(apiMarkersOverlay);
            // Configurar el proveedor de mapas (en este caso, GoogleMapProvider)
            gmapControl.MapProvider = GMapProviders.GoogleMap;
            
            // Configurar la posición y el nivel de zoom inicial dentro de España
            gmapControl.Position = new PointLatLng(defaultLat, defaultLng);
            gmapControl.MinZoom = 7;
            gmapControl.MaxZoom = 25;
            gmapControl.Zoom = 15;

            

            // Añadir el control GMapControl al panel1
            panel1.Controls.Add(gmapControl);

            // Suscribirse al evento OnPositionChanged para controlar la posición del mapa
           //gmapControl.OnPositionChanged += GmapControl_OnPositionChanged;
           gmapControl.MouseClick += GmapControl_OnMapClick;

            this.BackColor = Color.Red;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

            _ = ObtenerPuntosConIncidenciaAsync();
           
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
                var marker = new GMarkerGoogle(new PointLatLng(punto.latitud, punto.longitud), GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);

                // Cambiado a MarkerClick en lugar de MouseClick
   
            }

            // Agrega la capa de superposición con todos los marcadores al mapa
            gmapControl.Overlays.Add(markersOverlay);
        }
        public void QuitarMarcadores()
        {
            // Elimina todos los marcadores de la capa de la API
            apiMarkersOverlay.Markers.Clear();
        }

        public async Task ObtenerPuntosConIncidenciaAsync()
        {
            listaPuntos = await puntoService.GetPuntosConIncidenciasAsync();
            ColocarMarcadoresEnMapa(); // Agregar los nuevos marcadores
        }


        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            // Maneja la actualización aquí
            gmapControl.Refresh();
        }

        /*private void GmapControl_OnPositionChanged(PointLatLng point)
        {
            // Verificar y ajustar la posición del mapa para mantenerla dentro de España
            if (point.Lat < minLat || point.Lat > maxLat || point.Lng < minLng || point.Lng > maxLng)
            {
                // Si está fuera de las coordenadas permitidas, ajustar la posición a La Vila Joiosa
                gmapControl.Position = new PointLatLng(defaultLat, defaultLng);
            }
        }*/
        private void Marker_MarkerClick(GMapMarker item, MouseEventArgs e)
        {
            var punto = (Punto)item.Tag;
            MostrarInformacionDelPunto(punto);
        }

        private void MostrarInformacionDelPunto(Punto punto)
        {
            // Implementa aquí la lógica para mostrar la información del punto
            // Puedes utilizar MessageBox, mostrar en una etiqueta, etc.
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
