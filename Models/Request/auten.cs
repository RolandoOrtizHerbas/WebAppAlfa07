using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAlfa07.Models.Request
{
    public class auten
    {
        [Required]
        public string Usu { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
