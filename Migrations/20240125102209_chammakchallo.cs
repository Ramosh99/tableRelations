using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace signinfor.Migrations
{
    /// <inheritdoc />
    public partial class chammakchallo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bagpacks_characters_CharacterId",
                table: "bagpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterFaction_characters_charactersId",
                table: "CharacterFaction");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterFaction_factions_FactionsId",
                table: "CharacterFaction");

            migrationBuilder.DropForeignKey(
                name: "FK_weapons_characters_CharacterId",
                table: "weapons");

            migrationBuilder.DropTable(
                name: "n_data");

            migrationBuilder.DropPrimaryKey(
                name: "PK_weapons",
                table: "weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_factions",
                table: "factions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_characters",
                table: "characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bagpacks",
                table: "bagpacks");

            migrationBuilder.RenameTable(
                name: "weapons",
                newName: "Weapons");

            migrationBuilder.RenameTable(
                name: "factions",
                newName: "Factions");

            migrationBuilder.RenameTable(
                name: "characters",
                newName: "Characters");

            migrationBuilder.RenameTable(
                name: "bagpacks",
                newName: "Bagpacks");

            migrationBuilder.RenameIndex(
                name: "IX_weapons_CharacterId",
                table: "Weapons",
                newName: "IX_Weapons_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_bagpacks_CharacterId",
                table: "Bagpacks",
                newName: "IX_Bagpacks_CharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Factions",
                table: "Factions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bagpacks",
                table: "Bagpacks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bagpacks_Characters_CharacterId",
                table: "Bagpacks",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterFaction_Characters_charactersId",
                table: "CharacterFaction",
                column: "charactersId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterFaction_Factions_FactionsId",
                table: "CharacterFaction",
                column: "FactionsId",
                principalTable: "Factions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Characters_CharacterId",
                table: "Weapons",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bagpacks_Characters_CharacterId",
                table: "Bagpacks");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterFaction_Characters_charactersId",
                table: "CharacterFaction");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterFaction_Factions_FactionsId",
                table: "CharacterFaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Characters_CharacterId",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Factions",
                table: "Factions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bagpacks",
                table: "Bagpacks");

            migrationBuilder.RenameTable(
                name: "Weapons",
                newName: "weapons");

            migrationBuilder.RenameTable(
                name: "Factions",
                newName: "factions");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "characters");

            migrationBuilder.RenameTable(
                name: "Bagpacks",
                newName: "bagpacks");

            migrationBuilder.RenameIndex(
                name: "IX_Weapons_CharacterId",
                table: "weapons",
                newName: "IX_weapons_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Bagpacks_CharacterId",
                table: "bagpacks",
                newName: "IX_bagpacks_CharacterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_weapons",
                table: "weapons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_factions",
                table: "factions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_characters",
                table: "characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bagpacks",
                table: "bagpacks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "n_data",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(name: "User_Name", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_n_data", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_bagpacks_characters_CharacterId",
                table: "bagpacks",
                column: "CharacterId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterFaction_characters_charactersId",
                table: "CharacterFaction",
                column: "charactersId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterFaction_factions_FactionsId",
                table: "CharacterFaction",
                column: "FactionsId",
                principalTable: "factions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_weapons_characters_CharacterId",
                table: "weapons",
                column: "CharacterId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
