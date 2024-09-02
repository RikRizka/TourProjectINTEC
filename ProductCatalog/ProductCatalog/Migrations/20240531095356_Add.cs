using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductCatalog.Migrations
{
    /// <inheritdoc />
    public partial class Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true),
                    IsNewRelease = table.Column<bool>(type: "bit", nullable: true),
                    IsBestSeller = table.Column<bool>(type: "bit", nullable: true),
                    BindingType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Kids Book" },
                    { 2, "Food" },
                    { 3, "Comik" },
                    { 4, "Adult Book" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "BindingType", "CategoryId", "IsAvailable", "IsBestSeller", "IsNewRelease", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, null, 3, null, null, null, 10.1m, "Binggo" },
                    { 2, null, 2, null, null, null, 3.5m, "Cimochi" },
                    { 3, null, 4, null, null, null, 2.19m, "Loulou" },
                    { 5, null, 4, null, null, null, 6.1m, "Coucou" },
                    { 6, null, 3, null, null, null, 6.1m, "Desparcito" },
                    { 7, null, 4, null, null, null, 6.1m, "Belachelijk" },
                    { 8, null, 1, null, null, null, 6.1m, "Marsupilami" },
                    { 9, null, 2, null, null, null, 6.1m, "NumNum" },
                    { 10, null, 1, null, null, null, 6.1m, "Tom&Jery" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
