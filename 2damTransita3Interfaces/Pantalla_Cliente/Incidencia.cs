using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    public class Incidencia
    {
        public int Id { get; set; }
        public string lugar { get; set; }
        public double longitud { get; set; }
        public double latitud { get; set; }
        public Image Imagen { get; set; }


    }
}
