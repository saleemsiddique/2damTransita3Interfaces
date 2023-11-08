using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    class IncidenciaService
    {
        public  async Task<List<Incidencia>> GetIncidenciasAsync()
        {
            String url = Program.rutaBase + Rutas.incidencia;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Incidencia> listaIncidencias = JsonSerializer.Deserialize<List<Incidencia>>(response);

            return listaIncidencias;
        }

    }
}
