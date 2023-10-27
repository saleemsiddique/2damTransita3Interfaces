using System;
using System.Text.Json.Serialization;

internal class Incidencia
{
    public int id { get; set; }
    public string descripcion { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EstadoIncidencia estado { get; set; }
    public string duracion { get; set; }
    public DateTime fechaHora { get; set; }

    public override string ToString()
    {
        return $"ID: {id}, Descripción: {descripcion}, Estado: {estado}";
    }
}

internal enum EstadoIncidencia
{
    Abierta,
    Revision,
    Cerrada
}