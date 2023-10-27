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
        public async Task<bool> DeleteCliente(int Id, string token)
        {
            try
            {
                string url = $"http://localhost:8083/incidencia/eliminar/{Id}";
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                    HttpResponseMessage response = await client.DeleteAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                  
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
                        Console.WriteLine("Error al eliminar la incidencia");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here if necessary
                Console.WriteLine("Excepción al eliminar la incidencia: " + ex.Message);
                return false;
            }
        }




        private async void EliminarToolStripMenuItem_ClickAsync(object sender, EventArgs e)
        {
            string textoIdIncidencia= idIncidencia.Text;

            string token = "";

            if (int.TryParse(textoIdIncidencia, out int incidenciaId))
            {
                try
                {
                    bool eliminado = await DeleteCliente(incidenciaId, "eyJhbGciOiJIUzUxMiJ9.eyJzdWIiOiJob2xhM0BnbWFpbC5jb20iLCJpYXQiOjE2OTgzOTk0NTIsImV4cCI6MTY5ODQ4NTg1Mn0.Kwtj6tqqO1Ki5v3uRvln_CyWjPZ9kyOfURRxhWRbNQ4taiT-rNYrQzyZ4RKaxSQmOkHFERfXjnHU6g4IFz3u1w");

                    if (eliminado)
                    {
                        Console.WriteLine("Incidencia eliminada con éxito");
                        // Realiza cualquier otra acción que desees después de eliminar el cliente
                    }
                    else
                    {
                        Console.WriteLine("Error al eliminar la incidencia");
                        // Maneja cualquier error que ocurra durante la eliminación del cliente
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Excepción al eliminar la incidencia: " + ex.Message);
                }
            }
            else
            {
                // La conversión falló. Puedes manejar este escenario aquí.
                Console.WriteLine("La conversión a entero falló.");
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
