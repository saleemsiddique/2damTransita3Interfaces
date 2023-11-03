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
    public partial class ZonaBanner : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        public ZonaBanner()
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

        private void button8_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(button8, new System.Drawing.Point(0, button8.Height));
        }
        public Label getId()
        {
            return idZona;
        }

        public Label getNombre()
        {
            return nombreZona;
        }

        public Button getViewBtn()
        {
            return btnViewZona;
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
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas borrar esta zona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Console.WriteLine("metodo eliminar ha sido activado");
                String id = this.idZona.Text;
                String url = Program.configurations.rutaBase + "zona/eliminar/" + id;
                string response = await ApiClient.GetRequestAsync("DELETE", url, Program.configurations.token);

                Console.WriteLine(response);
                Form formularioPadre = this.FindForm();
                Transita formularioTransita = (Transita)formularioPadre.FindForm();
                if (formularioTransita != null)
                {
                    Console.WriteLine("No es null");
                    formularioTransita.MostrarPanelDeZona();
                }
            }
        }
        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarZonas form = new EditarZonas(idZona.Text);
            form.Owner = this.FindForm();
            form.ShowDialog();

        }

        private void ZonaBanner_Load(object sender, EventArgs e)
        {

        }
    }
}