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
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
            this.Font = new Font("Arial", 12);

            MostrarPanelDeCliente();
            btn_incidencias.Click += btn_incidencias_Click;
            btn_cliente.Click += btn_cliente_Click;

            buttons = new Button[] { btn_cliente, btn_incidencias, btn_zonas, btn_puntos, btn_mapa };

            currentButton = buttons[0];
            currentButton.Enabled = false;
            currentButton.BackColor = Color.FromArgb(64, 64, 64);
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

        private void MostrarPanelDeIncidencia()
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
        }

        private void MostrarPanelDeCliente()
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
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton != currentButton)
            {
                currentButton.Enabled = true;
                currentButton.BackColor = SystemColors.ControlDarkDark;
                currentButton = clickedButton;
                currentButton.Enabled = false;
                currentButton.BackColor = Color.FromArgb(64, 64, 64);
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
    }
}
