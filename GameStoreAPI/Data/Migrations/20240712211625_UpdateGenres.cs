using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameStoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Metroidvania");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Metroidvania");
        }
    }
}
