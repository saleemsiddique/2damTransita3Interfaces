﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pantalla_Cliente
{
    public partial class Incidencias_Pantalla : Form
    {
        List<Incidencia> listaIncidencias;
        private IncidenciaService incidenciaService = new IncidenciaService();
        private int filtro = 0;
        private bool esVisible = false;
        private int paginasTotalesActual;
        private int idInicial;
        private int idFinal;
        private int idPrincipio;
        private int paginasTotales;
        private int paginaActual = 1;


        public Incidencias_Pantalla()
        {
            InitializeComponent();

            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);
            this.Load += Incidencias_Load;
            btn_filtrar.FlatStyle = FlatStyle.Flat;
            btn_filtrar.FlatAppearance.BorderSize = 0;
            groupBox2.Visible = false;
            foreach (CheckBox checkBox in groupBox2.Controls.OfType<CheckBox>())
            {
                checkBox.CheckedChanged += checkBox_CheckedChanged;
            }


            buscarTextBox.LostFocus += new EventHandler(buscarTextBox_LostFocus);
            this.Click += new EventHandler(incidencias_Click);
            buscarTextBox.Click += new EventHandler(miTextBox_Click);
            buscarTextBox.Leave += new EventHandler(miTextBox_Leave);
            // Establece el alineamiento horizontal del texto en el centro
            buscarTextBox.Multiline = true; // Asegura que el TextBox sea de varias líneas
            buscarTextBox.TextAlign = HorizontalAlignment.Left; // Alinea el texto a la izquierda
            // Ajusta el espaciado superior para centrar verticalmente el texto
            buscarTextBox.Padding = new Padding(20, 20, 0, 0);

            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // Opcional, quita el borde de la ventana
            //this.Icon = Properties.Resources.icono_de_aplicacion; // Cambia el icono de la ventana
            //this.BackgroundImage = Properties.Resources.fondo_de_la_ventana; // Cambia el fondo de la ventana
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Text = "Título de la Ventana"; // Cambia el título de la ventana
            //this.BackgroundImage = Properties.Resources.fondo_de_la_ventana; // Cambia el fondo de la ventana
            this.BackgroundImageLayout = ImageLayout.Stretch;

            int buttonWidth = 30;
            int buttonMargin = 10;
             obtenerIncidencias(filtro);
        }



        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            // Asegurarse de que el evento fue desencadenado por un CheckBox
            if (sender is CheckBox checkBox)
            {
                // Verificar si el CheckBox actual está marcado
                if (checkBox.Checked)
                {
                    // Desmarcar todos los CheckBox en el mismo GroupBox
                    foreach (Control control in groupBox2.Controls)
                    {
                        if (control is CheckBox otherCheckBox && otherCheckBox != checkBox)
                        {
                            otherCheckBox.Checked = false;
                        }
                    }
                }
            }
        }
        public async Task obtenerIncidencias(int filtro)
        {
            await ObtenerIdInicialYFinal();
            idPrincipio = idInicial;
            listaIncidencias = await incidenciaService.GetIncidenciasByPagsAsync(filtro, idInicial, idFinal);
            CrearPanelesIncidencias(listaIncidencias);

        }

        private async Task ObtenerIdInicialYFinal()
        {
            idInicial = 1;
            idFinal = idInicial + 3;
            paginasTotalesActual = await incidenciaService.GetNumeroIncidencias(filtro);

            dividirEnPaginas();
        }

        public async Task obtenerIncidenciasRefresh() {
            paginasTotalesActual = await incidenciaService.GetNumeroIncidencias(filtro);
            dividirEnPaginas();
            idPrincipio = idInicial;
            listaIncidencias = await incidenciaService.GetIncidenciasByPagsAsync(filtro, idInicial, idFinal);
            CrearPanelesIncidencias(listaIncidencias);
        }


        private async Task ObtenerPuntosNextBack()
        {
            paginas.Text = paginaActual + "/" + paginasTotalesActual;
            idPrincipio = idInicial;
            listaIncidencias = await incidenciaService.GetIncidenciasByPagsAsync(filtro, idInicial, idFinal);
            CrearPanelesIncidencias(listaIncidencias);
        }


        private void dividirEnPaginas()
        {

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
        private void LimpiarVisualizacion()
        {

            foreach (Control control in panelInc.Controls.OfType<IncidenciaBanner>().ToList())
            {
                panelInc.Controls.Remove(control);
                control.Dispose();
            }
        }
        private void CrearPanelesIncidencias(List<Incidencia> lista)
        {

            int topPosition = 0; // Posición vertical inicial

            foreach (Incidencia incidencia in lista)
            {
                IncidenciaBanner incidenciaBanner = new IncidenciaBanner();


                if (incidencia.estado != EstadoIncidencia.ENVIADO)
                {
                    incidenciaBanner.getId().Text = incidencia.id.ToString();
                    incidenciaBanner.getNombre().Text = $"{incidencia.descripcion}";
                    incidenciaBanner.setFotosLocation(Rutas.imagenesPunto + incidencia.punto.foto);

                    incidenciaBanner.getViewBtn().Click += (sender, e) =>
                    {
                        incidencia_img.ImageLocation = Rutas.imagenesPunto + incidencia.punto.foto;
                        correo.Text = $"ID: {incidencia.id}";
                        nombre.Text = incidencia.descripcion;
                        id_mostrar.Text = incidencia.id.ToString();
                        descripcion_mostrar.Text = incidencia.descripcion;
                        fecha_mostrar.Text = incidencia.fechaHora.ToString("yyyy-MM-dd");
                        estado_mostrar.Text = incidencia.estado.ToString();
                    };
                }
                else
                {
                    incidenciaBanner.getId().Text = incidencia.id.ToString();
                    incidenciaBanner.getNombre().Text = $"{incidencia.descripcion}";
                    Console.WriteLine("else");
                    incidenciaBanner.getFotos().Image = LoadBase64(incidencia.fotos);

                    incidenciaBanner.getViewBtn().Click += (sender, e) =>
                    {
                        incidencia_img.Image = LoadBase64(incidencia.fotos.ToString());
                        correo.Text = $"ID: {incidencia.id}";
                        nombre.Text = incidencia.descripcion;
                        id_mostrar.Text = incidencia.id.ToString();
                        descripcion_mostrar.Text = incidencia.descripcion;
                        fecha_mostrar.Text = incidencia.fechaHora.ToString("yyyy-MM-dd");
                        estado_mostrar.Text = incidencia.estado.ToString();
                    };
                }



                // Configura la ubicación y otros detalles según sea necesario
                incidenciaBanner.Location = new Point(0, topPosition); // Personaliza la ubicación
                topPosition += incidenciaBanner.Height + 30; // Ajusta el espaciado vertical según sea necesario
                //incidenciaBanner.Anchor = AnchorStyles.Left | AnchorStyles.Right; // Anclaje para que se ajuste al tamaño del formulario
                incidenciaBanner.Show();
                // Agrega el control al formulario principal
                panelInc.Controls.Add(incidenciaBanner);
            }
        }





        public Panel ObtenerPanelCentralIncidencia()
        {
            return panel4;
        }

        public Panel ObtenerPanelDerechaIncidencia()
        {
            return panel3;
        }

        private void Incidencias_Load(object sender, EventArgs e)
        {

            // Configura los botones aquí
            btn_aceptarIncidencia.FlatStyle = FlatStyle.Flat;
            btn_aceptarIncidencia.FlatAppearance.BorderSize = 0;

            btn_eliminarIncidencia.FlatStyle = FlatStyle.Flat;
            btn_eliminarIncidencia.FlatAppearance.BorderSize = 0;

        }


        private void miTextBox_Click(object sender, EventArgs e)
        {
            // Cuando se hace clic en el TextBox, borra el texto
            buscarTextBox.Text = "";
        }
        private void buscarTextBox_LostFocus(object sender, EventArgs e)
        {
            buscarTextBox.ReadOnly = true; // Establece el TextBox en modo de solo lectura

        }

        private void incidencias_Click(object sender, EventArgs e)
        {
            buscarTextBox.ReadOnly = true; // Establece el TextBox en modo de solo lectura
        }

        private void miTextBox_Leave(object sender, EventArgs e)
        {
            // Cuando el TextBox pierde el foco, restaura el texto
            if (string.IsNullOrWhiteSpace(buscarTextBox.Text))
            {
                buscarTextBox.Text = "Buscar"; // Puedes cambiar este texto predeterminado
            }
        }


        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Cliente_Pantalla f = new Cliente_Pantalla();

            this.Hide();

            f.ShowDialog();
        }


        private void botonVerDatosIncidencia_Click(object sender, EventArgs e)
        {
            if (filtro == 1)
            {
                btn_eliminarIncidencia.Enabled = true;
                btn_aceptarIncidencia.Enabled = true;
            }
            datosIncidencia datosIncidencia = new datosIncidencia();
            
            

            datosIncidencia.ShowDialog();

        }



        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            CrearIncidencia incidencia = new CrearIncidencia();
            incidencia.Owner = this;
            incidencia.ShowDialog();
        }


        public Image LoadBase64(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        public Image stringToImage(string inputString)
        {
            byte[] imageBytes = Encoding.Unicode.GetBytes(inputString);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true, true);

            return image;
        }


        private void buttonFiltros_Click(object sender, EventArgs e)
        {
            if (esVisible)
            {
                groupBox2.Visible = false;
                esVisible = false;
            }
            else
            {
                groupBox2.Visible = true;
                esVisible = true;
            }

        }

      
        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                label_tipoIncidencia.Text = "INCIDENCIA ENVIADA";
                Console.WriteLine("CHECKBOX1 CHECKED");
                filtro = 2;
                btn_eliminarIncidencia.Enabled = true;
                btn_aceptarIncidencia.Enabled = true;

            }
            else if (checkBox2.Checked)
            {
                label_tipoIncidencia.Text = "INCIDENCIA ACEPTADA";
                Console.WriteLine("CHECKBOX2 CHECKED");
                filtro = 1;
            }
            else if (checkBox3.Checked)
            {
                label_tipoIncidencia.Text = "INCIDENCIA EN PROCESO";
                Console.WriteLine("CHECKBOX3 CHECKED");
                filtro = 3;
            }
            else if (checkBox4.Checked)
            {
                label_tipoIncidencia.Text = "INCIDENCIA FINALIZADA";
                Console.WriteLine("CHECKBOX4 CHECKED");
                filtro = 4;
            }
            else
            {
                label_tipoIncidencia.Text = "TODAS LAS INCIDENCIAS";
                Console.WriteLine("CHECKBOXS NOT CHECKED");
                filtro = 0;
                btn_eliminarIncidencia.Enabled = false;
                btn_aceptarIncidencia.Enabled = false;
            }
            incidencia_img.Image = null;
            correo.Text = $"";
            nombre.Text = $"";
            id_mostrar.Text = $"";
            descripcion_mostrar.Text = $"";
            fecha_mostrar.Text = $"";
            estado_mostrar.Text = $"";
            LimpiarVisualizacion();
            listaIncidencias.Clear();
            Console.WriteLine(filtro);
            groupBox2.Visible = false;
            esVisible = false;
            paginaActual = 1;
            paginas.Text = paginaActual + "/" + paginasTotalesActual;

            Task task = obtenerIncidencias(filtro);

            task.ContinueWith(t =>
            {
                // This part will be executed when modifyUser completes, but won't block the UI
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

        private void btn_aceptarIncidencia_Click(object sender, EventArgs e)
        {
            aceptarInAsync();
        }
        private async Task eliminarInAsync() {
            if (id_mostrar.Text.Equals(""))
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error: El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas borrar esta incidencia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Console.WriteLine("metodo eliminar ha sido activado");
                    String id = this.id_mostrar.Text;
                    String url = Program.rutaBase + "incidencia/eliminar/" + id;
                    string response = await ApiClient.GetRequestAsync("DELETE", url, Program.token);

                    incidencia_img.Image = null;
                    correo.Text = $"";
                    nombre.Text = $"";
                    id_mostrar.Text = $"";
                    descripcion_mostrar.Text = $"";
                    fecha_mostrar.Text = $"";
                    estado_mostrar.Text = $"";
                    LimpiarVisualizacion();
                    listaIncidencias.Clear();

                    Task task = obtenerIncidencias(2);

                    _ = task.ContinueWith(t =>
                    {
                        // This part will be executed when modifyUser completes, but won't block the UI
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

            }

         
        }
        private async Task aceptarInAsync()
        {
            if (id_mostrar.Text.Equals(""))
            {
                // Mostrar mensaje de error
                MessageBox.Show("Error: El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas aceptar esta incidencia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Console.WriteLine("metodo aceptar ha sido activado");
                    String id = this.id_mostrar.Text;
                    String url = Program.rutaBase + "incidencia/modificarEstado/" + id + "/aceptado";
                    string response = await ApiClient.GetRequestAsync("PUT", url, Program.token);
                    incidencia_img.Image = null;
                    correo.Text = $"";
                    nombre.Text = $"";
                    id_mostrar.Text = $"";
                    descripcion_mostrar.Text = $"";
                    fecha_mostrar.Text = $"";
                    estado_mostrar.Text = $"";
                    LimpiarVisualizacion();
                    listaIncidencias.Clear();

                    Task task = obtenerIncidencias(2);

                    _ = task.ContinueWith(t =>
                    {
                    // This part will be executed when modifyUser completes, but won't block the UI
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
            }
        }
        private void btn_eliminarIncidencia_Click(object sender, EventArgs e)
        {
            eliminarInAsync();
        }

        private async void adelanteBtn_Click(object sender, EventArgs e)
        {
            if (paginaActual < paginasTotalesActual)
            {
                LimpiarVisualizacion();
                idInicial += 4;
                idFinal = idInicial + 3;
                paginaActual++;
                await obtenerIncidenciasRefresh();
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
                    await obtenerIncidenciasRefresh();
                }
            }
        }

        private void btnVentanaInci_Click(object sender, EventArgs e)
        {
            VentanaPDFIncidencia ventanaPDFIncidencia=new VentanaPDFIncidencia();
            ventanaPDFIncidencia.ShowDialog();
        }
    }
}


