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
            eliminarToolStripMenuItem.Click += EliminarToolStripMenuItem_Click;

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

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Lógica para la acción de editar
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
