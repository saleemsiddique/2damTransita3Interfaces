using Pantalla_Cliente;
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

    public string foto { get; set; }

    public Cliente cliente { get; set; }

    public Punto punto { get; set; }

    public Incidencia(string descripcion, EstadoIncidencia estado, string duracion, DateTime fechaHora, Cliente cliente, Punto punto, string foto)
    {
        this.descripcion = descripcion;
        this.estado = estado;
        this.duracion = duracion;
        this.fechaHora = fechaHora;
        this.cliente = cliente;
        this.punto = punto;
        this.foto = foto;
    }

    public override string ToString()
    {
        return $"ID: {id}, Descripción: {descripcion}, Estado: {estado.ToString()}, Cliente: {cliente}, Punto: {punto}";
    }


}

internal enum EstadoIncidencia
{
    ENVIADO,
    ACEPTADO,
    ENPROCESO,
    FINALIZADO
}