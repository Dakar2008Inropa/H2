using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shapez.Migrations
{
    /// <inheritdoc />
    public partial class CreatedShapesDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shapes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Shapez = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Owner = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shapes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shapes");
        }
    }
}