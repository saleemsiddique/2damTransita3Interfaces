using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO: Hacer pantalla de carga de clientes
namespace Pantalla_Cliente
{
    public partial class Cliente_Pantalla : Form
    {
        private ClienteService clienteService = new ClienteService();
        private List<Cliente> listCliente;
        private bool esVisible = false;
        private int filtro = 2;
        private int idInicial;
        private int idFinal;
        private int idPrincipio;
        private int paginasTotales;
        private int paginaActual = 1;
        private int paginasTotalesActual;

        public Cliente_Pantalla()
        {
            InitializeComponent();
            ObtenerClientes();
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);
            foreach (CheckBox checkBox in groupBox1.Controls.OfType<CheckBox>())
            {
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
            }

        }

        public Panel ObtenerPanelCentralCliente()
        {
            return panel_central;
        }

        public Panel ObtenerPanelDerechaCliente()
        {
            return panel_derecha;
        }

        private async Task ObtenerIdInicialYFinal()
        {
            idInicial = 1;
            idFinal = idInicial + 3;
            paginasTotalesActual = await clienteService.GetNumeroClientes(filtro);
            dividirEnPaginas();

        }
        private void dividirEnPaginas() {

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

        private async Task ObtenerClientes() {
            await ObtenerIdInicialYFinal();
            idPrincipio = idInicial;
            listCliente = await clienteService.GetClientesFiltrado(filtro, idInicial, idFinal);
            CrearPanelesClientes(listCliente);
        }

        private async Task ObtenerClientesRefresh() {
            paginasTotalesActual = await clienteService.GetNumeroClientes(filtro);
            dividirEnPaginas();
            idPrincipio = idInicial;
            listCliente = await clienteService.GetClientesFiltrado(filtro, idInicial, idFinal);
            CrearPanelesClientes(listCliente);
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

        private void panel_central_Paint(object sender, PaintEventArgs e)
        {

        }

        private void filtroClientes_btn_Click(object sender, EventArgs e)
        {
            if (esVisible)
            {
                groupBox1.Visible = false;
                esVisible = false;
            }
            else {
                groupBox1.Visible = true;
                esVisible = true;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (estadoActivo.Checked)
            {
                filtro = 1;
                label_tipoclientes.Text = "Clientes Activados";
            }
            else if (estadoDesactivado.Checked)
            {
                filtro = 0;
                label_tipoclientes.Text = "Clientes Desactivados";
            }
            else {
                filtro = 2;
                label_tipoclientes.Text = "Todos los Clientes";
            }
            
            limpiarVisualizacion();
            groupBox1.Visible = false;
            esVisible = false;

            clienteImg = null;
            nombre.Text = "";
            correo.Text = "";
            id_mostrar.Text = "";
            nombre_mostrar.Text = "";
            apellidos_mostrar.Text = "";
            email_mostrar.Text = "";
            Task task = ObtenerClientesRefresh();
            paginaActual = 1;
            paginas.Text = paginaActual + "/" + paginasTotalesActual;

            task.ContinueWith(t =>
            {
                Form formularioPadre = this.Owner;

                if (formularioPadre != null)
                {
                    if (formularioPadre is Transita)
                    {
                        Transita formularioTransita = (Transita)formularioPadre;
                        formularioTransita.MostrarPanelDeCliente();
                        this.Close();
                    }
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void limpiarVisualizacion()
        {
            listCliente.Clear();
            foreach (Control control in panelClientes.Controls.OfType<ClienteBanner>().ToList())
            {
                panelClientes.Controls.Remove(control);
                control.Dispose();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void adelanteBtn_Click(object sender, EventArgs e)
        {
            if (paginaActual < paginasTotalesActual)
            {
                limpiarVisualizacion();
                idInicial += 4;
                idFinal = idInicial + 3;
                paginaActual++;
                await ObtenerClientesRefresh();
            }
        }

        private async void atrasBtn_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                if (idInicial >= idPrincipio)
                {
                    limpiarVisualizacion();
                    idInicial -= 4;
                    idFinal = idInicial + 3;
                    paginaActual--;
                    await ObtenerClientesRefresh();
                }
            }
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
