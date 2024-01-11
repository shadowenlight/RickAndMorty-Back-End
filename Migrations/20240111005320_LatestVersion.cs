using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RickAndMorty.Migrations
{
    /// <inheritdoc />
    public partial class LatestVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEpisode_characters_Charactersid",
                table: "CharacterEpisode");

            migrationBuilder.RenameColumn(
                name: "Charactersid",
                table: "CharacterEpisode",
                newName: "charactersid");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEpisode_characters_charactersid",
                table: "CharacterEpisode",
                column: "charactersid",
                principalTable: "characters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEpisode_characters_charactersid",
                table: "CharacterEpisode");

            migrationBuilder.RenameColumn(
                name: "charactersid",
                table: "CharacterEpisode",
                newName: "Charactersid");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEpisode_characters_Charactersid",
                table: "CharacterEpisode",
                column: "Charactersid",
                principalTable: "characters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
