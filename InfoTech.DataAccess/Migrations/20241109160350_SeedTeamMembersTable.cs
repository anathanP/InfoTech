using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedTeamMembersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Address", "Alt", "Title" },
                values: new object[,]
                {
                    { 37, "team/01.jpg", "عکس اعضا", "عکس اعضا" },
                    { 38, "team/02.jpg", "عکس اعضا", "عکس اعضا" },
                    { 39, "team/03.jpg", "عکس اعضا", "عکس اعضا" },
                    { 40, "team/04.jpg", "عکس اعضا", "عکس اعضا" },
                    { 41, "team/05.jpg", "عکس اعضا", "عکس اعضا" },
                    { 42, "team/06.jpg", "عکس اعضا", "عکس اعضا" },
                    { 43, "team/07.jpg", "عکس اعضا", "عکس اعضا" },
                    { 44, "team/08.jpg", "عکس اعضا", "عکس اعضا" },
                    { 45, "team/09.jpg", "عکس اعضا", "عکس اعضا" },
                    { 46, "team/10.jpg", "عکس اعضا", "عکس اعضا" },
                    { 47, "team/11.jpg", "عکس اعضا", "عکس اعضا" },
                    { 48, "team/12.jpg", "عکس اعضا", "عکس اعضا" },
                    { 49, "team/13.jpg", "عکس اعضا", "عکس اعضا" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Content", "Description", "Family", "ImageId", "Name" },
                values: new object[,]
                {
                    { 1, "", "", "مسعوداردکانی", 37, "عباس" },
                    { 2, "", "", "مسعوداردکانی", 38, "عباس" },
                    { 3, "", "", "مسعوداردکانی", 39, "عباس" },
                    { 4, "", "", "مسعوداردکانی", 40, "عباس" },
                    { 5, "", "", "مسعوداردکانی", 41, "عباس" },
                    { 6, "", "", "مسعوداردکانی", 42, "عباس" },
                    { 7, "", "", "مسعوداردکانی", 43, "عباس" },
                    { 8, "", "", "مسعوداردکانی", 44, "عباس" },
                    { 9, "", "", "مسعوداردکانی", 45, "عباس" },
                    { 10, "", "", "مسعوداردکانی", 46, "عباس" },
                    { 11, "", "", "مسعوداردکانی", 47, "عباس" },
                    { 12, "", "", "مسعوداردکانی", 48, "عباس" },
                    { 13, "", "", "مسعوداردکانی", 49, "عباس" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TeamMembers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 49);
        }
    }
}
