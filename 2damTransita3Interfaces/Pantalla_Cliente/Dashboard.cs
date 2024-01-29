using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using transitaControllers;

namespace Pantalla_Cliente
{
    public partial class Transita : Form
    {

        private Button[] buttons;
        private Button currentButton;
        static PuntosPantalla puntosPantalla;

        public Transita()
        {
            InitializeComponent();
            if (Program.userLogged.roles[0].Equals("ROLE_MODERADOR")) {
                btn_cliente.Enabled = false;
                btn_usuariosMunicipio.Enabled = false;
            }
            panelHome.Show();
            pictureBox2.Hide();
            userName.Text = Program.userLogged.nombre;



            this.Font = new Font("Arial", 12);

            //MostrarPanelDeCliente();
            btn_incidencias.Click += btn_incidencias_Click;
            btn_cliente.Click += btn_cliente_Click;
            btn_puntos.Click += btn_punto_Click;
            btn_usuariosMunicipio.Click += btn_usuariosMunicipio_Click;
            btn_mapa.Click += btn_mapa_Click;

            buttons = new Button[] { btn_cliente, btn_incidencias, btn_puntos, btn_mapa, btn_usuariosMunicipio};

            currentButton = null;

            /*currentButton = buttons[0];

            currentButton.Enabled = true;
            currentButton.BackColor = Color.FromArgb(64, 64, 64);
            */
        }

        private void panel1Degradado_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.FromArgb(31, 32, 37);
            Color endColor = Color.Silver;

            System.Drawing.Drawing2D.LinearGradientBrush gradientBrush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    panel1.ClientRectangle,
                    startColor, // Color inicial (31, 32, 37)
                    endColor,  // Color final (Silver)
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical); // Dirección vertical

