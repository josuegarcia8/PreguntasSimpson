using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDPersonajes;
using AccesoDatos;
using System.IO;

namespace PreguntasSimpson.Controllers
{
    public class PersonajeController : Controller
    {
        public IActionResult Index()
        {
            //Lista con todos los personajes
            List<Personaje> personajes = new List<Personaje>();

            //ToDo

            return View(personajes);
        }

        public IActionResult Hermano(string hermano1, string hermano2)
        {
            var url = "http://localhost:8705/hermano?hermano1=" + hermano1 + "&hermano2=" + hermano2;
            var webrequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);

            string respuesta = "";

            using(var response = webrequest.GetResponse()) 
            {
                using(var reader = new StreamReader(response.GetResponseStream())) 
                {
                    respuesta = reader.ReadToEnd();
                }
            }

            return Content(respuesta);
        }

        public IActionResult AgregarPersonaje()
        {
            //Agregar personajes
            Personaje personaje = new Personaje();

            //ToDo

            return View(personaje);
        }

        public IActionResult EditarPersonaje(int id)
        {
            Personaje personaje = new Personaje();

            //ToDo

            return View(personaje);
        }

        public IActionResult VerDetalles(int id)
        {
            //Listar personaje
            Personaje personaje = new Personaje();

            //ToDo

            return View(personaje);
        }
    }
}
