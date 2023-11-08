using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    class ClienteService
    {
        public async Task<List<Cliente>> GetClientesAsync() {
            string url = Program.rutaBase + Rutas.cliente;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);

            List<Cliente> listClientes = JsonSerializer.Deserialize<List<Cliente>>(response);
            return listClientes;
        }
    }
}
