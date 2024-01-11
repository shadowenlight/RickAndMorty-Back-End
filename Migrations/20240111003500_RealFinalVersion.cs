using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RickAndMorty.Migrations
{
    /// <inheritdoc />
    public partial class RealFinalVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEpisode_characters_CharactersId",
                table: "CharacterEpisode");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEpisode_episodes_EpisodesId",
                table: "CharacterEpisode");

            migrationBuilder.DropForeignKey(
                name: "FK_characters_locations_CurrentLocationId",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "FK_characters_locations_OriginId",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "AirDate",
                table: "episodes");

            migrationBuilder.DropColumn(
                name: "EpisodeNo",
                table: "episodes");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "characters");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "locations",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "locations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "episodes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "episodes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "episodes",
                newName: "episode");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "episodes",
                newName: "air_date");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "characters",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "characters",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Species",
                table: "characters",
                newName: "species");

            migrationBuilder.RenameColumn(
                name: "OriginId",
                table: "characters",
                newName: "originId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "characters",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "characters",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "characters",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "characters",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CurrentLocationId",
                table: "characters",
                newName: "locationId");

            migrationBuilder.RenameIndex(
                name: "IX_characters_OriginId",
                table: "characters",
                newName: "IX_characters_originId");

            migrationBuilder.RenameIndex(
                name: "IX_characters_CurrentLocationId",
                table: "characters",
                newName: "IX_characters_locationId");

            migrationBuilder.RenameColumn(
                name: "CharactersId",
                table: "CharacterEpisode",
                newName: "Charactersid");

            migrationBuilder.RenameColumn(
                name: "EpisodesId",
                table: "CharacterEpisode",
                newName: "episodeid");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterEpisode_EpisodesId",
                table: "CharacterEpisode",
                newName: "IX_CharacterEpisode_episodeid");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEpisode_characters_Charactersid",
                table: "CharacterEpisode",
                column: "Charactersid",
                principalTable: "characters",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEpisode_episodes_episodeid",
                table: "CharacterEpisode",
                column: "episodeid",
                principalTable: "episodes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_characters_locations_locationId",
                table: "characters",
                column: "locationId",
                principalTable: "locations",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_characters_locations_originId",
                table: "characters",
                column: "originId",
                principalTable: "locations",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEpisode_characters_Charactersid",
                table: "CharacterEpisode");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEpisode_episodes_episodeid",
                table: "CharacterEpisode");

            migrationBuilder.DropForeignKey(
                name: "FK_characters_locations_locationId",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "FK_characters_locations_originId",
                table: "characters");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "locations",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "locations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "episodes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "episodes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "episode",
                table: "episodes",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "air_date",
                table: "episodes",
                newName: "Created");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "characters",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "characters",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "species",
                table: "characters",
                newName: "Species");

            migrationBuilder.RenameColumn(
                name: "originId",
                table: "characters",
                newName: "OriginId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "characters",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "characters",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "characters",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "characters",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "locationId",
                table: "characters",
                newName: "CurrentLocationId");

            migrationBuilder.RenameIndex(
                name: "IX_characters_originId",
                table: "characters",
                newName: "IX_characters_OriginId");

            migrationBuilder.RenameIndex(
                name: "IX_characters_locationId",
                table: "characters",
                newName: "IX_characters_CurrentLocationId");

            migrationBuilder.RenameColumn(
                name: "Charactersid",
                table: "CharacterEpisode",
                newName: "CharactersId");

            migrationBuilder.RenameColumn(
                name: "episodeid",
                table: "CharacterEpisode",
                newName: "EpisodesId");

            migrationBuilder.RenameIndex(
                name: "IX_CharacterEpisode_episodeid",
                table: "CharacterEpisode",
                newName: "IX_CharacterEpisode_EpisodesId");

            migrationBuilder.AddColumn<DateTime>(
                name: "AirDate",
                table: "episodes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EpisodeNo",
                table: "episodes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "characters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEpisode_characters_CharactersId",
                table: "CharacterEpisode",
                column: "CharactersId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEpisode_episodes_EpisodesId",
                table: "CharacterEpisode",
                column: "EpisodesId",
                principalTable: "episodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_characters_locations_CurrentLocationId",
                table: "characters",
                column: "CurrentLocationId",
                principalTable: "locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_characters_locations_OriginId",
                table: "characters",
                column: "OriginId",
                principalTable: "locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
