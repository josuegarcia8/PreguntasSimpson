using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDPersonajes;
using AccesoDatos;

namespace PreguntasSimpson.Controllers
{
    public class OcupacionController : Controller
    {
        public IActionResult Index()
        {
            List<OcupacionPersonaje> model = new List<OcupacionPersonaje>();

            model = new OcupacionPersonajeAD().listarOcupaciones();

            return View(model);
        }
    }
}
