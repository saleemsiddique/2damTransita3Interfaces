using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Windows.Forms;



namespace Pantalla_Cliente
{
    static class Program
    {
        
        public static UserLoged userLogged;
        public static string rutaBase;
        public static string token;
        public static IConfiguration configurations;
        public static string fileFilter = "PNG files|*.png|JPEG files|*.jpg|GIF files|*.gif|Image files|*.bmp;*.jpg;*.gif;*.png;*.tif";

        [STAThread]
        static void Main()
        {
            string appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), "../../");

                configurations = new ConfigurationBuilder()
                .SetBasePath(appSettingsPath)
                .AddJsonFile("appsettings.json")
                .Build();


            rutaBase = configurations["AppSettings:RutaBase"];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }   
    }
}
