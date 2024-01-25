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
        public async Task<List<Incidencia>> GetIncidenciasAsync(int tipo)
        {
            if (tipo == 0)
            { 
                
                String url = Program.rutaBase + Rutas.incidencia;
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
                List<Incidencia> listaIncidencias = JsonSerializer.Deserialize<List<Incidencia>>(response);
                return listaIncidencias;
                
            }
            else if(tipo == 1)
            {
                String url = Program.rutaBase + Rutas.incidenciaEnviada;
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
                List<Incidencia> listaIncidencias = JsonSerializer.Deserialize<List<Incidencia>>(response);
                return listaIncidencias;
            }
            else if (tipo == 2)
            {
                String url = Program.rutaBase + Rutas.incidenciaAceptada;
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
                List<Incidencia> listaIncidencias = JsonSerializer.Deserialize<List<Incidencia>>(response);
                return listaIncidencias;
            }
            else if (tipo == 3)
            {
                String url = Program.rutaBase + Rutas.incidenciaProceso;
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
                List<Incidencia> listaIncidencias = JsonSerializer.Deserialize<List<Incidencia>>(response);
                return listaIncidencias;
            }
            else if (tipo == 4)
            {
                String url = Program.rutaBase + Rutas.incidenciaFinalizada;
                string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
                List<Incidencia> listaIncidencias = JsonSerializer.Deserialize<List<Incidencia>>(response);
                return listaIncidencias;
            }
            else {

                return null;
            }
        }

        public async Task<List<Incidencia>> GetIncidenciasByPagsAsync(int tipo, int idInicial, int idFinal) {
            String url = Program.rutaBase + Rutas.incidenciasFiltradas + "?idInicial=" + idInicial + "&idFinal=" + idFinal;
            if (tipo == 1)
            {
                url += "&estado=ACEPTADO";
            }
            else if (tipo == 2)
            {
                url += "&estado=ENVIADO";
            }
            else if (tipo == 3)
            {
                url += "&estado=ENPROCESO";
            }
            else if (tipo == 4) {
                url += "&estado=FINALIZADO";
            }
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Incidencia> listaIncidencias = JsonSerializer.Deserialize<List<Incidencia>>(response);
            return listaIncidencias;
        }

        public async Task<int> GetNumeroIncidencias(int estado)
        {
            string url = Program.rutaBase + "incidencia/count/filtros";
            if (estado == 1)
            {
                url += "?estado=ACEPTADO";
            }
            else if (estado == 2)
            {
                url += "?estado=ENVIADO";
            }
            else if (estado == 3)
            {
                url += "?estado=ENPROCESO";
            }
            else if (estado == 4)
            {
                url += "?estado=FINALIZADO";
            }
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            int numeroClientes = JsonSerializer.Deserialize<int>(response);
            return numeroClientes;
        }

    }
}
  
