using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Pantalla_Cliente
{
    class UsuarioMunicipioService
    {
        public async Task<List<Cliente>> GetUsuariosMunicipiosAsync(int filtro) {
            string url = Program.rutaBase + Rutas.usuarioMunicipio + filtro;
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Cliente> listUsuarios = JsonSerializer.Deserialize<List<Cliente>>(response);

            return listUsuarios;
        }

        public async Task<List<Cliente>> GetUsuarioMunicipiosFiltred(int filtro, int idInicial, int idFinal) {
            string url = Program.rutaBase + Rutas.usuarioMunicipioFiltred + "idInicial=" + idInicial + "&idFinal=" + idFinal;
            if (filtro != 0) {
                url += "&rol=" + filtro;
            }
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            List<Cliente> listClientes = JsonSerializer.Deserialize<List<Cliente>>(response);

            return listClientes;
        }

        public async Task<int> GetNumeroUsuarioMunicipiosFiltrado(int filtro) {
            string url = Program.rutaBase + Rutas.usuarioMunicipioCount;
            if (filtro != 0)
            {
                url += "&rol=" + filtro;
            }
            string response = await ApiClient.GetRequestAsync("GET", url, Program.token);
            int cantidadUsuarioMunicipio = JsonSerializer.Deserialize<int>(response);

            return cantidadUsuarioMunicipio;
        }
    }
}
