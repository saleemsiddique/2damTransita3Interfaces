using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    class ClienteService
    {
        private LoadingForm load = new LoadingForm();
        public async Task<List<Cliente>> GetClientesAsync() {
            load.ShowDialog();
            string url = Program.rutaBase + Rutas.cliente;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            Thread.Sleep(300);
            List<Cliente> listClientes = JsonSerializer.Deserialize<List<Cliente>>(response);
            load.dispose();
            return listClientes;
        }
    }
}
