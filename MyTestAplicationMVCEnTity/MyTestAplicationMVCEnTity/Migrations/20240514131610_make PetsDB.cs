using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyTestAplicationMVCEnTity.Migrations
{
    /// <inheritdoc />
    public partial class makePetsDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PetsDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalsGender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetsId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
