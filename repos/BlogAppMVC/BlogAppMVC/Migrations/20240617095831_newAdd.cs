using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class newAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description 1", "Author 1" },
                    { 2, "Description 1", "Author 2" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "BlogId", "Content", "CreatedAt", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Content 1", new DateTime(2024, 6, 17, 11, 58, 30, 742, DateTimeKind.Local).AddTicks(1052), "Book 1" },
                    { 2, 2, "Content 2", new DateTime(2024, 6, 17, 11, 58, 30, 742, DateTimeKind.Local).AddTicks(1091), "Book 2" },
                    { 3, 2, "Content 3", new DateTime(2024, 6, 17, 11, 58, 30, 742, DateTimeKind.Local).AddTicks(1093), "Book 3" },
                    { 4, 1, "Content 4", new DateTime(2024, 6, 17, 11, 58, 30, 742, DateTimeKind.Local).AddTicks(1095), "Book 4" },
                    { 5, 1, "Content 5", new DateTime(2024, 6, 17, 11, 58, 30, 742, DateTimeKind.Local).AddTicks(1097), "Book 5" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
