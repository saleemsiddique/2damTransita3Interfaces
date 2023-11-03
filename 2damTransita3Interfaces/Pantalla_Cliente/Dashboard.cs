using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class Transita : Form
    {

        private Button[] buttons;
        private Button currentButton;

        public Transita()
        {
            InitializeComponent();
            panelHome.Show();
            pictureBox2.Hide();


            this.Font = new Font("Arial", 12);

            //MostrarPanelDeCliente();
            btn_incidencias.Click += btn_incidencias_Click;
            btn_cliente.Click += btn_cliente_Click;
           

            buttons = new Button[] { btn_cliente, btn_incidencias, btn_zonas, btn_puntos, btn_mapa };

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


        public Panel ObtenerPanelCentralCliente()
        {
            return panel1_central;
        }

        public Panel ObtenerPanelDerechaCliente()
        {
            return panel1_derecha;
        }


        public void VaciarPaneles()
        {
            panel1_central.Controls.Clear();
            panel1_derecha.Controls.Clear();
        }
    
        public void MostrarPanelDeIncidencia()
        {
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

        public void MostrarPanelDeCliente()
        {
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

        private void panel1_central_Paint(object sender, PaintEventArgs e)
        {

        }

        private void imgTransita_Click(object sender, EventArgs e)
        {

        }
    }
}
