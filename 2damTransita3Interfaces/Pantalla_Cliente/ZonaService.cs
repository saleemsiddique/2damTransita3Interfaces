using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    class ZonaService
    {
        public async Task<List<Zona>> GetZonasAsync()
        {
            String url = Program.rutaBase + Rutas.zona;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Zona> listaZonas = JsonSerializer.Deserialize<List<Zona>>(response);

            return listaZonas;
        }
    }
}
