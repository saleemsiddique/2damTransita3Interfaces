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
    public partial class ZonasPantalla : Form
    {
        private ZonaService zonaService = new ZonaService();
        public ZonasPantalla()
        {
            InitializeComponent();
            getZonas();
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

           
        }

        private void buttonAddZona_Click(object sender, EventArgs e)
        {
            CrearZona crearZona = new CrearZona();
            crearZona.Owner = this;
            crearZona.ShowDialog();
        }
        public async void getZonas()
        {
            List<Zona> listaZonas = await zonaService.GetZonasAsync();
            listaZonas = listaZonas.OrderBy(x => x.id).ToList();
            CrearPanelesZonas(listaZonas);
        }

        private void CrearPanelesZonas(List<Zona> listaZonas)
        {
            
            foreach (Zona zona in listaZonas)
            { Console.WriteLine(zona.ToString()); }

            int topPosition = 0; // Posición vertical inicial

            foreach (Zona zona in listaZonas)
            {
                ZonaBanner zonaBanner = new ZonaBanner();

                zonaBanner.getId().Text = zona.id.ToString();
                zonaBanner.getNombre().Text = zona.nombre.ToString();


                zonaBanner.getViewBtn().Click += (sender, e) =>
                {
                    nombre.Text = zona.nombre;
                    correo.Text = $"ID: {zona.id}";
                    nombre_mostrar.Text = zona.nombre;
                    id_mostrar.Text = zona.id.ToString();
                };


                zonaBanner.Location = new Point(0, topPosition); 
                topPosition += zonaBanner.Height + 30;
                //zonaBanner.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                zonaBanner.Show();
               
                panelZonas.Controls.Add(zonaBanner);
            }
        }
        public Panel ObtenerPanelCentralZona()
        {
            return panel4;
        }

        public Panel ObtenerPanelDerechaZona()
        {
            return panel3;
        }



        private void buscarTextBox_Enter(object sender, EventArgs e)
        {
            if (buscarTextBox.Text == "Buscar")
            {
                buscarTextBox.Text = "";
            }
        }

        private void buscarTextBox_Leave(object sender, EventArgs e)
        {
            if (buscarTextBox.Text == "")
            {
                buscarTextBox.Text = "Buscar";
            }
        }

    }
}
