using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDPersonajes;
using AccesoDatos;

namespace PreguntasSimpson.Controllers
{
    public class TipoPersonajeController : Controller
    {
        public IActionResult Index()
        {
            List<TipoPersonaje> model = new List<TipoPersonaje>();

            model = new TipoPersonajeAD().listarTipos();

            return View(model);
        }
    }
}
