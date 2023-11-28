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
        private bool esVisible = false;
        private string filtroTipo = "%20";
        private string filtroAccesibilidad = "%20";
        private string filtroVisibilidad = "%20";
        private List<Punto> listaPuntos;

        public PuntosPantalla()
        {
            InitializeComponent();
            obtenerPuntos(filtroTipo, filtroAccesibilidad, filtroVisibilidad);
            this.BackColor = Color.Red;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

            btn_filtrar.FlatStyle = FlatStyle.Flat;
            btn_filtrar.FlatAppearance.BorderSize = 0;
        }

        private async Task obtenerPuntos(string filtroTipo, string filtroAccesibilidad, string filtroVisibilidad)
        {

            listaPuntos = await puntoService.GetPuntosAsync(filtroTipo, filtroAccesibilidad, filtroVisibilidad);
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


        private void btn_addPunto_Click_1(object sender, EventArgs e)
        {
            CrearPunto punto = new CrearPunto();
            punto.Owner = this;
            punto.ShowDialog();
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

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Asegúrate de que solo un CheckBox está seleccionado en cada GroupBox
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    // Desmarca todos los demás CheckBoxes en el mismo GroupBox
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

        private void buttonAceptar_Click(object sender, EventArgs e)
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
                filtroTipo = "%20";
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
                Console.WriteLine("PARICAL");
            }
            else
            {
                filtroAccesibilidad = "%20";
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
                filtroVisibilidad = "%20";
            }


            limpiarVisualizacion();
            groupBox1.Visible = false;
            esVisible = false;
            puntoImg = null;
            nombre.Text = "";
            id_mostrar.Text = "";
            descripcionPunto_mostrar.Text = "";
            latitud_mostrar.Text = "";
            longitud_mostrar.Text = "";
            accesibilidad_mostrar.Text = "";
            tipopunto_mostrar.Text = "";
            visibilidadpunto_mostar.Text = "";

            Task task = obtenerPuntos(filtroTipo, filtroAccesibilidad, filtroVisibilidad);
            task.ContinueWith(t =>
            {
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
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void limpiarVisualizacion()
        {
            listaPuntos.Clear();
            foreach (Control control in panelPuntos.Controls.OfType<PuntoBanner>().ToList())
            {
                panelPuntos.Controls.Remove(control);
                control.Dispose();
            }
        }
    }
}
