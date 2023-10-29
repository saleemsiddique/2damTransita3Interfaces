using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pantalla_Cliente;

namespace Pantalla_Cliente
{
    public partial class IncidenciaBanner : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        public IncidenciaBanner()
        {
            InitializeComponent();
            contextMenuStrip = new ContextMenuStrip();
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();

            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += EditarToolStripMenuItem_Click;

            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += EliminarToolStripMenuItem_ClickAsync;

            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, eliminarToolStripMenuItem });

            button8.MouseDown += Button8_MouseDown;
        }

        public Label getId()
        {
            return idIncidencia;
        }

        public Label getNombre()
        {
            return nombreIncidencia;
        }

        public Button getViewBtn()
        {
            return btnViewIncidencia;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      private void Button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(button8, new System.Drawing.Point(0, button8.Height));
            }
        }




        private async void EliminarToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            Console.WriteLine("metodo eliminar ha sido activado");
            String id = this.idIncidencia.Text;
            String url = "http://localhost:8083/incidencia/eliminar/" + id;
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJwcnVlYmExQGdtYWlsLmNvbSIsImlhdCI6MTY5ODU4ODQ2OCwiZXhwIjoxNjk4Njc0ODY4fQ.c_vlQ6q-tmdqfjDVeimg46dMJOE8Ch1Lr3z4VZDChGFkk6EGeu7jTGw4iOGWFiEfQnTiUiNps_03CXtYXxDJaQ"; // Reemplaza con el token adecuado, crea uno nuevo
            string response = await ApiClient.GetRequestAsync("DELETE", url, token);

            Console.WriteLine(response);
            Form formularioPadre = this.FindForm();
            Transita formularioTransita = (Transita)formularioPadre.FindForm();
            if (formularioTransita != null)
            {
                Console.WriteLine("No es null");
                formularioTransita.MostrarPanelDeIncidencia();
            }
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaIncidencia form = new NuevaIncidencia(idIncidencia.Text);

            form.ShowDialog();
        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para la acción de eliminar
        }

        private void button8_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(button8, new System.Drawing.Point(0, button8.Height));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
