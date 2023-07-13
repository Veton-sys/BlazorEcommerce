using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text-based video game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png", 9.99m, "Hitchhiker Guide" },
                    { 2, "asdasdasdasdasdasdasdaasdasdasdasdasdasdaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png", 19.99m, "Ready player one" },
                    { 3, "xzcccccccccccccccccccccccccccccccccccccccccccccccccccccccc", "https://upload.wikimedia.org/wikipedia/en/7/74/Ready_Player_One_%28film%29.png", 29.99m, "Nineteen eighty four" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
