using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppAlfa07.Models;
using WebAppAlfa07.Models.Resp;
using WebAppAlfa07.Models.Request;
using Microsoft.AspNetCore.Authorization;

namespace WebAppAlfa07.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {

            using (DBASEALFAContext db = new DBASEALFAContext())
            {
                Respuesta mirespuesta = new Respuesta();
                mirespuesta.sw1 = 0;
                try
                {

                    var lst = db.Productos.ToList();
                    mirespuesta.sw1 = 1;
                    mirespuesta.msj = "Exito";
                    mirespuesta.datos = lst;


                }
                catch (Exception ex)
                {
                    mirespuesta.msj = ex.Message;

                }
                return Ok(mirespuesta);
            }



        }

        [HttpPost]

        public IActionResult Add(ProductoRequest omodelo)
        {
            Respuesta orespuesta = new Respuesta();
            orespuesta.sw1 = 0;
            try
            {
                using (DBASEALFAContext db = new DBASEALFAContext())
                {
                    Producto oproducto = new Producto();
                    oproducto.Cveproducto = omodelo.CVEProducto;
                    oproducto.Produ= omodelo.Produ;
                    oproducto.Modelo = omodelo.Modelo;
                    oproducto.Cantidad = omodelo.Cantidad;

                    orespuesta.sw1 = 1;
                    orespuesta.msj = "Exito";
                    orespuesta.datos = oproducto;
                    db.Productos.Add(oproducto);
                    db.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                orespuesta.msj = ex.Message;
            }
            return Ok(orespuesta);
        }

    }
}
