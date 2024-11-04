using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingSocialMediasTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Icon", "Link", "Media" },
                values: new object[,]
                {
                    { 1, "<i class=\"bi bi-telegram\"></i>", "https://www.t.me/Abbasmasoud", "Telegram" },
                    { 2, "<i class=\"bi bi-whatsapp\"></i>", "+989369043949", "Whatsapp" },
                    { 3, "<i class=\"bi bi-instagram\"></i>", "https://www.instagram.com/leoneltech1?igsh=MXBycmQybXQ0bmVjaw==", "Instagram" },
                    { 4, "<i class=\"bi bi-linkedin\"></i>", "https://www.linkedin.com/in/abbas-masoud-0681a5315?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_mdeium=android_app", "LinkedIn" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
