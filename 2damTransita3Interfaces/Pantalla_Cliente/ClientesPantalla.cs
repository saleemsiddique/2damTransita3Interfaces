using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iText.Layout.Properties;
using iText.Layout.Element;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.IO.Image;
using iText.IO.Font.Constants;
using iText.Kernel.Geom;
using Point = System.Drawing.Point;

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
        private MapaPantalla mapaPantalla;
        private int clienteSeleccionado;

        public Cliente_Pantalla()
        {
            InitializeComponent();
            btn_verFavoritos.Visible = false;
            paginaDropDown.ContextMenuStrip = Utils.emptyMenu;
            ObtenerClientes();
            paginaDropDown.ContextMenuStrip = Utils.emptyMenu;
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
            idFinal = idInicial + 6;
            paginasTotalesActual = await clienteService.GetNumeroClientes(filtro, buscarTextBox.Text);
            dividirEnPaginas();
            paginaDropDown.SelectedItem = paginaActual;

        }
        private void dividirEnPaginas()
        {
            paginaDropDown.Items.Clear();
            if (paginasTotalesActual % 7 != 0)
            {
                paginasTotalesActual = paginasTotalesActual / 7;
                paginasTotalesActual++;

            }
            else
            {
                paginasTotalesActual = paginasTotalesActual / 7;
            }

            if (paginasTotalesActual != 0)
            {
                paginas.Text = "/   " + paginasTotalesActual;
            }
            else
            {
                paginas.Text = 0 + "/   " + paginasTotalesActual;
            }
            for (int i = 1; i <= paginasTotalesActual; i++)
            {
                paginaDropDown.Items.Add(i);
            }
        }

        private async Task ObtenerClientes()
        {
            await ObtenerIdInicialYFinal();
            idPrincipio = idInicial;
            listCliente = await clienteService.GetClientesFiltrado(filtro, idInicial, idFinal, buscarTextBox.Text);
        }

        private async Task ObtenerClientesRefresh()
        {
            paginasTotalesActual = await clienteService.GetNumeroClientes(filtro, buscarTextBox.Text);
            dividirEnPaginas();
            idPrincipio = idInicial;
            listCliente = await clienteService.GetClientesFiltrado(filtro, idInicial, idFinal, buscarTextBox.Text);
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
            int topPosition = 0;
            foreach (Cliente cliente in listaClientes)
            {
                ClienteBanner clienteBanner = new ClienteBanner();
                clienteBanner.getId().Text = cliente.id + "";
                clienteBanner.getNombre().Text = $"{cliente.nombre} {cliente.apellidos}";

                clienteBanner.getPanel().Click += (sender, e) =>
                {
                    btn_verFavoritos.Visible = true;
                    clienteBanner.getPanel().Focus();
                    nombre.Text = cliente.nombre + " " + cliente.apellidos;
                    correo.Text = cliente.nombreUsuario;
                    id_mostrar.Text = cliente.id + "";
                    nombre_mostrar.Text = cliente.nombre;
                    apellidos_mostrar.Text = cliente.apellidos;
                    email_mostrar.Text = cliente.nombreUsuario;
                    clienteBanner.getPanel().BorderStyle = BorderStyle.Fixed3D;
                    clienteBanner.getPanel().Invalidate();
                    clienteSeleccionado = cliente.id;
                };

                clienteBanner.getPanel().LostFocus += (sender, e) =>
                {
                    clienteBanner.getPanel().BorderStyle = BorderStyle.None;
                    clienteBanner.getPanel().Invalidate();
                };

                clienteBanner.Location = new Point(33, topPosition);
                topPosition += clienteBanner.Height + 10;
                clienteBanner.Show();
                panelClientes.Controls.Add(clienteBanner);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox5.Image = Transita3.Properties.Resources.estrellaAmarilla_fotor_bg_remover_20231021185036;
            }
            else
            {
                pictureBox5.Image = Transita3.Properties.Resources.estrellaNegra_fotor_bg_remover_2023102118503;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = !radioButton1.Checked;
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



        private void buscarTextBox_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(buscarTextBox.Text))
            {
                buscarTextBox.Text = "Buscar";
            }
        }

        private void buscarTextBox_Click(object sender, EventArgs e)
        {
            buscarTextBox.Text = "";
        }

        private void filtroClientes_btn_Click(object sender, EventArgs e)
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

        private async void buttonAceptar_Click(object sender, EventArgs e)
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
            else
            {
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
            idInicial = 1;
            idFinal = idInicial + 6;
            paginasTotalesActual = await clienteService.GetNumeroClientes(filtro, buscarTextBox.Text);
            paginaActual = 1;
            paginas.Text = "/   " + paginasTotalesActual;
            dividirEnPaginas();
            paginaDropDown.SelectedItem = paginaActual;
            Task task = ObtenerClientesRefresh();

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
        private async void adelanteBtn_Click(object sender, EventArgs e)
        {
            if (paginaActual < paginasTotalesActual)
            {
                limpiarVisualizacion();
                idInicial += 7;
                idFinal = idInicial + 6;
                paginaActual++;
                paginaDropDown.SelectedItem = paginaActual;
            }
        }

        private async void atrasBtn_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                if (idInicial >= idPrincipio)
                {
                    limpiarVisualizacion();
                    idInicial -= 7;
                    idFinal = idInicial + 6;
                    paginaActual--;
                    paginaDropDown.SelectedItem = paginaActual;
                }
            }
        }

        private async void paginaDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCliente != null)
            {
                limpiarVisualizacion();
            }

            paginaActual = (int)paginaDropDown.SelectedItem;

            idInicial = 1 + 7 * (paginaActual - 1);
            idFinal = idInicial + 6;

            await ObtenerClientesRefresh();
        }

        public void btnGenerarpdf_Click(object sender, EventArgs e)
        {
            VentanaPDF ventanaPDF = new VentanaPDF();

            ventanaPDF.ShowDialog();
        }

        private async void buscarTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                limpiarVisualizacion();
                clienteImg = null;
                nombre.Text = "";
                correo.Text = "";
                id_mostrar.Text = "";
                nombre_mostrar.Text = "";
                apellidos_mostrar.Text = "";
                email_mostrar.Text = "";
                idInicial = 1;
                idFinal = idInicial + 6;
                paginasTotalesActual = await clienteService.GetNumeroClientes(filtro, buscarTextBox.Text);
                paginaActual = 1;
                paginas.Text = "/   " + paginasTotalesActual;
                dividirEnPaginas();
                paginaDropDown.SelectedItem = paginaActual;
                await ObtenerClientesRefresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mapaPantalla == null)
            {
                MapaPantalla mapaPantalla = new MapaPantalla(clienteSeleccionado);
                Panel panelCentralMapa = mapaPantalla.ObtenerPanelCentralMapa();
                VaciarPanelCentral();
                panel_central.Controls.Add(panelCentralMapa);
                panel_derecha.Controls.Add(mapaPantalla.ObtenerPanelDerechaMapa());
                mapaPantalla.verFavoritos();
                panelCentralMapa.Dock = DockStyle.Fill;

            }
        }

        public void VaciarPanelCentral()
        {
            panel_central.Controls.Clear();
            panel_derecha.Controls.Clear();

        }
    }
}
