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
    }
}
