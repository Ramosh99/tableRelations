using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace signinfor.Migrations
{
    /// <inheritdoc />
    public partial class checkPackage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterFaction_Characters_charactersId",
                table: "CharacterFaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterFaction",
                table: "CharacterFaction");

            migrationBuilder.DropIndex(
                name: "IX_CharacterFaction_charactersId",
                table: "CharacterFaction");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Factions");

            migrationBuilder.RenameColumn(
                name: "charactersId",
                table: "CharacterFaction",
                newName: "CharactersId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterFaction",
                table: "CharacterFaction",
                columns: new[] { "CharactersId", "FactionsId" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFaction_FactionsId",
                table: "CharacterFaction",
                column: "FactionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterFaction_Characters_CharactersId",
                table: "CharacterFaction",
                column: "CharactersId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterFaction_Characters_CharactersId",
                table: "CharacterFaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CharacterFaction",
                table: "CharacterFaction");

            migrationBuilder.DropIndex(
                name: "IX_CharacterFaction_FactionsId",
                table: "CharacterFaction");

            migrationBuilder.RenameColumn(
                name: "CharactersId",
                table: "CharacterFaction",
                newName: "charactersId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Factions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CharacterFaction",
                table: "CharacterFaction",
                columns: new[] { "FactionsId", "charactersId" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFaction_charactersId",
                table: "CharacterFaction",
                column: "charactersId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterFaction_Characters_charactersId",
                table: "CharacterFaction",
                column: "charactersId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
