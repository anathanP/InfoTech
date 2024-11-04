using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingEmailsTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "Address", "Status" },
                values: new object[] { 1, "abbasmasoudardakani@gmail.com", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
