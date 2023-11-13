using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public partial class ClienteBanner : UserControl
    {
        bool color;

        public ClienteBanner()
        {
            InitializeComponent();
            Load += ClienteBanner_Load; // Suscribir el método al evento Load
        }
        private async void ClienteBanner_Load(object sender, EventArgs e)
        {
            await InitializeClienteBanner();
        }
        private async Task InitializeClienteBanner()
        {
            try
            {
                bool estadoActualCliente = await GetUserEstado();

                // Comparar el estado y cambiar el color del botón
                if (estadoActualCliente == false)
                {
                    buttonChangedEstado.BackColor = Color.Red;
                }
                else
                {
                    buttonChangedEstado.BackColor = Color.Green;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el estado del cliente: {ex.Message}");
                // Manejar el error según tus necesidades
            }
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
       

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void idCliente_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private async Task<bool> GetUserEstado()
        {
            string url = Program.rutaBase + "cliente/id/" + idCliente.Text;

            try
            {
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
                Cliente cliente = JsonConvert.DeserializeObject<Cliente>(response);

                return cliente?.estadoCuenta == EstadoCuenta.ACTIVADO;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el cliente: {ex.Message}");
                // Manejar el error según tus necesidades
                return false;
            }
        }

        private async Task ModifyUserEstado()
        {

            bool estadoActualCliente = await GetUserEstado();
            // Obtener el estado opuesto
            string nuevoEstadoCuenta = estadoActualCliente ? "DESACTIVADO" : "ACTIVADO";
                Console.WriteLine(nuevoEstadoCuenta);
               

                string urlMod = Program.rutaBase + "api/auth/cliente/modificarEstado/" + idCliente.Text;
                 
                // JSON con el nuevo estado
                string content = $"{{ \"nuevoEstadoCuenta\": \"{nuevoEstadoCuenta}\" }}";

             
                string putResponse = await ApiClient.GetRequestAsync("PUT", urlMod, Program.token, content);
                Console.WriteLine(putResponse);
                
        
        }
        
    

        private void buttonChangedEstado_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cambiar el estado del cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {

                ModifyUserEstado();
            }
        }
    }
}
