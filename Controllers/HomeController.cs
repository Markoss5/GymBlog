using Microsoft.AspNetCore.Mvc;
using GymBlog.Models;
using System.Collections.Generic;
using System.Linq;

namespace GymBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.BlogPosts = BlogPost.GetBlogPosts();
            ViewBag.Resultado = null;

            return View();
        }

        public IActionResult MiPrimerDiaDeGym()
        {
            return View();
        }

        public IActionResult ComoHacerVolumen()
        {
            return View();
        }

        public IActionResult CualEsMiRutina()
        {
            return View();
        }

        public IActionResult SobreMi()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalcularFuerza(double peso, int repeticiones)
        {
            double rm = peso * (1 + (repeticiones / 30.0));
            ViewBag.Resultado = rm;

            ViewBag.BlogPosts = BlogPost.GetBlogPosts();

            return View("Index");
        }

        public IActionResult BuscarGym()
        {
            ViewBag.Gyms = Gym.GetGyms();
            ViewBag.Gym = null;
            return View();
        }

        [HttpPost]
        public IActionResult BuscarGym(string barrio)
        {
            List <Gym>gyms = Gym.GetGyms();
            Gym gym1= null;
            foreach(Gym g in gyms) //recorro la lista de gyms 
            {
                if(g.Barrio == barrio) //Busco al gym que pertenece al barrio pasado por parámetro
                {
                    gym1=g;
                }
            }

            ViewBag.Gym = gym1;
            ViewBag.Gyms = gyms;
            return View();
        }
    }
}
