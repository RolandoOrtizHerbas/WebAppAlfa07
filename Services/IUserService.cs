using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAlfa07.Models;
using WebAppAlfa07.Models.Request;
using WebAppAlfa07.Models.Resp;
using WebAppAlfa07.Herramientas;

namespace WebAppAlfa07.Services
{
    public interface IUserService
    {
        UserResponce aut(auten model);
    }
}
