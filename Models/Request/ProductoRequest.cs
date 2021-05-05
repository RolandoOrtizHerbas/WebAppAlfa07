using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAlfa07.Models.Request
{
    public class ProductoRequest
    {
       
        public int Id { get; set; }
        public string CVEProducto { get; set; }

        public string Produ { get; set; }
        public string Modelo { get; set; }

        public decimal Cantidad { get; set; }
       
    }
}
