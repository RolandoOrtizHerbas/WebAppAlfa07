using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppAlfa07.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Cveproducto { get; set; }
        public string Produ { get; set; }
        public string Modelo { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
