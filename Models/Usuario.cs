﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppAlfa07.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Usu { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
    }
}
