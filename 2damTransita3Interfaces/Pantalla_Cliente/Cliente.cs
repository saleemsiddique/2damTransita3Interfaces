using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public enum EstadoCuenta
{
    ACTIVADO,
    DESACTIVADO
}

public class Cliente
{
    public int id { get; set; }
    public string nombre { get; set; }
    public string apellidos { get; set; }
    public string nombreUsuario { get; set; }
    public string contrasenya { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EstadoCuenta estadoCuenta { get; set; }


    public Cliente(int id, string nombre, string apellidos, string nombreUsuario, string contrasenya, EstadoCuenta estadoCuenta)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.nombreUsuario = nombreUsuario;
        this.contrasenya = contrasenya;
        this.estadoCuenta = estadoCuenta;
    }

    public override string ToString()
    {
        return $"ID: {id}, Nombre: {nombre}, Apellidos: {apellidos}, Nombre de Usuario: {nombreUsuario}, Estado de Cuenta: {estadoCuenta}";
    }
}