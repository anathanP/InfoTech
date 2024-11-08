using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoTech.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class CreateAndSeedProjectsTableInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Address", "Alt", "Title" },
                values: new object[,]
                {
                    { 22, "project/01.jpg", "عکس پروژه", "عکس پروژه" },
                    { 23, "project/02.jpg", "عکس پروژه", "عکس پروژه" },
                    { 24, "project/03.jpg", "عکس پروژه", "عکس پروژه" },
                    { 25, "project/04.jpg", "عکس پروژه", "عکس پروژه" },
                    { 26, "project/05.jpg", "عکس پروژه", "عکس پروژه" },
                    { 27, "project/06.jpg", "عکس پروژه", "عکس پروژه" },
                    { 28, "project/07.jpg", "عکس پروژه", "عکس پروژه" },
                    { 29, "project/08.jpg", "عکس پروژه", "عکس پروژه" },
                    { 30, "project/09.jpg", "عکس پروژه", "عکس پروژه" },
                    { 31, "project/10.jpg", "عکس پروژه", "عکس پروژه" },
                    { 32, "project/11.jpg", "عکس پروژه", "عکس پروژه" },
                    { 33, "project/12.jpg", "عکس پروژه", "عکس پروژه" },
                    { 34, "project/13.jpg", "عکس پروژه", "عکس پروژه" },
                    { 35, "project/14.jpg", "عکس پروژه", "عکس پروژه" },
                    { 36, "project/15.jpg", "عکس پروژه", "عکس پروژه" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Content", "Description", "ImageId", "ServiceId", "Title" },
                values: new object[,]
                {
                    { 1, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 22, 1, "پروژه یک" },
                    { 2, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 23, 2, "سیبهشتسک" },
                    { 3, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 24, 3, "سبیشثهشی" },
                    { 4, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 25, 4, "تست پروژه" },
                    { 5, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 26, 5, "پروژه تستی" },
                    { 6, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 27, 2, "پروژه تستی" },
                    { 7, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 28, 1, "پروژه تستی" },
                    { 8, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 29, 4, "پروژه تستی" },
                    { 9, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 30, 3, "پروژه تستی" },
                    { 10, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 31, 5, "پروژه تستی" },
                    { 11, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 32, 3, "پروژه تستی" },
                    { 12, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 33, 2, "پروژه تستی" },
                    { 13, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 34, 1, "پروژه تستی" },
                    { 14, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 35, 5, "پروژه تستی" },
                    { 15, "", "بنتشسهیبتتشثهبتشئههصشبتیشتکهتثهتبشکیستبشهصشبتهثصتبشیرئنتشهقثتبیسه", 36, 5, "پروژه تستی" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ImageId",
                table: "Projects",
                column: "ImageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ServiceId",
                table: "Projects",
                column: "ServiceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 36);
        }
    }
}
