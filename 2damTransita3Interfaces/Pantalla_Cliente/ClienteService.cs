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
        public async Task<List<Cliente>> GetClientesAsync(int tipo) {
            if (tipo == 0)
            {
                string url = Program.rutaBase + Rutas.clienteDesactivado;
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
                List<Cliente> listClientes = JsonSerializer.Deserialize<List<Cliente>>(response);
                return listClientes;
            }
            else if (tipo == 1)
            {
                string url = Program.rutaBase + Rutas.clienteActivado;
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
                List<Cliente> listClientes = JsonSerializer.Deserialize<List<Cliente>>(response);
                return listClientes;
            }
            else if (tipo == 2)
            {
                string url = Program.rutaBase + Rutas.cliente;
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
                List<Cliente> listClientes = JsonSerializer.Deserialize<List<Cliente>>(response);
                return listClientes;

            }
            else {
                return null;
                    
            }

        }
    }
}
