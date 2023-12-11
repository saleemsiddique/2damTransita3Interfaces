using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class PuntosPantalla : Form
    {
        private PuntoService puntoService = new PuntoService();
        private bool esVisible = false;
        private string filtroTipo = "";
        private string filtroAccesibilidad = "";
        private string filtroVisibilidad = "";
        public string filtroTipoActual = "";
        public string filtroAccesibilidadActual = "";
        public string filtroVisibilidadActual = "";
        private int paginasTotalesActual;
        private List<Punto> listaPuntos;
        private int idInicial;
        private int idFinal;
        private int idPrincipio;
        private int paginasTotales;
        private int paginaActual = 1;

        public PuntosPantalla()
        {
            InitializeComponent();
            this.BackColor = Color.Red;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

            btn_filtrar.FlatStyle = FlatStyle.Flat;
            btn_filtrar.FlatAppearance.BorderSize = 0;

            // Asigna el evento al botón Aceptar
            buttonAceptar.Click += buttonAceptar_Click;

            // Asigna el evento al botón Filtrar
            btn_filtrar.Click += btn_filtrar_Click;

            // Inicializa la obtención de puntos
            ObtenerPuntos(filtroTipo, filtroAccesibilidad, filtroVisibilidad);
        }

        public Panel ObtenerPanelCentralPunto()
        {
            return panel_central;
        }

        public Panel ObtenerPanelDerechaPunto()
        {
            return panel_derecha;
        }

        public async void ObtenerPuntos(string filtroTipo, string filtroAccesibilidad, string filtroVisibilidad)
        {

            filtroTipoActual = filtroTipo;
            filtroAccesibilidadActual = filtroAccesibilidad;
            filtroVisibilidadActual = filtroVisibilidad;

            await ObtenerIdInicialYFinal();

            idPrincipio = idInicial;
            listaPuntos = await puntoService.GetPuntosAsync(filtroTipo, filtroAccesibilidad, filtroVisibilidad, idInicial, idFinal);
            CrearPanelesPuntos(listaPuntos);
        }

        private async Task ObtenerIdInicialYFinal()
        {
            idInicial = 1;
            idFinal = idInicial + 3;
            paginasTotalesActual = await puntoService.GetNumeroPuntosConFiltros(filtroTipo, filtroAccesibilidad, filtroVisibilidad);

            if (paginasTotalesActual % 4 != 0)
            {
                paginasTotalesActual = paginasTotalesActual / 4;
                paginasTotalesActual++;
            }
            else
            {
                paginasTotalesActual = paginasTotalesActual / 4;
            }

            if (paginasTotalesActual != 0)
            {
                paginas.Text = paginaActual + "/" + paginasTotalesActual;
            }
            else
            {
                paginas.Text = 0 + "/" + paginasTotalesActual;
            }
        }

        public async Task ObtenerPuntosRefresh()
        {
            await ObtenerIdInicialYFinal();
            idPrincipio = idInicial;
            listaPuntos = await puntoService.GetPuntosAsync(filtroTipo, filtroAccesibilidad, filtroVisibilidad, idInicial, idFinal);
            CrearPanelesPuntos(listaPuntos);
        }

        private async Task ObtenerPuntosNextBack()
        {            
            paginas.Text = paginaActual + "/" + paginasTotalesActual;
            idPrincipio = idInicial;
            listaPuntos = await puntoService.GetPuntosAsync(filtroTipo, filtroAccesibilidad, filtroVisibilidad, idInicial, idFinal);
            CrearPanelesPuntos(listaPuntos);
        }

        private void CrearPanelesPuntos(List<Punto> listaPuntos)
        {
            foreach (Punto punto in listaPuntos)
            {
                Console.WriteLine(punto.ToString());
            }

            int topPosition = 0;

            foreach (Punto punto in listaPuntos)
            {
                PuntoBanner puntoBanner = new PuntoBanner();

                puntoBanner.getId().Text = punto.id.ToString();
                puntoBanner.getNombre().Text = $"{punto.accesibilidadPunto}";

                puntoBanner.getViewBtn().Click += (sender, e) =>
                {
                    id_mostrar.Text = punto.id.ToString();
                    puntoDescripcion_mostrar.Text = punto.descripcion;
                    latitud_mostrar.Text = punto.latitud.ToString();
                    longitud_mostrar.Text = punto.longitud.ToString();
                    accesibilidad_mostrar.Text = punto.accesibilidadPunto.ToString();
                    tipopunto_mostrar.Text = punto.tipoPunto.ToString();
                    visibilidadpunto_mostar.Text = punto.visibilidadPunto.ToString();
                };

                puntoBanner.Location = new Point(0, topPosition);
                topPosition += puntoBanner.Height + 30;
                puntoBanner.Show();
                panelPuntos.Controls.Add(puntoBanner);
            }
        }

        private async void adelanteBtn_Click(object sender, EventArgs e)
        {
            if (paginaActual < paginasTotalesActual)
            {
                LimpiarVisualizacion();
                idInicial += 4;
                idFinal = idInicial + 3;
                paginaActual++;
                await ObtenerPuntosNextBack();
            }
        }

        private async void atrasBtn_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                if (idInicial >= idPrincipio)
                {
                    LimpiarVisualizacion();
                    idInicial -= 4;
                    idFinal = idInicial + 3;
                    paginaActual--;
                    await ObtenerPuntosNextBack();
                }
            }
        }

        private void LimpiarVisualizacion()
        {
            listaPuntos.Clear();
            foreach (Control control in panelPuntos.Controls.OfType<PuntoBanner>().ToList())
            {
                panelPuntos.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if (esVisible)
            {
                groupBox1.Visible = false;
                esVisible = false;
            }
            else
            {
                groupBox1.Visible = true;
                esVisible = true;
            }
        }

        private void btn_addPunto_Click_1(object sender, EventArgs e)
        {
            CrearPunto punto = new CrearPunto();
            punto.Owner = this;
            punto.ShowDialog();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    foreach (Control control in checkBox.Parent.Controls)
                    {
                        if (control is CheckBox otherCheckBox && !otherCheckBox.Equals(checkBox))
                        {
                            otherCheckBox.Checked = false;
                        }
                    }
                }
            }
        }

        private async void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (filtro_acceso.Checked)
            {
                filtroTipo = "ACCESO";
                Console.WriteLine("ACCESO");
            }
            else if (filtro_lugar.Checked)
            {
                filtroTipo = "LUGAR";
                Console.WriteLine("LUGAR");
            }
            else
            {
                filtroTipo = "";
            }

            if (filtro_accesible.Checked)
            {
                filtroAccesibilidad = "ACCESIBLE";
                Console.WriteLine("ACCESIBLE");
            }
            else if (filtro_noAccesible.Checked)
            {
                filtroAccesibilidad = "NO_ACCESIBLE";
                Console.WriteLine("NO ACCESIBLE");
            }
            else if (filtro_parcialmenteAccesible.Checked)
            {
                filtroAccesibilidad = "PARCIALMENTE_ACCESIBLE";
                Console.WriteLine("PARCIAL");
            }
            else
            {
                filtroAccesibilidad = "";
            }

            if (filtro_global.Checked)
            {
                filtroVisibilidad = "GLOBAL";
                Console.WriteLine("GLOBAL");
            }
            else if (filtro_incidencia.Checked)
            {
                filtroVisibilidad = "INCIDENCIA";
                Console.WriteLine("INCIDENCIA");
            }
            else if (filtro_favorito.Checked)
            {
                filtroVisibilidad = "FAVORITO";
                Console.WriteLine("FAV");
            }
            else if (filtro_oculto.Checked)
            {
                filtroVisibilidad = "OCULTO";
                Console.WriteLine("OCULTO");
            }
            else
            {
                filtroVisibilidad = "";
            }

            LimpiarVisualizacion();
            groupBox1.Visible = false;
            esVisible = false;

            id_mostrar.Text = "";
            descripcionPunto_mostrar.Text = "";
            latitud_mostrar.Text = "";
            longitud_mostrar.Text = "";
            accesibilidad_mostrar.Text = "";
            tipopunto_mostrar.Text = "";
            visibilidadpunto_mostar.Text = "";

            await ObtenerPuntosRefresh();
            paginaActual = 1;
            paginas.Text = paginaActual + "/" + paginasTotalesActual;

        }

        private void btn_filtrar_Click(object sender, MouseEventArgs e)
        {

        }
    }
}
