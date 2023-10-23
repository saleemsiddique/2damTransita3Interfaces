using System.Drawing;
using System;
namespace Pantalla_Cliente
{
    internal class Incidencia
    {
        private int id { get; set;}
        private long duracion { get; set; }
        private DateTime fechaHora { get; set; }
        private string descripcion { get; set; }
        private EstadoIncidencia estado { get; set; }

    }
   
}