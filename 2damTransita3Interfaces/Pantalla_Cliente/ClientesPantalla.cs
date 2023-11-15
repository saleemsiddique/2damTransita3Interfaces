using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Button = System.Windows.Forms.Button;
//TODO: Hacer pantalla de carga de clientes
namespace Pantalla_Cliente
{
    public partial class Cliente_Pantalla : Form
    {
        private ClienteService clienteService = new ClienteService();

        public Cliente_Pantalla()
        {
            InitializeComponent();
            ObtenerClientes();
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


        private async void ObtenerClientes() {


            // Objeto loadingForm 
            List<Cliente> listCliente = await clienteService.GetClientesAsync();
            // acabar del loadingform a true cierras el form
            CrearPanelesClientes(listCliente);
        }

        private void CrearPanelesClientes(List<Cliente> listaClientes)
        {

            foreach (Cliente cliente in listaClientes)
            { Console.WriteLine(cliente.ToString()); }

            int topPosition = 0; // Posición vertical inicial
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
                clienteBanner.Location = new Point(0, topPosition); // Personaliza la ubicación
                topPosition += clienteBanner.Height + 30; // Ajusta el espaciado vertical según sea necesario
                //clienteBanner.Anchor = AnchorStyles.Left | AnchorStyles.Right; // Anclaje para que se ajuste al tamaño del formulario
                clienteBanner.Show();
                // Agrega el control al formulario principal
                panelClientes.Controls.Add(clienteBanner);
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

        private void Cliente_Pantalla_Load(object sender, EventArgs e)
        {


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
