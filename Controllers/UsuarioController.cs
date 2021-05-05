using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAlfa07.Models;
using WebAppAlfa07.Models.Resp;
using WebAppAlfa07.Models.Request;
using WebAppAlfa07.Services;

namespace WebAppAlfa07.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUserService _userService;
        public UsuarioController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("login")]
        public IActionResult Autentificar([FromBody] auten model)
        {
            Respuesta respuesta = new Respuesta();
            var userresponse = _userService.aut(model);
            if (userresponse == null)
            {
                respuesta.sw1 = 0;
                respuesta.msj = "El Password no corresponde";
                return BadRequest(respuesta);
            }
            respuesta.sw1 = 1;
            respuesta.datos = userresponse;
            return Ok(respuesta);
        }
    

    }
}
