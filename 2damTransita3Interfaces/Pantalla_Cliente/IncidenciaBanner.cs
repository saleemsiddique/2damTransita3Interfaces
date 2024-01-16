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

        public Panel getPanel()
        {
            return panel2;
        }

        public PictureBox getFotos() {
            return incidencia_img;
        }

        public void setFotosLocation(String image) {
            incidencia_img.ImageLocation = image;
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
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas borrar esta incidencia?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
            Console.WriteLine("metodo eliminar ha sido activado");
            String id = this.idIncidencia.Text;
            String url = Program.rutaBase + "incidencia/eliminar/" + id;
            string response = await ApiClient.GetRequestAsync("DELETE", url, Program.token);

            Console.WriteLine(response);
            Form formularioPadre = this.FindForm();
            Transita formularioTransita = (Transita)formularioPadre.FindForm();
            if (formularioTransita != null)
            {
                Console.WriteLine("No es null");
                formularioTransita.MostrarPanelDeIncidencia();
            }
            }
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarIncidencia form = new EditarIncidencia(idIncidencia.Text);
            form.Owner = this.FindForm();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(button8, new System.Drawing.Point(0, button8.Height));
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnViewIncidencia_Click(object sender, EventArgs e)
        {

        }
    }
}
