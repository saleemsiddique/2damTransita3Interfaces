using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//TODO: Hacer pantalla de carga de clientes
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

        public Cliente_Pantalla()
        {
            InitializeComponent();
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
            paginasTotalesActual = await clienteService.GetNumeroClientes(filtro);
            dividirEnPaginas();
            paginaDropDown.SelectedItem = paginaActual;

        }
        private void dividirEnPaginas() {
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

        private async Task ObtenerClientes() {
            await ObtenerIdInicialYFinal();
            idPrincipio = idInicial;
            listCliente = await clienteService.GetClientesFiltrado(filtro, idInicial, idFinal);
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

                clienteBanner.getPanel().Click += (sender, e) =>
                {
                    clienteBanner.getPanel().Focus();
                    nombre.Text = cliente.nombre + " " + cliente.apellidos;
                    correo.Text = cliente.nombreUsuario;
                    id_mostrar.Text = cliente.id + "";
                    nombre_mostrar.Text = cliente.nombre;
                    apellidos_mostrar.Text = cliente.apellidos;
                    email_mostrar.Text = cliente.nombreUsuario;
                    clienteBanner.getPanel().BorderStyle = BorderStyle.Fixed3D;
                    clienteBanner.getPanel().Invalidate();
                };

                clienteBanner.getPanel().LostFocus += (sender, e) =>
                {
                    clienteBanner.getPanel().BorderStyle = BorderStyle.None;
                    clienteBanner.getPanel().Invalidate();
                };

                // Configura la ubicación y otros detalles según sea necesario
                clienteBanner.Location = new Point(33, topPosition); // Personaliza la ubicación
                topPosition += clienteBanner.Height + 10; // Ajusta el espaciado vertical según sea necesario
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
            idInicial = 1;
            idFinal = idInicial + 6;
            paginasTotalesActual = await clienteService.GetNumeroClientes(filtro);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

            if (listCliente != null) { 
                        limpiarVisualizacion();
            }
            paginaActual = (int)paginaDropDown.SelectedItem;

            if (paginaActual == 1)
            {
                idInicial = 1;
            }
            else {
                idInicial = 8 * (paginaActual - 1);
            }
            idFinal = idInicial + 6;

            await ObtenerClientesRefresh();

        }

        //Aqui empieza el pdf
        public void btnGenerarpdf_Click(object sender, EventArgs e)
        {

            //string filtro = txtFiltro.Text;
            //crearPDF();
            //axAcroPDF.src = "C:/Users/hamon/Documents/GitHub/2damTransita3Interfaces/2damTransita3Interfaces/Pantalla_Cliente/bin/Debug/ReporteProducto.pdf";

            VentanaPDF ventanaPDF = new VentanaPDF();

            ventanaPDF.ShowDialog();
        }
        /*
        private void crearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("Reporte.pdf");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            PageSize tamanioH = new PageSize(792, 612);
            Document documento = new Document(pdf, tamanioH);

            documento.SetMargins(60, 20, 55, 20);

            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            string[] columnas = { "id", "apellidos", "contrasenya", "estado", "nombre", "nombre_usuario" };

            float[] tamanios = { 2, 2, 2, 2, 2, 2 };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));

            }

            string sql = "SELECT id, apellidos, contrasenya, estado, nombre, nombre_usuario FROM cliente ";//WHERE nombre = '"+filtro+"'";


            MySqlConnection connectionDB = Conexion.conexion();
            connectionDB.Open();

            MySqlCommand comando = new MySqlCommand(sql, connectionDB);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                //for (int x = 1; x < 100; x++)
                //{
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["id"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["apellidos"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["contrasenya"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["estado"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["nombre"].ToString()).SetFont(fontContenido)));
                    tabla.AddCell(new Cell().Add(new Paragraph(reader["nombre_usuario"].ToString()).SetFont(fontContenido)));

                //}

            }
            documento.Add(tabla);

            documento.Close();

            var logo = new iText.Layout.Element.Image(ImageDataFactory.Create("C:/Users/hamon/Pictures/12.png")).SetWidth(50);
            var plogo = new Paragraph("").Add(logo);

            var titulo = new Paragraph("Reporte de productos");
            titulo.SetTextAlignment(TextAlignment.CENTER);
            titulo.SetFontSize(12);

            var dfecha = DateTime.Now.ToString("dd-MM-yyyy");
            var dhora = DateTime.Now.ToString("hh:mm:ss");
            var fecha = new Paragraph("Fecha: " + dfecha + "\nHora: " + dhora);
            fecha.SetFontSize(12);

            PdfDocument pdfDoc = new PdfDocument(new PdfReader("Reporte.pdf"), new PdfWriter("ReporteProducto.pdf"));
            Document doc = new Document(pdfDoc);
            int numeros = pdfDoc.GetNumberOfPages();

            for (int i = 1; i < numeros; i++)
            {
                PdfPage pagina = pdfDoc.GetPage(i);

                float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                doc.ShowTextAligned(new Paragraph(String.Format("Página {0} de {1}", i, numeros)), pdfDoc.GetPage(i).GetPageSize().GetWidth() / 2, pdfDoc.GetPage(i).GetPageSize().GetBottom() + 30, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

            }
            doc.Close();

        }
        */

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
