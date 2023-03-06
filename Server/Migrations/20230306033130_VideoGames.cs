using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class VideoGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Pelea", "pelea" },
                    { 2, "Disparos", "disparos" },
                    { 3, "Historia", "historia" }
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Igual que sus predecesores, se trata de un juego de lucha donde hay que debilitar a los rivales para expulsarles de los márgenes del escenario. El plantel está formado por personajes de otros videojuegos, tanto de Nintendo como de otras desarrolladoras independientes, e incluye a todos los combatientes de entregas anteriores. ", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Super_Smash_Bros._Ultimate_logo.svg/1920px-Super_Smash_Bros._Ultimate_logo.svg.png", 9.99m, "Super Smash Bros. Ultimate" },
                    { 2, 2, "es un videojuego de disparos en primera persona, perteneciente al género Battle royale gratuito, lanzado el 10 de marzo de 2020 para PlayStation 4, PlayStation 5, Xbox One, Xbox Series X|S y Microsoft Windows. El modo juego está disponible en estas plataformas y es parte del videojuego de 2019, Call of Duty: Modern Warfare, pero no requiere su compra y se presentó durante la temporada 2 del contenido de Modern Warfare. Con la integración con Call of Duty: Vanguard pasó a denominarse Call of Duty: Warzone Pacific.", "https://upload.wikimedia.org/wikipedia/commons/e/e6/Call_of_Duty_Warzone_Logo.png", 7.99m, "Call of Duty: Warzone" },
                    { 3, 3, "Ambientado en el siglo IX, el juego tiene lugar durante la invasión de Gran Bretaña por parte de los Vikingos, con el jugador controlando al guerrero vikingo Eivor dirigiendo a su pueblo contra el rey sajón Alfredo el Grande y sus reinos vasallos, a los que controla a través de una secta pagana llamada la Orden de los Antiguos, y que pretende cristianizarla.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7c/Assassin%27s_Creed_Valhalla_text_logo.svg/1920px-Assassin%27s_Creed_Valhalla_text_logo.svg.png", 8.99m, "Assassin's Creed: Valhalla" },
                    { 4, 3, "Es un videojuego de acción-aventura de mundo abierto desarrollado y publicado por Nintendo para la consola Nintendo Switch y Wii U. La historia sigue a Link, quien se despierta de un sueño de 100 años para descubrir que el reino de Hyrule está en ruinas y es amenazado por el malvado Calamity Ganon.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/The_Legend_of_Zelda_Breath_of_the_Wild_logo.png/1920px-The_Legend_of_Zelda_Breath_of_the_Wild_logo.png", 12.99m, "The Legend of Zelda: Breath of the Wild" },
                    { 5, 3, "Es un videojuego de simulación de fútbol desarrollado por EA Sports y publicado por Electronic Arts. Es el vigésimo noveno título de la serie FIFA y se lanzó en septiembre de 2021 para varias plataformas de videojuegos.", "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f7/FIFA_22_Logo.png/1920px-FIFA_22_Logo.png", 10.99m, "FIFA 22" },
                    { 6, 2, "Es un videojuego de acción-aventura de mundo abierto desarrollado por Rockstar North y publicado por Rockstar Games. La historia sigue a tres criminales y sus esfuerzos por cometer delitos mientras son perseguidos por la policía y otros enemigos.", "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a5/Grand_Theft_Auto_V_Logo.svg/1920px-Grand_Theft_Auto_V_Logo.svg.png", 15.99m, "Grand Theft Auto V" },
                    { 7, 3, "Es un videojuego de terror y supervivencia en tercera persona lanzado en mayo de 2021. El juego sigue a Ethan Winters mientras explora una aldea aislada y lucha contra los habitantes mutantes y los jefes del lugar, incluyendo a la famosa Lady Dimitrescu. El juego cuenta con gráficos mejorados y un sistema de inventario y crafteo más avanzado.", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/Resident_Evil_Village_Logo.png/640px-Resident_Evil_Village_Logo.png", 11.99m, "Resident Evil Village" },
                    { 8, 1, "Es un videojuego de aventuras de mundo abierto lanzado en 2017. El jugador controla a Link, que despierta después de cien años de sueño para luchar contra Calamity Ganon y liberar a la Princesa Zelda y el Reino de Hyrule. El juego presenta un vasto mundo abierto para explorar y una amplia variedad de enemigos y jefes.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4c/BotW_Link_Artwork.png/640px-BotW_Link_Artwork.png", 10.99m, "The Legend of Zelda: Breath of the Wild" },
                    { 9, 3, "Es un videojuego de construcción y aventuras lanzado en 2011 que permite a los jugadores crear mundos virtuales en 3D con bloques de diferentes materiales. El juego ofrece diferentes modos de juego, como supervivencia, donde los jugadores deben sobrevivir en un mundo peligroso recolectando recursos y construyendo refugios, y creativo, donde los jugadores tienen acceso a todos los recursos y pueden construir libremente sin preocuparse por la supervivencia. Minecraft ha sido un gran éxito y ha vendido más de 200 millones de copias en todo el mundo.", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/51/Minecraft_gameplay_screenshot.png/1280px-Minecraft_gameplay_screenshot.png", 6.99m, "Minecraft" },
                    { 10, 1, "Es un videojuego de rol de acción en un mundo abierto lanzado en 2011. El juego tiene lugar en el mundo ficticio de Tamriel y los jugadores pueden explorar libremente su vasto mundo, completar misiones y luchar contra enemigos mientras adquieren habilidades y experiencia. Skyrim ha sido aclamado por su jugabilidad, su mundo inmersivo y su gran cantidad de contenido.", "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Skyrim_cover.png/1920px-Skyrim_cover.png", 11.99m, "The Elder Scrolls V: Skyrim" },
                    { 13, 2, "Es un videojuego de acción y aventuras lanzado en 2018 que tiene lugar en un mundo abierto en el Viejo Oeste. Los jugadores controlan al forajido Arthur Morgan mientras lucha contra pandillas rivales, caza y pesca para sobrevivir, y toma decisiones que afectan el resultado del juego. Red Dead Redemption 2 ha sido elogiado por su mundo detallado y realista, su historia emocionante y su gran cantidad de contenido.", "https://upload.wikimedia.org/wikipedia/commons/9/9f/Red_Dead_Redemption_2.png", 14.99m, "Red Dead Redemption 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
