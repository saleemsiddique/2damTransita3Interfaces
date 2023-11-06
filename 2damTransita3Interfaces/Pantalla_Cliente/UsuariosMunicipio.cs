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
    public partial class UsuariosMunicipio : Form
    {
        public UsuariosMunicipio()
        {
            InitializeComponent();
            getUsuarios();
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);
        }
        public async void getUsuarios()
        {
            Console.WriteLine("metodo ha sido activado");
            String url = Program.rutaBase + "cliente/RolMunicipio";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            Console.WriteLine(response);

            CrearPanelesUsuariosMunicipio(response);
        }
        private void CrearPanelesUsuariosMunicipio(String jsonClientes)
        {

            List<Cliente> listaUsuariosMunicipio = JsonSerializer.Deserialize<List<Cliente>>(jsonClientes);
            foreach (Cliente usuario in listaUsuariosMunicipio)
            { Console.WriteLine(usuario.ToString()); }

            int topPosition = 203; // Posición vertical inicial
            foreach (Cliente usuario in listaUsuariosMunicipio)
            {
                ClienteBanner clienteBanner = new ClienteBanner(); // Crea una instancia del UserControl
                clienteBanner.getId().Text = usuario.id + "";
                clienteBanner.getNombre().Text = $"{usuario.nombre} {usuario.apellidos}";

                clienteBanner.getViewBtn().Click += (sender, e) =>
                {
                    nombre.Text = usuario.nombre + " " + usuario.apellidos;
                    correo.Text = usuario.nombreUsuario;
                    id_mostrar.Text = usuario.id + "";
                    nombre_mostrar.Text = usuario.nombre;
                    apellido_mostrar.Text = usuario.apellidos;
                    nombreUsuario_mostrar.Text = usuario.nombreUsuario;
                };

                // Configura la ubicación y otros detalles según sea necesario
                clienteBanner.Location = new Point(51, topPosition); // Personaliza la ubicación
                topPosition += clienteBanner.Height + 30; // Ajusta el espaciado vertical según sea necesario
                clienteBanner.Anchor = AnchorStyles.Left | AnchorStyles.Right; // Anclaje para que se ajuste al tamaño del formulario
                clienteBanner.Show();
                // Agrega el control al formulario principal
                panel4.Controls.Add(clienteBanner);
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
