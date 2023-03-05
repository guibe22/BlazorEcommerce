

namespace BlazorEcommerce.Server.Data
{
    public class DataContext:DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(

                 new Products
                 {
                     Id = 1,
                     Title = "Super Smash Bros. Ultimate",
                     Description = "Igual que sus predecesores, se trata de un juego de lucha donde hay que debilitar a los rivales para expulsarles de los márgenes del escenario. El plantel está formado por personajes de otros videojuegos, tanto de Nintendo como de otras desarrolladoras independientes, e incluye a todos los combatientes de entregas anteriores. ",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Super_Smash_Bros._Ultimate_logo.svg/1920px-Super_Smash_Bros._Ultimate_logo.svg.png",
                     Price = 9.99m
                 },

         new Products
         {
             Id = 2,
             Title = "Call of Duty: Warzone",
             Description = "es un videojuego de disparos en primera persona, perteneciente al género Battle royale gratuito, lanzado el 10 de marzo de 2020 para PlayStation 4, PlayStation 5, Xbox One, Xbox Series X|S y Microsoft Windows. El modo juego está disponible en estas plataformas y es parte del videojuego de 2019, Call of Duty: Modern Warfare, pero no requiere su compra y se presentó durante la temporada 2 del contenido de Modern Warfare. Con la integración con Call of Duty: Vanguard pasó a denominarse Call of Duty: Warzone Pacific.",
             ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e6/Call_of_Duty_Warzone_Logo.png",
             Price = 7.99m
         },

         new Products
         {
             Id = 3,
             Title = "Assassin's Creed: Valhalla",
             Description = "Ambientado en el siglo IX, el juego tiene lugar durante la invasión de Gran Bretaña por parte de los Vikingos, con el jugador controlando al guerrero vikingo Eivor dirigiendo a su pueblo contra el rey sajón Alfredo el Grande y sus reinos vasallos, a los que controla a través de una secta pagana llamada la Orden de los Antiguos, y que pretende cristianizarla.",
             ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Assassin%27s_Creed_Valhalla_text_logo.svg/1920px-Assassin%27s_Creed_Valhalla_text_logo.svg.png",
             Price = 8.99m
         }
                );

        }

       public DbSet<Products> products { get; set; }

    }
}
