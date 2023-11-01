using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.IO;
using System.Windows.Forms;



namespace Pantalla_Cliente
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static string rutaBase;
        public static string token;
        static void Main()
        {
            string appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "../../");

            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(appSettingsPath)
                .AddJsonFile("appsettings.json")
                .Build();


            rutaBase = configuration["AppSettings:RutaBase"];
            token = configuration["AppSettings:token"];

            Console.WriteLine(rutaBase);
            Console.WriteLine(token);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Transita());
        }   
    }
}
