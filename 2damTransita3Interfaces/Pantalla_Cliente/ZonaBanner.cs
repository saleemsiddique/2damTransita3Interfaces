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

namespace Pantalla_Zona
{
    public partial class ZonaBanner : UserControl
    {
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        bool deleted = false;

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

            moreOption.MouseDown += Button8_MouseDown;
        }

        private void moreOption_Click(object sender, EventArgs e)
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
    
        public async Task<bool> DeleteCliente(int Id, string token)
        {
            try
            {
                string url = $"http://localhost:8083/cliente/eliminar/{Id}";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        btnViewCliente.PerformClick();
                        // Remove the UI element representing the deleted client
                        Cliente_Pantalla c = new Cliente_Pantalla();
                        c.Invalidate();
                        c.Update();
                        Transita t = new Transita();
                        t.MostrarPanelDeCliente();
                        return true;
                    }
                    else
                    {
                        // Handle errors here if necessary
                        Console.WriteLine("Error al eliminar el cliente");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here if necessary
                Console.WriteLine("Excepción al eliminar el cliente: " + ex.Message);
                return false;
            }
        }

        private void RemoveClienteBannerFromForm(string clientId)
        {
            if (int.TryParse(clientId, out int idAsInt))
            {
                // Find and remove the ClienteBanner associated with the deleted client
                foreach (Control control in panel2.Controls)
                {
                    if (control is ClienteBanner clienteBanner)
                    {
                        if (int.TryParse(clienteBanner.getId().Text, out int bannerId) && bannerId == idAsInt)
                        {
                            panel2.Controls.Remove(clienteBanner);
                            clienteBanner.Dispose(); // Dispose of the control to release resources
                            break;
                        }
                    }
                }
            }
            else
            {
                // Handle the case where the string cannot be converted to an integer
                Console.WriteLine("Invalid client ID format: " + clientId);
            }
        }


        private async void EliminarToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            string textoIdCliente = idCliente.Text;

            if (int.TryParse(textoIdCliente, out int clienteId))
            {
                try
                {
                    bool eliminado = await DeleteCliente(clienteId, "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJob2xhM0BnbWFpbC5jb20iLCJpYXQiOjE2OTgzOTk0NTIsImV4cCI6MTY5ODQ4NTg1Mn0.Kwtj6tqqO1Ki5v3uRvln_CyWjPZ9kyOfURRxhWRbNQ4taiT-rNYrQzyZ4RKaxSQmOkHFERfXjnHU6g4IFz3u1w");

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
                catch (Exception ex)
                {
                    Console.WriteLine("Excepción al eliminar el cliente: " + ex.Message);
                }
            }
            else
            {
                // La conversión falló. Puedes manejar este escenario aquí.
                Console.WriteLine("La conversión a entero falló.");
            }
        }

    }
}
