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

            }
        }
  
