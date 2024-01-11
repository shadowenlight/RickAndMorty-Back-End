using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RickAndMorty.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "episodes");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "characters");
        }
    }
}
