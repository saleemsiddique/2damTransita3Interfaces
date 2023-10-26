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

namespace Pantalla_Cliente
{
    public partial class ClienteBanner : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;

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
            FormNuevoCliente form = new FormNuevoCliente();

            form.ShowDialog();
        }
        public async Task<bool> DeleteCliente(int clienteId, string token)
        {
            try
            {
                string url = $"http://localhost:8083/cliente/{clienteId}";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        return true; // Éxito
                    }
                    else
                    {
                        // Maneja errores aquí si es necesario
                        Console.WriteLine("Error al eliminar el cliente");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Maneja excepciones aquí si es necesario
                Console.WriteLine("Excepción al eliminar el cliente: " + ex.Message);
                return false;
            }
        }

        private async void EliminarToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
         
           string textoIdCliente = idCliente.Text;
            int clienteId;

            if (int.TryParse(textoIdCliente, out clienteId))
            {
               
            }
            else
            {
                // La conversión falló. Puedes manejar este escenario aquí.
                Console.WriteLine("La conversión a entero falló.");
            }

            bool eliminado = await DeleteCliente(clienteId, "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJhZGFkYWFhQGdtYWlsLmNvbSIsImlhdCI6MTY5ODMzNTg4MywiZXhwIjoxNjk4NDIyMjgzfQ.4OO0CxrFJZU9lrz9CbbFgxkU7--fhZZOqTMZ1mRuRg5THQCwCqBhoj77GS9jzy7AEJnCwwmClHw926Kknq0ArQ");

            if (eliminado)
            {
                Console.WriteLine("Cliente eliminado con éxito");
                // Realiza cualquier otra acción que desees después de eliminar el cliente
            }
            else
            {
                Console.WriteLine("Error al eliminar el cliente");
                // Maneja cualquier error que ocurra durante la eliminación del cliente
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
