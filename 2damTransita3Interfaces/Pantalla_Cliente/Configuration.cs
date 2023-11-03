using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public class Configuration
    {
        public string rutaBase { get; set; }
        public string token { get; set; }

        private string appSettingsPath;

        private IConfiguration configuration;

        public Configuration()
        {
            appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "../../");
            configuration = new ConfigurationBuilder()
                .SetBasePath(appSettingsPath)
                .AddJsonFile("appsettings.json")
                .Build();

            rutaBase = configuration["AppSettings:RutaBase"];
            token = configuration["AppSettings:token"];

        }
    }
}

