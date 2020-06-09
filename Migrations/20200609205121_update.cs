using Microsoft.EntityFrameworkCore.Migrations;

namespace APIPractice.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: 3,
                column: "StoryName",
                value: "The Accident by Minnboy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stories",
                keyColumn: "StoryId",
                keyValue: 3,
                column: "StoryName",
                value: "The Acciden by Minnboy");
        }
    }
}