            e.Graphics.FillRectangle(gradientBrush, panel1.ClientRectangle);
        }

        public Panel ObtenerPanelCentralMapa()
        {
            return panel1_central;
        }

        public Panel ObtenerPanelCentralCliente()
        {
            return panel1_central;
        }

        public Panel ObtenerPanelDerechaCliente()
        {
            return panel1_derecha;
        }
        public Panel ObtenerPanelCentralZona()
        {
            return panel1_central;
        }

        public Panel ObtenerPanelDerechaZona()
        {
            return panel1_derecha;
        }

        public Panel ObtenerPanelCentralUsuariosMunicipio()
        {
            return panel1_central;
        }

        public Panel ObtenerPanelDerechaUsuariosMunicipio()
        {
            return panel1_derecha;
        }
        public Panel ObtenerPanelCentralPunto()
        {
            return panel1_central;
        }

        public Panel ObtenerPanelDerechaPunto()
        {
            return panel1_derecha;
        }
        public void VaciarPaneles()
        {
            panel1_central.Controls.Clear();
            panel1_derecha.Controls.Clear();
        }
        public void VaciarPanelCentral()
        {
            panel1_central.Controls.Clear();
           
        }
          public void VaciarPanelDerecha()
        {
            panel1_derecha.Controls.Clear();
           
        }
        public void MostrarPanelDeIncidencia()
        {
            panel1_derecha.Visible = true;
            Incidencias_Pantalla incidenciaForm = new Incidencias_Pantalla();
            Panel panelCentralIncidencia = incidenciaForm.ObtenerPanelCentralIncidencia();
            Panel panelDerechaIncidencia = incidenciaForm.ObtenerPanelDerechaIncidencia();


            VaciarPaneles();

            // Agrega el panel al control contenedor en este formulario
            panel1_central.Controls.Add(panelCentralIncidencia);
            panel1_derecha.Controls.Add(panelDerechaIncidencia);


            // Puedes personalizar el tamaño y la posición del panel según tus necesidades
            panelCentralIncidencia.Dock = DockStyle.Fill;
            panelDerechaIncidencia.Dock = DockStyle.Fill;

            pictureBox2.Show();
        }
        public void MostrarPanelDeMapa()
        {

            MapaPantalla mapaPantalla = new MapaPantalla();
            Panel panelCentralMapa = mapaPantalla.ObtenerPanelCentralMapa();
            VaciarPanelCentral();
            panel1_derecha.Visible = false;
            // Agrega el panel al control contenedor en este formulario
            panel1_central.Controls.Add(panelCentralMapa);
          
            // Puedes personalizar el tamaño y la posición del panel según tus necesidades
            panelCentralMapa.Dock = DockStyle.Fill;
            

            pictureBox2.Show();
        }
        public void MostrarPanelDeCliente()
        {
            panel1_derecha.Visible = true;
            Cliente_Pantalla clientePantalla = new Cliente_Pantalla();
            Panel panelCentralIncidencia = clientePantalla.ObtenerPanelCentralCliente();
            Panel panelDerechaIncidencia = clientePantalla.ObtenerPanelDerechaCliente();


            VaciarPaneles();

            // Agrega el panel al control contenedor en este formulario
            panel1_central.Controls.Add(panelCentralIncidencia);
            panel1_derecha.Controls.Add(panelDerechaIncidencia);


            // Puedes personalizar el tamaño y la posición del panel según tus necesidades
            panelCentralIncidencia.Dock = DockStyle.Fill;
            panelDerechaIncidencia.Dock = DockStyle.Fill;

            pictureBox2.Show();

        }

        public void MostrarPanelDePunto()
        {
            panel1_derecha.Visible = true;
            puntosPantalla = new PuntosPantalla();
            Panel panelCentralPunto = puntosPantalla.ObtenerPanelCentralPunto();
            Panel panelDerechaPunto = puntosPantalla.ObtenerPanelDerechaPunto();


            VaciarPaneles();

            // Agrega el panel al control contenedor en este formulario
            panel1_central.Controls.Add(panelCentralPunto);
            panel1_derecha.Controls.Add(panelDerechaPunto);


            // Puedes personalizar el tamaño y la posición del panel según tus necesidades
            panelCentralPunto.Dock = DockStyle.Fill;
            panelDerechaPunto.Dock = DockStyle.Fill;

            pictureBox2.Show();
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (currentButton != null)
            {
                currentButton.Enabled = true;
                currentButton.BackColor = Color.FromArgb(44, 45, 49);
                currentButton.ForeColor = Color.White;
            }

            if (clickedButton != currentButton)
            {
                currentButton = clickedButton;
                currentButton.Enabled = true;
                currentButton.BackColor = Color.FromArgb(31, 32, 37);
                currentButton.ForeColor = Color.White;
            }
        }

        private void btn_incidencias_Click(object sender, EventArgs e)
        {
            MostrarPanelDeIncidencia();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            MostrarPanelDeCliente();
        }
        private void btn_mapa_Click(object sender, EventArgs e)
        {
            MostrarPanelDeMapa();
        }
        private void btn_punto_Click(object sender, EventArgs e)
        {
            MostrarPanelDePunto();
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void MostrarPanelDeUsuariosMunicipio()
        {
            panel1_derecha.Visible = true;
            UsuariosMunicipio usuariosMunicipio = new UsuariosMunicipio();
            Panel panelCentralZona = usuariosMunicipio.ObtenerPanelCentralZona();
            Panel panelDerechaZona = usuariosMunicipio.ObtenerPanelDerechaZona();


            VaciarPaneles();

            // Agrega el panel al control contenedor en este formulario
            panel1_central.Controls.Add(panelCentralZona);
            panel1_derecha.Controls.Add(panelDerechaZona);


            // Puedes personalizar el tamaño y la posición del panel según tus necesidades
            panelCentralZona.Dock = DockStyle.Fill;
            panelDerechaZona.Dock = DockStyle.Fill;
        }
        private void btn_usuariosMunicipio_Click(object sender, EventArgs e)
        {
            MostrarPanelDeUsuariosMunicipio();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LogOutPantalla logOutPantalla = new LogOutPantalla();
            logOutPantalla.ShowDialog();
        }

    }
}
