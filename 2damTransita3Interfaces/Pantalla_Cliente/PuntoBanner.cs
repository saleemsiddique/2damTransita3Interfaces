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
    public partial class PuntoBanner : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        public PuntoBanner()
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
                String id = this.idPunto.Text;
                String url = Program.rutaBase + "punto/eliminar/" + id;
                string response = await ApiClient.GetRequestAsync("DELETE", url, Program.token);

                
                Form formularioPadre = this.FindForm();
                Transita formularioTransita = (Transita)formularioPadre.FindForm();
                if (formularioTransita != null)
                {
                    Console.WriteLine("No es null");
                    formularioTransita.MostrarPanelDePunto();
                }
            }
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarPunto form = new EditarPunto(idPunto.Text);
            form.Owner = this.FindForm();
            form.ShowDialog();
        }
      
        public Label getId()
        {
            return idPunto;
        }

        public Label getNombre()
        {
            return nombrePunto;
        }

        public Button getViewBtn()
        {
            return btnViewPunto;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewPunto_Click(object sender, EventArgs e)
        {

        }

        private void nombrePunto_Click(object sender, EventArgs e)
        {

        }

        private void idPunto_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip.Show(button8, new System.Drawing.Point(0, button8.Height));
        }
    }
}
