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
        public static Configuration configurations = new Configuration();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Transita());
            Console.WriteLine(configurations.rutaBase);
            Console.WriteLine(configurations.token);
        }   
    }
}
