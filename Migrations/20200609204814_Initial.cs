using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIPractice.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    StoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StoryName = table.Column<string>(nullable: true),
                    StoryDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.StoryId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GenreName = table.Column<string>(nullable: true),
                    GenreDescription = table.Column<string>(nullable: true),
                    StoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                    table.ForeignKey(
                        name: "FK_Genres_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "StoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StoryGenre",
                columns: table => new
                {
                    StoryGenreId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StoryId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoryGenre", x => x.StoryGenreId);
                    table.ForeignKey(
                        name: "FK_StoryGenre_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoryGenre_Stories_StoryId",
                        column: x => x.StoryId,
                        principalTable: "Stories",
                        principalColumn: "StoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreDescription", "GenreName", "StoryId" },
                values: new object[,]
                {
                    { 1, "A Collection of Short Horror Stories", "Horror", null },
                    { 2, "A Collection of Short Comedic Stories", "Comedy", null },
                    { 3, "A Collection of Short Drama Stories", "Drama", null },
                    { 4, "A Collection of Short Adventure Stories", "Adventure", null },
                    { 5, "A Collection of Short Suspenseful Stories", "Suspenseful", null },
                    { 6, "A Collection of Short Poems", "Poems", null }
                });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "StoryId", "StoryDetails", "StoryName" },
                values: new object[,]
                {
                    { 1, "Id love to have an adventureTo different worlds where my heart can flyTo different worlds where my heart desiresAnd will be remembered until I die.Id love to have an adventureAlong with my precious penAnd write down all the things Ive witnessedAnd read it all again.Id love to have an adventureThrough the darkest part of the forestAnd meet the greatest beastsAnd see who is the toughest.Id love to have an adventureThrough the deepest part of the seaWhere a place I can find peaceAs if there is no living creature but me.Id love to have an adventureWhere mysterious mountains hide secretsThen Ill climb to its toppest partBy ignoring the chirping crickets.Id love to have an adventureWhere I can be my fullest selfTogether with my loved onesAnd finish the books on the shelf.Id love to have an adventureWith my eyes that is sharper than knifeIll face my battles, brave and humbleUntil I get to the Everlasting Life", "Id Love To Have An Adventure" },
                    { 2, "Like crunchy cornflakesGold leaves rustle underfootBeauty in decay.", "Octobers Gold by Paul Holmes" },
                    { 3, "It was one a.m. and Guy Halverson sat in his dark living room. He hadn't moved for over an hour. The accident earlier that evening kept playing over and over in his mind. The light turned red, but he was in a hurry and accelerated. An orange blur came from his right, and in a split second there was a violent jolt, then the bicyclist rolled across his hood and fell out of sight on the pavement. Horns blared angrily and he panicked, stepping on the gas and screeching away from the chaos into the darkness, shaken and keeping an eye on his rearview mirror until he got home.Why did you run, you idiot? He'd never committed a crime before this and punished himself by imagining years in jail, his career gone, his family gone, his future gone.Why not just go to the police right now? You can afford a lawyer.Then someone tapped on the front door and his world suddenly crumbled away beneath him. They found me. There was nothing he could do but answer it. Running would only make matters worse. His body trembling, he got up, went to the door and opened it. A police officer stood under the porch light.Mr. Halverson?asked the grim officer.He let out a defeated sigh.Yes. Let me —I am terribly sorry, but I'm afraid I have some bad news. Your son's bike was struck by a hit and run driver this evening. He died at the scene. I'm very sorry for your loss.", "The Acciden by Minnboy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_StoryId",
                table: "Genres",
                column: "StoryId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryGenre_GenreId",
                table: "StoryGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_StoryGenre_StoryId",
                table: "StoryGenre",
                column: "StoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StoryGenre");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Stories");
        }
    }
}
