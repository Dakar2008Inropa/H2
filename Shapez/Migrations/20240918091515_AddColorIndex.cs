using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shapez.Migrations
{
    /// <inheritdoc />
    public partial class AddColorIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Color",
                table: "Shapes",
                column: "Color");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Color",
                table: "Shapes");
        }
    }
}
