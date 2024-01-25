using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace signinfor.Migrations
{
    /// <inheritdoc />
    public partial class updateFAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "factions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterFaction",
                columns: table => new
                {
                    FactionsId = table.Column<int>(type: "int", nullable: false),
                    charactersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFaction", x => new { x.FactionsId, x.charactersId });
                    table.ForeignKey(
                        name: "FK_CharacterFaction_characters_charactersId",
                        column: x => x.charactersId,
                        principalTable: "characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFaction_factions_FactionsId",
                        column: x => x.FactionsId,
                        principalTable: "factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFaction_charactersId",
                table: "CharacterFaction",
                column: "charactersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterFaction");

            migrationBuilder.DropTable(
                name: "factions");
        }
    }
}
