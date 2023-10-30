﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class ClienteBanner : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
         bool deleted = false;

        public ClienteBanner()
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

        public Button getViewBtn()
        {
            return btnViewCliente;
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

        }


        private async void EliminarToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            Console.WriteLine("metodo eliminar ha sido activado");
            String id = this.idCliente.Text;
            String url = "http://localhost:8083/cliente/eliminar/" + id;
            string token = "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJwcnVlYmExQGdtYWlsLmNvbSIsImlhdCI6MTY5ODY4MzMxMSwiZXhwIjoxNjk4NzY5NzExfQ.jJ5GnGTuY0Gz_eAK12ImIM9aXbhylCeO1ICQ0gN2wuS6XpzXbSGfQ6_RK7TqzrzjiK0pQOM6-XzJHzEeIWlnyw"; // Reemplaza con el token adecuado, crea uno nuevo
            string response = await ApiClient.GetRequestAsync("DELETE", url, token);

            Console.WriteLine(response);
            Form formularioPadre = this.FindForm();
            Transita formularioTransita = (Transita)formularioPadre.FindForm();
            if (formularioTransita != null)
            {
                Console.WriteLine("No es null");
                formularioTransita.MostrarPanelDeCliente();
            }
        }


        private void moreOption_Click(object sender, EventArgs e)
        {
            contextMenuStrip.Show(moreOption, new System.Drawing.Point(0, moreOption.Height));
        }

        private void idCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
