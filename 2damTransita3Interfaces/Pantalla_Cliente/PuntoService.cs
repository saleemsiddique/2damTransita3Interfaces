using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    internal class PuntoService
    {
        public async Task<List<Punto>> GetPuntosAsync(string tipo, string accesibilidad, string visibilidad)
        {
            
            String url = Program.rutaBase + Rutas.punto + "/tipo/" + tipo + "/accesibilidad/" + accesibilidad + "/visibilidad/" + visibilidad ;
            Console.WriteLine("\n\n\n url");
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Punto> listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);

            return listaPuntos;
        }

        public async Task<int> GetIdInicial() {
            String url = Program.rutaBase + Rutas.puntoIncial;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            Punto punto = JsonSerializer.Deserialize<Punto>(response);

            return punto.id;
        }

        public async Task<List<Punto>> GetPuntos(int idInicial, int idFinal) {
            string url = Program.rutaBase + Rutas.punto + "/" + idInicial + "-" + idFinal;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Punto> listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);
            Console.WriteLine("\n\n\n response" + response + "\n\n\n idInicial - final" + idInicial + "-" + idFinal);
            return listaPuntos;
        }

        public async Task<int> GetNumeroPuntos() {
            string url = Program.rutaBase + Rutas.numeroPuntos;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            int numeroPuntos = JsonSerializer.Deserialize<int>(response);

            return numeroPuntos;
        }
    }
}
