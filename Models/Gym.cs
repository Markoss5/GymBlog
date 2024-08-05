namespace GymBlog.Models
{
    public class Gym
    {
        public string Barrio { get; set; }
        public string NombreGym { get; set; }
        public string Direccion { get; set; }
        public string RutaImagen { get; set; }

        public static List<Gym> GetGyms()
        {
            return new List<Gym>
            {
                new Gym { NombreGym = "BIGG Barrio Norte", Barrio = "Zona Norte", Direccion = "Sánchez De Bustamante 1852, 1425 Buenos Aires", RutaImagen = "/images/BarrioNorte.jpg" },
                new Gym { NombreGym = "SportClub Sur", Barrio = "Sur", Direccion = "Av. Caseros 2675, Buenos Aires", RutaImagen = "/images/SportClub.png" },
                new Gym { NombreGym = "Megatlon Caballito", Barrio = "Este", Direccion = "Av. Rivadavia 5108, Buenos Aires", RutaImagen = "/images/Megatlon.jpg" },
                new Gym { NombreGym = "SportClub Oeste", Barrio = "Oeste", Direccion = "Av. Juan B. Justo 6200, Buenos Aires", RutaImagen = "/images/SportClub.png" },
                new Gym { NombreGym = "Always Gym", Barrio = "Palermo", Direccion = "Guatemala 4641, Palermo, Buenos Aires", RutaImagen = "/images/Megatlon.jpg" },
                new Gym { NombreGym = "Megatlon Belgrano", Barrio = "Belgrano", Direccion = "Av. Cabildo 1209, Belgrano, Buenos Aires", RutaImagen = "/images/Megatlon.jpg" },
                new Gym { NombreGym = "Broklyn Gym Recoleta", Barrio = "Recoleta", Direccion = "Av. Pueyrredón 1770, Recoleta, Buenos Aires", RutaImagen = "/images/Recoleta.jpg" },
                new Gym { NombreGym = "Megatlon Caballito", Barrio = "Caballito", Direccion = "Av. Rivadavia 5108, Caballito, Buenos Aires", RutaImagen = "/images/Megatlon.jpg" },
                new Gym { NombreGym = "SportClub Almagro ", Barrio = "Almagro", Direccion = "Av. Rivadavia 4100, Almagro, Buenos Aires", RutaImagen = "/images/SportClub.png" },
                new Gym { NombreGym = "United Fight Center", Barrio = "Villa Crespo", Direccion = "Av. Corrientes 5200, Villa Crespo, Buenos Aires", RutaImagen = "/images/VillaCrespo.png" },
                new Gym { NombreGym = "SportClub Barracas", Barrio = "Barracas", Direccion = "Av. Montes de Oca 100, Barracas, Buenos Aires", RutaImagen = "/images/SportClub.png" },
            };
        }
    }
}
