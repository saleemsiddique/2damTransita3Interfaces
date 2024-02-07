using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq;

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
    public List<Pantalla_Cliente.Rol> rols { get; set; }

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

    public Cliente(int id, string nombre, string apellidos, string nombreUsuario, string contrasenya, EstadoCuenta estadoCuenta, List<Pantalla_Cliente.Rol> roles)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.nombreUsuario = nombreUsuario;
        this.contrasenya = contrasenya;
        this.estadoCuenta = estadoCuenta;
        this.rols = roles;
    }

    public Cliente(string nombre, string apellidos, string nombreUsuario, string contrasenya, EstadoCuenta estadoCuenta, List<Pantalla_Cliente.Rol> roles)
    {
        this.id = id;
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.nombreUsuario = nombreUsuario;
        this.contrasenya = contrasenya;
        this.estadoCuenta = estadoCuenta;
        this.rols = roles;
    }

    public override string ToString()
    {
        string roleNames = string.Join(", ", rols.Select(r => r.nombre));

        return $"ID: {id}, Nombre: {nombre}, Apellidos: {apellidos}, Nombre de Usuario: {nombreUsuario}, Estado de Cuenta: {estadoCuenta}, Roles: {roleNames}";
    }

}
