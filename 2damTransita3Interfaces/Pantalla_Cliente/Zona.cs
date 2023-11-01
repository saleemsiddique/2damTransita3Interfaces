using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    internal class Zona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Zona(string nombre)
        {
            this.id = id;
            this.nombre = nombre;

        }
        public override string ToString()
        {
            return $"ID: {id}, Nombre: {nombre}";
        }
    }
   
}
