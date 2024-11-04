using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingPhonesTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "Id", "Number", "Status" },
                values: new object[] { 1, "+989369043949", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
