using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    internal class PuntoService
    {
        public async Task<List<Punto>> GetPuntosAsync()
        {
            String url = Program.rutaBase + Rutas.punto;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Punto> listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);

            return listaPuntos;
        }
    }
}
