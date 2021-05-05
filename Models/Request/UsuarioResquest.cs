using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAlfa07.Models.Request
{
    public class UsuarioResquest
    {
        public int Id { get; set; }
        public string Usu { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        public string Rol { get; set; }

    }
}
