using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedMarquesTableMore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Name", "Title" },
                values: new object[,]
                {
                    { 6, "امنیت سایبری", "امنیت سایبری" },
                    { 7, "امنیت سایبری", "امنیت سایبری" },
                    { 8, "امنیت سایبری", "امنیت سایبری" },
                    { 9, "امنیت سایبری", "امنیت سایبری" },
                    { 10, "امنیت سایبری", "امنیت سایبری" },
                    { 11, "امنیت سایبری", "امنیت سایبری" },
                    { 12, "امنیت سایبری", "امنیت سایبری" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Marques",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
