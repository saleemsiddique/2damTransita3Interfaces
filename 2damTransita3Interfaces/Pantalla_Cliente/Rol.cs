using System;
using System.Collections.Generic;

namespace Pantalla_Cliente
{
    public enum ERole
    {
        ROLE_USUARIO,
        ROLE_ADMIN,
        ROLE_MODERADOR
    }

    public class Rol
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public Rol()
        {
        }

        public Rol(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"{nombre}";
        }

        public static implicit operator List<object>(Rol v)
        {
            throw new NotImplementedException();
        }
    }
}
