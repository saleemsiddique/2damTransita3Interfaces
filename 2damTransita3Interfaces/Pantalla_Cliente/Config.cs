﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace Pantalla_Cliente
{
    public class Config
    {
        private string RutaBase { get; set; }
        private string Token { get; set; }

        private string appSettingsPath;

        private IConfiguration configuration;

        public Config()
        {
            appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "../../");
            configuration = new ConfigurationBuilder()
                .SetBasePath(appSettingsPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}

