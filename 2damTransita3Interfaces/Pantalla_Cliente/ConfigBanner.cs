using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace Pantalla_Cliente
{
    public partial class ConfigBanner : Form
    {

        string direccion = Program.rutaBase;
        string jsonPath = "../../appsettings.json";

        public ConfigBanner()
        {
            InitializeComponent();
        }

        private void ConfigBanner_Load(object sender, EventArgs e)
        {
            direccionBox.Text = direccion;
            System.Drawing.Drawing2D.GraphicsPath objDraw = new System.Drawing.Drawing2D.GraphicsPath();
            int borderRadius = 10; // Puedes ajustar este valor para controlar el redondeo

            int width = this.Width;
            int height = this.Height;
            int arcSize = borderRadius * 2;

            objDraw.AddArc(0, 0, arcSize, arcSize, 180, 90); // Esquina superior izquierda
            objDraw.AddArc(width - arcSize, 0, arcSize, arcSize, 270, 90); // Esquina superior derecha
            objDraw.AddArc(width - arcSize, height - arcSize, arcSize, arcSize, 0, 90); // Esquina inferior derecha
            objDraw.AddArc(0, height - arcSize, arcSize, arcSize, 90, 90); // Esquina inferior izquierda

            objDraw.CloseFigure();

            this.Region = new Region(objDraw);
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            Program.rutaBase = direccionBox.Text;
            string json = File.ReadAllText(jsonPath);
            var jObject = JObject.Parse(json);

            jObject["AppSettings"]["RutaBase"] = direccionBox.Text;
            Configuration config = JsonSerializer.Deserialize<Configuration>(json);

            

            string updatedJson = jObject.ToString(Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonPath, updatedJson);
            this.Close();
        }

        private void direccionBox_TextChanged(object sender, EventArgs e)
        {
            if (!direccionBox.Text.Equals(direccion))
            {
                btn_aceptar.Text = "APLICAR";
            }
        }
    }
}
