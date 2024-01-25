using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace signinfor.Migrations
{
    /// <inheritdoc />
    public partial class yasiru : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "n_data",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "n_data");
        }
    }
}
