namespace GymBlog.Models
{
    public class BlogPost
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string RutaImg { get; set; }
        public string Url { get; set; }

        public static List<BlogPost> GetBlogPosts()
        {
            return new List<BlogPost>
            {
                new BlogPost
                {
                    Titulo = "Mi Primer Día De Gym",
                    Descripcion = "Conoce cómo empezar tu primer día en el gimnasio.",
                    RutaImg = "/images/PrimerDia.jpg",
                    Url = "/Home/MiPrimerDiaDeGym"
                },
                new BlogPost
                {
                    Titulo = "Cómo Hacer Volumen",
                    Descripcion = "Aprende las mejores técnicas para ganar masa muscular.",
                    RutaImg = "/images/bulk.jpeg",
                    Url = "/Home/ComoHacerVolumen"
                },
                new BlogPost
                {
                    Titulo = "Cuál Es Mi Rutina",
                    Descripcion = "Descubre mi rutina personal de ejercicios.",
                    RutaImg = "/images/Rutina.jpg",
                    Url = "/Home/CualEsMiRutina"
                }
            };
        }
    }
}
