using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAlfa07.Models.Resp
{
    public class Respuesta
    {
        public int sw1 {get;set;}
        public string msj { get; set; }

        public object datos { get; set; }
    }
}
