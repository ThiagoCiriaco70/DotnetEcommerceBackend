using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedGenres2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Metroidvania" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
