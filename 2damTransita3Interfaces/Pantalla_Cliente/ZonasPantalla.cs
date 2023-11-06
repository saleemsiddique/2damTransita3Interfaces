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
        public ZonasPantalla()
        {
            InitializeComponent();
            getZonas();
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

           
        }

        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            CrearZona crearZona = new CrearZona();
            crearZona.Owner = this;
            crearZona.Show();
        }
        public async void getZonas()
        {
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "zonas";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            Console.WriteLine(response);

            CrearPanelesZonas(response);
        }

        private void CrearPanelesZonas(String jsonZonas)
        {
            List<Zona> listazonas = JsonSerializer.Deserialize<List<Zona>>(jsonZonas);
            foreach (Zona zona in listazonas)
            { Console.WriteLine(zona.ToString()); }

            int topPosition = 203; // Posición vertical inicial

            foreach (Zona zona in listazonas)
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


                zonaBanner.Location = new Point(51, topPosition); 
                topPosition += zonaBanner.Height + 30;
                zonaBanner.Anchor = AnchorStyles.Left | AnchorStyles.Right;
                zonaBanner.Show();
               
                panel4.Controls.Add(zonaBanner);
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

        private void botonVerDatosIncidencia_Click(object sender, EventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureZona_Click(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void correo_Click(object sender, EventArgs e)
        {

        }

        private void id_mostrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_mostrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void buscarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void imgTransita_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
