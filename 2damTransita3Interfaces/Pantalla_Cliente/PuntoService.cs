using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    internal class PuntoService
    {
        public async Task<List<Punto>> GetPuntosAsync(string tipoPunto, string accesibilidadPunto, string visibilidadPunto, int idInicial, int idFinal)
        {
            string url = $"{Program.rutaBase}{Rutas.punto}/filtrados?idInicial={idInicial}&idFinal={idFinal}";

            if (!string.IsNullOrEmpty(tipoPunto))
                url += $"&tipoPunto={tipoPunto}";

            if (!string.IsNullOrEmpty(accesibilidadPunto))
                url += $"&accesibilidadPunto={accesibilidadPunto}";

            if (!string.IsNullOrEmpty(visibilidadPunto))
                url += $"&visibilidadPunto={visibilidadPunto}";

            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Punto> listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);
            return listaPuntos;
        }

        public async Task<List<Punto>> GetPuntoAsyncMapa(string tipo, string accesibilidad, string visibilidadPunto) {
            string url = Program.rutaBase + "puntos/filtrados/mapa?";

            if (!string.IsNullOrEmpty(tipo))
                url += $"&tipoPunto={tipo}";

            if (!string.IsNullOrEmpty(accesibilidad))
                url += $"&accesibilidadPunto={accesibilidad}";

            if (!string.IsNullOrEmpty(visibilidadPunto))
                url += $"&visibilidadPunto={visibilidadPunto}";


            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Punto> listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);
            return listaPuntos;

        }

        public async Task<List<Punto>> GetPuntosConIncidenciasAsync()
        {
            string url = $"{Program.rutaBase}{Rutas.puntoIncidencia}";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Punto> listaPuntos = JsonSerializer.Deserialize<List<Punto>>(response);
            return listaPuntos;
        }

        public async Task<List<Punto>> GetPuntosTodos()
        {
            string url = $"{Program.rutaBase}{Rutas.punto}";
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
            return listaPuntos;
        }

        public async Task<int> GetNumeroPuntos() {
            string url = Program.rutaBase + Rutas.numeroPuntos;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            int numeroPuntos = JsonSerializer.Deserialize<int>(response);

            return numeroPuntos;
        }

        public async Task<int> GetNumeroPuntosConFiltros(string tipoPunto, string accesibilidadPunto, string visibilidadPunto)
        {
            string url = Program.rutaBase + Rutas.numeroPuntosConFiltros;

            if (!string.IsNullOrEmpty(tipoPunto))
                url += $"&tipoPunto={tipoPunto}";

            if (!string.IsNullOrEmpty(accesibilidadPunto))
                url += $"&accesibilidadPunto={accesibilidadPunto}";

            if (!string.IsNullOrEmpty(visibilidadPunto))
                url += $"&visibilidadPunto={visibilidadPunto}";

            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            int numeroPuntos = JsonSerializer.Deserialize<int>(response);

            return numeroPuntos;
        }

        public async Task<List<Punto>> GetAllPuntos() {
            string url = Program.rutaBase + "puntos";
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            return JsonSerializer.Deserialize<List<Punto>>(response);
        }

        public async Task<List<Punto>> GetPuntosFavoritos(int idCliente) {
            string url = Program.rutaBase + "favoritos/" + idCliente;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            return JsonSerializer.Deserialize<List<Punto>>(response);
        }

        public async Task<List<Punto>> GetAllPuntosFiltro(string filtro, string valor)
        {
            string url = Program.rutaBase + "punto/filtro?filtro=" + filtro + "&valor=" + valor;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            return JsonSerializer.Deserialize<List<Punto>>(response);
        }
    }
}
