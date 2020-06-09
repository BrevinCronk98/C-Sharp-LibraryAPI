using Microsoft.EntityFrameworkCore.Migrations;

namespace APIPractice.Migrations
{
    public partial class UpdateText : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { " A Collection of Short Horror Stories", " Horror " });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { " A Collection of Short Comedic Stories ", " Comedy " });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { " A Collection of Short Drama Stories ", " Drama " });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { " A Collection of Short Adventure Stories", " Adventure " });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { " A Collection of Short Suspenseful Stories ", " Suspenseful " });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { " A Collection of Short Poems ", " Poems " });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: 1,
                column: "StoryDetails",
                value: " Id love to have an adventure  To different worlds where my heart can fly  To different worlds where my heart desires  And will be remembered until I die.  Id love to have an adventure  Along with my precious pen  And write down all the things Ive witnessed  And read it all again.  Id love to have an adventure  Through the darkest part of the forest  And meet the greatest beasts  And see who is the toughest.  Id love to have an adventure  Through the deepest part of the sea  Where a place I can find peace  As if there is no living creature but me.  Id love to have an adventure  Where mysterious mountains hide secrets  Then Ill climb to its toppest part  By ignoring the chirping crickets.  Id love to have an adventure  Where I can be my fullest self  Together with my loved ones  And finish the books on the shelf.  Id love to have an adventure  With my eyes that is sharper than knife  Ill face my battles, brave and humble  Until I get to the Everlasting Life ");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: 2,
                columns: new[] { "StoryDetails", "StoryName" },
                values: new object[] { " Like crunchy cornflakes  Gold leaves rustle underfoot  Beauty in decay. ", "Octobers Gold" });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: 3,
                columns: new[] { "StoryDetails", "StoryName" },
                values: new object[] { " It was one a.m. and Guy Halverson sat in his dark living room. He hadn't moved for over an hour. The accident earlier that evening kept playing over and over in his mind. The light turned red, but he was in a hurry and accelerated. An orange blur came from his right, and in a split second there was a violent jolt, then the bicyclist rolled across his hood and fell out of sight on the pavement. Horns blared angrily and he panicked, stepping on the gas and screeching away from the chaos into the darkness, shaken and keeping an eye on his rearview mirror until he got home.Why did you run, you idiot? He'd never committed a crime before this and punished himself by imagining years in jail, his career gone, his family gone, his future gone.Why not just go to the police right now? You can afford a lawyer.Then someone tapped on the front door and his world suddenly crumbled away beneath him. They found me. There was nothing he could do but answer it. Running would only make matters worse. His body trembling, he got up, went to the door and opened it. A police officer stood under the porch light. Mr. Halverson?  asked the grim officer.He let out a defeated sigh. Yes. Let me —  I am terribly sorry, but I'm afraid I have some bad news. Your son's bike was struck by a hit and run driver this evening. He died at the scene. I'm very sorry for your loss.", "The Accident" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { "A Collection of Short Horror Stories", "Horror" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { "A Collection of Short Comedic Stories", "Comedy" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 3,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { "A Collection of Short Drama Stories", "Drama" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 4,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { "A Collection of Short Adventure Stories", "Adventure" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 5,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { "A Collection of Short Suspenseful Stories", "Suspenseful" });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 6,
                columns: new[] { "GenreDescription", "GenreName" },
                values: new object[] { "A Collection of Short Poems", "Poems" });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: 1,
                column: "StoryDetails",
                value: "Id love to have an adventureTo different worlds where my heart can flyTo different worlds where my heart desiresAnd will be remembered until I die.Id love to have an adventureAlong with my precious penAnd write down all the things Ive witnessedAnd read it all again.Id love to have an adventureThrough the darkest part of the forestAnd meet the greatest beastsAnd see who is the toughest.Id love to have an adventureThrough the deepest part of the seaWhere a place I can find peaceAs if there is no living creature but me.Id love to have an adventureWhere mysterious mountains hide secretsThen Ill climb to its toppest partBy ignoring the chirping crickets.Id love to have an adventureWhere I can be my fullest selfTogether with my loved onesAnd finish the books on the shelf.Id love to have an adventureWith my eyes that is sharper than knifeIll face my battles, brave and humbleUntil I get to the Everlasting Life");

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: 2,
                columns: new[] { "StoryDetails", "StoryName" },
                values: new object[] { "Like crunchy cornflakesGold leaves rustle underfootBeauty in decay.", "Octobers Gold by Paul Holmes" });

            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: 3,
                columns: new[] { "StoryDetails", "StoryName" },
                values: new object[] { "It was one a.m. and Guy Halverson sat in his dark living room. He hadn't moved for over an hour. The accident earlier that evening kept playing over and over in his mind. The light turned red, but he was in a hurry and accelerated. An orange blur came from his right, and in a split second there was a violent jolt, then the bicyclist rolled across his hood and fell out of sight on the pavement. Horns blared angrily and he panicked, stepping on the gas and screeching away from the chaos into the darkness, shaken and keeping an eye on his rearview mirror until he got home.Why did you run, you idiot? He'd never committed a crime before this and punished himself by imagining years in jail, his career gone, his family gone, his future gone.Why not just go to the police right now? You can afford a lawyer.Then someone tapped on the front door and his world suddenly crumbled away beneath him. They found me. There was nothing he could do but answer it. Running would only make matters worse. His body trembling, he got up, went to the door and opened it. A police officer stood under the porch light.Mr. Halverson?asked the grim officer.He let out a defeated sigh.Yes. Let me —I am terribly sorry, but I'm afraid I have some bad news. Your son's bike was struck by a hit and run driver this evening. He died at the scene. I'm very sorry for your loss.", "The Accident by Minnboy" });
        }
    }
}
