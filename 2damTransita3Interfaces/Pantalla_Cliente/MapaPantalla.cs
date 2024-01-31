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
        private List<Punto> puntosFavoritos;
        private List<Punto> listaPuntosSinIncidencia;
        private List<Punto> puntos;
        private List<Incidencia> listaIncidencias;
        private int puntoMarcado = 0;
        private PuntoService puntoService = new PuntoService();
        GMapControl gmapControl;
        private GMapOverlay apiMarkersOverlay;
        public double LatitudNuevoPunto { get; private set; }
        public double LongitudNuevoPunto { get; private set; }

        private bool mensajeMostrado = false;
        double defaultLat = 38.5034;
        double defaultLng = -0.2271;
        GMarkerGoogle marker;
        private PointLatLng mapaPosicionInicial;
        public MapaPantalla()
        {
            InitializeComponent();
            cargarTodo();
            toolTipCrearPuntoButton.SetToolTip(btn_crearPunto,"Boton para crear un punto apartir de la marca en el mapa");
            toolTipMapCenter.SetToolTip(btn_resetPointer, "Boton para volver al centro de la vilajoiosa");
            toolTipCrearPuntoButton.SetToolTip(btnCrearIncidencia, "Boton para crear una incidencia apartir del punto seleccionado");
            listaIncidencias = new List<Incidencia>();
            gmapControl = new GMapControl();
            gmapControl.Dock = DockStyle.Fill;
            apiMarkersOverlay = new GMapOverlay("apiMarkers");
            gmapControl.Overlays.Add(apiMarkersOverlay);

            gmapControl.MapProvider = GMapProviders.GoogleMap;

            gmapControl.MinZoom = 7;
            gmapControl.MaxZoom = 25;
            gmapControl.Zoom = 15;


            panel1.Controls.Add(gmapControl);



            gmapControl.Position = new PointLatLng(defaultLat, defaultLng);
            gmapControl.MouseClick += GmapControl_OnMapClick;
            this.BackColor = Color.Red;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);
            
           
            gmapControl.OnMarkerClick += GmapControl_OnMarkerClick;
        }

        public MapaPantalla(int idCliente) {
            InitializeComponent();
            cargarFavoritos(idCliente);
            toolTipCrearPuntoButton.SetToolTip(btn_crearPunto, "Boton para crear un punto apartir de la marca en el mapa");
            toolTipMapCenter.SetToolTip(btn_resetPointer, "Boton para volver al centro de la vilajoiosa");
            toolTipCrearPuntoButton.SetToolTip(btnCrearIncidencia, "Boton para crear una incidencia apartir del punto seleccionado");
            listaIncidencias = new List<Incidencia>();
            gmapControl = new GMapControl();
            gmapControl.Dock = DockStyle.Fill;
            apiMarkersOverlay = new GMapOverlay("apiMarkers");
            gmapControl.Overlays.Add(apiMarkersOverlay);

            gmapControl.MapProvider = GMapProviders.GoogleMap;

            gmapControl.MinZoom = 7;
            gmapControl.MaxZoom = 25;
            gmapControl.Zoom = 15;


            panel1.Controls.Add(gmapControl);



            gmapControl.Position = new PointLatLng(defaultLat, defaultLng);
            gmapControl.MouseClick += GmapControl_OnMapClick;
            this.BackColor = Color.Red;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);


            gmapControl.OnMarkerClick += GmapControl_OnMarkerClick;
        }

        private async void cargarTodo() {
            await obtenerIncidencias();
            await ObtenerPuntos();
        }

        private async void cargarFavoritos(int idCliente) {
            puntosFavoritos = await puntoService.GetPuntosFavoritos(idCliente);
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            gmapControl.Overlays.Add(markersOverlay);
            // Itera sobre la lista de puntos y coloca un marcador en el mapa por cada punto
            foreach (var punto in puntosFavoritos)
            {
                var marker = new GMarkerGoogle(new PointLatLng(punto.latitud, punto.longitud), GMarkerGoogleType.yellow);
                marker.Tag = punto;
                markersOverlay.Markers.Add(marker);
            }
        }

        private void GmapControl_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (item.Tag is Punto punto)
            {
                // Busca todas las incidencias asociadas al punto clicado
                var incidenciasDelPunto = new List<Incidencia>();
                puntoMarcado = punto.id;


                foreach (var incidencia in listaIncidencias)
                {
                    // Compara los identificadores (id) de los puntos
                    if (incidencia.punto.id == punto.id)
                    {
                        incidenciasDelPunto.Add(incidencia);
                    }
                }

                // Verifica si hay incidencias asociadas al punto
                if (incidenciasDelPunto.Count > 0)
                {

                    // Limpia el contenido del ListBox antes de agregar nuevos elementos
                    listBoxIncidencias.Items.Clear();

                    // Agrega el id y descripción del punto al ListBox
                    listBoxIncidencias.Items.Add($"ID del Punto: {punto.id}, Descripción: {punto.descripcion}");

                    foreach (var incidencia in incidenciasDelPunto)
                    {
                        listBoxIncidencias.Items.Add(" ");
                        // Agrega la información de la incidencia al ListBox con saltos de línea
                        listBoxIncidencias.Items.Add($"Id: {incidencia.id}");
                        listBoxIncidencias.Items.Add($"Descripcion: {incidencia.descripcion}");
                        listBoxIncidencias.Items.Add($"Duracion: {incidencia.duracion}");
                        listBoxIncidencias.Items.Add($"Estado: {incidencia.estado}");
                        listBoxIncidencias.Items.Add($"Fecha: {incidencia.fechaHora}");

                    }

                    // Puedes ajustar la visibilidad del control ListBox según tus necesidades
                    listBoxIncidencias.Visible = true;
                }
                else
                {
                    listBoxIncidencias.Items.Clear();
                    listBoxIncidencias.Items.Add($"Punto con Id: {punto.id}");
                    listBoxIncidencias.Items.Add($"Descripcion: {punto.descripcion}");
                }

                // Marcar que el mensaje ha sido mostrado
                mensajeMostrado = true;
            }

        }
        private void GmapControl_OnMapClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (puntoMarcado == 0)
                {
                    // Almacena la posición inicial del mapa antes del primer clic
                    mapaPosicionInicial = gmapControl.Position;
                }

                puntoMarcado = 0;
                listBoxIncidencias.Items.Clear();
                PointLatLng point = gmapControl.FromLocalToLatLng(e.X, e.Y);

                LatitudNuevoPunto = point.Lat;
                LongitudNuevoPunto = point.Lng;

                if (marker != null)
                {
                    marker.Position = point;
                }
                else
                {
                    // Habilita el botón
                    btn_crearPunto.Enabled = true;
                    btnCrearIncidencia.Enabled = true;

                    // Añade un nuevo marcador en el lugar del clic si no existe
                    marker = new GMarkerGoogle(point, GMarkerGoogleType.blue);
                    GMapOverlay markersOverlay = new GMapOverlay("markers");
                    markersOverlay.Markers.Add(marker);
                    gmapControl.Overlays.Add(markersOverlay);
                }

                // Restaura la posición inicial del mapa después de agregar el marcador
                gmapControl.Position = mapaPosicionInicial;
            }
        }

     
        public void ColocarMarcadoresEnMapaPuntosSinIncidencia()
        {
            // Crea una única capa de superposición para todos los marcadores
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            gmapControl.Overlays.Add(markersOverlay);
            // Itera sobre la lista de puntos y coloca un marcador en el mapa por cada punto
            foreach (var puntos in listaPuntosSinIncidencia)
            {

                var marker = new GMarkerGoogle(new PointLatLng(puntos.latitud, puntos.longitud), GMarkerGoogleType.green);
                if (puntos.accesibilidadPunto == AccesibilidadTipo.ACCESIBLE) {
                    marker = new GMarkerGoogle(new PointLatLng(puntos.latitud, puntos.longitud), GMarkerGoogleType.green);
                } else if (puntos.accesibilidadPunto == AccesibilidadTipo.PARCIALMENTE_ACCESIBLE) {
                    marker = new GMarkerGoogle(new PointLatLng(puntos.latitud, puntos.longitud), GMarkerGoogleType.orange);
                } else {
                    marker = new GMarkerGoogle(new PointLatLng(puntos.latitud, puntos.longitud), GMarkerGoogleType.red);
                }
                marker.Tag = puntos;
                markersOverlay.Markers.Add(marker);
            }
        }
    
        

        public async Task ObtenerPuntos()
        {
            listaPuntosSinIncidencia = await puntoService.GetPuntosTodos();
            ColocarMarcadoresEnMapaPuntosSinIncidencia();
        }


        public async Task obtenerIncidencias()
        {
           
            listaIncidencias = await incidenciaService.GetIncidenciasAsync(0);
            puntos = await puntoService.GetAllPuntos();
        }

        public Panel ObtenerPanelCentralMapa()
        {
            return panel_central;
        }

        public Panel ObtenerPanelDerechaMapa() {
            return panel_derecha;
        }

        public void verFavoritos() {
            btn_crearPunto.Visible = false;
            btnCrearIncidencia.Visible = false;
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

       

        private void btn_crearPunto_Click(object sender, EventArgs e)
        {
           
            CrearPunto crearPuntoForm = new CrearPunto();

            crearPuntoForm.LatitudPuntoMapa = LatitudNuevoPunto;
            crearPuntoForm.LongitudPuntoMapa = LongitudNuevoPunto;

            crearPuntoForm.ShowDialog();
        }

        private void btnCrearIncidencia_Click(object sender, EventArgs e)
        {
            CrearIncidencia crearIncidencia;

            if (puntoMarcado == 0)
            {
                puntoMarcado = puntos.Last().id + 1;
                crearIncidencia = new CrearIncidencia(puntoMarcado, LatitudNuevoPunto, LongitudNuevoPunto);
                Console.WriteLine(puntoMarcado);
            }
            else {
                crearIncidencia = new CrearIncidencia(puntoMarcado);
            }
            
            crearIncidencia.ShowDialog();
        }
    }
}
