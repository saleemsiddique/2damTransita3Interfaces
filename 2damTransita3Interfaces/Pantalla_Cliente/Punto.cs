using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    class Punto
    {

        public int Id { get; set; }
        public byte[] Foto { get; set; } // Usamos byte[] para almacenar la imagen (puede variar según el tipo de almacenamiento)
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public int Accesibilidad { get; set; } // 0: acceso, 1: lugar
        public string Tipo { get; set; } // "acceso" o "lugar"
        public string Descripcion { get; set; }

    }
}
