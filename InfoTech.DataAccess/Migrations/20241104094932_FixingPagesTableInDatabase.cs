using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixingPagesTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Action", "Author", "Description", "Keywords", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "/Customer/Home/Index", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "صفحه اصلی", "Home" },
                    { 2, "/Customer/Home/About", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "درباره", "About Us" },
                    { 3, "/Customer/Home/Services", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "خدمات", "Services" },
                    { 4, "/Customer/Home/Pages", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "صفحات", "Pages" },
                    { 5, "/Customer/Home/Blogs", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "وبلاگ", "Blogs" },
                    { 6, "/Customer/Home/Contact", "Anathan", "صفحه نخست سایت اینفو تک", "Home, info tech, C#", "تماس", "Contact" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
