using Microsoft.AspNetCore.Mvc;
using GymBlog.Models;
using System.Collections.Generic;
using System.Linq;

namespace GymBlog.Controllers
{
    public class HomeController : Controller
    {
        private List<BlogPost> GetBlogPosts()
        {
            return new List<BlogPost>
            {
                new BlogPost
                {
                    Title = "Mi Primer Día De Gym",
                    Description = "Conoce cómo empezar tu primer día en el gimnasio.",
                    ImageUrl = "/images/PrimerDia.jpg",
                    Url = "/Home/MiPrimerDiaDeGym"
                },
                new BlogPost
                {
                    Title = "Cómo Hacer Volumen",
                    Description = "Aprende las mejores técnicas para ganar masa muscular.",
                    ImageUrl = "/images/bulk.jpeg",
                    Url = "/Home/ComoHacerVolumen"
                },
                new BlogPost
                {
                    Title = "Cuál Es Mi Rutina",
                    Description = "Descubre mi rutina personal de ejercicios.",
                    ImageUrl = "/images/Rutina.jpg",
                    Url = "/Home/CualEsMiRutina"
                }
            };
        }

        private List<Gym> GetGyms()
        {
            return new List<Gym>
            {
                new Gym
                {
                    Neighborhood = "Palermo",
                    Name = "Gym Palermo",
                    Address = "Calle Falsa 123, Palermo",
                    GoogleMapsUrl = "https://maps.google.com/?q=Gym+Palermo"
                },
                new Gym
                {
                    Neighborhood = "Recoleta",
                    Name = "Gym Recoleta",
                    Address = "Calle Verdadera 456, Recoleta",
                    GoogleMapsUrl = "https://maps.google.com/?q=Gym+Recoleta"
                },
                // Agregar más gimnasios aquí
            };
        }

        public IActionResult Index()
        {
            ViewBag.BlogPosts = GetBlogPosts();
            ViewBag.Resultado = null; // Inicializar Resultado para evitar null references

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

            ViewBag.BlogPosts = GetBlogPosts(); // Reutilizar el código para inicializar blogPosts

            return View("Index");
        }

        public IActionResult BuscarGym()
        {
            ViewBag.Gyms = GetGyms();
            return View();
        }

        [HttpPost]
        public IActionResult BuscarGym(string barrio)
        {
            var gyms = GetGyms();
            var gym = gyms.FirstOrDefault(g => g.Neighborhood == barrio);

            if (gym != null)
            {
                ViewBag.Gym = gym;
            }

            ViewBag.Gyms = gyms;
            return View();
        }
    }
}
