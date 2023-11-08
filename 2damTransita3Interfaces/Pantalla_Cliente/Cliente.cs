using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public enum EstadoCuenta
{
    ACTIVADO,
    DESACTIVADO
}
public enum Rol
{
    ROLE_ADMIN,
    ROLE_MODERADOR,
    ROLE_USUARIO
}
public class Cliente
{
    public int id { get; set; }
    public string nombre { get; set; }
    public string apellidos { get; set; }
    public string nombreUsuario { get; set; }
    public string contrasenya { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Rol rol { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public EstadoCuenta estadoCuenta { get; set; }

    public Cliente()
    {
        
    }
    public Cliente(int id, string nombre, string apellidos, string nombreUsuario, string contrasenya, EstadoCuenta estadoCuenta)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.nombreUsuario = nombreUsuario;
        this.contrasenya = contrasenya;
        this.estadoCuenta = estadoCuenta;
    }
    public Cliente(int id, string nombre, string apellidos, string nombreUsuario, string contrasenya, EstadoCuenta estadoCuenta,Rol rol)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.nombreUsuario = nombreUsuario;
        this.contrasenya = contrasenya;
        this.estadoCuenta = estadoCuenta;
        this.rol = rol;
    }
    public override string ToString()
    {
        return $"ID: {id}, Nombre: {nombre}, Apellidos: {apellidos}, Nombre de Usuario: {nombreUsuario}, Estado de Cuenta: {estadoCuenta}";
    }
}