using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Pantalla_Cliente
{
    public enum AccesibilidadTipo
    {
        ACCESIBLE,
        NO_ACCESIBLE
    }

    public enum TipoPunto
    {
        ACCESO,
        LUGAR
    }

    public class Punto
    {
        public int id { get; set; }
        public string descripcion { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TipoPunto tipoPunto { get; set; }
        public string foto { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public AccesibilidadTipo accesibilidadPunto { get; set; }

        public override string ToString()
        {
            return $"Id: {id}, Descripcion: {descripcion}, TipoPunto: {tipoPunto}, Foto: {foto}, " +
                   $"Latitud: {latitud}, Longitud: {longitud}, AccesibilidadPunto: {accesibilidadPunto}";
        }
    }
}
