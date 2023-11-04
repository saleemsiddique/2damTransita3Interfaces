namespace Pantalla_Cliente
{
    public enum Estado
    {
        ACTIVADO,
        DESACTIVADO
    }

    class UserLoged
    {
        public string token { get; set; }
        public string type { get; set; }
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string nombreUsuario { get; set; }
        public string contrasenya { get; set; }
        public Estado estado { get; set; }
        public string[] roles { get; set; }

        public UserLoged(string token, string type, int id, string nombre, string apellidos, string nombreUsuario, string contrasenya, Estado estado, string[] roles)
        {
            this.token = token;
            this.type = type;
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.nombreUsuario = nombreUsuario;
            this.contrasenya = contrasenya;
            this.estado = estado;
            this.roles = roles;
        }

        public override string ToString()
        {
            return $"Token: {token}, Type: {type}, ID: {id}, Nombre: {nombre}, Apellidos: {apellidos}, Nombre de Usuario: {nombreUsuario}, Contraseña: {contrasenya}, Estado: {estado}, Roles: {string.Join(", ", roles)}";
        }
    }
}
