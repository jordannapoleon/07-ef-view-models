using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LuckySpin.Migrations
{
    /// <inheritdoc />
    public partial class trackspins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Numbers",
                table: "Spins",
                type: "TEXT",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numbers",
                table: "Spins");
        }
    }
}
