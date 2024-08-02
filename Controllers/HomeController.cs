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
                new Gym { Name = "Gimnasio Central", Neighborhood = "Centro", Address = "Calle Principal 123", GImageUrl = "/images/gym_central.jpg" },
                new Gym { Name = "Gimnasio Norte", Neighborhood = "Norte", Address = "Avenida Norte 456", GImageUrl = "/images/gym_norte.jpg" },
                new Gym { Name = "Gimnasio Sur", Neighborhood = "Sur", Address = "Calle Sur 789", GImageUrl = "/images/gym_sur.jpg" },
                new Gym { Name = "Gimnasio Este", Neighborhood = "Este", Address = "Avenida Este 101", GImageUrl = "/images/gym_este.jpg" },
                new Gym { Name = "Gimnasio Oeste", Neighborhood = "Oeste", Address = "Calle Oeste 202", GImageUrl = "/images/gym_oeste.jpg" },
                new Gym { Name = "Gimnasio San Miguel", Neighborhood = "San Miguel", Address = "Calle San Miguel 303", GImageUrl = "/images/gym_san_miguel.jpg" },
                new Gym { Name = "Gimnasio Palermo", Neighborhood = "Palermo", Address = "Avenida Palermo 404", GImageUrl = "/images/gym_palermo.jpg" },
                new Gym { Name = "Gimnasio Belgrano", Neighborhood = "Belgrano", Address = "Calle Belgrano 505", GImageUrl = "/images/gym_belgrano.jpg" },
                new Gym { Name = "Gimnasio Recoleta", Neighborhood = "Recoleta", Address = "Avenida Recoleta 606", GImageUrl = "/images/gym_recoleta.jpg" },
                new Gym { Name = "Gimnasio Caballito", Neighborhood = "Caballito", Address = "Calle Caballito 707", GImageUrl = "/images/gym_caballito.jpg" },
                new Gym { Name = "Gimnasio Almagro", Neighborhood = "Almagro", Address = "Avenida Almagro 808", GImageUrl = "/images/gym_almagro.jpg" },
                new Gym { Name = "Gimnasio Boedo", Neighborhood = "Boedo", Address = "Calle Boedo 909", GImageUrl = "/images/gym_boedo.jpg" },
                new Gym { Name = "Gimnasio Villa Crespo", Neighborhood = "Villa Crespo", Address = "Avenida Villa Crespo 1010", GImageUrl = "/images/gym_villa_crespo.jpg" },
                new Gym { Name = "Gimnasio Villa Urquiza", Neighborhood = "Villa Urquiza", Address = "Calle Villa Urquiza 1111", GImageUrl = "/images/gym_villa_urquiza.jpg" },
                new Gym { Name = "Gimnasio Barracas", Neighborhood = "Barracas", Address = "Avenida Barracas 1212", GImageUrl = "/images/gym_barracas.jpg" },
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
            ViewBag.Gyms = GetGyms(); // Asegurarse de inicializar ViewBag.Gyms
            ViewBag.Gym = null; // Inicializar Gym para evitar null references
            return View();
        }

        [HttpPost]
        public IActionResult BuscarGym(string barrio)
        {
            var gyms = GetGyms();
            var gym = gyms.FirstOrDefault(g => g.Neighborhood == barrio);

            ViewBag.Gym = gym;
            ViewBag.Gyms = gyms; // Asegurarse de inicializar ViewBag.Gyms
            return View();
        }
    }
}
