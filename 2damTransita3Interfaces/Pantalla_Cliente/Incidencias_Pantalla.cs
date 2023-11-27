﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pantalla_Cliente
{
    public partial class Incidencias_Pantalla : Form
    {
        
        private IncidenciaService incidenciaService = new IncidenciaService();
        int filtro = 0;
        

        public Incidencias_Pantalla()
        {
            Console.WriteLine(filtro);
            InitializeComponent();
            _ = obtenerIncidencias();
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

            btn_filtrar.FlatStyle = FlatStyle.Flat;
            btn_filtrar.FlatAppearance.BorderSize = 0;
            groupBox2.Visible = false;
            
          

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
        }
       
      
       
       
        public async        
      
       
       
        Task
obtenerIncidencias()
        {
          
            List<Incidencia> listaIncidencia = await incidenciaService.GetIncidenciasAsync(filtro);
            CrearPanelesIncidencias(listaIncidencia);

        }

        private void CrearPanelesIncidencias(List<Incidencia> listaIncidencia)
        {

            int topPosition = 0; // Posición vertical inicial

            foreach (Incidencia incidencia in listaIncidencia)
            {
                IncidenciaBanner incidenciaBanner = new IncidenciaBanner();


                if (incidencia.estado == EstadoIncidencia.ACEPTADO)
                {
                    incidenciaBanner.getId().Text = incidencia.id.ToString();
                    incidenciaBanner.getNombre().Text = $"{incidencia.descripcion}";
                    incidenciaBanner.getFotos().ImageLocation = "http://127.0.0.1/img/imagenes/punto/" + incidencia.punto.foto;
                    Console.WriteLine("\n\n\n127.0.0.1/img/imagenes/punto/" + incidencia.punto.foto);
                    incidenciaBanner.getViewBtn().Click += (sender, e) =>
                    {
                        incidencia_img.ImageLocation = "http://127.0.0.1/img/imagenes/punto/" + incidencia.punto.foto;
                        correo.Text = $"ID: {incidencia.id}";
                        nombre.Text = incidencia.descripcion;
                        id_mostrar.Text = incidencia.id.ToString();
                        descripcion_mostrar.Text = incidencia.descripcion;
                        fecha_mostrar.Text = incidencia.fechaHora.ToString("yyyy-MM-dd");
                        estado_mostrar.Text = incidencia.estado.ToString();
                    };
                }
                else {
                    incidenciaBanner.getId().Text = incidencia.id.ToString();
                    incidenciaBanner.getNombre().Text = $"{incidencia.descripcion}";
                    incidenciaBanner.getFotos().Image = LoadBase64(incidencia.fotos.ToString());

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
            datosIncidencia datosIncidencia = new datosIncidencia();


            datosIncidencia.ShowDialog();

        }




        private void buttonAddCliente_Click(object sender, EventArgs e)
        {
            CrearIncidencia incidencia = new CrearIncidencia();
            incidencia.Owner = this;
            incidencia.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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



        private void buttonFiltros_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
           
        }

        private void  checkBox3_CheckedChangedAsync(object sender, EventArgs e)
        {
            

        }

        private async Task buttonAceptar_ClickAsync(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Console.WriteLine("CHECKBOX1 CHECKED");
                filtro = 1;
            }
            else if (checkBox2.Checked)
            {
                Console.WriteLine("CHECKBOX2 CHECKED");
                filtro = 2;
            }
            else if (checkBox3.Checked)
            {
                Console.WriteLine("CHECKBOX3 CHECKED");
                filtro = 3;
            }
            else if (checkBox4.Checked)
            {
                Console.WriteLine("CHECKBOX4 CHECKED");
                filtro = 4;
            }
            else
            {
                Console.WriteLine("CHECKBOXS NOT CHECKED");
                filtro = 0;
            }

            Console.WriteLine(filtro);
            await obtenerIncidencias();

         
            
            groupBox2.Visible = false;
        }
    }
}
