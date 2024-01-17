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
    public partial class UsuariosMunicipioBanner : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem cambiarContrasenyaToolStripMenuItem;
        bool deleted = false;
        public UsuariosMunicipioBanner()
        {
            InitializeComponent();
            contextMenuStrip = new ContextMenuStrip();
            editarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            cambiarContrasenyaToolStripMenuItem = new ToolStripMenuItem();

            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += EditarToolStripMenuItem_Click;

            cambiarContrasenyaToolStripMenuItem.Text = "Cambiar contraseña";
            cambiarContrasenyaToolStripMenuItem.Click += ModificarContrasenyaToolStripMenuItem_Click;

            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += EliminarToolStripMenuItem_ClickAsync;

            contextMenuStrip.Items.AddRange(new ToolStripItem[] { editarToolStripMenuItem, cambiarContrasenyaToolStripMenuItem ,eliminarToolStripMenuItem });

            moreOption.MouseDown += Button8_MouseDown;
        }
        public Label getId()
        {
            return idCliente;
        }

        public Label getNombre()
        {
            return nombreCliente;
        }

        public Panel getPanel()
        {
            return panel1;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Button8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip.Show(moreOption, new System.Drawing.Point(0, moreOption.Height));
            }
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarUsuarioMunicipio editarUsuarioMunicipio = new EditarUsuarioMunicipio(idCliente.Text);
            editarUsuarioMunicipio.Owner = this.FindForm();
            editarUsuarioMunicipio.ShowDialog();

        }

        private void ModificarContrasenyaToolStripMenuItem_Click(object sender, EventArgs e) {
            ModificarContrasenyaUsuarioMunicipio modificarContrasenyaUsuarioMunicipio = new ModificarContrasenyaUsuarioMunicipio(idCliente.Text);
            modificarContrasenyaUsuarioMunicipio.Owner = this.FindForm();
            modificarContrasenyaUsuarioMunicipio.ShowDialog();
        }


        private async void EliminarToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            Console.WriteLine("metodo eliminar ha sido activado");
            String id = this.idCliente.Text;
            String url = Program.rutaBase + "cliente/eliminar/" + id;
            string response = await ApiClient.GetRequestAsync("DELETE", url, Program.token);

            Console.WriteLine(response);
            Form formularioPadre = this.FindForm();
            Transita formularioTransita = (Transita)formularioPadre.FindForm();
            if (formularioTransita != null)
            {
                Console.WriteLine("No es null");
                formularioTransita.MostrarPanelDeUsuariosMunicipio();
            }
        }


        private void moreOption_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(moreOption, new System.Drawing.Point(0, moreOption.Height));
        }

        private void btnViewCliente_Click(object sender, EventArgs e)
        {

        }

        private void nombreCliente_Click(object sender, EventArgs e)
        {

        }

        private void UsuariosMunicipioBanner_Load(object sender, EventArgs e)
        {

        }
    }
}
