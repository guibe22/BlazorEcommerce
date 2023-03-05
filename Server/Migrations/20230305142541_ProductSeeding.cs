using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Igual que sus predecesores, se trata de un juego de lucha donde hay que debilitar a los rivales para expulsarles de los márgenes del escenario. El plantel está formado por personajes de otros videojuegos, tanto de Nintendo como de otras desarrolladoras independientes, e incluye a todos los combatientes de entregas anteriores. ", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Super_Smash_Bros._Ultimate_logo.svg/1920px-Super_Smash_Bros._Ultimate_logo.svg.png", 9.99m, "Super Smash Bros. Ultimate" },
                    { 2, "es un videojuego de disparos en primera persona, perteneciente al género Battle royale gratuito, lanzado el 10 de marzo de 2020 para PlayStation 4, PlayStation 5, Xbox One, Xbox Series X|S y Microsoft Windows. El modo juego está disponible en estas plataformas y es parte del videojuego de 2019, Call of Duty: Modern Warfare, pero no requiere su compra y se presentó durante la temporada 2 del contenido de Modern Warfare. Con la integración con Call of Duty: Vanguard pasó a denominarse Call of Duty: Warzone Pacific.", "https://upload.wikimedia.org/wikipedia/commons/e/e6/Call_of_Duty_Warzone_Logo.png", 7.99m, "Call of Duty: Warzone" },
                    { 3, "Ambientado en el siglo IX, el juego tiene lugar durante la invasión de Gran Bretaña por parte de los Vikingos, con el jugador controlando al guerrero vikingo Eivor dirigiendo a su pueblo contra el rey sajón Alfredo el Grande y sus reinos vasallos, a los que controla a través de una secta pagana llamada la Orden de los Antiguos, y que pretende cristianizarla.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Assassin%27s_Creed_Valhalla_text_logo.svg/1920px-Assassin%27s_Creed_Valhalla_text_logo.svg.png", 8.99m, "Assassin's Creed: Valhalla" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
