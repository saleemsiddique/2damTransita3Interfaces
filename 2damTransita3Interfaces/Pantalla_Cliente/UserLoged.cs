using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantalla_Cliente
{
    class UserLoged
    {
    
           /* public string token { get; set; }
            public string type { get; set; }
            public int id { get; set; }
            public string nombre { get; set; }
            public string apellidos { get; set; }*/
            public string nombreUsuario { get; set; }
            public string contrasenya { get; set; }
            //public string estado { get; set; }
            //public string[] roles { get; set; }
        public UserLoged(string nombreUsuario, string contrasenya)
        {
            this.nombreUsuario = nombreUsuario;
            this.contrasenya = contrasenya;
        }
    }
}
