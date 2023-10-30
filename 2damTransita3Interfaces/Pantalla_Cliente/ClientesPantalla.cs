using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;

namespace Pantalla_Cliente
{
    public partial class Cliente_Pantalla : Form
    {

        public Cliente_Pantalla()
        {
            InitializeComponent();
            getClientes();
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12); 
        }

        public Panel ObtenerPanelCentralCliente()
        {
            return panel_central;
        }

        public Panel ObtenerPanelDerechaCliente()
        {
            return panel_derecha;
        }

        public async Task getClientes()
        {
            Console.WriteLine("metodo ha sido activado");
            String url = "http://localhost:8083/cliente";
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJwcnVlYmEwQGVtYWlsLmNvbSIsImlhdCI6MTY5ODY1MTg0NCwiZXhwIjoxNjk4NzM4MjQ0fQ.XqeVOLJsM00dH5-6IGIvC5OpEVCoWMhR7CjhDQjS0RS8SbSj7FKZw4d9i2bXxKZttUcS68uNEqN84NIc2_8FIA"; // Reemplaza con el token adecuado, crea uno nuevo
            string response = await ApiClient.GetRequestAsync("GET", url, token);
            
            Console.WriteLine(response);

            CrearPanelesClientes(response);
        }

        private void CrearPanelesClientes(String jsonClientes)
        {

            List<Cliente> listaClientes = JsonSerializer.Deserialize<List<Cliente>>(jsonClientes);
            foreach (Cliente cliente in listaClientes)
            { Console.WriteLine(cliente.ToString()); }

            int topPosition = 203; // Posición vertical inicial
            foreach (Cliente cliente in listaClientes)
            {
                ClienteBanner clienteBanner = new ClienteBanner(); // Crea una instancia del UserControl
                clienteBanner.getId().Text = cliente.id + "";
                clienteBanner.getNombre().Text = $"{cliente.nombre} {cliente.apellidos}";

                clienteBanner.getViewBtn().Click += (sender, e) =>
                {
                    nombre.Text = cliente.nombre + " " + cliente.apellidos;
                    correo.Text = cliente.nombreUsuario;
                    id_mostrar.Text = cliente.id + "";
                    nombre_mostrar.Text = cliente.nombre;
                    apellidos_mostrar.Text = cliente.apellidos;
                    email_mostrar.Text = cliente.nombreUsuario;
                };

                // Configura la ubicación y otros detalles según sea necesario
                clienteBanner.Location = new Point(51, topPosition); // Personaliza la ubicación
                topPosition += clienteBanner.Height + 30; // Ajusta el espaciado vertical según sea necesario
                clienteBanner.Anchor = AnchorStyles.Left | AnchorStyles.Right; // Anclaje para que se ajuste al tamaño del formulario
                clienteBanner.Show();
                // Agrega el control al formulario principal
                panel_central.Controls.Add(clienteBanner);
            }
        }




        //Codigo para el Boton Favorito
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox5.Image = Properties.Resources.estrellaAmarilla_fotor_bg_remover_20231021185036; // Cambia la imagen a la estrella seleccionada
            }
            else
            {
                pictureBox5.Image = Properties.Resources.estrellaNegra_fotor_bg_remover_2023102118503; // Cambia la imagen a la estrella no seleccionada
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = !radioButton1.Checked;
        }


        //Para hacer el boton circular de añadir nuevo cliente

        private void buttonAddCliente_Paint(object sender, PaintEventArgs e)
        {

            System.Windows.Forms.Button btn1 = (System.Windows.Forms.Button)sender;
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(2, 2, btn1.Width-5, btn1.Height-5);
            btn1.Region = new Region(gp);
        }

        private void buttonAddCliente_Click_1(object sender, EventArgs e)
        {

        }

        //PlaceHolder del botton de buscar cliente
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

        //Boton para cerrar la aplicación
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimizar la pantalla
        private void buttonMinimizarr_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void PantallaCliente_Load(object sender, EventArgs e)
        {

        }

        private void fondoGrisMid_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button8_Click(object sender, EventArgs e)
        {
   
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_incidencias_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buscarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void modify_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void buscarTextBox_Leave_1(object sender, EventArgs e)
        {
            // Cuando el TextBox pierde el foco, restaura el texto
            if (string.IsNullOrWhiteSpace(buscarTextBox.Text))
            {
                buscarTextBox.Text = "Buscar"; // Puedes cambiar este texto predeterminado
            }
        }

        private void buscarTextBox_Click(object sender, EventArgs e)
        {
            buscarTextBox.Text = "";
        }
    }

    /*Codigo para refrescar la unica pantalla usa
     * private void btnCambiarContenido_Click(object sender, EventArgs e)
{
    // Borra el contenido actual del Panel
    panelContenido.Controls.Clear();

    // Crea y agrega un nuevo control o formulario al Panel
    var nuevoContenido = new MiNuevoControl(); // Reemplaza 'MiNuevoControl' con el control que deseas mostrar
    panelContenido.Controls.Add(nuevoContenido);

    // Ajusta el tamaño del nuevo contenido
    nuevoContenido.Dock = DockStyle.Fill;
}*/
}
