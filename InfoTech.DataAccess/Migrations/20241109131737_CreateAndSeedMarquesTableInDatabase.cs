using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateAndSeedMarquesTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marques", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Marques",
                columns: new[] { "Id", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "امنیت سایبری", "امنیت سایبری" },
                    { 2, "راه حل اطلاعاتی", "راه حل اطلاعاتی" },
                    { 3, "فن آوری", "فن آوری" },
                    { 4, "امنیت سایبری", "امنیت سایبری" },
                    { 5, "امنیت سایبری", "امنیت سایبری" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marques");
        }
    }
}
